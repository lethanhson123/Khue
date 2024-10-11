namespace Data.Model
{
    public partial class ThanhVien : BaseModel
    {
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? CCCD { get; set; }
        public string? NganHang { get; set; }
        public string? NganHangTaiKhoan { get; set; }         
        public ThanhVien()
        {
        }
    }
}

