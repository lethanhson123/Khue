namespace Data.Model
{
    public partial class HoaDonChiTiet : BaseModel
    {
        public decimal? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public long? ThanhVienID { get; set; }
        public long? DanhMucSanPhamID { get; set; }
        public long? DanhMucDuAnID { get; set; }
        public DateTime? NgayGhiNhan { get; set; }
        public string? ThanhVienName { get; set; }
        public string? DanhMucSanPhamName { get; set; }
        public string? DanhMucDuAnName { get; set; }
        public HoaDonChiTiet()
        {
            SoLuong = 1;
            NgayGhiNhan = GlobalHelper.InitializationDateTime;
        }
    }
}

