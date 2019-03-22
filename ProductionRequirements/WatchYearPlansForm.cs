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
    public partial class WatchYearPlansForm : Form
    {
        public WatchYearPlansForm()
        {
            InitializeComponent();
            RefreshYears();
        }

        private void RefreshYears()
        {
            List<string> years;
            using (var context = new ProductionModel())
            {
                years = context.ProductionPlans.GroupBy(elem => elem.PlanningPeriod).Select(elem => elem.Key).ToList();
            }
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(years.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<YearProductsPlanViewModel> planViewModels;
            using (var context = new ProductionModel())
            {
                planViewModels = context.ProductionPlans.Include("Product").Include("Product.UoM")
                    .Where(plan => plan.PlanningPeriod == comboBox1.Text)
                    .Select(elem => new YearProductsPlanViewModel {ProductName = elem.Product.Name, ProductAmount = elem.PlannedAmount, UoM = elem.Product.UoM.ShortName }).ToList();
            }
            dataGridView1.DataSource = planViewModels;
        }
    }
}
