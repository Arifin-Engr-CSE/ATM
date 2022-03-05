CREATE PROCEDURE [dbo].[sp_deposit]
	@accNo nvarchar(100),
	@pin bigint,
	@amount bigint
AS
BEGIN
	update Customer
	set Balance=Balance+@amount
	where AccNo=@accNo and PIN=@pin
END
