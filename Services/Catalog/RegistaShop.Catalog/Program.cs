using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using RegistaShop.Catalog.Services.AboutServices;
using RegistaShop.Catalog.Services.BrandServices;
using RegistaShop.Catalog.Services.CategoryServices;
using RegistaShop.Catalog.Services.ContactServices;
using RegistaShop.Catalog.Services.FeatureServices;
using RegistaShop.Catalog.Services.FeatureSliderServices;
using RegistaShop.Catalog.Services.OfferDiscountServices;
using RegistaShop.Catalog.Services.ProductDetailServices;
using RegistaShop.Catalog.Services.ProductImageServices;
using RegistaShop.Catalog.Services.ProductServices;
using RegistaShop.Catalog.Services.SpecialOfferServices;
using RegistaShop.Catalog.Settings;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
	opt.Authority = builder.Configuration["IdentityServerUrl"];
	opt.Audience = "ResourceCatalog";
	opt.RequireHttpsMetadata = false;
});

// Add services to the container.
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductDetailService, ProductDetailService>();
builder.Services.AddScoped<IProductImageService, ProductImageService>();
builder.Services.AddScoped<IFeatureSliderService, FeatureSliderService>();
builder.Services.AddScoped<ISpecialOfferService, SpecialOfferService>();
builder.Services.AddScoped<IFeatureService, FeatureService>();
builder.Services.AddScoped<IOfferDiscountService, OfferDiscountService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IContactService, ContactService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
	return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
}); // databasesettings içindeki deðerlere ulaþmak için

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
