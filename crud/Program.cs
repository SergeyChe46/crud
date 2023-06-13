using crud.Repository;
using crud.Services.RegisterServices;

var builder = WebApplication.CreateBuilder(args);

IConfiguration config = builder.Configuration;
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.RegisterDatabase(config);
builder.Services.RegisterDependencyInjection();
builder.Services.RegisterIdentity(config);

var app = builder.Build();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
