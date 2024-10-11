namespace Data.Model
{
    public partial class DanhMucSanPham : BaseModel
    {
        public decimal? DonGia { get; set; }
        public DanhMucSanPham()
        {
            DonGia = GlobalHelper.InitializationNumber;
        }
    }
}

