using ProductionRequirements.Models;
using ProductionRequirements.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionRequirements
{
    public partial class AddYearPlanForm : Form
    {
        public List<YearProductsPlanViewModel> addedProductsPlans;
        public List<YearProductsPlanViewModel> availableProductsPlans;

        private List<Product> products;
        private List<YearProductsPlanViewModel> dummy = new List<YearProductsPlanViewModel> { new YearProductsPlanViewModel { ProductName = " ", ProductAmount = 0, UoM = " " } };

        private BindingSource avalable;

        public AddYearPlanForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            addedProductsPlans = new List<YearProductsPlanViewModel>();
            availableProductsPlans = new List<YearProductsPlanViewModel>();

            availablePlansSource.DataSource = availableProductsPlans;
            addedPlansSource.DataSource = addedProductsPlans;

            avalable = new BindingSource();
            numericUpDown1.Value = DateTime.Now.Year;
            numericUpDown1.Maximum = DateTime.Now.Year + 100;

            using (var context = new ProductionModel())
            {
                products = context.Products.Include(p => p.UoM).ToList();
            }
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(products.Select(product => product.Name).ToArray());
        }

        private void addProductToPlanButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || numericUpDown2.Value <= 0)
            {
                MessageBox.Show("Невірні дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addedProductsPlans.Any(planVm => planVm.ProductName == comboBox1.Text) || availableProductsPlans.Any(planVm => planVm.ProductName == comboBox1.Text))
            {
                MessageBox.Show("Такий продукт вже є у плані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            addedProductsPlans.Add(new YearProductsPlanViewModel {
                ProductName = comboBox1.Text,
                ProductAmount = (double)numericUpDown2.Value,
                UoM = products.First(p => p.Name == comboBox1.Text).UoM.ShortName
            });

            RefreshDataGrid();
        }

        private void removeProductFromPlanButton_Click(object sender, EventArgs e)
        {
            if (addedPlans.SelectedRows.Count != 1)
            {
                return;
            }
            var selectedName = addedPlans.SelectedRows[0].Cells[0].Value as string;
            addedProductsPlans.RemoveAt(addedProductsPlans.FindIndex(planVm => planVm.ProductName == selectedName));

            RefreshDataGrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = products.First(p => p.Name == comboBox1.Text).UoM.ShortName;
        }

        private void RefreshDataGrid()
        {
            availablePlansSource.ResetBindings(false);
            addedPlansSource.ResetBindings(false);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            using (var context = new ProductionModel())
            {
                var selectedPeriod = numericUpDown1.Value.ToString();
                var plans = context.ProductionPlans.Include("Product").Where(plan => plan.PlanningPeriod == selectedPeriod)
                    .Select(plan => new YearProductsPlanViewModel { ProductName = plan.Product.Name, ProductAmount = plan.PlannedAmount, UoM = plan.Product.UoM.ShortName});

                availableProductsPlans.Clear();
                availableProductsPlans.AddRange(plans);
            }

            addedProductsPlans.Clear();
            RefreshDataGrid();
        }

        private void savePlanButton_Click(object sender, EventArgs e)
        {
            var productPlans = addedProductsPlans.Select(planVm => new ProductionPlan
            {
                Id = Guid.NewGuid(),
                ProductId = products.First(product => product.Name == planVm.ProductName).Id,
                PlannedAmount = planVm.ProductAmount,
                PlanningPeriod = numericUpDown1.Value.ToString(),
            });
            using (var context = new ProductionModel())
            {
                var plans = context.ProductionPlans;
                plans.AddRange(productPlans);
                context.SaveChanges();
            }

            this.Close();
        }
    }
}
