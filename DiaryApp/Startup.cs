using DiaryApp.Data;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp;

public class Startup
{
    public Startup(IConfiguration configuration) => 
        _configuration = configuration;

    private readonly IConfiguration _configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        
        services.AddDbContext<ApplicationDbContext>(
            options => options.UseSqlServer(
                _configuration.GetConnectionString("DefaultConnection")
            ));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
    {
        if (environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseStaticFiles();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();
            endpoints.MapFallbackToController("Error", "Home");
        });
    }
}