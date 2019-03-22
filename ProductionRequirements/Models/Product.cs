using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionRequirements.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public Guid UoMId { get; set; }

        [ForeignKey("UoMId")]
        public virtual UnitOfMeasurement UoM { get; set; }

        public virtual ICollection<ProductToComponentRelation> ProductToComponentRelations { get; set; }
    }
}