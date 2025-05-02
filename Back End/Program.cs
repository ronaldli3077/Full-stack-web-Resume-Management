
using System.Text.Json.Serialization;
using backendResume.Core.AutoMapperConfig;
using backendResume.Core.Context;
using Microsoft.EntityFrameworkCore;

namespace backendResume
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //dB CONFIGURATION
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("local"));
            });


            //automapper config
            builder.Services.AddAutoMapper(typeof (AutoMapperConfigProfile));



            builder.Services
                .AddControllers()
                .AddJsonOptions (options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                });



            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(options =>
            {
                options.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
