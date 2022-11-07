using IfoodApi.Data;
using Microsoft.EntityFrameworkCore;
using IfoodApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(opts => 
    opts.UseMySql(@"server=localhost;database=IfoodDb;uid=root;password=root;", new MySqlServerVersion(new Version(8, 0))));
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<RestauranteService,RestauranteService>();
builder.Services.AddScoped<AddressService, AddressService>();
builder.Services.AddScoped<ProdutoService, ProdutoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
