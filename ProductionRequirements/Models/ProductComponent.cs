using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionRequirements.Models
{
    public class ProductComponent
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public Guid UoMId { get; set; }
        public decimal PricePerUnit { get; set; }

        [ForeignKey("UoMId")]
        public virtual UnitOfMeasurement UoM { get; set; }
    }
}