var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=File}/{action=DownloadFile}/{id?}");

app.Run();
