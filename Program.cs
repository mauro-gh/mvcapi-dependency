using mvcapi.Models.Services.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// torna sempre lo stesso numero, anche da 2 browser differenti
builder.Services.AddSingleton<ISingletonRandom, NetRandom>();

// torna sempre numeri differenti
builder.Services.AddTransient<ITransientRandom, NetRandom>();

// torna sempre numeri differenti
builder.Services.AddScoped<IScopedRandom, NetRandom>();



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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
