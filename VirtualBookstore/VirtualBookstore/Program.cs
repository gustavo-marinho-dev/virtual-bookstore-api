using VirtualBookstore.Api.Configurations;
using VirtualBookstore.Application;
using VirtualBookstore.CrossCutting.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureApplication();
builder.Services.ConfigureApiBehavior();
builder.Services.ConfigureCorsPolicy();
builder.Services.AddControllers();

builder.Services.ConfigureIoC(builder.Configuration);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

//var serviceScope = app.Services.CreateScope();

//var dataContext = serviceScope.ServiceProvider.GetService<VirtualBookstoreContext>();
//dataContext?.Database.EnsureCreated();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "VirtualBookstore.API v1");
    });
}

app.UseErrorHandler();

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
