var builder = WebApplication.CreateBuilder(args);

// Указываем приложению слушать порт 8080
builder.WebHost.UseUrls("http://0.0.0.0:8080");

var app = builder.Build();

app.MapGet("/health", () => "OK");

app.MapGet("/tasks", () => new[] 
{
    new { Id = 1, Title = "Изучить Docker", IsCompleted = true },
    new { Id = 2, Title = "Сделать контрольную точку", IsCompleted = false }
});

app.Run();
