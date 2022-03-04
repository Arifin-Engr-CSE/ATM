
CREATE PROCEDURE sp_CreateAccount 
	@accName nvarchar(100),
	@accNo nvarchar(100),
	@accType nvarchar(50),
	@PIN bigint,
	@gender nvarchar(150),
	@date date,
	@address nvarchar(200),
	@nid bigint,
	@phoneNo nvarchar(20),
	@email nvarchar(30),
	@branch nvarchar(50),
	@image Image

AS
BEGIN
	insert into Customer(AccName,AccNo,AccType,PIN,Gender,OpenDate,[Address],NID,PhoneNo,[Email],Branch,[Image])values(@accName,@accNo,@accType,@PIN,@gender,@date,@address,@nid,@phoneNo,@email,@branch,@image)
	
END
