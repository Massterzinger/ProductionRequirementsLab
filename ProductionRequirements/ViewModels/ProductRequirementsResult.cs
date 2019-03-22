using System;
using System.ComponentModel;

namespace ProductionRequirements.ViewModels
{
    public class ProductRequirementsResult
    {
        //[DisplayName("Плановий період")]
        //public string Year { get; set; }

        [DisplayName("Код ПКВ")]
        public Guid ProductComponentId { get; set; }

        [DisplayName("Назва ПКВ")]
        public string ProductComponentName { get; set; }

        [DisplayName("Одиниця виміру ПКВ")]
        public string ComponentUoM { get; set; }

        [DisplayName("Ціна за одиницю ПКВ")]
        public decimal ProductComponentPrice { get; set; }

        [DisplayName("Код Продукту")]
        public Guid ProductId { get; set; }

        [DisplayName("Назва Продукту")]
        public string ProductName { get; set; }

        [DisplayName("План виробництва продукту")]
        public double ProductCount { get; set; }

        [DisplayName("Одиниця виміру продукту")]
        public string ProductUoM { get; set; }

        [DisplayName("Норма витрат ПКВ на одиницю продукту")]
        public double ComponentAmountPerProduct { get; set; }

        [DisplayName("Планова потреба ПКВ на тип продукту")]
        public double ComponentAmountPerPlan { get; set; }

        [DisplayName("Вартість ПКВ")]
        public double ProductComponentsCost { get; set; }
    }
}