using FluentValidation;
using Microsoft.OpenApi.Models;
using Profile.Application.CharacterApp.Commands;
using Profile.Domain.CharacterAggregate.Interfaces;
using Profile.Infra.Data;
using Profile.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateNewCharacterCommand>());

ValidatorOptions.Global.LanguageManager.Enabled = false;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "Profile API - V1",
            Version = "v1"
        }
     );

    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Profile.API.xml"), true);
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Profile.Application.xml"));
});

builder.Services.AddRouting(opt => opt.LowercaseUrls = true);

builder.Services.AddDbContext<ProfileDbContext>();

builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using var scope = app.Services.GetService<IServiceScopeFactory>()?.CreateScope();
    var context = scope?.ServiceProvider.GetRequiredService<ProfileDbContext>();
    context?.Database.EnsureCreated();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
