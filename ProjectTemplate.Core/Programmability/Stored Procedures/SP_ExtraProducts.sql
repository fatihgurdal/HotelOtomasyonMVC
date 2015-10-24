CREATE PROCEDURE SP_ExtraProducts
(
@PacketId INT
)
AS
BEGIN

SELECT * FROM ExtraProducts AS EP
INNER JOIN PacketsExtraProductCategories AS PEPC ON PEPC.ExtraProductCategoryId=EP.ExtraProductCategoryId
WHERE PEPC.PacketId!= @PacketId

END