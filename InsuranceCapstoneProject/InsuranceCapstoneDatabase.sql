

CREATE DATABASE InsuranceCapstoneProject;

use InsuranceCapstoneProject


CREATE TABLE UsersInfo (
    userID INT PRIMARY KEY identity(100,1),
    userName NVARCHAR(50) UNIQUE,
    userPassword NVARCHAR(100),
    userEmail NVARCHAR(100),
    mobileNumber INT,
    walletBalance DECIMAL(20,2)
);

INSERT INTO UsersInfo (userName, userPassword, userEmail, mobileNumber, walletBalance)
VALUES
    ('john_doe', 'password123', 'john.doe@example.com', 1234567890, 1000.00),
    ('jane_smith', 'password456', 'jane.smith@example.com', 9876543210, 500.00),
    ('mike_jackson', 'password789', 'mike.jackson@example.com', 5551234567, 1500.00),
    ('emma_johnson', 'passwordabc', 'emma.johnson@example.com', 4449876543, 2000.00),
    ('chris_brown', 'passworddef', 'chris.brown@example.com', 7774561230, 750.00),
    ('sarah_adams', 'passwordghi', 'sarah.adams@example.com', 9997894560, 3000.00),
    ('david_lee', 'passwordjkl', 'david.lee@example.com', 2226547890, 1200.00),
    ('lisa_taylor', 'passwordmno', 'lisa.taylor@example.com', 1117896543, 1800.00),
    ('kevin_clark', 'passwordpqr', 'kevin.clark@example.com', 6666547890, 2200.00),
    ('natalie_white', 'passwordstu', 'natalie.white@example.com', 3339876543, 900.00);


-- Create the Admins table
CREATE TABLE AdminsInfo (
    AdminID INT PRIMARY KEY identity(500,1),
    Username NVARCHAR(50) UNIQUE,
    Password NVARCHAR(100)
);

-- Insert sample records into the AdminsInfo table
INSERT INTO AdminsInfo (Username, Password)
VALUES
    ('admin1', 'adminpassword1'),
    ('admin2', 'adminpassword2'),
    ('admin3', 'adminpassword3'),
    ('admin4', 'adminpassword4'),
    ('admin5', 'adminpassword5');




-- Create the stored procedure
CREATE PROCEDURE GetUsersInfoWithoutPassword
AS
BEGIN
    SELECT userID, userName, userEmail, mobileNumber, walletBalance
    FROM UsersInfo;
END;




-- Create the InsuranceDetails table
CREATE TABLE InsuranceDetails (
    insuranceID INT PRIMARY KEY identity(800,1),
    insuranceBrand NVARCHAR(100),
	insuranceCategory NVARCHAR(20) CHECK (insuranceCategory IN ('Health', 'Car', 'Life')),
	insuranceDescription NVARCHAR(MAX),
    insurancePrice DECIMAL(18, 2),
    insuranceAgeRequirement INT,
);
GO

insert into InsuranceDetails (insuranceBrand, insuranceCategory, insuranceDescription, insurancePrice, insuranceAgeRequirement)
values
('LIC', 'Health', 'Health insurance with extensive coverage and cashless hospitalization.', 5000.00, 5),
('LIC', 'Car', 'Car insurance with zero depreciation and roadside assistance.', 2000.00, 18),
('LIC', 'Life', 'Term life insurance plan with riders for critical illness and accidental death.', 1000.00, 5);

-- Insert additional entries for LIC


-- Insert entries for the remaining brands
INSERT INTO InsuranceDetails (insuranceBrand, insuranceCategory, insuranceDescription, insurancePrice, insuranceAgeRequirement)
VALUES
    ('Bajaj Allianz', 'Health', 'Comprehensive health coverage including hospitalization.', 6000.00, 8),
    ('Bajaj Allianz', 'Car', 'Comprehensive car insurance for various car models.', 3000.00, 21),
    ('Bajaj Allianz', 'Life', 'Whole life insurance with lifelong coverage and cash value.', 4000.00, 10),
    
    ('Aditya Birla', 'Health', 'Customizable health insurance with added benefits.', 4500.00, 7),
    ('Aditya Birla', 'Car', 'Car insurance with additional benefits and roadside assistance.', 2500.00, 20),
    ('Aditya Birla', 'Life', 'Universal life insurance with flexibility in premiums and benefits.', 3500.00, 15),
    
    ('TATA AIG', 'Health', 'Family floater health insurance plan for comprehensive coverage.', 5500.00, 9),
    ('TATA AIG', 'Car', 'Car insurance with coverage for personal belongings and accessories.', 4000.00, 22),
    ('TATA AIG', 'Life', 'Term life insurance plan with riders for critical illness and accidental death.', 3000.00, 12),
    
    ('Iffco Tokio', 'Health', 'Individual health insurance with added wellness benefits.', 4800.00, 6),
    ('Iffco Tokio', 'Car', 'Car insurance with add-ons for engine protection and key replacement.', 3200.00, 19),
    ('Iffco Tokio', 'Life', 'Unit-linked insurance plan (ULIP) with investment options and life cover.', 4200.00, 11);

	--Insurance Order Details
