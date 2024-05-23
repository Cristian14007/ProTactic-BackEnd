using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using BackEnd.Business;
using BackEnd.Data;


//var builder = WebApplication.CreateBuilder(args);
var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:5173")
                                .AllowAnyMethod() // Esto permitirá todos los métodos, incluyendo DELETE
                                .AllowAnyHeader();
                      });
});



// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



/* builder.Services.AddSingleton<IPizzaRepository, PizzaRepository>();
builder.Services.AddScoped<PizzaService>();
builder.Services.AddSingleton<IIngredientesRepository, IngredientesRepository>();
builder.Services.AddScoped<IngredienteService>(); */


builder.Services.AddScoped<IExerciseService, ExerciseService>();
builder.Services.AddScoped<IExerciseRepository, ExerciseEFRepository>();



builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserEFRepository>();

builder.Services.AddScoped<IPlanService, PlanService>();
builder.Services.AddScoped<IPlanRepository, PlanEFRepository>();

builder.Services.AddScoped<IAmigoService, AmigoService>();
builder.Services.AddScoped<IAmigoRepository, AmigoEFRepository>();


//var connectionString = builder.Configuration.GetConnectionString("ServerDB");
var connectionString = builder.Configuration.GetConnectionString("ServerDB");

builder.Services.AddDbContext<ExerciseContext>(options =>
    options.UseSqlServer(connectionString)
    .LogTo(Console.WriteLine,LogLevel.Information));
  
  



/* builder.Services.AddScoped<IPizzaRepository, PizzaSqlRepository>(serviceProvider => 
    new PizzaSqlRepository(connectionString));

    builder.Services.AddScoped<IIngredientesRepository, IngredienteSqlRepository>(serviceProvider => 
    new IngredienteSqlRepository(connectionString)); */


/* builder.Services.AddScoped<IngredienteService>();
builder.Services.AddSingleton<IIngredientesRepository, IngredientesRepository>(); */

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();


app.MapControllers();

app.Run();
