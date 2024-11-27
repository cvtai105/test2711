using Microsoft.EntityFrameworkCore;
using test2711.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Retrieve CORS origins from configuration
var allowedOrigins = builder.Configuration.GetSection("AllowedHosts").Get<string[]>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CustomPolicy", policy =>
        policy.WithOrigins(allowedOrigins ?? ["*"])
              .AllowAnyMethod()
              .AllowAnyHeader());
});

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
    
var app = builder.Build();  

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();