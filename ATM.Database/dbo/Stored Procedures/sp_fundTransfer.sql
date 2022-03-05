CREATE PROCEDURE [dbo].[sp_fundTransfer] 
	@fromAccNo nvarchar(100),
	@fromAccName nvarchar(100),
	@fromBranch nvarchar(100),
	@fromPin bigint,
	@toAccNo nvarchar(100),
	@toAccName nvarchar(100),
	@toBranch nvarchar(100),
	@amount bigint

AS
BEGIN
update Customer
	set Balance=Balance+@amount
	where AccNo=@toAccNo and AccName=@toAccName and Branch=@toBranch

	update Customer
	set Balance=Balance-@amount
	where AccNo=@fromAccNo and AccName=@fromAccName and Branch=@fromBranch and PIN=@fromPin

END