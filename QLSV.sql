--DROP DATABASE QuanLySinhVien2

CREATE DATABASE QuanLySinhVien2

USE QuanLySinhVien2
--USE master

CREATE TABLE SinhVien
(
	MSSV INT IDENTITY NOT NULL PRIMARY KEY,
	TenDangNhap NVARCHAR(20) NOT NULL,
	Ten nvarchar(20),
	Ho nvarchar(20),
	Pass NVARCHAR(20),
	NgayThangNamSinh DATETIME,
	GioiTinh INT,
	SoDienThoai nvarchar(15),
	QueQuan NVARCHAR(20),
	Anh IMAGE,
	Tucach INT,
	Deleted INT DEFAULT 0 NOT NULL
)

CREATE TABLE GiangVien
(
	MSGV INT IDENTITY NOT NULL PRIMARY KEY,
	TenDangNhap NVARCHAR(20) NOT NULL,
	Ten nvarchar(20),
	Ho nvarchar(20),
	Pass NVARCHAR(20),
	NgayThangNamSinh DATETIME,
	GioiTinh INT,
	SoDienThoai nvarchar(15),
	QueQuan NVARCHAR(20),
	Anh IMAGE,
	Tucach INT,
	Deleted INT DEFAULT 0 NOT NULL
)

--ALTER TABLE dbo.SinhVien
--ADD Deleted INT DEFAULT 0 NOT NULL

--ALTER TABLE dbo.GiangVien
--ADD Deleted INT DEFAULT 0 NOT NULL

CREATE TABLE AdminSys
(
	MSAD INT IDENTITY NOT NULL PRIMARY KEY,
	TenDangNhap NVARCHAR(20) NOT NULL,
	Ten nvarchar(20),
	Ho nvarchar(20),
	Pass NVARCHAR(20),
	NgayThangNamSinh DATETIME,
	GioiTinh INT,
	SoDienThoai nvarchar(15),
	QueQuan NVARCHAR(20),
	Anh IMAGE,
	Tucach INT
)

CREATE TABLE MonHoc
(
	MaMH INT NOT NULL IDENTITY PRIMARY KEY,
	TenMH nvarchar(70),
	TinChi INT
)

--CREATE TABLE GiangVienMonHoc
--(
--	MSGV INT NOT NULL FOREIGN KEY REFERENCES dbo.GiangVien(MSGV),
--	MaMH INT NOT NULL FOREIGN KEY REFERENCES MonHoc(MaMH),
--	PRIMARY KEY(MSGV, MaMH)
--)

CREATE TABLE LopHoc
(
	MaLop INT NOT NULL IDENTITY PRIMARY KEY,
	MaGV INT FOREIGN KEY REFERENCES dbo.GiangVien(MSGV),
	MaMH INT FOREIGN KEY REFERENCES MonHoc(MaMH),
	HocKy CHAR(5) CHECK (HocKy IN ('HK1', 'HK2', 'HK3')),
	NamHoc CHAR(15),
	SiSo INT
)

--CREATE TABLE Diem
--(
--	MaDiem INT NOT NULL IDENTITY PRIMARY KEY,
--	MaMH INT FOREIGN KEY REFERENCES dbo.MonHoc(MaMH),
--	MaSV INT FOREIGN KEY REFERENCES dbo.SinhVien(MSSV),
--	DiemTK FLOAT DEFAULT 0,
--	DiemGK FLOAT DEFAULT 0,
--	DiemCK FLOAT DEFAULT 0,
--	DiemTongKet FLOAT DEFAULT 0,
--	XepLoai CHAR(5) CHECK(XepLoai IN ('A', 'B', 'C', 'D', 'F'))
--)

CREATE TABLE LopSinhVien
(
	MaLop INT NOT NULL FOREIGN KEY REFERENCES LopHoc(MaLop),
	MaSV INT FOREIGN KEY REFERENCES dbo.SinhVien(MSSV),
	DiemTK FLOAT DEFAULT 0,
	DiemGK FLOAT DEFAULT 0,
	DiemCK FLOAT DEFAULT 0,
	DiemTongKet FLOAT DEFAULT 0,
	XepLoai CHAR(5) CHECK(XepLoai IN ('A', 'B', 'C', 'D'))
	PRIMARY KEY(MaLop, MaSV)
)

