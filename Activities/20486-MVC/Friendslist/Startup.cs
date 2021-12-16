using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeFriendslist.Models;
using ChallengeFriendslist.Services;
using ChallengeFriendslist.Data;
using Microsoft.EntityFrameworkCore;

namespace ChallengeFriendslist
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionstring = "Server=GPC-LEON\\SQLEXPRESS;Database=Friends;Trusted_Connection=True;MultipleActiveResultSets=true";
            // GPC-LEON\SQLEXPRESS

            services.AddTransient<IListOfFriends, ListOfFriends>(); // Add Buttler to interact with database
            services.AddDbContext<FriendContext>(options => options.UseSqlServer(connectionstring)); // Service of DataContext
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Friend}/{action=Index}/{id?}");
            });
        }
    }
}
