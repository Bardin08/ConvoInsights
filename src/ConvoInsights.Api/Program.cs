using ConvoInsights.Api.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddConvoInsightsServices(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
