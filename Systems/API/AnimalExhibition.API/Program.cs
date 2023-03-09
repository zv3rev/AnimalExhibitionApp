using AnimalExhibition.Api;
using AnimalExhibition.Api.Configuration;
using AnimalExhibition.API.Configuration;
using AnimalExhibition.Services.Settings;
using AnimalExhibition.Settings;
using DSRNetSchool.Api.Configuration;
using AnimalExhibition.Context;

var mainSettings = Settings.Load<MainSettings>("Main");
var swaggerSettings = Settings.Load<SwaggerSettings>("Swagger");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.AddAppLogger();

var services = builder.Services;

services.AddHttpContextAccessor();

services.AddAppHealthChecks();

services.AddAppCors();

services.AddAppDbContext(builder.Configuration);

services.AddAppVersioning();

services.AddAppSwagger(mainSettings, swaggerSettings);

services.AddAppControllerAndViews();

services.RegisterAppServices();

var app = builder.Build();

app.UseAppHealthChecks();

app.UseAppSwagger();

app.UseAppControllerAndViews();

DbInitializer.Execute(app.Services);

DbSeeder.Execute(app.Services,true,true);


// Configure the HTTP request pipeline.

app.UseAuthorization();

app.Run();
