create database QuanLyDiemSinhVien
use QuanLyDiemSinhVien

create table Khoa   
(    
MaKhoa varchar(50) not null,
TenKhoa nvarchar(50) not null,

constraint pk_Khoa
primary key (MaKhoa),

constraint unique_Khoa
unique (TenKhoa)
)
create table Lop   
(
 MaLop varchar(50) not null,
 TenLop nvarchar(50) not null,
 MaKhoa varchar(50) not null,
 
constraint pk_Lop
primary key (MaLop),
 
constraint unique_Lop
unique (TenLop),

constraint fk_Lop_Khoa
foreign key (MaKhoa)
references Khoa(MaKhoa)
)


create table SinhVien     
(
 MaSinhVien varchar(50) not null,
 HoTen nvarchar(50) not null,
 GioiTinh nvarchar(50),
 NgaySinh varchar(50) ,
 QueQuan nvarchar(50),
 Khoas varchar(50) not null,
 MaLop varchar(50) not null,

 constraint pk_SinhVien
 primary key (MaSinhVien),

 constraint fk_SinhVien_Lop
foreign key (MaLop)
references Lop(MaLop)
)

create table BoMon
(
 MaBoMon varchar(50) not null,
 TenBoMon nvarchar(50) not null,
 MaKhoa varchar(50) not null,

 constraint pk_BoMon
 primary key (MaBoMon),

 constraint fk_BoMon
 foreign key (MaKhoa)
 references Khoa(MaKhoa)
)

create table MonHoc 
(
 MaMon varchar(50) not null,
 TenMon nvarchar(50) not null,
 SoTC int not null,
 MaBoMon varchar(50) not null,
 
 constraint pk_MonHoc
 primary key (MaMon),

 constraint fk_MonHoc
 foreign key (MaBoMon)
 references BoMon(MaBoMon)
)

create table HocKy 
(
 MaHocKy varchar(50) not null,
 TenHocKy nvarchar(50) not null,
 Nam varchar(50) not null,

 constraint pk_HocKy
 primary key (MaHocKy)
)


create table LopHocPhan 
(
  MaHocPhan nvarchar(50) not null,
  TenHocPhan nvarchar(50) not null,
  MaMon varchar(50) not null,
  MaHocKy varchar(50) not null,

  Constraint pk_LopHocPhan
  primary key (MaHocPhan),

  constraint fk_LopHocPhan_Mon
  foreign key (MaMon)
  references MonHoc(MaMon),

  constraint fk_LopHocPhan_HocKy
  foreign key (MaHocKy)
  references HocKy(MaHocKy),
)

create table SinhVien_LopHocPhan  
(
   MaSinhVien varchar(50) not null,
   MaHocPhan nvarchar(50)  not null,

   Constraint pk_SinhVien_LopHocPhan
   primary key (MaSinhVien,MaHocPhan),

   Constraint fk_SinhVien_LopHocPhan1
   foreign key (MaSinhVien)
   references SinhVien(MaSinhVien),

   Constraint fk_SinhVien_LopHocPhan2
   foreign key (MaHocPhan)
   references LopHocPhan(MaHocPhan)
)
create table Diem
(
  MaSinhVien varchar(50) not null,
  MaHocPhan nvarchar(50) not null,
  LanThi int ,
  DiemThi float not null,
  DiemQuaTrinh float not null,

  constraint pk_Diem
  primary key (MaSinhVien,MaHocPhan),

  constraint fk_Diem_SinhVien
  foreign key (MaSinhVien)
  references SinhVien(MaSinhVien),

  constraint fk_Diem_LopHocPhan
  foreign key (MaHocPhan)
  references LopHocPhan(MaHocPhan)
)




------------------------------------------------------Nhập giá trị------------------------------------------------------------------------
--Nhập thông tin khoa
Insert into Khoa values('CK',N'Cơ khí')
Insert into Khoa values('CNTT',N'Công nghệ thông tin')
Insert into Khoa values('DDT',N'Điện điện tử')
Insert into Khoa values('CDT',N'Cơ điện tử')
Insert into Khoa values('KT',N'Kinh tế')

--Nhập thông tin bộ môn
Insert into BoMon values('KHMT',N'Khoa học máy tính','CNTT') 
Insert into BoMon values('CNPM',N'Công nghệ phần mềm','CNTT') 
Insert into BoMon values('M-HTTT',N'Mạng và hệ thống thông tin','CNTT') 
Insert into BoMon values('CNGT',N'Công nghệ giao thông','CNTT') 