GO
CREATE TRIGGER sp_Updatediem
ON dbo.LopSinhVien FOR UPDATE, INSERT
AS BEGIN
	DECLARE @masv INT, @malop INT 
	SELECT @masv = i.MaSV, @malop = i.MaLop FROM Inserted i

	UPDATE dbo.LopSinhVien
	SET DiemTongKet = 0.2 * DiemTK + 0.3 * DiemGK + 0.5 * DiemCK
	WHERE MaLop = @malop AND MaSV = @masv

	UPDATE dbo.LopSinhVien
	SET XepLoai = 
			CASE 
				WHEN DiemTongKet < 5 THEN 'D'
				WHEN DiemTongKet >= 5 AND DiemTongKet < 7 THEN 'C'
				WHEN DiemTongKet >= 7 AND DiemTongKet < 9 THEN 'B'
				ELSE 'A'
			END
	WHERE MaLop = @malop AND MaSV = @masv
END 

INSERT dbo.SinhVien(TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, Anh, Tucach)
VALUES('quanghuy124', 'Huy', N'Nguyễn Quang', '123456', '1998-6-7', 1, '0908371510', N'Ninh Thuận', NULL, 0),
	  ('minhhau7411', N'Hậu', N'Đỗ Minh', '234567', '1998-4-1', 1, '0733112548', N'An Giang', NULL, 0),
	  ('binhpham1214', N'Bình', N'Phạm Thái', '345678', '1998-12-14', 1, '5151515510', N'Thái Bình', NULL, 0),
	  ('maingoc444', N'Ngọc', N'Mai Thị', '456789', '1998-7-2', 0, '851151555', N'Đồng Tháp', NULL, 0)

INSERT dbo.GiangVien(TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, Anh, Tucach)
VALUES('longlong441', 'Long', N'Đỗ Văn', '111111', '1967-3-4', 1, '0123457888', 'TP. HCM', NULL, 1),
	  ('hoahoa111', 'Hoa', N'Nguyễn VĂn', '222222', '1955-3-24', 0, '0254852291', 'TP. HCM', NULL, 1)

INSERT dbo.AdminSys(TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, Anh, Tucach)
VALUES('admin', 'admin', 'system', 'pass', GETDATE(), 1, '', '', NULL, 2)

INSERT dbo.MonHoc(TenMH, TinChi)
VALUES(N'Lý Thuyết đồ thị', 3),
	  (N'Ngôn ngữ học', 4),
	  (N'Tư tưởng Hồ Chí Minh', 2)

INSERT dbo.LopHoc(MaGV, MaMH, HocKy, NamHoc, SiSo)
VALUES(1, 1, 'HK1', '2018-2019', 55),
	  (1, 2, 'HK1', '2018-2019', 30),
	  (2, 3, 'HK1', '2018-2019', 80)

INSERT dbo.LopSinhVien(MaLop, MaSV)
VALUES(1, 1), (1, 2),
	  (2, 1), (2, 2), (2, 4),
	  (3, 2), (3, 3)
	  GO 
-- check đăng nhập
CREATE VIEW view_BangDangNhap
as
	SELECT TenDangNhap, Pass, MSSV, Tucach, Deleted FROM dbo.SinhVien 
		UNION 
	SELECT TenDangNhap, Pass, MSGV, Tucach, Deleted FROM dbo.GiangVien 
		UNION 
	SELECT TenDangNhap, Pass, MSAD, Tucach, 0 FROM dbo.AdminSys
GO 
CREATE PROC sp_GetAllPerson
AS SELECT * FROM dbo.view_BangDangNhap

EXEC dbo.sp_GetAllPerson

-- Lấy thông tin của một người khi biết mã số và tư cách
DECLARE @tc INT, @mssv int
SET @tc = 1
SET @mssv = 1

GO 
CREATE PROC sp_GetInfo @tc INT, @ms INT
AS
	BEGIN
	    IF @tc = 0 SELECT * FROM dbo.SinhVien WHERE MSSV = @ms
		IF @tc = 1 SELECT * FROM dbo.GiangVien WHERE MSGV = @ms
		IF @tc = 2 SELECT * FROM dbo.AdminSys WHERE MSAD = @ms
	END
GO 
EXEC dbo.sp_GetInfo 1, 1

GO 
-- lấy thông tin lớp sinh viên đang học
CREATE PROC sp_GetHocKy
AS BEGIN
	SELECT DISTINCT HocKy
	FROM dbo.LopHoc
END
GO 

CREATE PROC sp_GetNamHoc
AS BEGIN
	SELECT DISTINCT NamHoc
	FROM dbo.LopHoc
END


