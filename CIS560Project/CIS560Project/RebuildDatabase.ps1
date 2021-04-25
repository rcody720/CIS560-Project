Param(
    [string] $Server = "mssql.cs.ksu.edu",
    [string] $Database = "rcody720"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
#& ".\Scripts\DropDatabase.ps1" -Database $Database
#& ".\Scripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "CIS560Project\Sql\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "CIS560Project\Sql\Movies.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "CIS560Project\Sql\Tables.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "CIS560Project\Sql\Movies.CreateMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "CIS560Project\Sql\Movies.FetchMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "CIS560Project\Sql\Movies.GetMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "CIS560Project\Sql\Movies.GetRecentMovies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "CIS560Project\Sql\Movies.RetrieveMovies.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "CIS560Project\Sql\Data.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
