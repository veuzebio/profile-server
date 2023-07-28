using Profile.Application.Resume.Commands;
using Profile.Infra.Data;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateNewResumeCommand>());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(opt => opt.LowercaseUrls = true);

builder.Services.AddDbContext<ProfileDbContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