-- Các lớp sinh viên đang học
SELECT ls.MaLop, m.TenMH, g.Ho + ' ' + g.Ten AS TenGV, l.HocKy, l.NamHoc, l.SiSo
FROM dbo.LopSinhVien ls JOIN dbo.LopHoc l ON l.MaLop = ls.MaLop
						JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
						JOIN dbo.GiangVien g ON l.MaGV = g.MSGV
WHERE ls.MaSV = 1 AND l.HocKy = 'HK1' AND l.NamHoc = '2018-2019'



-- Các lớp sinh viên chưa đăng kí
SELECT l.MaLop, m.TenMH, g.Ho + ' ' + g.Ten AS TenGV, l.HocKy, l.NamHoc, l.SiSo
FROM dbo.LopHoc l JOIN dbo.GiangVien g ON g.MSGV = l.MaGV
				  JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
WHERE MaLop NOT IN (SELECT MaLop FROM dbo.LopSinhVien WHERE MaSV = 1)
	  AND l.HocKy = 'HK1' AND l.NamHoc = '2018-2019'


-- lấy thông tin các lớp gv đang dạy
SELECT l.MaLop, m.TenMH, g.Ho + ' ' + g.Ten AS TenGV, l.HocKy, l.NamHoc, l.SiSo
FROM dbo.LopHoc l JOIN dbo.GiangVien g ON l.MaGV = g.MSGV
				  JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
WHERE l.MaGV = 1 AND l.HocKy = 'HK1' AND l.NamHoc = '2018-2019'

GO 

ALTER PROC sp_GetClassInfo @hk CHAR(5), @namhoc CHAR(15), @tc INT, @ms INT, @dadk INT 
AS
BEGIN
    IF @tc = 0 
		BEGIN
			IF @dadk = 1
				BEGIN
					SELECT ls.MaLop, m.TenMH, g.Ho + ' ' + g.Ten AS TenGV, l.HocKy, l.NamHoc, l.SiSo
					FROM dbo.LopSinhVien ls JOIN dbo.LopHoc l ON l.MaLop = ls.MaLop
											JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
											JOIN dbo.GiangVien g ON l.MaGV = g.MSGV
					WHERE ls.MaSV = @ms AND l.HocKy = @hk AND l.NamHoc = @namhoc
				END
			ELSE
				BEGIN
					SELECT l.MaLop, m.TenMH, g.Ho + ' ' + g.Ten AS hoten, l.HocKy, l.NamHoc, l.SiSo, COUNT(l.MaLop) AS DaDK
					FROM dbo.LopSinhVien ls RIGHT JOIN dbo.LopHoc l ON l.MaLop = ls.MaLop
											JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
											JOIN dbo.GiangVien g ON g.MSGV = l.MaGV
					WHERE l.MaLop NOT IN (SELECT MaLop FROM dbo.LopSinhVien WHERE MaSV = @ms)
					GROUP BY l.MaLop, m.TenMH, g.Ho + ' ' + g.Ten, l.HocKy, l.NamHoc, l.SiSo
				END
		END
	IF @tc = 1
		BEGIN
		    SELECT l.MaLop, m.TenMH, g.Ho + ' ' + g.Ten AS TenGV, l.HocKy, l.NamHoc, l.SiSo, l.MaMH
			FROM dbo.LopHoc l JOIN dbo.GiangVien g ON l.MaGV = g.MSGV
							  JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
			WHERE l.MaGV = @ms AND l.HocKy = @hk AND l.NamHoc = @namhoc
		END
END
GO 
EXEC dbo.sp_GetClassInfo 'HK1', '2018-2019', 1, 1, 0

-- Lớp có mã 1, đã có bao nhiêu sv đk:

SELECT l.MaLop, m.TenMH, g.Ho + ' ' + g.Ten AS hoten, l.HocKy, l.NamHoc, l.SiSo, COUNT(l.MaLop) AS DaDK
FROM dbo.LopSinhVien ls RIGHT JOIN dbo.LopHoc l ON l.MaLop = ls.MaLop
						JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
						JOIN dbo.GiangVien g ON g.MSGV = l.MaGV
WHERE l.MaLop NOT IN (SELECT MaLop FROM dbo.LopSinhVien WHERE MaSV = 1)
GROUP BY l.MaLop, m.TenMH, g.Ho + ' ' + g.Ten, l.HocKy, l.NamHoc, l.SiSo

-- sinh viên xem tất cả điểm
SELECT m.TenMH, ls.DiemTK, ls.DiemGK, ls.DiemCK, [DiemTongKet], [XepLoai]
FROM dbo.LopSinhVien ls JOIN dbo.LopHoc l ON l.MaLop = ls.MaLop
						JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
