namespace Service.Implement
{
    public class HoaDonChiTietService : BaseService<HoaDonChiTiet, IHoaDonChiTietRepository>
    , IHoaDonChiTietService
    {
        private readonly IHoaDonChiTietRepository _HoaDonChiTietRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly IDanhMucSanPhamRepository _DanhMucSanPhamRepository;
        public HoaDonChiTietService(IHoaDonChiTietRepository HoaDonChiTietRepository, IWebHostEnvironment WebHostEnvironment


            , IDanhMucSanPhamRepository DanhMucSanPhamRepository

            ) : base(HoaDonChiTietRepository, WebHostEnvironment)
        {
            _HoaDonChiTietRepository = HoaDonChiTietRepository;
            _WebHostEnvironment = WebHostEnvironment;

            _DanhMucSanPhamRepository = DanhMucSanPhamRepository;
        }
        public override void Initialization(HoaDonChiTiet model)
        {
            BaseInitialization(model);
            if (model.SoLuong == null)
            {
                model.SoLuong = GlobalHelper.InitializationNumber;
            }
            if (model.DanhMucSanPhamID == null)
            {
                model.DanhMucSanPhamID = GlobalHelper.DanhMucSanPhamID;
            }
            if (model.DanhMucSanPhamID > 0)
            {
                DanhMucSanPham DanhMucSanPham = _DanhMucSanPhamRepository.GetByID(model.DanhMucSanPhamID.Value);
                if (string.IsNullOrEmpty(model.DanhMucSanPhamName))
                {
                    model.DanhMucSanPhamName = DanhMucSanPham.Name;
                }
                if (model.DonGia == null)
                {
                    model.DonGia = DanhMucSanPham.DonGia;
                }
            }
            if (model.NgayGhiNhan == null)
            {
                model.NgayGhiNhan = GlobalHelper.InitializationDateTime;
            }
            model.ThanhTien = model.SoLuong * model.DonGia;
        }
    }
}

