var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// adds services related to the ProblemDetails feature
builder.Services.AddProblemDetails();

var app = builder.Build();

app.UseExceptionHandler();
app.UseStatusCodePages();

/*if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}*/

app.MapControllers();
app.Run();