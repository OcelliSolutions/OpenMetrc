#!/bin/bash

# Function to check if a command is available
command_exists() {
    command -v "$1" >/dev/null 2>&1
}

# Ensure required tools are installed
if ! command_exists dotnet || ! command_exists reportgenerator || ! command_exists xdg-open; then
    echo "Installing required tools..."

    # Install .NET SDK (dotnet) if not installed
    if ! command_exists dotnet; then
        # Example: Install using package manager (e.g., apt)
        sudo apt install dotnet-sdk-6.0 dotnet-sdk-7.0 dotnet-sdk-8.0
    fi

    # Install ReportGenerator if not installed
    if ! command_exists reportgenerator; then
        dotnet tool install -g dotnet-reportgenerator-globaltool
    fi
fi

# Rest of your script
COVERAGE_RUN_IDENTIFIER=$(uuidgen)
REPORT_TYPES="HTML;cobertura;"

# Build and Test
dotnet restore OpenMetrc.sln
dotnet test OpenMetrc.sln --collect:"XPlat Code Coverage" --results-directory:".coverage/$COVERAGE_RUN_IDENTIFIER"

# Calculated Parameters - Report Generator - CHANGE WITH EXTREME CAUTION
TARGET_DIR=".coverage-report/$COVERAGE_RUN_IDENTIFIER"
REPORT_HTML_FILE=".coverage-report/$COVERAGE_RUN_IDENTIFIER/index.html"

# Generate Report
reportgenerator "-reports:.coverage/$COVERAGE_RUN_IDENTIFIER/*/coverage.cobertura.xml" "-targetdir:$TARGET_DIR" "-reporttypes:$REPORT_TYPES"

# Open Report using the default file explorer in Windows (assuming you are using WSL)
/mnt/c/Windows/explorer.exe "$(wslpath -w "$REPORT_HTML_FILE")"