--Nhập thông tin lớp
Insert into Lop values('CNTT1-K59',N'Công nghệ thông tin 1 K59','CNTT')
Insert into Lop values('CNTT2-K59',N'Công nghệ thông tin 2 K59','CNTT')
Insert into Lop values('CNTT3-K59',N'Công nghệ thông tin 3 K59','CNTT')
Insert into Lop values('CNTT4-K59',N'Công nghệ thông tin 4 K59','CNTT')

--Nhập thông tin Mon hoc
Insert into MonHoc values('KHM07.3',N'An toàn bảo mật thông tin',30,'KHMT')
Insert into MonHoc values('CPM212.3',N'Lập trình sử dụng API',30,'CNPM')
Insert into MonHoc values('MHT234.3',N'Lập trình thiết bị di động',45,'M-HTTT')
Insert into MonHoc values('MHT208.3',N'Lập trình Web',45,'M-HTTT')
Insert into MonHoc values('KHM25.3',N'Lý thuyết trò chơi và ứng dụng',30,'KHMT')

--Nhập thông tin học kỳ
Insert into HocKy values('2019-2020.1',N'Học kỳ 1 năm 2019-2020','2019-2020')
Insert into HocKy values('2019-2020.2',N'Học kỳ 2 năm 2019-2020','2019-2020')
Insert into HocKy values('2020-2021.1',N'Học kỳ 1 năm 2020-2021','2020-2021')
Insert into HocKy values('2020-2021.2',N'Học kỳ 2 năm 2020-2021','2020-2021')

--Nhập thông tin lớp học phần 
Insert into LopHocPhan values('KHM07.3.N01',N'An toàn bảo mật thông tin N01','KHM07.3','2020-2021.1')
Insert into LopHocPhan values('CPM212.3.N01',N'Lập trình sử dụng API N01','CPM212.3','2020-2021.1')
Insert into LopHocPhan values('MHT234.3.N01',N'Lập trình thiết bị di động N01','MHT234.3','2020-2021.1')
Insert into LopHocPhan values('MHT208.3.N01',N'Lập trình Web N01','MHT208.3','2020-2021.1')
Insert into LopHocPhan values('KHM25.3.N01',N'Lý thuyết trò chơi và ứng dụng N01','KHM25.3','2020-2021.1')

--Nhập thông tin sinh viên
Insert into SinhVien values('181202001',N'Đinh Mạnh Chiến',N'Nam','12/1/2000',N'Hà Giang','K59','CNTT1-K59')
Insert into SinhVien values('181202002',N'Trần Đăng Dũng',N'Nam','4/3/2000',N'Hà Nội','K59','CNTT1-K59')
Insert into SinhVien values('181202003',N'Trần Hoàng Nam',N'Nam','5/1/2000',N'Bắc cạn','K59','CNTT1-K59')
Insert into SinhVien values('181202004',N'Lê Đăng Dung',N'Nữ','12/1/2000',N'Hà Giang','K59','CNTT1-K59')
Insert into SinhVien values('181202005',N'Trần Thị Điểm',N'Nữ','12/1/2000',N'Hà Giang','K59','CNTT1-K59')
Insert into SinhVien values('181202006',N'Nguyễn Văn A',N'Nữ','12/1/2000',N'Hà Giang','K59','CNTT3-K59')
--Nhập thông tin sinh viên lớp học phần
Insert into SinhVien_LopHocPhan values('181202001','KHM07.3.N01')
Insert into SinhVien_LopHocPhan values('181202001','CPM212.3.N01')
Insert into SinhVien_LopHocPhan values('181202001','MHT234.3.N01')
Insert into SinhVien_LopHocPhan values('181202001','MHT208.3.N01')
Insert into SinhVien_LopHocPhan values('181202001','KHM25.3.N01')

Insert into SinhVien_LopHocPhan values('181202002','KHM07.3.N01')
Insert into SinhVien_LopHocPhan values('181202002','CPM212.3.N01')
Insert into SinhVien_LopHocPhan values('181202002','MHT234.3.N01')
Insert into SinhVien_LopHocPhan values('181202002','MHT208.3.N01')
Insert into SinhVien_LopHocPhan values('181202002','KHM25.3.N01')

