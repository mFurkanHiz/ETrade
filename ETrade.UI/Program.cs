using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstract;
using ETrade.Rep.Concretes;
using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
/*****************************************************************/
// ADDED

builder.Services.AddDbContext<Context>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("ETrade")));
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IPropertyRepository, PropertyRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


builder.Services.AddScoped<IUow, Uow>();
//builder.Services.AddScoped<Foods>();


builder.Services.AddScoped<CategoriesModel>();
builder.Services.AddScoped<FoodsModel>();
builder.Services.AddScoped<CategoriesModel>();
builder.Services.AddScoped<PropertiesModel>();
builder.Services.AddScoped<AdminModel>();



// ADDED
/*****************************************************************/
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
