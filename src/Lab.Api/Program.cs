var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/health", () => TypedResults.Ok(new { status = "ok" }));

app.Run();
public partial class Program { }