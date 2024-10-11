namespace Service.Implement
{
    public class ThanhVienService : BaseService<ThanhVien, IThanhVienRepository>
    , IThanhVienService
    {
        private readonly IThanhVienRepository _ThanhVienRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ThanhVienService(IThanhVienRepository ThanhVienRepository, IWebHostEnvironment WebHostEnvironment) : base(ThanhVienRepository, WebHostEnvironment)
        {
            _ThanhVienRepository = ThanhVienRepository;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

