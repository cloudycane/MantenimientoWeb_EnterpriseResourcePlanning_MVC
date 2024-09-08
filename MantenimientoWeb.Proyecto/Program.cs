using MantenimientoWeb.Aplicacion.Servicios.UseCases;
using MantenimientoWeb.Dominio.Interfaces;
using MantenimientoWeb.Dominio.ServiciosDominios;
using MantenimientoWeb.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// USECASES
builder.Services.AddScoped<GetTipoProductosQuery>();
builder.Services.AddScoped<GetEmpaquetamientoQuery>();
builder.Services.AddScoped<GetTransportesQuery>();
builder.Services.AddScoped<GetClasificacionesQuery>();
builder.Services.AddScoped<GetPaisesQuery>();
builder.Services.AddScoped<GetCategoriasQuery>();
builder.Services.AddScoped<GetTipoEmpresaQuery>();
builder.Services.AddScoped<GetMonedasQuery>();
builder.Services.AddScoped<GetEstadoProductosQuery>();

// SERVICIOS 
builder.Services.AddScoped<ICompraService, CompraService>();
builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<IEmpresaService, EmpresaService>();
builder.Services.AddScoped<IInventarioService, InventarioService>();

// REPOSITORIOS

builder.Services.AddScoped<IEmpaquetamientoRepository, EmpaquetamientoRepository>();
builder.Services.AddScoped<ITransporteRepository, TransporteRepository>();
builder.Services.AddScoped<IClasificacionRepository, ClasificacionRepository>();
builder.Services.AddScoped<IPaisRepository, PaisRepository>();
builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
builder.Services.AddScoped<ITipoEmpresaRepository, TipoEmpresaRepository>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<IMonedaRepository, MonedaRepository>();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<ITipoProductoRepository, TipoProductoRepository>();
builder.Services.AddScoped<IEstadoProductoRepository, EstadoProductoRepository>();
builder.Services.AddScoped<IInventarioRepository, InventarioRepository>();
builder.Services.AddScoped<ICompraRepository, CompraRepository>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Si añadimos la area seria area=NombreArea...

app.Run();
