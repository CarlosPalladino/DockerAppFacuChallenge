using Infrastructures.Configuration;
using RedLockNet.SERedis;
using RedLockNet.SERedis.Configuration;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationDbContext(builder.Configuration);
//builder.Services.AddSingleton<IRedLockFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// deberia ir acá ? 
var reddisConnection = ConnectionMultiplexer.Connect("");
var redlockFactory = RedLockFactory.Create(new List<RedLockMultiplexer>
{
    reddisConnection
});


//builder.Services.AddDbContext<ApplicationDbContext>();

app.UseHttpsRedirection();



app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
