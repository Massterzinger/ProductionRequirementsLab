using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProductionRequirements.Models
{
    public class UnitOfMeasurement
    {
        [Key]
        public Guid Id { get; set; }

        public string LongName { get; set; }
        public string ShortName { get; set; }

        public override string ToString()
        {
            return ShortName;
        }
    }
}