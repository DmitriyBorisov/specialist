using Lab6._1.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IHello, Hello>();
var app = builder.Build();

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf8";
    var helloServ = context.RequestServices.GetRequiredService<IHello>();
    await context.Response.WriteAsync($"<h1>{helloServ.WelcomeUser()}</h1>");
});

app.Run();
