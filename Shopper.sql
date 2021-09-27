Create Database DataShop
go
use DataShop
go

Create Table Categories(
	cateID int identity(1,1) primary key,
	cateName Nvarchar(100),
)
go
--Insert table Categories
Insert into Categories values(N'Quần-áo')
Insert into Categories values(N'Giày-dép')
Insert into Categories values(N'Mũ(nón)')
Create Table ProductTypes(
	typeID int identity(1,1) primary key,
	cateID int FOREIGN KEY REFERENCES Categories(cateID),
	typeName Nvarchar(100)
)
go
--Insert table ProductTypes
Insert into ProductTypes values(1, N'Mùa Đông')
Insert into ProductTypes values(1, N'Mùa Hè')
Insert into ProductTypes values(1, N'Mùa Thu')
Insert into ProductTypes values(1, N'Đồ công sở')
Insert into ProductTypes values(1, N'Đồ ngủ')
Insert into ProductTypes values(2, N'Giày thể thao')
Insert into ProductTypes values(2, N'Giày thời trang')
Insert into ProductTypes values(2, N'Dép lê')
Insert into ProductTypes values(2, N'Dép có quai')
Insert into ProductTypes values(3, N'Mũ thời trang')
Insert into ProductTypes values(3, N'Mũ bảo hiểm')

Create Table Products(
	proID varchar(50) primary key,
	typeID int FOREIGN KEY REFERENCES ProductTypes(typeID),
	proName Nvarchar(200),
	proSize varchar(10),
	proamount int,
	proPrice float,
	proDiscount int,
	proPhoto Nvarchar(MAX),
	proUpdateDate Datetime,
	proDescription Nvarchar(MAX)
)
go
--Insert table Products
Insert into Products values('MU001',  10, N'Mũ phớt nam', 'M,S,L,...',100,'60000', 0, N'img (1).jpg', '10/01/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('MU002', 10, N'Mũ thời trang kiểu xã hội đen', 'M,S,...',50, '82000', 0, N'img (20).jpg', '10/02/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('MU003',  10, N'Mũ thời trang FILA (đen)', 'XL,L,...',80, '45000', 0, N'img (27).jpg', '10/03/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('MU004', 11, N'Mũ bảo hiểm honda', 'S,M,...', '120000',60, 5, N'img (29).jpg', '10/04/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('CS001',  4, N'Đầm công sở nữ', 'S,M,...', '320000',90, 10, N'img (2).jpg', '10/05/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('CS002',  4, N'Đồ công sở quần dài', 'M,S,L', '230000',150, 5, N'img (4).jpg', '10/06/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('CS003', 4, N'Kiểu dáng học sinh', 'M,S,...', '200000',200, 0, N'img (19).jpg', '10/07/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('AK001', 1, N'Áo khoác nam', 'XL,XXL,L', '110000', 150,0, N'img (3).jpg', '10/08/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('AT001',  2, N'Áo thun nữ sành điệu', 'S,M,L...', '80000',160, 0, N'img (8).jpg', '10/09/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('AT002', 2, N'Áo body nam', 'L,XL,XXL', '130000',140, 0, N'img (12).jpg', '10/10/2017 6:43:36 AM', N'Không có mô tả')
Insert into Products values('AT003', 3, N'Áo nữ 100% cotton', 'S,M,L...', '170000',100, 0, N'img (13).jpg', '10/11/2017 6:43:36 AM', N'Không có mô tả')
select* from ProductTypes
Create Table Administrator(
	cusPhone varchar(20) FOREIGN KEY REFERENCES Customers(cusPhone),
	adPass varchar(20)
	Constraint PK_admin Primary key (cusPhone)
)
--Insert table Administrator
Insert into Administrator values('01234567891','1234')
Insert into Administrator values('01234567892','1234')
go
select * from Administrator
Create Table Customers(
	cusPhone varchar(20) primary key,
	cusFullName Nvarchar(200),
	cusEmail varchar(100),
	cusAddress Nvarchar(500)
)
go
--Insert table Customers
Insert into Customers values('01234567891', N'Vũ Văn A', 'a@gmail.com', N'Nhà A')
Insert into Customers values('01234567892', N'Vũ Văn B', 'b@gmail.com', N'Nhà B')
Insert into Customers values('01234567893', N'Vũ Văn C', 'c@gmail.com', N'Nhà C')
Insert into Customers values('01234567894', N'Vũ Văn D', 'd@gmail.com', N'Nhà D')
Insert into Customers values('01234567895', N'Vũ Văn E', 'e@gmail.com', N'Nhà E')

Create Table Orders(
	orderID int identity(1,1) primary key,
	cusPhone varchar(20) FOREIGN KEY REFERENCES Customers(cusPhone),
	orderMessage Nvarchar(MAX),
	orderDateTime varchar(50),
	orderStatus Nvarchar(50)
)
go
--Insert table Orders
Insert into Orders values( '01234567891', 'Size: M', '11/20/2017 10:40:30 AM', N'0')

Create Table OrderDetails(
	orderID int FOREIGN KEY REFERENCES Orders(orderID),
	proID varchar(50) FOREIGN KEY REFERENCES Products(proID),
	ordtsQuantity int,
	ordtsThanhTien varchar(50),
	Constraint PK_OrderDetails Primary key (orderID, proID)
)
go
--Insert table OrderDetails
Insert into OrderDetails values('1', 'AT001', 2, '160000')
Insert into OrderDetails values('1', 'AT002', 1, '130000')
Insert into OrderDetails values('1', 'AT003', 1, '170000')

Create Table Comments(
	commentID int identity(1,1) primary key,
	proID varchar(50) FOREIGN KEY REFERENCES Products(proID),
	commentMessage Nvarchar(MAX)

)
select* from Products
go

--Insert table Comments
Insert into Comments values('MU001', N'đã đánh giá MU001')
Insert into Comments values('MU002', N'đã đánh giá MU002')
Insert into Comments values('MU003', N'đã đánh giá MU003')
Insert into Comments values('MU004', N'đã đánh giá MU004')
Insert into Comments values('CS001', N'đã đánh giá CS001')
Insert into Comments values('CS002', N'đã đánh giá CS002')
Insert into Comments values('CS003', N'đã đánh giá CS003')
Insert into Comments values('AK001', N'đã đánh giá AK001')
Insert into Comments values('AT001', N'đã đánh giá AT001')
Insert into Comments values('AT002', N'đã đánh giá AT002')
Insert into Comments values('AT003', N'đã đánh giá AT003')

select* from productTypes