WHERE ls.MaSV = 1 AND l.HocKy = 'HK1' AND l.NamHoc = '2018-2019'
GO 
---------------------

GO 
CREATE PROC sp_InsertNewStudenttoClass @malop INT, @masv INT 
AS
BEGIN
    INSERT dbo.LopSinhVien(MaLop, MaSV)
	VALUES(@malop, @masv)
END
GO 
---------------------
SELECT * FROM dbo.LopSinhVien
GO 

CREATE PROC sp_GetMarkInfo @hk CHAR(5), @namhoc CHAR(15), @masv INT
AS 
BEGIN
    SELECT m.TenMH, ls.DiemTK, ls.DiemGK, ls.DiemCK, DiemTongKet, XepLoai
	FROM dbo.LopSinhVien ls JOIN dbo.LopHoc l ON l.MaLop = ls.MaLop
							JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
	WHERE ls.MaSV = @masv AND l.HocKy = @hk AND l.NamHoc = @namhoc
END
GO 
EXEC dbo.sp_GetMarkInfo 'HK1', '2018-2019', 1
GO 

CREATE PROC sp_updateSinhVien
	@ms INT,
	@TenDN NVARCHAR(20),
	@Ten NVARCHAR(20),
	@Ho NVARCHAR(20),
	@password NVARCHAR(20),
	@birthday DATETIME,
	@GioiTInh INT,
	@Sdt NVARCHAR(15),
	@QueQuan NVARCHAR(20),
	@Anh IMAGE,
	@TuCach INT
AS
BEGIN
	IF @TuCach = 0
		UPDATE dbo.SinhVien 
		SET TenDangNhap = @TenDN, 
			Ten = @Ten, 
			Ho = @Ho, 
			Pass = @password, 
			NgayThangNamSinh = @birthday, 
			GioiTinh = @GioiTInh, 
			SoDienThoai = @Sdt, 
			QueQuan = @QueQuan, 
			Anh = @Anh,
			Tucach = @TuCach
		WHERE MSSV = @ms
	IF @TuCach = 1
		UPDATE dbo.GiangVien 
		SET TenDangNhap = @TenDN, 
			Ten = @Ten, 
			Ho = @Ho, 
			Pass = @password, 
			NgayThangNamSinh = @birthday, 
			GioiTinh = @GioiTInh, 
			SoDienThoai = @Sdt, 
			QueQuan = @QueQuan, 
			Anh = @Anh,
			Tucach = @TuCach
		WHERE MSGV = @ms
END
GO 

-- Giảng viên xem thông tin điểm của một lớp
SELECT s.MSSV, s.Ho + ' ' + s.Ten AS tenSV, ls.DiemTK, ls.DiemGK, ls.DiemCK, ls.DiemTongKet, ls.XepLoai, ls.MaSV
FROM dbo.LopHoc l JOIN dbo.LopSinhVien ls ON ls.MaLop = l.MaLop
				  JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
				  JOIN dbo.SinhVien s ON ls.MaSV = s.MSSV
WHERE l.MaLop = 1
GO 

CREATE PROC sp_getDSSV @malop INT, @ma INT 
AS
BEGIN
	IF @ma IS NULL
		BEGIN
			SELECT s.MSSV, s.Ho + ' ' + s.Ten AS tenSV, ls.DiemTK, ls.DiemGK, ls.DiemCK, ls.DiemTongKet, ls.XepLoai
			FROM dbo.LopHoc l JOIN dbo.LopSinhVien ls ON ls.MaLop = l.MaLop
							  JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
							  JOIN dbo.SinhVien s ON ls.MaSV = s.MSSV
			WHERE l.MaLop = @malop
		END
    ELSE
		BEGIN
		    SELECT s.MSSV, s.Ho + ' ' + s.Ten AS tenSV, ls.DiemTK, ls.DiemGK, ls.DiemCK, ls.DiemTongKet, ls.XepLoai
			FROM dbo.LopHoc l JOIN dbo.LopSinhVien ls ON ls.MaLop = l.MaLop
							  JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
							  JOIN dbo.SinhVien s ON ls.MaSV = s.MSSV
			WHERE l.MaLop = @malop AND ls.MaSV = @ma
		END
END

EXEC dbo.sp_getDSSV 1, NULL

