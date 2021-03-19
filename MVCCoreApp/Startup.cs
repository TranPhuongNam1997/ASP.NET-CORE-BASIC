using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace MVCCoreApp
{
    public class Startup
    {
        private object routes;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //khai báo không tường minh
            //app.UseMvcWithDefaultRoute();


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //khai báo tường minh

            //app.UseMvc();

            app.UseMvc(routes =>
            {

                //đây là 2 route nằm trong connection khi khởi động ứng dụng nạp 2 thằng vào connecttion
                // và no chạy từ trên xuống nếu map thằng nào trả về routehandler (mặc trong mvc core)
                // khi thành công sẽ quyết định xem action hay controller nào được xử lý 
                //tạo ra instance của controller đấy
                //và lúc đó gọi actionmethod tương ứng

                //routes.MapRoute("secure", "secure", new
                //{
                //    Controller = "Admin",
                //    Action = "Index"
                //});

                // đây là cách dùng maproute

                //routes.MapRoute("default", "{controller=Home}/{action=index}/{id?}");
                //routes.MapRoute("default", "{controller=Home}/{action=index}/{id:int?}");

                // cách dùng theo object
                //routes.MapRoute("default", "{controller}/{action}/{id}",
                //    new { controller = "Home", action = "Index" },
                //    new { id = new IntRouteConstraint() });

                //routes.MapRoute("default",
                //    "post/{id:int}",
                //    new { controller = "Post", action = "PostsByID" });

                //routes.MapRoute("anotherRoute",
                //    "post/{id:alpha}",
                //    new { controller = "Post", action = "PostsByName" });
                routes.MapRoute("default", "{controller=Home}/{action=index}/{id:alpha:minlength(6)?}");





            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });

        }
    }
}
