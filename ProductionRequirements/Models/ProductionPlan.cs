using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionRequirements.Models
{
    public class ProductionPlan
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }
        public double PlannedAmount { get; set; }
        public string PlanningPeriod { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}