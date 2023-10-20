use Supermarker
create table Producto
(
 Product_Id int identity (100000,1) primary key,
 Product_Name nvarchar (50) not null,
 Product_Observation nvarchar (50) not null,
)

