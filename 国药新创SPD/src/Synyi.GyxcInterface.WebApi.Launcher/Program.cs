using Synyi.Framework.AspNet.Hosting;
using Synyi.Framework.AspNet.Middleware;
using Synyi.Framework.Domain.Hosting;
using Synyi.Framework.EntityFramework.Hosting;

namespace Synyi.GyxcInterface.WebApi.Launcher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            /* ϵͳĬ������
              builder.Services.AddControllers();
              // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
              builder.Services.AddEndpointsApiExplorer();
              builder.Services.AddSwaggerGen();
            */
            builder.Host.ConfigureAspNet<ModuleCatalog>();
            builder.Host.ConfigureEntityFramework<ConnectionStringProvider>();

            //�������
            builder.Services.AddCors(options =>
            {
                //options.AddPolicy("any", p => p.WithOrigins(builder.Configuration.GetValue<string>("corsUrls").Split(",")).AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

                options.AddPolicy("any", p => p.WithOrigins("*").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            var app = builder.Build();


            app.UseDomain();
            app.UseAspNet(app.Environment);

            //��ʱ����������swagger
            if (app.Environment.EnvironmentName.StartsWith("Development"))
            {
                app.UseSwagger(options =>
                {
                    options.RouteTemplate = "{documentName}/swagger.json";
                });
                app.UseSwaggerUI(options =>
                {
                    options.RoutePrefix = "swagger";
                    options.SwaggerEndpoint("/default/swagger.json", "default");
                });
            }

            /* ϵͳĬ������
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            */

            app.UseAuthorization();


            app.MapControllers();
            //�������
            app.UseCors("any");
            app.Run();
        }
    }
}
