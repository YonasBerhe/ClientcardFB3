RESTORE DATABASE [ClientcardFB3] FROM  DISK = N'C:\Users\Public\ClientcardFB3\Database\FB3x8Prod.BAK' WITH  FILE = 1,  MOVE N'ClientCardFB' TO N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ClientcardFB3.mdf',  MOVE N'ClientCardFB_log' TO N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ClientcardFB3.LDF',  NOUNLOAD,  STATS = 10
GO
