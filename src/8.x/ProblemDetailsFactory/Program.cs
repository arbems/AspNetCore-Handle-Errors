using CustomProblemDetailsFactory;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<ProblemDetailsFactory, SampleProblemDetailsFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    // Custom error handling for the Development environment
    app.UseExceptionHandler("/error-development");
}
else
{
    // Custom error handling for the Production environment
    app.UseExceptionHandler("/error");
}

app.UseAuthorization();

app.MapControllers();

app.Run();
