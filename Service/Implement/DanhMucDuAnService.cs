namespace Service.Implement
{
    public class DanhMucDuAnService : BaseService<DanhMucDuAn, IDanhMucDuAnRepository>
    , IDanhMucDuAnService
    {
        private readonly IDanhMucDuAnRepository _DanhMucDuAnRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucDuAnService(IDanhMucDuAnRepository DanhMucDuAnRepository, IWebHostEnvironment WebHostEnvironment) : base(DanhMucDuAnRepository, WebHostEnvironment)
        {
            _DanhMucDuAnRepository = DanhMucDuAnRepository;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

