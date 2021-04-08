CREATE DATABASE RentCarDB
USE RentCarDB

CREATE TABLE Vehicle
(
	CarNumber VARCHAR(50) NOT NULL PRIMARY KEY,
	CarName NVARCHAR(50) NOT NULL,
	CarOrigin NVARCHAR(50) DEFAULT N'Unknown',
	CarPriceBy FLOAT NOT NULL,
	CarStatus VARCHAR(20) DEFAULT 'Available',
	CarPriceRent FLOAT DEFAULT 10000000,
	CarMileage FLOAT DEFAULT 0,
	CarCategory VARCHAR(20) NOT NULL
)

GO
CREATE TABLE Customer
(
	CustomerId INT NOT NULL PRIMARY KEY,
	CustomerName NVARCHAR(100) NOT NULL,
	CustomerAge INT NOT NULL,
	CustomerAddress NVARCHAR(100) DEFAULT N'Unknown',
	CustomerCreditCard VARCHAR(20) DEFAULT 'Unknown',
	CustomerCarLicense VARCHAR(20)  DEFAULT 'Unknown',
	CustomerDeposit FLOAT DEFAULT 0.0
)


CREATE TABLE Contract
(
	ContractId VARCHAR(20) NOT NULL PRIMARY KEY,
	CarNumber VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES dbo.Vehicle(CarNumber),
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES dbo.Customer(CustomerId),
	DateStart DATE DEFAULT GETDATE(),
	DateEnd DATE NOT NULL,
	ContractCost FLOAT DEFAULT 0.0,
	ContractContent NVARCHAR(1000) DEFAULT N'Unknown',
	ContractStatus VARCHAR(20) DEFAULT 'Process'
)

GO

CREATE TABLE Service
(
	ServiceID INT NOT NULL PRIMARY KEY,
	ServiceCategory NVARCHAR(20)
)

CREATE TABLE ServiceHistory
(
	ID INT IDENTITY PRIMARY KEY,
	ServiceID INT NOT NULL FOREIGN KEY REFERENCES dbo.Service(ServiceID),
	CarID VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES dbo.Vehicle(CarNumber),
	DateService DATE DEFAULT GETDATE(),
	Mileage FLOAT,
	Content NVARCHAR(100)
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) NOT NULL PRIMARY KEY,
	PassWord VARCHAR(20) NOT NULL,
	PersonName NVARCHAR(100) NOT NULL,
	Address NVARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(20) NOT NULL
)
GO


CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

GO

INSERT dbo.Service
        ( ServiceID, ServiceCategory )
VALUES  ( 1, -- ServiceID - int
          N'Service Engine'  -- ServiceCategory - nvarchar(20)
          )

INSERT dbo.Service
        ( ServiceID, ServiceCategory )
VALUES  ( 2, -- ServiceID - int
          N'Service Transmission'  -- ServiceCategory - nvarchar(20)
          )

INSERT dbo.Service
        ( ServiceID, ServiceCategory )
VALUES  ( 3, -- ServiceID - int
          N'Service Tires'  -- ServiceCategory - nvarchar(20)
          )

GO

CREATE TRIGGER ChangeCarStatus ON dbo.Contract FOR INSERT 
AS 
BEGIN
	DECLARE @carNum VARCHAR(50)
	SELECT @carNum = Inserted.CarNumber FROM Inserted
	UPDATE dbo.Vehicle SET CarStatus = 'Unavailable' WHERE CarNumber = @carNum
END

GO

CREATE PROCEDURE CompleteContract
@id VARCHAR(20), @carNum VARCHAR(50)
AS
BEGIN
	UPDATE dbo.Contract SET ContractStatus = 'Complete' WHERE ContractId = @id
	UPDATE dbo.Vehicle SET CarStatus = 'Available' WHERE CarNumber = @carNum
END

GO
