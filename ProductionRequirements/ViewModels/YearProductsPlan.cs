using System.ComponentModel;

namespace ProductionRequirements.ViewModels
{
    public class YearProductsPlanViewModel
    {
        [DisplayName("Найменування продукту")]
        public string ProductName { get; set; }

        [DisplayName("Кількість")]
        public double ProductAmount { get; set; }

        [DisplayName("Одиниця виміру")]
        public string UoM { get; set; }
    }
}
