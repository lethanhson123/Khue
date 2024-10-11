namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThanhVienController : BaseController<ThanhVien, IThanhVienService>
    {
        private readonly IThanhVienService _ThanhVienService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ThanhVienController(IThanhVienService ThanhVienService, IWebHostEnvironment WebHostEnvironment) : base(ThanhVienService, WebHostEnvironment)
        {
            _ThanhVienService = ThanhVienService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

