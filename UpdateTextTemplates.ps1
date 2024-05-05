$textTransformPath = "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\TextTransform.exe"

# Get the directory containing the Newtonsoft.Json.dll file
$assemblyPath = Get-ChildItem -Path $path -Recurse -Filter "Newtonsoft.Json.dll" -File | Select-Object -First 1 -ExpandProperty FullName | Split-Path -Parent

if (-not $assemblyPath) {
    Write-Host "Error: Newtonsoft.Json.dll not found in the project directory."
    exit
}

# Add the path to Newtonsoft.Json.dll as an assembly reference
#Add-Type -Path $assemblyPath

$ttFiles = Get-ChildItem -Path $path -Filter "*.tt" -Recurse

foreach ($ttFile in $ttFiles) {
    $ttFilePath = $ttFile.FullName
    Write-Host "Processing $ttFilePath"
    Start-Process -FilePath $textTransformPath -ArgumentList $ttFilePath -NoNewWindow -Wait -WorkingDirectory "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\PrivateAssemblies\Newtonsoft.Json.13.0.3.0"
}