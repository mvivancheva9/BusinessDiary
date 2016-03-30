namespace BusinessDiary.Web.App_Start
{
    using Data;
    using Data.Migrations;
    using System.Data.Entity;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BusinessDiaryDbContext, Configuration>());

            BusinessDiaryDbContext.Create().Database.Initialize(true);
        }
    }
}