Insert into SinhVien_LopHocPhan values('181202003','KHM07.3.N01')
Insert into SinhVien_LopHocPhan values('181202003','CPM212.3.N01')
Insert into SinhVien_LopHocPhan values('181202003','MHT234.3.N01')
Insert into SinhVien_LopHocPhan values('181202003','MHT208.3.N01')
Insert into SinhVien_LopHocPhan values('181202003','KHM25.3.N01')

Insert into SinhVien_LopHocPhan values('181202004','KHM07.3.N01')
Insert into SinhVien_LopHocPhan values('181202004','CPM212.3.N01')
Insert into SinhVien_LopHocPhan values('181202004','MHT234.3.N01')
Insert into SinhVien_LopHocPhan values('181202004','MHT208.3.N01')
Insert into SinhVien_LopHocPhan values('181202004','KHM25.3.N01')

Insert into SinhVien_LopHocPhan values('181202005','KHM07.3.N01')
Insert into SinhVien_LopHocPhan values('181202005','CPM212.3.N01')
Insert into SinhVien_LopHocPhan values('181202005','MHT234.3.N01')
Insert into SinhVien_LopHocPhan values('181202005','MHT208.3.N01')
Insert into SinhVien_LopHocPhan values('181202005','KHM25.3.N01')

--Nhập thông tin điểm
Insert into Diem values('181202001','KHM07.3.N01',1,7,8)
Insert into Diem values('181202001','CPM212.3.N01',1,5,8)
Insert into Diem values('181202001','MHT234.3.N01',1,6,8)
Insert into Diem values('181202001','MHT208.3.N01',1,5,5.5)
Insert into Diem values('181202001','KHM25.3.N01',1,7,8)

Insert into Diem values('181202002','KHM07.3.N01',1,5,8)
Insert into Diem values('181202002','CPM212.3.N01',1,5,8)
Insert into Diem values('181202002','MHT234.3.N01',1,6,8)
Insert into Diem values('181202002','MHT208.3.N01',1,5,5.5)
Insert into Diem values('181202002','KHM25.3.N01',1,7,8)

Insert into Diem values('181202003','KHM07.3.N01',1,7,8)
Insert into Diem values('181202003','CPM212.3.N01',1,5,8)
Insert into Diem values('181202003','MHT234.3.N01',1,6,8)
Insert into Diem values('181202003','MHT208.3.N01',1,5,5.5)
Insert into Diem values('181202003','KHM25.3.N01',1,7,8)

Insert into Diem values('181202004','KHM07.3.N01',1,7,8)
Insert into Diem values('181202004','CPM212.3.N01',1,5,8)
Insert into Diem values('181202004','MHT234.3.N01',1,6,8)
Insert into Diem values('181202004','MHT208.3.N01',1,5,5.5)
Insert into Diem values('181202004','KHM25.3.N01',1,7,8)

Insert into Diem values('181202005','KHM07.3.N01',1,7,8)
Insert into Diem values('181202005','CPM212.3.N01',1,5,8)
Insert into Diem values('181202005','MHT234.3.N01',1,6,8)
Insert into Diem values('181202005','MHT208.3.N01',1,5,5.5)
Insert into Diem values('181202005','KHM25.3.N01',1,7,8)


-------------------------------------------------------Nội thủ tục------------------------------------------------------------------------

create proc dataKhoaByMaKhoa @makhoa varchar(50)  --Tìm Khoa khi biết mã khoa
as
begin
 select * from Khoa
 where MaKhoa = @makhoa
end


create proc dataLopByMaLop @malop varchar(50) as
begin
 select MaLop,TenLop,MaKhoa
 from Lop 
 where MaLop = @malop
end

create proc MaLopByMaKhoa @makhoa varchar(50) as 
begin
   select MaLop from Lop
   where MaKhoa = @makhoa
end

create proc dataSinhVienByMaSV @masv varchar(50)
as
begin
   select * from View_SinhVien
   where MaSinhVien = @masv
end

create proc MaSinhVienByMaLop @malop varchar(50) as
begin
 select MaSinhVien from SinhVien where MaLop = @malop
end


create proc dataSinhVienByMaLop @malop varchar(50) as
begin
   select * from View_SinhVien
   where MaLop = @malop
end

create proc dataMonHocByMaMon @mamon varchar(50)
as begin
 select * from MonHoc where MaMon = @mamon
