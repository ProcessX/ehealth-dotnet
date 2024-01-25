using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

using eHealth.Data;
using eHealth.Models;
using eHealth.Filters;
using eHealth.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<LogActionFiltersAttribute>();
string connectionString = "Data Source=doctors.db";
builder.Services.AddDbContext<DoctorContext>(options => options.UseSqlite(connectionString));


builder.Services.AddControllersWithViews();
builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "DoctorsRouter",
    pattern: "{controller}/{action}/{name}",
    constraints: new { name = "[A-Za-z]+" },
    defaults: new { controller = "Doctors", action = "Index", name = "Lucas G." });

app.Run();
