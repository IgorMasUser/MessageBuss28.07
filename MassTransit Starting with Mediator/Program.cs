using MassTransit;
using Sample.Components.Consumers;
using Sample.Contracts;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddMassTransit(x =>
//{
//    x.AddMediator(cfg =>
//    {
//        cfg.AddConsumer<SubmitOrderConsumer>();
//        cfg.AddRequestClient<SubmitOrder>();
//    });
//});

builder.Services.AddMediator(options =>
{
    options.AddConsumer<SubmitOrderConsumer>();
    options.AddRequestClient<SubmitOrder>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApiDocument(cfg => cfg.PostProcess = d => d.Info.Title = "Sample API Site");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    app.UseSwaggerUi3();
    app.UseOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseRouting();

app.Run();
