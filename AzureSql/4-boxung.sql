CREATE PROC sp_checklopday @malop INT
AS
BEGIN
	SELECT l.SiSo, COUNT(l.MaLop) AS DaDK
	FROM dbo.LopSinhVien ls RIGHT JOIN dbo.LopHoc l ON l.MaLop = ls.MaLop
	WHERE l.MaLop = @malop
	GROUP BY l.SiSo
END

--24 store proc