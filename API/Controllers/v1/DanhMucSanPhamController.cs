namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucSanPhamController : BaseController<DanhMucSanPham, IDanhMucSanPhamService>
    {
        private readonly IDanhMucSanPhamService _DanhMucSanPhamService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucSanPhamController(IDanhMucSanPhamService DanhMucSanPhamService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucSanPhamService, WebHostEnvironment)
        {
            _DanhMucSanPhamService = DanhMucSanPhamService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

