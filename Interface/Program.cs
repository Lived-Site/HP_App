using Interface.Components;
using Repositroy;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Registro de tus servicios y repositorios (Inyección de Dependencias)
builder.Services.AddSingleton<PersonajeService>();
builder.Services.AddSingleton<CasaRepository>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    // 🔮 AGREGAMOS AQUÍ LAS OPCIONES DEL HUB MÁGICO 🔮
    .AddHubOptions(options =>
    {
        // Ampliamos el tamaño máximo permitido para mensajes de SignalR a 2 MB
        options.MaximumReceiveMessageSize = 1024 * 1024 * 2; 
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();