namespace Service.Implement
{
    public class DanhMucDuAnService : BaseService<DanhMucDuAn, IDanhMucDuAnRepository>
    , IDanhMucDuAnService
    {
        private readonly IDanhMucDuAnRepository _DanhMucDuAnRepository;
        public DanhMucDuAnService(IDanhMucDuAnRepository DanhMucDuAnRepository) : base(DanhMucDuAnRepository)
        {
            _DanhMucDuAnRepository = DanhMucDuAnRepository;
        }
    }
}

