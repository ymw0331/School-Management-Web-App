using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using School_Management_Web_App.Models;
using System;

[assembly: OwinStartupAttribute(typeof(School_Management_Web_App.Startup))]
namespace School_Management_Web_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            ConfigureAuth(app);
            createRolesAndUsers();
        }


        //create 3 different roles when appp start
        public void createRolesAndUsers()
        {
            //intialise appDB context
            var context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //var user = new ApplicationUser
            //{
            //    UserName = "admin",
            //    Email = "admin@schmng.com",
            //    BirthDate = DateTime.Now

            //};
            //var password = "password";

            //var usr = userManager.Create(user, password);

            //if (usr.Succeeded)
            //{
            //    var result = userManager.AddToRole(user.Id, "Admin");
            //}

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Teacher"))
            {
                var role = new IdentityRole();
                role.Name = "Teacher";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Supervisor"))
            {
                var role = new IdentityRole();
                role.Name = "Supervisor";
                roleManager.Create(role);
            }

        }
    }
}
