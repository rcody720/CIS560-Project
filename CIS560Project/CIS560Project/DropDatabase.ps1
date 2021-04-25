[cmdletbinding()]
Param(
    [string] $Server = "mssql.cs.ksu.edu",
    [string] $Database = "rcody720"
)

$Sql = @"
IF EXISTS
   (
      SELECT *
      FROM sys.databases d
      WHERE d.name = N'`$(DatabaseName)'
   )
BEGIN
   ALTER DATABASE [`$(DatabaseName)]
   SET SINGLE_USER
   WITH ROLLBACK IMMEDIATE;

   DROP DATABASE [`$(DatabaseName)];
END;
"@

Write-Host "Dropping $Database database"

Invoke-Sqlcmd -ServerInstance $Server -Database "master" -Username rcody720 -Password @dr93/cr99"&"Kr60"&"Cr53 -Query $Sql -Variable "DatabaseName=$Database"

Read-Host -Prompt "Press Enter to exit"
