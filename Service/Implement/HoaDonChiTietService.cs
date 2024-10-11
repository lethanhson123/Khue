namespace Service.Implement
{
    public class HoaDonChiTietService : BaseService<HoaDonChiTiet, IHoaDonChiTietRepository>
    , IHoaDonChiTietService
    {
        private readonly IHoaDonChiTietRepository _HoaDonChiTietRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly IDanhMucSanPhamRepository _DanhMucSanPhamRepository;
        public HoaDonChiTietService(IHoaDonChiTietRepository HoaDonChiTietRepository, IWebHostEnvironment WebHostEnvironment


            , IDanhMucSanPhamRepository DanhMucSanPhamRepository

            ) : base(HoaDonChiTietRepository, WebHostEnvironment)
        {
            _HoaDonChiTietRepository = HoaDonChiTietRepository;
            _WebHostEnvironment = WebHostEnvironment;

            _DanhMucSanPhamRepository = DanhMucSanPhamRepository;
        }
        public override void Initialization(HoaDonChiTiet model)
        {
            BaseInitialization(model);
            if (model.SoLuong == null)
            {
                model.SoLuong = GlobalHelper.InitializationNumber;
            }
            if (model.DanhMucSanPhamID == null)
            {
                model.DanhMucSanPhamID = GlobalHelper.DanhMucSanPhamID;
            }
            if (model.DanhMucSanPhamID > 0)
            {
                DanhMucSanPham DanhMucSanPham = _DanhMucSanPhamRepository.GetByID(model.DanhMucSanPhamID.Value);
                if (string.IsNullOrEmpty(model.DanhMucSanPhamName))
                {
                    model.DanhMucSanPhamName = DanhMucSanPham.Name;
                }
                if (model.DonGia == null)
                {
                    model.DonGia = DanhMucSanPham.DonGia;
                }
            }
            if (model.NgayGhiNhan == null)
            {
                model.NgayGhiNhan = GlobalHelper.InitializationDateTime;
            }
            model.ThanhTien = model.SoLuong * model.DonGia;
        }
        public virtual async Task<List<HoaDonChiTiet>> GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThucToListAsync(long DanhMucDuAnID, long ThanhVienID, DateTime BatDau, DateTime KetThuc)
        {
            List<HoaDonChiTiet> result = new List<HoaDonChiTiet>();
            if (BatDau == null)
            {
                BatDau = GlobalHelper.InitializationDateTime;
            }
            if (KetThuc == null)
            {
                KetThuc = GlobalHelper.InitializationDateTime;
            }
            BatDau = new DateTime(BatDau.Year, BatDau.Month, BatDau.Day, 0, 0, 0);
            KetThuc = new DateTime(KetThuc.Year, KetThuc.Month, KetThuc.Day, 23, 59, 59);
            result = await GetByCondition(item => item.NgayGhiNhan >= BatDau && item.NgayGhiNhan <= KetThuc).ToListAsync();
            if (DanhMucDuAnID > 0)
            {
                if (ThanhVienID > 0)
                {
                    result = result.Where(item => item.DanhMucDuAnID == DanhMucDuAnID && item.ThanhVienID == ThanhVienID).ToList();
                }
                else
                {
                    result = result.Where(item => item.DanhMucDuAnID == DanhMucDuAnID).ToList();
                }
            }
            else
            {
                if (ThanhVienID > 0)
                {
                    result = result.Where(item => item.ThanhVienID == ThanhVienID).ToList();
                }
            }
            if (result == null)
            {
                result = new List<HoaDonChiTiet>();
            }
            return result;
        }
        public virtual async Task<List<HoaDonChiTiet>> GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThuc_EmptyToListAsync(long DanhMucDuAnID, long ThanhVienID, DateTime BatDau, DateTime KetThuc)
        {
            List<HoaDonChiTiet> result = new List<HoaDonChiTiet>();
            HoaDonChiTiet Empty = new HoaDonChiTiet();
            result.Add(Empty);
            if (BatDau == null)
            {
                BatDau = GlobalHelper.InitializationDateTime;
            }
            if (KetThuc == null)
            {
                KetThuc = GlobalHelper.InitializationDateTime;
            }
            BatDau = new DateTime(BatDau.Year, BatDau.Month, BatDau.Day, 0, 0, 0);
            KetThuc = new DateTime(KetThuc.Year, KetThuc.Month, KetThuc.Day, 23, 59, 59);
            result.AddRange(await GetByCondition(item => item.NgayGhiNhan >= BatDau && item.NgayGhiNhan <= KetThuc).ToListAsync());
            if (DanhMucDuAnID > 0)
            {
                if (ThanhVienID > 0)
                {
                    result = result.Where(item => item.DanhMucDuAnID == DanhMucDuAnID && item.ThanhVienID == ThanhVienID).ToList();
                }
                else
                {
                    result = result.Where(item => item.DanhMucDuAnID == DanhMucDuAnID).ToList();
                }
            }
            else
            {
                if (ThanhVienID > 0)
                {
                    result = result.Where(item => item.ThanhVienID == ThanhVienID).ToList();
                }
            }
            if (result == null)
            {
                result = new List<HoaDonChiTiet>();
                result.Add(Empty);
            }
            return result;
        }
    }
}

