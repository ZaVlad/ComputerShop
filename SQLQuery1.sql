Use ComputerFirmDb;
GO

CREATE PROCEDURE [dbo].[spSupplier_GetByGuarantee]
@HaveGuarantee BIT
AS
BEGIN
SELECT [R].[RepairId],[PC].[GoodsTypeId],[R].[ProductCodeId],[R].[Price],[R].[HaveGuarantee],[PC].[Code],[R].[RepairStage] FROM [dbo].[Repair] AS[R]
INNER JOIN [dbo].[ProductCode] AS[PC] ON [R].[ProductCodeId] = [PC].[ProductCodeId]
WHERE [R].[HaveGuarantee] =@HaveGuarantee

END

--DROP PROCEDURE [dbo].[spSupplier_GetByGuarantee]

-- EXEC [dbo].[spSupplier_GetByGuarantee] 1

CREATE PROCEDURE [dbo].[spCustomer_GetByFirmGoods]
@Firm INT
AS
BEGIN 
SELECT [Cu].[CustomerId],[Cu].[Adress],[Cu].[BillingCity],[Cu].[BillingCountry],
[Cu].[City],[Cu].[DateEntered],[Cu].[Email],[Cu].[FirstName],[Cu].[LastName],
[Cu].[Phone],[Cu].[ShipCountry],[Cu].[ShipRegion],[C].[Firm] FROM [dbo].[Computer] AS[C]
INNER JOIN  [dbo].[ProductCode] AS[PC] ON [C].[ProductCodeId] = [PC].[ProductCodeId]
INNER JOIN [dbo].[OrderDetail] AS[OD] ON [OD].[ProductCodeId] = [PC].[ProductCodeId]
INNER JOIN [dbo].[Order] AS[O] ON [OD].[OrderId] = [O].[OrderId]
INNER JOIN [dbo].[Customer] AS [Cu] ON [Cu].[CustomerId] = [O].[CustomerId] 
WHERE [C].[Firm] = @Firm
END

-- DROP PROCEDURE [dbo].[spCustomer_GetByFirmGoods]

EXEC [dbo].[spCustomer_GetByFirmGoods] 0