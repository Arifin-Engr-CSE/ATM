CREATE PROCEDURE sp_checkBalance
	@accNumber nvarchar(100),
	@pin bigint
AS
BEGIN
	select*from Customer where AccNo=@accNumber and PIN=@pin
END
