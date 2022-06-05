using Backend_basis;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/beer", () => new Repository().GetCervezas());
app.MapGet("/beer/{id}", (int id) =>
{
    var cervecita = new Repository().GetCerveza(id);
    return cervecita == null ? Results.NotFound() : Results.Ok(cervecita);
});
app.Run();
