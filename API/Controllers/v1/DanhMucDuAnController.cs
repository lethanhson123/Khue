namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucDuAnController : BaseController<DanhMucDuAn, IDanhMucDuAnService>
    {
        private readonly IDanhMucDuAnService _DanhMucDuAnService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucDuAnController(IDanhMucDuAnService DanhMucDuAnService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucDuAnService, WebHostEnvironment)
        {
            _DanhMucDuAnService = DanhMucDuAnService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

