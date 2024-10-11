
namespace Data.Context
{
	public partial class Context : DbContext
	{
		public Context()
		{
		}
		public Context(DbContextOptions<Context> options)
			: base(options)
		{
		}
       

        public virtual DbSet<Data.Model.DanhMucDuAn> DanhMucDuAn { get; set; }
        public virtual DbSet<Data.Model.DanhMucSanPham> DanhMucSanPham { get; set; }
        public virtual DbSet<Data.Model.HoaDonChiTiet> HoaDonChiTiet { get; set; }
		public virtual DbSet<Data.Model.ThanhVien> ThanhVien { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(GlobalHelper.SQLServerConectionString);
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			OnModelCreatingPartial(modelBuilder);
		}
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
