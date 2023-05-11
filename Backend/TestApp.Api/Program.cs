using TestApp.Api.Configurations;
using TestApp.DataLayer;
using TestApp.Models.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureDatabase();
builder.Services.ConfigureSettings<DbSettings>(builder.Configuration, nameof(DbSettings));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MigrationDbContext<DataDbContext>();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();