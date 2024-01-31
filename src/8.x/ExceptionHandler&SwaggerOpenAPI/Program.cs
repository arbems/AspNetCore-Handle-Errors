var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

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
