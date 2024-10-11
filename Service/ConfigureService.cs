using Data.Model;
using Repository.Implement;
using Repository.Interface;
using Service.Implement;
using Service.Interface;

namespace Service
{
    public static class ConfigureService
    {
        public static IServiceCollection AddJWT(this IServiceCollection services)
        {         

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = GlobalHelper.Audience,
                    ValidIssuer = GlobalHelper.Issuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(GlobalHelper.Key))
                };
            });
            return services;
        }
        public static IServiceCollection AddContext(this IServiceCollection services)
        {
            services.AddDbContext<Context>(opts =>
            {
            });
            return services;
        }
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddTransient<IDanhMucDuAnService, DanhMucDuAnService>();
            services.AddTransient<IDanhMucSanPhamService, DanhMucSanPhamService>();
            services.AddTransient<IHoaDonChiTietService, HoaDonChiTietService>();
            services.AddTransient<IThanhVienService, ThanhVienService>();

            services.AddSingleton(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IDanhMucDuAnRepository, DanhMucDuAnRepository>();
            services.AddTransient<IDanhMucSanPhamRepository, DanhMucSanPhamRepository>();
            services.AddTransient<IHoaDonChiTietRepository, HoaDonChiTietRepository>();
            services.AddTransient<IThanhVienRepository, ThanhVienRepository>();

            return services;
        }
    }
}
