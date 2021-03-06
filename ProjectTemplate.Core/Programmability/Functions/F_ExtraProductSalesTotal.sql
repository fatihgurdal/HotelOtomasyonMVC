--USE [HotelDB]
--GO
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
CREATE FUNCTION [dbo].[F_ExtraProductSalesTotal]
(
	@RoomId int
)
RETURNS decimal(8,2) 
AS
BEGIN
	--aktif paketin bulunması
	DECLARE @PacketId int;
	SELECT @PacketId=(SELECT SO.PacketId FROM RoomSales AS SO WHERE SO.Id=@RoomId)

	--pakete dahil olmayan ürünlerin ücretlendirilmesi
	DECLARE @ExtraTotal decimal(8,2);
	SELECT @ExtraTotal= CAST(
	(SELECT SUM(SE.ProductUnit*SE.ProductAmount) AS ExtraToplami FROM SaleExtras AS SE
	INNER JOIN ExtraProducts AS EP ON EP.Id=SE.ExtraProductId
	INNER JOIN ExtraProductCategories AS EPC ON EPC.Id=EP.ExtraProductCategoryId
	WHERE SE.RoomSaleId=@RoomId AND 
	(EPC.Id NOT IN (
	SELECT PEPC.ExtraProductCategoryId FROM PacketsExtraProductCategories AS PEPC WHERE PEPC.PacketId=@PacketId
	))) as  decimal(8, 2))

	IF @ExtraTotal IS NULL
	BEGIN SELECT @ExtraTotal=0.000 END

	RETURN (@ExtraTotal)
END

