namespace Repository.Implement
{
    public class DanhMucDuAnRepository : BaseRepository<DanhMucDuAn>
    , IDanhMucDuAnRepository
    {
        private readonly Data.Context.Context _context;
        public DanhMucDuAnRepository(Data.Context.Context context) : base(context)
        {
            _context = context;
        }
    }
}

