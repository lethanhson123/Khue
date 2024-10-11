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
        [HttpPost]
        [Route("GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThucToListAsync")]
        public async Task<List<HoaDonChiTiet>> GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThucToListAsync()
        {
            List<HoaDonChiTiet> result = new List<HoaDonChiTiet>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                if (model.BatDau == null)
                {
                    model.BatDau = GlobalHelper.InitializationDateTime;
                }
                if (model.KetThuc == null)
                {
                    model.KetThuc = GlobalHelper.InitializationDateTime;
                }
                if (model.DanhMucDuAnID == null)
                {
                    model.DanhMucDuAnID = GlobalHelper.InitializationNumber;
                }
                if (model.ThanhVienID == null)
                {
                    model.ThanhVienID = GlobalHelper.InitializationNumber;
                }
                result = await _HoaDonChiTietService.GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThucToListAsync(model.DanhMucDuAnID.Value, model.ThanhVienID.Value, model.BatDau.Value, model.KetThuc.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThuc_EmptyToListAsync")]
        public async Task<List<HoaDonChiTiet>> GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThuc_EmptyToListAsync()
        {
            List<HoaDonChiTiet> result = new List<HoaDonChiTiet>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                if (model.BatDau == null)
                {
                    model.BatDau = GlobalHelper.InitializationDateTime;
                }
                if (model.KetThuc == null)
                {
                    model.KetThuc = GlobalHelper.InitializationDateTime;
                }
                if (model.DanhMucDuAnID == null)
                {
                    model.DanhMucDuAnID = GlobalHelper.InitializationNumber;
                }
                if (model.ThanhVienID == null)
                {
                    model.ThanhVienID = GlobalHelper.InitializationNumber;
                }
                result = await _HoaDonChiTietService.GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThuc_EmptyToListAsync(model.DanhMucDuAnID.Value, model.ThanhVienID.Value, model.BatDau.Value, model.KetThuc.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

