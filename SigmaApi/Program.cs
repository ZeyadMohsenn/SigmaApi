using Microsoft.EntityFrameworkCore;
using SigmaApi.BL;
using SigmaApi.DAL;
using SigmaApi.DAL.Data.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Database
string? connectionString = builder.Configuration.GetConnectionString("Sigma");
builder.Services.AddDbContext<SigmaContext>(options =>
    options.UseSqlServer(connectionString));
#endregion

#region Repos
builder.Services.AddScoped<ICandidateRepo, CandidateRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
#endregion

#region Services
builder.Services.AddScoped<ICandidateService, CandidateService>();
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
