using System.Data.Entity.Migrations;

namespace EntityFrameworkTest
{
    public class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataContext context)
        {
            Seeder.Seed(context);
        }
    }
}
