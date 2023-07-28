using Profile.Application.Resume.Commands;
using Profile.Domain.Resume.Interfaces;
using Profile.Infra.Data;
using Profile.Infra.Data.Repository.Resume;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateNewResumeCommand>());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(opt => opt.LowercaseUrls = true);

builder.Services.AddDbContext<ProfileDbContext>();

builder.Services.AddScoped<IResumeRepository, ResumeRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
