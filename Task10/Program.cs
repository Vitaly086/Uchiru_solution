using Task10;
using Task10.Services;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddControllersWithViews();
services.AddControllers();
services.AddScoped<DepositCalculatorService>();
services.AddHttpClient();
services.AddScoped<FakeDbContext>();
services.AddScoped<DepositLoggingService>();
services.AddSingleton<BankApiService>();


var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bank}/{action=Index}");
app.MapControllers();

app.Run();