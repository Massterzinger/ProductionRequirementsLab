namespace ProductionRequirements.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedRedundant : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductionPlans", "PlanApprovalDate");
            DropColumn("dbo.ProductionPlans", "PlanClosedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductionPlans", "PlanClosedDate", c => c.DateTime());
            AddColumn("dbo.ProductionPlans", "PlanApprovalDate", c => c.DateTime(nullable: false));
        }
    }
}