GO 
CREATE PROC sp_CapNhatDiem @tk FLOAT, @gk FLOAT, @ck FLOAT, @masv INT, @malop INT 
AS
BEGIN
    UPDATE dbo.LopSinhVien
	SET DiemTK = @tk, DiemGK = @gk, DiemCK = @ck
	WHERE MaLop = @malop AND MaSV = @masv
END
GO 

EXEC dbo.sp_CapNhatDiem 10, 10, 10, 1, 1

SELECT * FROM dbo.LopSinhVien
GO 
GO 


ALTER PROC sp_GetAllP @d INT
AS
BEGIN
	IF @d IS NULL 
	BEGIN
	    SELECT * 
		FROM dbo.view_allP
	END
	ELSE
	BEGIN
	    SELECT * 
		FROM dbo.view_allP
		WHERE Deleted = @d
	END
	
END

GO 
ALTER VIEW view_allP
AS
	SELECT MSSV, TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, CAST(Anh AS VARBINARY(MAX)) AS Anh, Tucach, Deleted FROM dbo.SinhVien 
		UNION 
	SELECT MSGV, TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, CAST(Anh AS VARBINARY(MAX)) AS Anh, Tucach, Deleted FROM dbo.GiangVien 
GO
 
EXEC dbo.sp_GetAllP 1
GO 

CREATE PROC sp_insertNewSinhVien
	@TenDN NVARCHAR(20),
	@Ten NVARCHAR(20),
	@Ho NVARCHAR(20),
	@password NVARCHAR(20),
	@birthday DATETIME,
	@GioiTInh INT,
	@Sdt NVARCHAR(15),
	@QueQuan NVARCHAR(20),
	@Anh IMAGE,
	@TuCach INT
AS
BEGIN
    IF @TuCach = 0
		BEGIN
		    INSERT dbo.SinhVien(TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, Anh, Tucach)
		    VALUES(@TenDN, @Ten, @Ho, @password, @birthday, @GioiTInh, @Sdt, @QueQuan, @Anh, @TuCach)
		END
	IF @TuCach = 1
		BEGIN
		    INSERT dbo.GiangVien(TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, Anh, Tucach)
		    VALUES(@TenDN, @Ten, @Ho, @password, @birthday, @GioiTInh, @Sdt, @QueQuan, @Anh, @TuCach)
		END
END
GO 
-- tìm kiếm
ALTER PROC sp_TimKiem @loaiTK INT, @noidung NVARCHAR(20)
AS BEGIN
    IF @loaiTK=0 BEGIN
        SELECT MSSV, TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, Anh, Tucach
        FROM dbo.view_allP
        WHERE MSSV=@noidung AND Deleted=0;
    END;
    IF @loaiTK=1 BEGIN
        SELECT MSSV, TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, Anh, Tucach
        FROM dbo.view_allP
        WHERE Ten LIKE @noidung+'%' AND Deleted=0;
    END;
END;
GO
EXEC dbo.sp_TimKiem 0, 1, NULL

SELECT * FROM dbo.SinhVien

GO 
ALTER PROC sp_deleteuser @maso INT, @tc INT AS
BEGIN
    UPDATE dbo.view_allP
	SET Deleted = 1
	WHERE MSSV = @maso AND Tucach = @tc
END
GO 
CREATE TRIGGER deleteuser ON dbo.view_allP INSTEAD OF UPDATE AS
BEGIN
    DECLARE @ma INT, @tc INT 
	SELECT @ma = Inserted.MSSV, @tc = Inserted.Tucach FROM Inserted

	IF @tc = 0
		UPDATE dbo.SinhVien SET Deleted = 1 WHERE MSSV = @ma
	IF @tc = 1
		UPDATE dbo.GiangVien SET Deleted = 1 WHERE MSGV = @ma
END

EXEC sp_deleteuser 6, 0
SELECT * FROM dbo.SinhVien

GO 
-- Khôi phục người dùng
CREATE PROC sp_restoreuser @maso INT, @tc INT 
AS
BEGIN
	IF @tc = 0
		UPDATE dbo.SinhVien
		SET Deleted = 0
		WHERE MSSV = @maso
	IF @tc = 1
		UPDATE dbo.GiangVien
		SET Deleted = 0
		WHERE MSGV = @maso
END

EXEC dbo.sp_restoreuser 6, 0


SELECT Deleted FROM dbo.view_allP WHERE MSSV = 6

-- Tất cả môn học
SELECT * 
FROM dbo.MonHoc

-- Các lớp học đang dạy môn có mã số 1
SELECT *
FROM dbo.LopHoc l JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
WHERE l.MaMH = 1

