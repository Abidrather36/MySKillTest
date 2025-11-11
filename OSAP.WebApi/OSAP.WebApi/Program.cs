using MySkillTest.Application;
using MySkillTest.WebApi;
using MySkillTest.Persistence;
using MySkillTest.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiService(builder.Configuration)
                 .AddApplicationService(builder.Configuration)
                 .AddPersistenceService(builder.Configuration)
                 .AddInfrastructureService()
                 .AddCors(options =>
                 {
                     options.AddDefaultPolicy(policy =>
                     {
                         policy.WithOrigins("", "");
                         policy.AllowCredentials();
                         policy.AllowAnyHeader();
                         policy.AllowAnyMethod();
                     });
                 });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
