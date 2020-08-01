using CRM_Project.DAL.Context;
using System.Data.Entity.Migrations;

namespace CRM_Project.Migrations
{
    internal sealed class Configurations : DbMigrationsConfiguration<CRM_Project.DAL.Context.CRMContext>
    {

        public Configurations()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "CRM_Project.DAL.Context.CRMContext";
        }

        protected override void Seed(CRMContext context)
        {
            base.Seed(context);
        }
    }
}