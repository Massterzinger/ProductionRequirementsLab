using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionRequirements.Models
{
    public class ProductToComponentRelation
    {
        //[Key]
        public Guid Id { get; set; }

        public double ComponentRequiredAmount { get; set; }

        public Guid ProductId { get; set; }

        public Guid ProductComponentId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("ProductComponentId")]
        public virtual ProductComponent Component { get; set; }
    }
}