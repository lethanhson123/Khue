namespace Service.Implement
{
    public class DanhMucSanPhamService : BaseService<DanhMucSanPham, IDanhMucSanPhamRepository>
    , IDanhMucSanPhamService
    {
        private readonly IDanhMucSanPhamRepository _DanhMucSanPhamRepository;      
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucSanPhamService(IDanhMucSanPhamRepository DanhMucSanPhamRepository, IWebHostEnvironment WebHostEnvironment) : base(DanhMucSanPhamRepository, WebHostEnvironment)
        {
            _DanhMucSanPhamRepository = DanhMucSanPhamRepository;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

