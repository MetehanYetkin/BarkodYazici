TRUNCATE TABLE BarkodYazıcı.dbo.Barcodes 
DECLARE @UniqueNumber INT

SET @UniqueNumber = 1

SELECT FORMAT(@UniqueNumber, 'd3')