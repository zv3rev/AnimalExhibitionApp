using AnimalExhibition.Api.Configuration;
using AnimalExhibition.API.Configuration;
using DSRNetSchool.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.AddAppLogger();

var services = builder.Services;

services.AddHttpContextAccessor();

services.AddAppHealthChecks();

services.AddAppCors();

services.AddAppVersioning();

services.AddAppSwagger();

services.AddAppControllerAndViews();

var app = builder.Build();

app.UseAppHealthChecks();

app.UseAppSwagger();

app.UseAppControllerAndViews();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.Run();
