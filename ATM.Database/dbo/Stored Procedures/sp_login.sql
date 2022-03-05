CREATE PROCEDURE [dbo].[sp_login]
	@accNo nvarchar(100),
	@pin bigint
AS
BEGIN
	select*from Customer where AccNo=@accNo and PIN=@pin
END