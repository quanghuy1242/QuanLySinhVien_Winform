
GO
/****** Object:  StoredProcedure [dbo].[sp_addNewClass]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_addNewClass]
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
/****** Object:  StoredProcedure [dbo].[sp_CapNhatDiem]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CapNhatDiem] @tk FLOAT, @gk FLOAT, @ck FLOAT, @masv INT, @malop INT 
AS
BEGIN
    UPDATE dbo.LopSinhVien
	SET DiemTK = @tk, DiemGK = @gk, DiemCK = @ck
	WHERE MaLop = @malop AND MaSV = @masv
END
GO
/****** Object:  StoredProcedure [dbo].[sp_checkSVMaLopDaCo]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_checkSVMaLopDaCo] @MaLop INT, @MaSV INT 
AS
BEGIN
    IF @MaLop IN (SELECT MaLop FROM dbo.LopSinhVien WHERE MaSV = @MaSV)
		SELECT 1
	ELSE 
		SELECT 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteuser]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_deleteuser] @maso INT, @tc INT AS
BEGIN
    UPDATE dbo.view_allP
	SET Deleted = 1
	WHERE MSSV = @maso AND Tucach = @tc
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllP]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllP] @d INT
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllPerson]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetAllPerson]
AS SELECT * FROM dbo.view_BangDangNhap
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllSubject]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getAllSubject] AS
BEGIN
    SELECT MaMH, TenMH, TinChi FROM dbo.MonHoc
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetClassFromSubject]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_GetClassFromSubject] @maMH INT, @hk CHAR(5), @nh CHAR(15)
AS
BEGIN
    SELECT l.MaLop, g.Ten + ' ' + g.Ho AS HoTenGV, l.HocKy, l.NamHoc, l.SiSo, l.MaGV, m.TenMH
	FROM dbo.LopHoc l JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
					  JOIN dbo.GiangVien g ON g.MSGV = l.MaGV
	WHERE l.MaMH = @maMH AND l.HocKy = @hk AND l.NamHoc = @nh
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetClassInfo]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetClassInfo] @hk CHAR(5), @namhoc CHAR(15), @tc INT, @ms INT, @dadk INT 
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
/****** Object:  StoredProcedure [dbo].[sp_getDSMon]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getDSMon] @mamh INT
AS
BEGIN
    SELECT MaMH, TenMH, TinChi
	FROM dbo.MonHoc
END

GO
/****** Object:  StoredProcedure [dbo].[sp_getDSSV]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getDSSV] @malop INT, @ma INT 
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
GO
/****** Object:  StoredProcedure [dbo].[sp_GetHocKy]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetHocKy]
AS BEGIN
	SELECT DISTINCT HocKy
	FROM dbo.LopHoc
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetInfo]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetInfo] @tc INT, @ms INT
AS
	BEGIN
	    IF @tc = 0 SELECT * FROM dbo.SinhVien WHERE MSSV = @ms
		IF @tc = 1 SELECT * FROM dbo.GiangVien WHERE MSGV = @ms
		IF @tc = 2 SELECT * FROM dbo.AdminSys WHERE MSAD = @ms
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetMarkInfo]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetMarkInfo] @hk CHAR(5), @namhoc CHAR(15), @masv INT
AS 
BEGIN
    SELECT m.TenMH, ls.DiemTK, ls.DiemGK, ls.DiemCK, DiemTongKet, XepLoai
	FROM dbo.LopSinhVien ls JOIN dbo.LopHoc l ON l.MaLop = ls.MaLop
							JOIN dbo.MonHoc m ON m.MaMH = l.MaMH
	WHERE ls.MaSV = @masv AND l.HocKy = @hk AND l.NamHoc = @namhoc
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetNamHoc]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetNamHoc]
AS BEGIN
	SELECT DISTINCT NamHoc
	FROM dbo.LopHoc
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getNumberClassOfGV]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_getNumberClassOfGV] @magv INT 
AS
BEGIN
    SELECT COUNT(*)
	FROM dbo.LopHoc l JOIN dbo.GiangVien g ON g.MSGV = l.MaGV
	WHERE l.MaGV = @magv
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HuyHocPhan]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_HuyHocPhan] @MaLop INT, @MaSV INT 
AS
BEGIN
    DELETE FROM dbo.LopSinhVien
	WHERE MaLop = @MaLop AND MaSV = @MaSV
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertNewSinhVien]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_insertNewSinhVien]
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
/****** Object:  StoredProcedure [dbo].[sp_InsertNewStudenttoClass]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertNewStudenttoClass] @malop INT, @masv INT 
AS
BEGIN
    INSERT dbo.LopSinhVien(MaLop, MaSV)
	VALUES(@malop, @masv)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_restoreuser]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_restoreuser] @maso INT, @tc INT 
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
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiem]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TimKiem] @loaiTK INT, @noidung NVARCHAR(20)
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
/****** Object:  StoredProcedure [dbo].[sp_updateClass]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_updateClass] 
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
GO
/****** Object:  StoredProcedure [dbo].[sp_updateSinhVien]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_updateSinhVien]
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
/****** Object:  Table [dbo].[AdminSys]    Script Date: 11/11/2018 12:31:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminSys](
	[MSAD] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](20) NULL,
	[Ho] [nvarchar](20) NULL,
	[Pass] [nvarchar](20) NULL,
	[NgayThangNamSinh] [datetime] NULL,
	[GioiTinh] [int] NULL,
	[SoDienThoai] [nvarchar](15) NULL,
	[QueQuan] [nvarchar](20) NULL,
	[Anh] [image] NULL,
	[Tucach] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MSAD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 11/11/2018 12:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MSGV] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](20) NULL,
	[Ho] [nvarchar](20) NULL,
	[Pass] [nvarchar](20) NULL,
	[NgayThangNamSinh] [datetime] NULL,
	[GioiTinh] [int] NULL,
	[SoDienThoai] [nvarchar](15) NULL,
	[QueQuan] [nvarchar](20) NULL,
	[Anh] [image] NULL,
	[Tucach] [int] NULL,
	[Deleted] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MSGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 11/11/2018 12:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopHoc](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[MaGV] [int] NULL,
	[MaMH] [int] NULL,
	[HocKy] [char](5) NULL,
	[NamHoc] [char](15) NULL,
	[SiSo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LopSinhVien]    Script Date: 11/11/2018 12:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopSinhVien](
	[MaLop] [int] NOT NULL,
	[MaSV] [int] NULL,
	[DiemTK] [float] NULL,
	[DiemGK] [float] NULL,
	[DiemCK] [float] NULL,
	[DiemTongKet] [float] NULL,
	[XepLoai] [char](5) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 11/11/2018 12:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [int] IDENTITY(1,1) NOT NULL,
	[TenMH] [nvarchar](70) NULL,
	[TinChi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 11/11/2018 12:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MSSV] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](20) NULL,
	[Ho] [nvarchar](20) NULL,
	[Pass] [nvarchar](20) NULL,
	[NgayThangNamSinh] [datetime] NULL,
	[GioiTinh] [int] NULL,
	[SoDienThoai] [nvarchar](15) NULL,
	[QueQuan] [nvarchar](20) NULL,
	[Anh] [image] NULL,
	[Tucach] [int] NULL,
	[Deleted] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_allP]    Script Date: 11/11/2018 12:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_allP]
AS
	SELECT MSSV, TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, CAST(Anh AS VARBINARY(MAX)) AS Anh, Tucach, Deleted FROM dbo.SinhVien 
		UNION 
	SELECT MSGV, TenDangNhap, Ten, Ho, Pass, NgayThangNamSinh, GioiTinh, SoDienThoai, QueQuan, CAST(Anh AS VARBINARY(MAX)) AS Anh, Tucach, Deleted FROM dbo.GiangVien 

GO
/****** Object:  View [dbo].[view_BangDangNhap]    Script Date: 11/11/2018 12:31:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_BangDangNhap]
as
	SELECT TenDangNhap, Pass, MSSV, Tucach, Deleted FROM dbo.SinhVien 
		UNION 
	SELECT TenDangNhap, Pass, MSGV, Tucach, Deleted FROM dbo.GiangVien 
		UNION 
	SELECT TenDangNhap, Pass, MSAD, Tucach, 0 FROM dbo.AdminSys

GO
ALTER TABLE [dbo].[GiangVien] ADD  DEFAULT ((0)) FOR [Deleted]
GO
ALTER TABLE [dbo].[LopSinhVien] ADD  DEFAULT ((0)) FOR [DiemTK]
GO
ALTER TABLE [dbo].[LopSinhVien] ADD  DEFAULT ((0)) FOR [DiemGK]
GO
ALTER TABLE [dbo].[LopSinhVien] ADD  DEFAULT ((0)) FOR [DiemCK]
GO
ALTER TABLE [dbo].[LopSinhVien] ADD  DEFAULT ((0)) FOR [DiemTongKet]
GO
ALTER TABLE [dbo].[SinhVien] ADD  DEFAULT ((0)) FOR [Deleted]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiangVien] ([MSGV])
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[LopSinhVien]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[LopSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_Masv] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MSSV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LopSinhVien] CHECK CONSTRAINT [FK_Masv]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD CHECK  (([HocKy]='HK3' OR [HocKy]='HK2' OR [HocKy]='HK1'))
GO
ALTER TABLE [dbo].[LopSinhVien]  WITH CHECK ADD CHECK  (([XepLoai]='F' OR [XepLoai]='D' OR [XepLoai]='C' OR [XepLoai]='B' OR [XepLoai]='A'))
GO
