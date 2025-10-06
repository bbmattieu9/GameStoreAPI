using GameStore.Api.Data;
using GameStore.Api.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStoreConnString");
builder.Services.AddDbContext<GameStoreContext>(options => options.UseSqlServer(connString));

var app = builder.Build();

app.MapGamesEndpoints();

app.MigrateDb();

app.Run();
