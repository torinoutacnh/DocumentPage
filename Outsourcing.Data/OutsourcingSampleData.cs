using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Outsourcing.Data.Models;


namespace Outsourcing.Data
{
    public class OutsourcingSampleData : DropCreateDatabaseIfModelChanges<OutsourcingEntities>
    {
        private UserManager<User> UserManager;
        private RoleManager<IdentityRole> RoleManager;

        protected override void Seed(OutsourcingEntities context)
        {
            UserManager = new UserManager<User>(new UserStore<User>(context));
            RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //Create User

            //var users = new List<User>() {
            //      new User(){ UserName = "admin", FirstName = "Company", LastName = "Admin",RoleId = SystemRoles.Role01},
            //    new User(){ UserName = "vuonghtt", FirstName = "Vuong", LastName = "Nhan",RoleId = SystemRoles.Role01}};
            //foreach (var user in users)
            //{
            //    if (UserManager.FindByName(user.UserName) == null)
            //    {
            //        UserManager.Create(user, "123456");
            //    }
            //}


            //Create Roles
            //var listRoles = new List<string>(new string[] { "Admin" });
            //foreach (var role in listRoles)
            //{
            //    if (!RoleManager.RoleExists(role))
            //    {
            //        RoleManager.Create(new IdentityRole(role));
            //    }
            //}
           
            context.WebsiteAttributes.Add(new WebsiteAttribute() { Name = "Labixa.PopupWebsite", IsPublic = true, Deleted = false });
            context.SaveChanges();
        }

    }
}