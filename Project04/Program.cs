<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using Project04.Models;
using Project04.Repository;

=======
>>>>>>> 1ff16e3bdf148423009bcb4ac30ea88e2ebf31cb
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

<<<<<<< HEAD
var connectionString = builder.Configuration.GetConnectionString("Project4Context");
builder.Services.AddDbContext<Project4Context>(x=>x.UseSqlServer(connectionString));

builder.Services.AddScoped<Category, Categories>();

=======
>>>>>>> 1ff16e3bdf148423009bcb4ac30ea88e2ebf31cb
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

app.Run();
