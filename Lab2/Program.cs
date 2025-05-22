using System.Net;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async(context, next) =>
{
    context.Response.ContentType = "text/html; charset=utf8";
    await next();
});

app.Map("/time", app2 => 
{
    app2.Run(async context => 
    {
        await context.Response.WriteAsync(DateTime.Now.ToLongTimeString());
    });
});

app.Map("/date", app2 =>
{
    app2.Run(async context =>
    {
        await context.Response.WriteAsync(DateTime.Now.ToLongDateString());
    });
});

app.MapWhen(context => context.Request.Path == "/", app2 =>
{
    app2.Run(async context => 
    {
        await context.Response.WriteAsync("<h1>Главная страница!</h1>");
    });
    
});

app.Run(async context =>
{
    context.Response.StatusCode = StatusCodes.Status404NotFound;
    await context.Response.WriteAsync("<h1>Ресурс не найден!</h1>");
});

app.Run();
