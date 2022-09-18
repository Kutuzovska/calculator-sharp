using ccalc.Common;
using ccalc.Repositories;
using ccalc.Services;

namespace ccalc;

public static class Program
{
    public static void Main()
    {
        var builder = WebApplication.CreateBuilder();
        builder.Services.AddControllersWithViews();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddSingleton<IDistancesRepository, MongoDistancesRepository>();
        builder.Services.AddSingleton<ICalculatorService, CalculatorService>();
        builder.Services.AddSingleton<Mongo>();

        var app = builder.Build();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        else
        {
            app.UseHsts();
        }


        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.UseStaticFiles();
        app.UseRouting();
        app.MapFallbackToFile("index.html");
        app.Run();
    }
}