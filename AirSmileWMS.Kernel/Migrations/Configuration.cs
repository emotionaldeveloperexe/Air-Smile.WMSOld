namespace AirSmileWMS.Kernel.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AirSmileWMS.Kernel.Data.Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            #if DEBUG
            // В разработке можно потерять данные (таблицы дропнутся — хуй с ними)
            AutomaticMigrationDataLossAllowed = true;
            #else
            // На проде ни в коем случае!
            AutomaticMigrationDataLossAllowed = false;
            #endif
        }

        protected override void Seed(AirSmileWMS.Kernel.Data.Db context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
