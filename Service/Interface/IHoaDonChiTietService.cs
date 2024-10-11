namespace Service.Interface
{
    public interface IHoaDonChiTietService : IBaseService<HoaDonChiTiet>
    {
        Task<List<HoaDonChiTiet>> GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThucToListAsync(long DanhMucDuAnID, long ThanhVienID, DateTime BatDau, DateTime KetThuc);
        Task<List<HoaDonChiTiet>> GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThuc_EmptyToListAsync(long DanhMucDuAnID, long ThanhVienID, DateTime BatDau, DateTime KetThuc);
    }
}

