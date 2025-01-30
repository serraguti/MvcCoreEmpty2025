var builder = WebApplication.CreateBuilder(args);
//TODO LO QUE INDIQUEMOS SERAN SERVICIOS
//AÑADIMOS LOS SERVICIOS DE VISTAS Y CONTROLLERS
builder.Services.AddControllersWithViews();

var app = builder.Build();
//DEBEMOS INDICAR QUE UTILIZAREMOS RUTAS PARA 
//CONTROLLERS Y VIEWS

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
