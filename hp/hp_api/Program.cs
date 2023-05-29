using hp_api.Controllers.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Allow CORS 
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

//Allow CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins, builder =>
    {
        builder.WithOrigins("http://servidor09").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
        builder.SetIsOriginAllowed(origin => true);
    });
}); //tem q configurar o cors

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext 
builder.Services.AddDbContext<HpContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("StringConexaoSQLServer"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Allow CORS 
app.UseCors(MyAllowSpecificOrigins);

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
