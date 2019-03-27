namespace ProductionRequirements
{
    using System;
    using ProductionRequirements.Models;
    using System.Data.Entity;
    using System.Linq;

    public class ProductionModel : DbContext
    {
        static ProductionModel()
        {
            Database.SetInitializer(new ProductModelInitializer());
            //Database.SetInitializer<ProductionModel>(null);
        }

        public ProductionModel()
            : base("name=ProductionModelEgor")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductToComponentRelation>()
                .HasRequired(c => c.Product)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>().HasMany(p => p.ProductToComponentRelations).WithRequired(c => c.Product);

        }

        public virtual DbSet<UnitOfMeasurement> UnitsOfMeasurement { get; set; }
        public virtual DbSet<ProductComponent> ProductComponents { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductToComponentRelation> ProductToComponentRelations { get; set; }
    }
}