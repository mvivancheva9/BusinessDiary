namespace BusinessDiary.Data.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<BusinessDiaryDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BusinessDiaryDbContext context)
        {
            context.Roles.AddOrUpdate(
              p => p.Name,
              new IdentityRole { Name = "Admin" });

            context.SaveChanges();
            if (!context.Users.Where(u => u.UserName == "vivabags@abv.com").Any())
            {
                var admin = new User
                {
                    UserName = "vivabags@abv.com",
                    Email = "vivabags@abv.com",
                    PasswordHash = "AJ6xY/N9kWRShbJYh8QE5fIt5Yg5IeyTFBnJ9RXAdIXUo9hiqxtVWRiYJ0XyUHVDbg==",
                    SecurityStamp = "59bcf0ca-0367-4397-b3c1-af413e479e0c",
                    LockoutEnabled = true,
                };

                context.Users.Add(admin);

                var role = context.Roles.Where(r => r.Name == "Admin").FirstOrDefault();
                var adminRole = new IdentityUserRole
                {
                    RoleId = role.Id
                };

                admin.Roles.Add(adminRole);
                context.SaveChanges();
            }
        }
    }
}
