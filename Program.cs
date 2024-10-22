using Microsoft.EntityFrameworkCore;
using WebNhaHang.Models;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký DbContext
builder.Services.AddDbContext<DBNhaHangContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBNhaHangConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Thêm dịch vụ Session trước khi xây dựng ứng dụng
builder.Services.AddSession(options =>
{
    // Tùy chọn cấu hình session
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Thời gian hết hạn session
    options.Cookie.HttpOnly = true; // Bảo mật cookie session
    options.Cookie.IsEssential = true; // Đảm bảo cookie session luôn được gửi đi
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // Sử dụng Session middleware sau khi đã thêm dịch vụ

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=TrangChu}/{id?}");

app.Run();
