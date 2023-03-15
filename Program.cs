using ZooManagement;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using ZooManagement.Data;
using ZooManagement.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "zoo", Version = "v1" });
});

builder.Services.AddDbContext<ZooDbContext>(options =>
{
    options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
    options.UseSqlite("Data Source=zoo.db");
});

builder.Services.AddTransient<IAnimalsRepo, AnimalsRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "zoo v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

CreateDbIfNotExists(app);

app.Run();

static void CreateDbIfNotExists(IHost host)
{
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ZooDbContext>();
    context.Database.EnsureCreated();

     if (!context.Animal.Any())
       {
           var animals = SampleAnimals.GetAnimals();
           context.Animal.AddRange(animals);
           context.SaveChanges();

        //    var posts = SamplePosts.GetPosts();
        //    context.Posts.AddRange(posts);
        //    context.SaveChanges();

        //    var interactions = SampleInteractions.GetInteractions();
        //    context.Interactions.AddRange(interactions);
        //    context.SaveChanges();
       }
   
}


