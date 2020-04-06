### MASTER DEAIL | SHOP ONLINE

CREATE DATABASE OnlineShop;
USE OnlineShop;
/* *****Customer Table***** */
CREATE TABLE Customer
(
	CustomerId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT newsequentialid(),
	Name NVARCHAR(50) NOT NUll,
	Address NVARCHAR(MAX) NUll,
	OrderDate DATETIME NOT NULL
);
/* *****Orders Table***** */
CREATE TABLE Orders
(
	OrderId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT newsequentialid(),
	ProductName NVARCHAR(150) NOT NUll,
	Quantity INT NOT NULL,
	Price DECIMAL NOT NULL,
	Amount DECIMAL NUll,
	CustomerId UNIQUEIDENTIFIER Not Null,
	FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId)
);

Source Code: http://abctutorial.com/Post/35/mvc-5-master-details-using-jquery-ajax

- List 
![masterdeail](https://user-images.githubusercontent.com/42701669/78566198-121c1f00-7849-11ea-8879-c1abd6ca606b.PNG)

- Add
![masterdeail_2](https://user-images.githubusercontent.com/42701669/78566304-38da5580-7849-11ea-81a4-451e6f28faa8.PNG)

