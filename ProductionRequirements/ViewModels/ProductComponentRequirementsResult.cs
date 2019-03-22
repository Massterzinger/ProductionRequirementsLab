using System.ComponentModel;

namespace ProductionRequirements.ViewModels
{
    public class ProductComponentRequirementsResult
    {
        [DisplayName("Найменування ПКВ")]
        public string Name { get; set; }

        [DisplayName("Кількість")]
        public double Amount { get; set; }

        [DisplayName("Одиниця виміру")]
        public string UoM { get; set; }

        [DisplayName("Вартість")]
        public double Cost { get; set; }
    }
}
