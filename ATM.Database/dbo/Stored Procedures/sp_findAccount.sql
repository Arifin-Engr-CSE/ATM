CREATE PROCEDURE sp_findAccount
	@accNumber nvarchar(100)
AS
BEGIN
	select*from Customer where AccNo=@accNumber
END
