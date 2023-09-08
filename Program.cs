using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AzCelebrates.Context.FormContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FormContext")
    );
});
var app = builder.Build();



app.MapControllers();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    // endpoints.MapControllerRoute(
    //     name: "default",
    //     pattern: "{controller=Home}/{action=Index}/{id?}");
});

// app.MapGet("/", () => "Hello World!");

app.Run();