end

create proc MaHocPhanByMaSV @masinhvien varchar(50) as
begin
 select MaHocPhan from SinhVien_LopHocPhan where MaSinhVien = @masinhvien
end

create proc dataDiemByMaHocKy @mahocky varchar(50) as
begin
 select View_Diem.MaSinhVien,HoTen,View_Diem.MaHocPhan,LopHocPhan.MaMon,TenMon,LanThi,DiemThi,DiemQuaTrinh,DiemTK,DanhGia 
 from View_Diem join LopHocPhan on View_Diem.MaHocPhan = LopHocPhan.MaHocPhan
 where MaHocKy = @mahocky
end

create proc dataDiemByMaSinhVien @masinhvien varchar(50) as
begin
 select * from View_Diem where MaSinhVien = @masinhvien
end

create proc dataDiemBy_SV_HK @mahocky varchar(50),@maSV varchar(50) as
begin
 select View_Diem.MaSinhVien,HoTen,View_Diem.MaHocPhan,LopHocPhan.MaMon,TenMon,LanThi,DiemThi,DiemQuaTrinh,DiemTK,DanhGia 
 from View_Diem join LopHocPhan on View_Diem.MaHocPhan = LopHocPhan.MaHocPhan
 where MaHocKy = @mahocky and MaSinhVien = @maSV
end 

create proc DSDiem_Lop_HocKy @malop varchar(50),@mahocky varchar(50) as
begin
 select View_Diem.MaSinhVien,View_Diem.HoTen,View_Diem.MaHocPhan,LopHocPhan.MaMon,TenMon,LanThi,DiemThi,DiemQuaTrinh,DiemTK,DanhGia 
 from View_Diem,SinhVien ,Lop,LopHocPhan
 where View_Diem.MaSinhVien=SinhVien.MaSinhVien and SinhVien.MaLop = Lop.MaLop and View_Diem.MaHocPhan = LopHocPhan.MaHocPhan 
       and SinhVien.MaLop = @malop and MaHocKy = @mahocky 
end

create proc DSDiem_Lop_HocKy_Mon @malop varchar(50),@mamon varchar(50) as
begin
 select View_Diem.MaSinhVien,View_Diem.HoTen,View_Diem.MaHocPhan,LopHocPhan.MaMon,TenMon,LanThi,DiemThi,DiemQuaTrinh,DiemTK,DanhGia 
 from View_Diem,SinhVien ,Lop,LopHocPhan
 where View_Diem.MaSinhVien=SinhVien.MaSinhVien and SinhVien.MaLop = Lop.MaLop and View_Diem.MaHocPhan = LopHocPhan.MaHocPhan 
       and SinhVien.MaLop = @malop and LopHocPhan.MaMon = @mamon
end
------------------------------------------------------------Tạo view----------------------------------------------------------------------
create view View_Khoa as 
select * from Khoa

create view View_Lop as        
select * from Lop

create view View_Mon as  
select * from MonHoc

create view View_Diem as
select Diem.MaSinhVien,HoTen,Diem.MaHocPhan,LopHocPhan.MaMon,TenMon,LanThi,DiemThi,DiemQuaTrinh,
		[dbo].DiemTK(Diem.MaSinhVien,Diem.MaHocPhan) as 'DiemTK',
		[dbo].DanhGia(Diem.MaSinhVien,Diem.MaHocPhan) as 'DanhGia'
from ((Diem join SinhVien on Diem.MaSinhVien = SinhVien.MaSinhVien) join LopHocPhan on Diem.MaHocPhan = LopHocPhan.MaHocPhan) join MonHoc on LopHocPhan.MaMon = MonHoc.MaMon


create view View_SinhVien as
select MaSinhVien,HoTen,GioiTinh,NgaySinh,QueQuan,Khoas,SinhVien.MaLop,Lop.MaKhoa
from SinhVien join Lop on SinhVien.MaLop = Lop.MaLop

create view SinhVien_HocKy_TongSoTC as
select MaSinhVien,MaHocKy,sum(SoTC) as TongSoTC
from (SinhVien_LopHocPhan join LopHocPhan on SinhVien_LopHocPhan.MaHocPhan = LopHocPhan.MaHocPhan)join MonHoc on LopHocPhan.MaMon = MonHoc.MaMon
group by MaSinhVien,MaHocKy

