namespace OisinLynch_S00189006.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OisinLynch_S00189006.PhoneData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OisinLynch_S00189006.PhoneData";
        }

        protected override void Seed(OisinLynch_S00189006.PhoneData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
