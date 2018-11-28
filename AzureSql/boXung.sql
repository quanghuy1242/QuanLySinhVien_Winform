ALTER TABLE dbo.LopSinhVien DROP CONSTRAINT FK__LopSinhVie__MaSV__5CD6CB2B

ALTER TABLE dbo.LopSinhVien ADD CONSTRAINT FK_Masv FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MSSV) ON DELETE CASCADE

go 
create proc sp_xoaHoanToan @ms int, @tc int
as
	begin
		if @tc = 0
			begin 
				delete from SinhVien
				where MSSV = @ms
			end
		if @tc = 1
			begin
				delete from GiangVien
				where MSGV = @ms
			end
	end
go 