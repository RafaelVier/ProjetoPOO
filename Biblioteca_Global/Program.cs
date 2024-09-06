//Aplicativo de Gerenciamento de Biblioteca: Desenvolva um aplicativo para gerenciar informa��es de livros, autores e usu�rios da biblioteca,
//incluindo empr�stimos, devolu��es e reservas. O aplicativo deve usar o EF Core para persist�ncia de dados e OO para uma estrutura de c�digo bem organizada e escal�vel.
using Biblioteca_Global.Components;
using Biblioteca_Global.Context;
using Biblioteca_Global.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(GenericsService<>));
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Conex�o com o banco de dados
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
//Teste Corre��o GitHub