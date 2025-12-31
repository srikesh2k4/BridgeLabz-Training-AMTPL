using System.Text.Json;
using Microsoft.AspNetCore.Http.HttpResults;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

//adding json as service
// builder.Services.AddSingleton<UserJsonService>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();



// app.MapGet("/user", (UserJsonService service,HttpContext context) =>
// {
//     var data = service.GetUsers();
//     return context.Request.Path;
//
// });
//
// app.MapGet("/user/{name}", (string name,UserJsonService service) =>
// {
//     var data = service.GetUsers();
//     var user = data.FirstOrDefault(x => string.Equals(x.name,name,StringComparison.OrdinalIgnoreCase));
//     return user is null? Results.NotFound("User not found"):Results.Ok(user);
// });
//
// app.MapPost("/shirts", () =>
// {
//     return "Shirt is created";
// });
//
// app.MapPut("/shirts/{id}", (int id) =>
// {
//     return $"this is the shirt updated {id}";
// });
//
// app.MapDelete("/shirts/{id}", (int id) =>
// {
//     return $"this is delete {id}";
// });