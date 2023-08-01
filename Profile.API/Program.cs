using Profile.Application.Resume.Commands;
using Profile.Domain.CharacterAggregate.Interfaces;
using Profile.Infra.Data;
using Profile.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateNewCharacterCommand>());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
