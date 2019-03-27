using System.ComponentModel;

namespace ProductionRequirements.ViewModels
{
    public class ProductViewModel
    {
        [DisplayName("Найменування виробу")]
        public string ProductName { get; set; }

        [DisplayName("Одиниця виміру")]
        public string UoM { get; set; }
    }
}
