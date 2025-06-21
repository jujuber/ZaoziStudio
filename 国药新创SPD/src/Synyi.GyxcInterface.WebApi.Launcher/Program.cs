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
            /* 系统默认生成
              builder.Services.AddControllers();
              // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
              builder.Services.AddEndpointsApiExplorer();
              builder.Services.AddSwaggerGen();
            */
            builder.Host.ConfigureAspNet<ModuleCatalog>();
            builder.Host.ConfigureEntityFramework<ConnectionStringProvider>();

            //跨域策略
            builder.Services.AddCors(options =>
            {
                //options.AddPolicy("any", p => p.WithOrigins(builder.Configuration.GetValue<string>("corsUrls").Split(",")).AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

                options.AddPolicy("any", p => p.WithOrigins("*").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            var app = builder.Build();


            app.UseDomain();
            app.UseAspNet(app.Environment);

            //临时处理下启用swagger
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

            /* 系统默认生成
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            */

            app.UseAuthorization();


            app.MapControllers();
            //跨域策略
            app.UseCors("any");
            app.Run();
        }
    }
}
