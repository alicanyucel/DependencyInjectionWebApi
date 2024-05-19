using DependencyInjectionWebApi.Controllers;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddTransient<IUser, User>();

builder.Services.AddTransient<User>();
//builder.Services.AddScoped<User>();
//builder.Services.AddSingleton<User>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();