using eTicketsProject.Data;
using eTicketsProject.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//DbContext configuration ; define the data storage so that the translator need to know between which data storage and which c# classes it needs to translate 
//to get data from the appsetting.json, we use the IConfiguration interface which value has been set into the Configuration property
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"))); //connection string from the appsetting.json file

// Add services to the container.
builder.Services.AddControllersWithViews();

//Services configuration
builder.Services.AddScoped<IActorsServices, ActorsService>();

var app = builder.Build();

//Seed database
AppDbInitializer.Seed(app);

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

