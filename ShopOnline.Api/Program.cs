using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* Build works but a network-related/instance-specific error occured.
 * The server was not found or was not accessible.
 * Issue still isn't solved.
 * Bug is still bothering me.
 * THIS IS HARD, STILL NOT FIXED 
 * im gonna cry
 */

builder.Services.AddDbContextPool<ShopOnlineDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ShopOnlineConnection")));
// Issue probably persists in the AddDbContextPool
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); 

app.Run();