SELECT * FROM dbo.LopHoc
GO

CREATE PROC sp_getAllSubject AS
BEGIN
    SELECT MaMH, TenMH, TinChi FROM dbo.MonHoc
END
GO 

CREATE PROC sp_GetClassFromSubject @maMH INT, @hk CHAR(5), @nh CHAR(15)
AS
BEGIN
    SELECT l.MaLop, g.Ten + ' ' + g.Ho AS HoTenGV, l.HocKy, l.NamHoc, l.SiSo, l.MaGV, m.TenMH
	FROM dbo.LopHoc l JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
					  JOIN dbo.GiangVien g ON g.MSGV = l.MaGV
	WHERE l.MaMH = @maMH AND l.HocKy = @hk AND l.NamHoc = @nh
END
GO 
EXEC dbo.sp_getAllSubject
EXEC dbo.sp_GetClassFromSubject 1, 'HK1', '2018-2019'

EXEC dbo.sp_GetInfo 1, 1

SELECT * FROM LopHoc

GO 
CREATE PROC sp_updateClass 
	@malop INT,
	@magv INT,
	@mamh INT,
	@hk CHAR(5),
	@namhoc CHAR(15),
	@ss INT 
AS
BEGIN
    UPDATE dbo.LopHoc
	SET MaGV = @magv,
		MaMH = @mamh,
		HocKy = @hk,
		NamHoc = @namhoc,
		SiSo = @ss
	WHERE MaLop = @malop
END

EXEC dbo.sp_updateClass 1, 1, 1, 'HK1', '2018-2019', 56
GO 
CREATE PROC sp_addNewClass
	@magv INT,
	@mamh INT,
	@hk CHAR(5),
	@namhoc CHAR(15),
	@ss INT
AS
BEGIN
    INSERT dbo.LopHoc(MaGV, MaMH, HocKy, NamHoc, SiSo)
    VALUES(@magv, @mamh, @hk, @namhoc, @ss)
END
GO 
CREATE PROC sp_getDSMon @mamh INT
AS
BEGIN
    SELECT MaMH, TenMH, TinChi
	FROM dbo.MonHoc
END
GO
SELECT * FROM dbo.LopHoc

SELECT * FROM dbo.GiangVien
GO 
SELECT * FROM dbo.LopSinhVien

SELECT * FROM dbo.SinhVien

SELECT * FROM dbo.LopHoc

INSERT dbo.LopSinhVien(MaLop, MaSV)
VALUES(4, 7)

ALTER TABLE dbo.SinhVien NOCHECK CONSTRAINT ALL 


-- xoá sinh viên

ALTER TABLE dbo.LopSinhVien DROP CONSTRAINT FK__LopSinhVie__MaSV__1CF15040

ALTER TABLE dbo.LopSinhVien ADD CONSTRAINT FK_Masv FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MSSV) ON DELETE CASCADE

DELETE FROM dbo.SinhVien WHERE MSSV = 7

-- xoá gv
SELECT * FROM dbo.GiangVien

-- Kiểm tra một giáo viên bất kì dạy bao nhiêu lớp
SELECT COUNT(*)
FROM dbo.LopHoc l JOIN dbo.GiangVien g ON g.MSGV = l.MaGV
WHERE l.MaGV = 2
GO 
CREATE PROC sp_getNumberClassOfGV @magv INT 
AS
BEGIN
    SELECT COUNT(*)
	FROM dbo.LopHoc l JOIN dbo.GiangVien g ON g.MSGV = l.MaGV
	WHERE l.MaGV = @magv
END
GO 
EXEC dbo.sp_getNumberClassOfGV @magv=5

GO 
EXEC dbo.sp_GetAllPerson
GO 
CREATE PROC sp_checkSVMaLopDaCo @MaLop INT, @MaSV INT 
AS
BEGIN
    IF @MaLop IN (SELECT MaLop FROM dbo.LopSinhVien WHERE MaSV = @MaSV)
		SELECT 1
	ELSE 
		SELECT 0
END
GO 
EXEC dbo.sp_checkSVMaLopDaCo 3, 1
GO 
CREATE PROC sp_HuyHocPhan @MaLop INT, @MaSV INT 
AS
BEGIN
    DELETE FROM dbo.LopSinhVien
	WHERE MaLop = @MaLop AND MaSV = @MaSV
END
GO 
SELECT * FROM dbo.LopSinhVien WHERE MaLop = 3 AND MaSV = 1