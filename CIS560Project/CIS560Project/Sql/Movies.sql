IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Person'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Movies] AUTHORIZATION [dbo];');
END;