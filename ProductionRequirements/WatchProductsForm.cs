using ProductionRequirements.Models;
using ProductionRequirements.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionRequirements
{
    public partial class WatchProductsForm : Form
    {
        public WatchProductsForm()
        {
            InitializeComponent();
            RefreshYears();
        }

        private void RefreshYears()
        {
            List<ProductViewModel> planViewModels;
            using (var context = new ProductionModel())
            {
                planViewModels = context.Products.Include("Product").Include("Product.UoM")
                    .Select(elem => new ProductViewModel { ProductName = elem.Name, UoM = elem.UoM.ShortName }).ToList();
            }
            dataGridView1.DataSource = planViewModels;
        }
    }
}
