namespace Repository.Implement
{
    public class DanhMucSanPhamRepository : BaseRepository<DanhMucSanPham>
    , IDanhMucSanPhamRepository
    {
        private readonly Data.Context.Context _context;
        public DanhMucSanPhamRepository(Data.Context.Context context) : base(context)
        {
            _context = context;
        }
    }
}

