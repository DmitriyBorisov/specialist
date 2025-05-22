using Lab3._1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/courses", async context => await context.Response.WriteAsJsonAsync(Course.All));

app.MapGet("/api/courses/{id:int}", async (HttpContext context, int id) =>
{
    Course course = Course.All.SingleOrDefault(c => c.Id == id);
    if (course == null) context.Response.StatusCode = StatusCodes.Status404NotFound;
    else await context.Response.WriteAsJsonAsync(course);
});

app.MapGet("/api/courses/{search}", async (HttpContext context, string search) =>
{
    var course = Course.All.Where(c => c.Title.Contains(search, StringComparison.OrdinalIgnoreCase));
    await context.Response.WriteAsJsonAsync(course);
});

app.MapPost("/api/courses", async (HttpContext context, Course course) =>
{
    if(course.Id == 0) course.Id = Course.All.Select( c => c.Id).Max() + 1;
    Course.All.Add(course);
    await context.Response.WriteAsJsonAsync(course);
});

app.MapDelete("/api/courses/{id:int}", (HttpContext context, int id) =>
{
    Course course = Course.All.SingleOrDefault(c => c.Id == id);
    if (course == null) context.Response.StatusCode = StatusCodes.Status404NotFound;
    else Course.All.Remove(course);
});

app.Run();
