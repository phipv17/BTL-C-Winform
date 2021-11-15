use master
go
create database HotelManagerNew
go
use HotelManagerNew
go

create table chucvu(
	macv char(2) primary key,
	tencv nvarchar(30) not null
)
go
insert into chucvu values('GD',N'Giám đốc')
insert into chucvu values('PD',N'Phó Giám đốc')
insert into chucvu values('KT',N'Kế toán')
insert into chucvu values('TK',N'Thư ký')
insert into chucvu values('LT',N'Lễ tân')
insert into chucvu values('PV',N'Phục vụ')
insert into chucvu values('BV',N'Bảo vệ')
go

create table nhanvien(
	manv char(5) primary key,
	macv char(2) foreign key references chucvu(macv) not null,
	hoten nvarchar(30) not null,
	ngaysinh date check(ngaysinh < getdate()) not null,
	gioitinh nvarchar(3) check(gioitinh in(N'Nam',N'Nữ')) not null,
	sdt varchar(12) check(sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	cmnd char(9) check(cmnd like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') unique not null,
	diachi nvarchar(50) not null,
	email varchar(30) unique check(email  like '[a-z]%@[a-z]%.[a-z]%'),
)


create table TaiKhoan(
	tentaikhoan nvarchar(20) not null primary key,
	hoten nvarchar(30) not null,
	matkhau nvarchar(8) not null,
	quyen nvarchar(20) not null,
)

insert into TaiKhoan values('Phipv','Phạm Văn Phi','123456','Quản trị')
insert into TaiKhoan values('Thaovp','Vũ Phương Thảo','123456','Nhân viên')
insert into TaiKhoan values('Anhvn','Nguyễn Vân Anh','123456','Nhân viên')

select * from TaiKhoan

GO

insert into nhanvien values('NV001','GD',N'Phạm Văn Phi',convert(date,'02/06/1989',105),N'Nam','01228030531','212555660',N'Hải Hậu, Nam Định','phipv@gmail.com')
insert into nhanvien values('NV002','LT',N'Nguyễn Vân Anh',convert(date,'03/02/1995',105),N'Nữ','01245789613','124965327',N'Thanh Ba, Phú Thọ','vana2@gmail.com')
insert into nhanvien values('NV003','LT',N'Vũ Phương Thảo',convert(date,'05/10/1996',105),N'Nữ','01228030533','212555662',N'Từ Sơn, Bắc Ninh','thaovp@gmail.com')

select * from nhanvien



create table loaiphong(
	tenlp varchar(10) primary key,
	soluongtrong int not null,
	giaphong int not null,
	soluongco int not null,
)
 select * from loaiphong
go

select * from loaiphong

insert into loaiphong values('Standard',10,200000,10)
insert into loaiphong values('Deluxe',10,300000,10)
insert into loaiphong values('Suite',5,400000,5)
insert into loaiphong values('Superio',5,500000,5)

create table phong(
	maphong char(4) primary key,
	tenlp varchar(10) foreign key references loaiphong(tenlp),
	tinhtrang bit
)
select * from phong
go
insert into phong values('S503','Standard',0)
insert into phong values('S504','Standard',0)
insert into phong values('S505','Standard',0)
insert into phong values('S403','Standard',0)
insert into phong values('S404','Standard',0)
insert into phong values('S405','Standard',0)
insert into phong values('S303','Standard',0)
insert into phong values('S304','Standard',0)
insert into phong values('S305','Standard',0)
insert into phong values('S205','Standard',0)
insert into phong values('D501','Deluxe',0)
insert into phong values('D502','Deluxe',0)
insert into phong values('D401','Deluxe',0)
insert into phong values('D402','Deluxe',0)
insert into phong values('D301','Deluxe',0)
insert into phong values('D302','Deluxe',0)
insert into phong values('D203','Deluxe',0)
insert into phong values('D204','Deluxe',0)
insert into phong values('D104','Deluxe',0)
insert into phong values('D105','Deluxe',0)
insert into phong values('E201','Suite',0)
insert into phong values('E202','Suite',0)
insert into phong values('E103','Suite',0)
insert into phong values('E102','Suite',0)
insert into phong values('E101','Suite',0)
insert into phong values('V001','Superio',0)
insert into phong values('V002','Superio',0)
insert into phong values('V003','Superio',0)
insert into phong values('V004','Superio',0)
insert into phong values('V005','Superio',0)
select * from phong
select tenlp from phong where maphong = 'V004'
go

create table khachhang(
	makh char(5) primary key,
	hoten nvarchar(30) not null,
	cmnd char(9) check(cmnd like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') unique not null,
	sdt varchar(12) check(sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	email varchar(30) unique check(email  like '[a-z]%@[a-z]%.[a-z]%'),
	diachi nvarchar(50) not null
)
go
insert into khachhang values('KH001',N'Phạm Văn Phi','222555888','0909050505','phipv@yahoo.com',N'Nam Định')
insert into khachhang values('KH002',N'Lê Hồng Lâm','222777511','01668135131','lamle@yahoo.com',N'Hà Tĩnh')
insert into khachhang values('KH003',N'Mai Văn Nam','222555782','0909050805','nam@yahoo.com',N'Thanh Hóa')
insert into khachhang values('KH004',N'Hà Thị Nhiên','222444456','01668135181','nhien@yahoo.com',N'Thái Bình')
insert into khachhang values('KH005',N'Nguyễn Thị Hương','229995753','0913050505','thaison@yahoo.com',N'Hải Phòng')
go
select * from khachhang
create table dichvu(
	madv nvarchar(20) not null primary key,
	tendv nvarchar(20),
	gia money,
)

go

insert into dichvu values ('DV001',N'Bò húc', 12000)
insert into dichvu values ('DV002',N'Mirinda', 120000)
insert into dichvu values ('DV003',N'Cơm gà', 25000)
insert into dichvu values ('DV004',N'Cơm rang', 15000)
insert into dichvu values ('DV005',N'Nước khoáng', 10000)
insert into dichvu values ('DV006',N'Phở bò', 20000)
insert into dichvu values ('DV007', N'Không có dịch vụ',0)

create table datphong(
	madp char(5) primary key,
	manv char(5) foreign key references nhanvien(manv) not null,
	makh char(5) foreign key references khachhang(makh) not null,
	tenlp varchar(10) foreign key references loaiphong(tenlp) not null,
	ngaydat date default(getdate()) not null,
	ngayden date default(getdate()) not null,
	ngaydi date default(getdate()) not null,
	soluong int not null	,
	trangthaitt nvarchar not null,
	dsphong nvarchar(200)
)


select * from khachhang
alter table datphong drop COLUMN trangthaitt
alter table datphong add trangthaitt nvarchar(30)
select * from datphong

insert into datphong values('DP001','NV002','KH001','Superio',getdate(),convert(date,'27/05/2021',105),convert(date,'28/05/2021',105),1,'Đã thanh toán')
insert into datphong values('DP002','NV002','KH002','Standard',getdate(),convert(date,'29/05/2015',105),convert(date,'30/05/2021',105),1,'Đã thanh toán')

select * from datphong
select * from datphong

go

create table hoadon(
	mahd char(5) primary key,
	madp char(5) foreign key references datphong(madp) not null,
	madv nvarchar(20) not null foreign key references dichvu(madv),
	ngaylap date default(getdate()) not null,
	tongtien money not null
)
select * from datphong

insert into hoadon values('HD001','DP005','DV001',getdate(),2400000)

go
select * from nhanvien where gioitinh='Nam'

select * from datphong
select * from khachhang
select * from datphong
select * from hoadon