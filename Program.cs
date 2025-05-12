using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using AspNetStatic;
using AspNetStatic.Optimizer;
using AspNetStaticContrib.AspNetStatic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSassCompiler();
builder.Services.AddSingleton<IStaticResourcesInfoProvider>(
  new StaticResourcesInfoProvider(
    new []
    {
      new PageResource("/"),
      new PageResource("/Resume.styles.css"),
    }
  )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapRazorPages();
app.MapFallbackToPage("/_Host");

Directory.CreateDirectory("bin/static");
app.GenerateStaticContent("bin/static");
app.Run();
