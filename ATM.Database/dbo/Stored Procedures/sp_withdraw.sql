
CREATE PROCEDURE sp_withdraw
	@pin bigint,
	@amount bigint,
	@accNo nvarchar(100)
	
AS
BEGIN
	update Customer
	set Balance=Balance-@amount
	where AccNo=@accNo and PIN=@pin
END
