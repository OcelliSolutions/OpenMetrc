# Function to check if a command is available
function Command-Exists {
    param([string]$cmd)
    $command = Get-Command -Name $cmd -ErrorAction SilentlyContinue
    return $command -ne $null
}

# Ensure required tools are installed
if (-Not (Command-Exists "dotnet") -or -Not (Command-Exists "reportgenerator") -or -Not (Command-Exists "xdg-open")) {
    Write-Host "Installing required tools..."

    # Install .NET SDK (dotnet) if not installed
    if (-Not (Command-Exists "dotnet")) {
        # Example: Install using package manager (e.g., Chocolatey)
        choco install dotnet-sdk --version 6.0.100 -y
        choco install dotnet-sdk --version 7.0.100 -y
        choco install dotnet-sdk --version 8.0.100 -y
    }

    # Install ReportGenerator if not installed
    if (-Not (Command-Exists "reportgenerator")) {
        dotnet tool install -g dotnet-reportgenerator-globaltool
    }
}

# Rest of your script
$COVERAGE_RUN_IDENTIFIER = [System.Guid]::NewGuid().ToString()
$REPORT_TYPES = "HTML;cobertura;"

# Build and Test
dotnet restore OpenMetrc.sln
dotnet test OpenMetrc.sln --collect:"XPlat Code Coverage" --results-directory:".coverage/$COVERAGE_RUN_IDENTIFIER"

# Calculated Parameters - Report Generator - CHANGE WITH EXTREME CAUTION
$TARGET_DIR = ".coverage-report/$COVERAGE_RUN_IDENTIFIER"
$REPORT_HTML_FILE = ".coverage-report/$COVERAGE_RUN_IDENTIFIER/index.html"

# Generate Report
reportgenerator "-reports:.coverage/$COVERAGE_RUN_IDENTIFIER/*/coverage.cobertura.xml" "-targetdir:$TARGET_DIR" "-reporttypes:$REPORT_TYPES"

# Open Report using the default file explorer in Windows (assuming you are using WSL)
Invoke-Item -Path ("$REPORT_HTML_FILE")
