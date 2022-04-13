var builder = WebApplication.CreateBuilder(args);


// code below this was written in configureservices method
#region ConfigureServices

// Add services to the container.
builder.Services.AddControllersWithViews();
#endregion



// code below this was written in configure method and it will contain middleware
// and environment related code
#region Configure
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
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
#endregion