[cmdletbinding()]
Param(
    [string] $Server = "mssql.cs.ksu.edu",
    [string] $Database = "rcody720"
)

$CurrentDrive = (Get-Location).Drive.Name + ":"
$CreateDatabaseScript = $PSScriptRoot + "\CreateDatabase.sql"

Write-Host
Write-Host "Creating database [$Database] if it does not exist..."
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -Username rcody720 -Password @dr93/cr99"&"Kr60"&"Cr53 -InputFile $CreateDatabaseScript -Variable "DatabaseName=$Database"

if ( -not $? ) {
    throw "An error occurred creating the database."
}

Write-Host
Set-Location $CurrentDrive