create table OrderDetails(
    orderID int primary key identity (2000,1),
    userID int foreign key references UsersInfo(UserID),
    orderDate datetime,
    duePremium decimal(10, 2),
    orderStatus varchar(50) check(OrderStatus in ('Delivered', 'Pending', 'Cancelled')),
)

--Insurance Cart Details

create table CartDetails (
    cartId int primary key,
    orderID int foreign key references OrderDetails(orderID),
    insuranceID int foreign key references InsuranceDetails(insuranceID),
    insuranceQty int,
);


/*CREATE PROCEDURE SearchInsuranceProduct
   @productName NVARCHAR(100) = NULL,
    @productCategory NVARCHAR(20) = NULL,
    @minPrice DECIMAL(18, 2) = NULL,
    @maxPrice DECIMAL(18, 2) = NULL,
    @productBrand NVARCHAR(100) = NULL,
    @productAgeRequirement INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM InsuranceDetails
    WHERE (@productName IS NULL OR insuranceDescription LIKE '%' + @productName + '%')
      AND (@productCategory IS NULL OR insuranceCategory = @productCategory)
      AND (@minPrice IS NULL OR insurancePrice >= @minPrice)
      AND (@maxPrice IS NULL OR insurancePrice <= @maxPrice)
      AND (@productBrand IS NULL OR insuranceBrand = @productBrand)
      AND (@productAgeRequirement IS NULL OR insuranceAgeRequirement <= @productAgeRequirement);
END;*/

---Search by Name---
CREATE PROCEDURE SearchInsuranceByName
    @insuranceBrand NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM InsuranceDetails
    WHERE insuranceBrand = @insuranceBrand;
END;

---Search By Category
CREATE PROCEDURE SearchInsuranceByCategory
    @insuranceCategory NVARCHAR(20)
AS
BEGIN
    SELECT *
    FROM InsuranceDetails
    WHERE insuranceCategory = @insuranceCategory;
END;

---Search By Price Range
CREATE PROCEDURE SearchInsuranceByPriceRange
    @minPrice DECIMAL(18, 2),
    @maxPrice DECIMAL(18, 2)
AS
BEGIN
    SELECT *
    FROM InsuranceDetails
    WHERE insurancePrice BETWEEN @minPrice AND @maxPrice;
END;

--Search By Max Price
CREATE PROCEDURE SearchInsuranceByMaxPrice
    @maxPrice DECIMAL(18, 2)
AS
BEGIN
    SELECT *
    FROM InsuranceDetails
    WHERE insurancePrice <= @maxPrice;
END;

--Search By Min Price
CREATE PROCEDURE SearchInsuranceByMinPrice
    @minPrice DECIMAL(18, 2)
AS
BEGIN
    SELECT *
    FROM InsuranceDetails
    WHERE insurancePrice >= @minPrice;
END;

--Age Range
CREATE PROCEDURE SearchInsuranceByAgeRange
    @age1 INT,
    @age2 INT
AS
BEGIN
    SELECT *
    FROM InsuranceDetails
    WHERE insuranceAgeRequirement BETWEEN @age1 AND @age2;
END;

--add new insurance
CREATE PROCEDURE AddInsuranceDetail
    @insuranceBrand NVARCHAR(100),
    @insuranceCategory NVARCHAR(20),
    @insuranceDescription NVARCHAR(MAX),
    @insurancePrice DECIMAL(18, 2),
    @insuranceAgeRequirement INT
AS
BEGIN
    INSERT INTO InsuranceDetails (insuranceBrand, insuranceCategory, insuranceDescription, insurancePrice, insuranceAgeRequirement)
    VALUES (@insuranceBrand, @insuranceCategory, @insuranceDescription, @insurancePrice, @insuranceAgeRequirement);
END;

--delete
CREATE PROCEDURE DeleteInsuranceDetail
    @insuranceID INT
AS
BEGIN
    DELETE FROM InsuranceDetails
    WHERE insuranceID = @insuranceID;
END;















