using ECommerceApp.Data; // Import your DbContext namespace
using Microsoft.EntityFrameworkCore; // For database configurations

var builder = WebApplication.CreateBuilder(args);

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowNuxtApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // Nuxt frontend URL
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials(); // If you're using cookies or auth tokens
    });
});


// Add services to the container
builder.Services.AddControllers(); // Enables API controllers
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))); // Register PostgreSQL connection

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Helpful for debugging in development mode
}
//using cores
app.UseCors("AllowNuxtApp");

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseRouting(); // Enable routing

app.MapControllers(); // Map your API controllers

app.Run();
