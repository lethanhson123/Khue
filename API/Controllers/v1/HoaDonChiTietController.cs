namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoaDonChiTietController : BaseController<HoaDonChiTiet, IHoaDonChiTietService>
    {
        private readonly IHoaDonChiTietService _HoaDonChiTietService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public HoaDonChiTietController(IHoaDonChiTietService HoaDonChiTietService, IWebHostEnvironment WebHostEnvironment) : base(HoaDonChiTietService, WebHostEnvironment)
        {
            _HoaDonChiTietService = HoaDonChiTietService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

