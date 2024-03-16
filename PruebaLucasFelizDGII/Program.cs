using Microsoft.EntityFrameworkCore;
using PruebaLucasFelizDGII.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DGIIDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DGIICS")));
builder.Services.AddControllersWithViews();
builder.Services.AddCors(options =>
    options.AddPolicy("corsapp", builder =>
    { builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors("corsapp");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