create view SinhVien_HocKy_DiemTK as
select MaSinhVien,MaHocKy,[dbo].[DiemTongKetHocKy](MaSinhVien,MaHocKy) as DTK
from SinhVien_LopHocPhan join LopHocPhan on SinhVien_LopHocPhan.MaHocPhan = LopHocPhan.MaHocPhan
group by MaSinhVien,MaHocKy

create view TongKetMon as
select MaSinhVien,LopHocPhan.MaMon,max([dbo].DiemTK(MaSinhVien,LopHocPhan.MaMon)) as DiemTongKet 
from (Diem join LopHocPhan on Diem.MaHocPhan = LopHocPhan.MaHocPhan) join MonHoc on LopHocPhan.MaMon = MonHoc.MaMon
group by MaSinhVien,LopHocPhan.MaMon

 
------------------------------------------------------------Trigger ----------------------------------------------------------------------
create trigger CapNhapLanThi on Diem for insert as 
begin
	declare @masv varchar(50),@mahp nvarchar(50),@mamon varchar(50),@lanthi int 
	select @mamon = MaMon,@mahp = inserted.MaHocPhan, @masv = inserted.MaSinhVien
	from inserted  join LopHocPhan on inserted.MaHocPhan = LopHocPhan.MaHocPhan 
	
	set @lanthi=( select count(MaHocPhan) 
	              from (select MaSinhVien,Diem.MaHocPhan,MaMon
	                    from Diem full join LopHocPhan on Diem.MaHocPhan = LopHocPhan.MaHocPhan) as A
	             where MaMon = @mamon and MaSinhVien = @masv
	             group By MaSinhVien )
	update Diem set LanThi = @lanthi where MasinhVien =@masv and MaHocPhan = @mahp
end


create trigger CheckDiem on Diem for insert,update as
begin
 declare @diemthi float,@diemQT float
 select @diemthi = DiemThi,@diemQT = DiemQuaTrinh
 from inserted
 if (@diemthi not between 0 and 10) or (@diemQT not between 0 and 10)
 rollback transaction
end

------------------------------------------------------------Function ----------------------------------------------------------------------
create function DiemTK(@masv varchar(50),@mahp nvarchar(50)) returns float
as begin
 declare @dqt float,@dt float
 select @dqt = DiemQuaTrinh,@dt = DiemThi from Diem 
 where MaSinhVien = @masv and MaHocPhan = @mahp
 return ROUND((@dqt * 0.3 + @dt * 0.7),2)
end

create function DanhGia(@masv varchar(50),@mahp nvarchar(50)) returns nvarchar(50)
as begin
  declare @danhgia nvarchar(50)
  if [dbo].[DiemTK](@masv,@mahp) >= 4 set @danhgia = N'Đạt'
  else set @danhgia = N'Chưa đạt'
  return @danhgia
end

create function HocKy_TongSoTC(@masv varchar(50),@mahk varchar(50)) returns int
as begin
declare @tongSoTC int
select @tongSoTC = sum(SoTC)
from (SinhVien_LopHocPhan join LopHocPhan on SinhVien_LopHocPhan.MaHocPhan = LopHocPhan.MaHocPhan) join MonHoc on LopHocPhan.MaMon = MonHoc.MaMon
where MaSinhVien = @masv and MaHocKy = @mahk
group by MaSinhVien,MaHocKy
return @tongSoTC
end

create function DiemTongKetHocKy(@masv varchar(50),@mahk varchar(50)) returns float
as begin
declare @diemTK float
select @diemTK = ROUND(sum(DiemTK * SoTC)/sum(SoTC),2)
from (View_Diem join LopHocPhan on View_Diem.MaHocPhan = LopHocPhan.MaHocPhan)
      join MonHoc on LopHocPhan.MaMon = MonHoc.MaMon
where MaSinhVien = @masv and MaHocKy = @mahk
return @diemTK
end


--------------------------------------------- Các câu lệnh ngôn ngữ điều khiển dữ liệu-------------------------------------------------------

CREATE LOGIN GiaoThongVanTai    --Tạo login
WITH PASSWORD = '12345678'

CREATE USER Admin               --Tạo user
FOR LOGIN GiaoThongVanTai

GRANT insert,update,delete,select,alter ON Diem to Admin   
--Cấp phép các quyền insert,update ,detele,select,alter cho người dùng có tên là Admin trên bảng Diem









