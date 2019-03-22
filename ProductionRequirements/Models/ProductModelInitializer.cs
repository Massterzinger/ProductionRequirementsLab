using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProductionRequirements.Models
{
    public class ProductModelInitializer : CreateDatabaseIfNotExists<ProductionModel>
    {
        protected override void Seed(ProductionModel context)
        {
            var uoms = new List<UnitOfMeasurement>
            {
                new UnitOfMeasurement { Id = Guid.NewGuid(), LongName = "Штука", ShortName = "шт."},
                new UnitOfMeasurement { Id = Guid.NewGuid(), LongName = "Літр", ShortName = "л." },
                new UnitOfMeasurement { Id = Guid.NewGuid(), LongName = "Кілограм", ShortName = "кг." }
            };

            context.UnitsOfMeasurement.AddRange(uoms);

            var productComponents = new List<ProductComponent>
            {
                new ProductComponent { Id = Guid.NewGuid(), Name = "Молоко", PricePerUnit = 25, UoMId = uoms[1].Id },
                new ProductComponent { Id = Guid.NewGuid(), Name = "Масло", PricePerUnit = 250, UoMId = uoms[2].Id },
                new ProductComponent { Id = Guid.NewGuid(), Name = "Вершки", PricePerUnit = 155, UoMId = uoms[1].Id },
                new ProductComponent { Id = Guid.NewGuid(), Name = "Цукор", PricePerUnit = 12.50M, UoMId = uoms[2].Id },
                new ProductComponent { Id = Guid.NewGuid(), Name = "Яйце", PricePerUnit = 0.5M, UoMId = uoms[0].Id },
                new ProductComponent { Id = Guid.NewGuid(), Name = "Ріжок", PricePerUnit = 2, UoMId = uoms[0].Id }
            };

            context.ProductComponents.AddRange(productComponents);

            var products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Морозиво ріжок \"Пломбір\"", UoMId = uoms[0].Id},
                new Product { Id = Guid.NewGuid(), Name = "Морозиво вагове \"Пломбір\"", UoMId = uoms[2].Id},
                new Product { Id = Guid.NewGuid(), Name = "Морозиво ріжок \"Крем-Брюле\"", UoMId = uoms[0].Id},
                new Product { Id = Guid.NewGuid(), Name = "Морозиво вагове \"Крем-Брюле\"", UoMId = uoms[2].Id}
            };

            context.Products.AddRange(products);

            var productToComponentRelations = new List<ProductToComponentRelation>
            {
                // Ріжок пломбір
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[0].Id, ProductComponentId = productComponents[0].Id , ComponentRequiredAmount = 0.012},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[0].Id, ProductComponentId = productComponents[2].Id , ComponentRequiredAmount = 0.043},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[0].Id, ProductComponentId = productComponents[3].Id , ComponentRequiredAmount = 0.02},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[0].Id, ProductComponentId = productComponents[5].Id , ComponentRequiredAmount = 1},
                
                // Вагове пломбір
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[1].Id, ProductComponentId = productComponents[0].Id , ComponentRequiredAmount = 0.15},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[1].Id, ProductComponentId = productComponents[1].Id , ComponentRequiredAmount = 0.1},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[1].Id, ProductComponentId = productComponents[3].Id , ComponentRequiredAmount = 0.3},
                
                // Ріжок крем-брюле
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[2].Id, ProductComponentId = productComponents[0].Id , ComponentRequiredAmount = 0.012},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[2].Id, ProductComponentId = productComponents[1].Id , ComponentRequiredAmount = 0.031},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[2].Id, ProductComponentId = productComponents[3].Id , ComponentRequiredAmount = 0.02},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[2].Id, ProductComponentId = productComponents[4].Id , ComponentRequiredAmount = 0.5},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[2].Id, ProductComponentId = productComponents[5].Id , ComponentRequiredAmount = 1},
                
                // Вагове крем-брюле
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[3].Id, ProductComponentId = productComponents[0].Id , ComponentRequiredAmount = 0.15},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[3].Id, ProductComponentId = productComponents[1].Id , ComponentRequiredAmount = 0.1},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[3].Id, ProductComponentId = productComponents[3].Id , ComponentRequiredAmount = 0.2},
                new ProductToComponentRelation{ Id = Guid.NewGuid(), ProductId = products[3].Id, ProductComponentId = productComponents[4].Id , ComponentRequiredAmount = 3}

            };

            context.ProductToComponentRelations.AddRange(productToComponentRelations);

            var plans = new List<ProductionPlan>
            {
                new ProductionPlan{Id = Guid.NewGuid(), PlanningPeriod = "2014", ProductId = products[0].Id, PlannedAmount = 15000},
                new ProductionPlan{Id = Guid.NewGuid(), PlanningPeriod = "2014", ProductId = products[1].Id, PlannedAmount = 2000},
                new ProductionPlan{Id = Guid.NewGuid(), PlanningPeriod = "2014", ProductId = products[2].Id, PlannedAmount = 13400},
                new ProductionPlan{Id = Guid.NewGuid(), PlanningPeriod = "2014", ProductId = products[3].Id, PlannedAmount = 3000}
            };

            context.ProductionPlans.AddRange(plans);
            
            context.SaveChanges();
        }
    }
}