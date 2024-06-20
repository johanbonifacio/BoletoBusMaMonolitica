using BoletoBusMaMonolitica.Data.Context;
using BoletoBusMaMonolitica.Data.DbObjects;
using BoletoBusMaMonolitica.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Asegúrate de que el nombre del connection string sea el correcto
builder.Services.AddDbContext<BoletoBusContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BoletoBusContext")));

#region Scoped
builder.Services.AddScoped<IBusDb, BusDb>();
builder.Services.AddScoped<IAsientoDb, AsientoDb>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
