namespace Repository.Implement
{
    public class HoaDonChiTietRepository : BaseRepository<HoaDonChiTiet>
    , IHoaDonChiTietRepository
    {
        private readonly Data.Context.Context _context;
        public HoaDonChiTietRepository(Data.Context.Context context) : base(context)
        {
            _context = context;
        }
    }
}

