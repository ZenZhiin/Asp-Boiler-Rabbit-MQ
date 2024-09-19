CREATE PROCEDURE UpdateProductStock
    @ProductId INT,
    @Quantity INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentStock INT;

    SELECT @CurrentStock = Quantity FROM ProductStock WHERE ProductId = @ProductId;

    IF @CurrentStock < @Quantity
    BEGIN
        -- 库存不足
        RAISERROR('Insufficient stock', 16, 1);
    END
    ELSE
    BEGIN
        -- 更新库存
        UPDATE ProductStock
        SET Quantity = Quantity - @Quantity
        WHERE ProductId = @ProductId;
    END
END;
