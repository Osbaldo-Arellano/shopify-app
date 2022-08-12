using AuntieDot.Data;
using Microsoft.EntityFrameworkCore;

namespace AuntieDot;

public class Startup
{
    
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        services.AddControllersWithViews();
    }

}