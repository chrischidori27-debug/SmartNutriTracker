using SmartNutriTracker.Components;
using SmartNutriTracker.Modelos;
using SmartNutriTracker.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Servicios de Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Conexión con PostgreSQL (Supabase)
builder.Services.AddDbContextFactory<SmartNutriTrackerContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("ConexionSQL")
    )
    .UseSnakeCaseNamingConvention()   // mapea PascalCase → snake_case
);

// Servicio para proteger y verificar contraseñas
builder.Services.AddScoped<IPasswordHasher<Usuario>, PasswordHasher<Usuario>>();

// Servicios de la aplicación
builder.Services.AddScoped<UsuarioServicio>();
builder.Services.AddScoped<UsuarioSesion>();
builder.Services.AddScoped<AlimentoServicio>();
builder.Services.AddScoped<MenuServicio>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStatusCodePagesWithReExecute(
    "/not-found",
    createScopeForStatusCodePages: true);

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();