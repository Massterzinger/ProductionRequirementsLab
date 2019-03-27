using ProductionRequirements.Models;
using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using System.Windows.Forms;
using ProductionRequirements.ViewModels;

namespace ProductionRequirements
{
    public partial class Form1 : Form
    {
        List<ProductComponentRequirementsResult> componentsResultList;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitData()
        {
            RefreshProducts();
            componentsResultList= new List<ProductComponentRequirementsResult>();
            productComponentRequirementsResultBindingSource.DataSource = componentsResultList;
        }

        private void RefreshProducts()
        {
            List<Product> products;
            using (var context = new ProductionModel())
            {
                products = context.Products.ToList();
            }
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(products.ToArray());
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = componentsResultList.Sum(component => component.Cost).ToString();
            FillDataGrid();
            RefreshDataGrid();
        }

        private void FillDataGrid()
        {
            List<ProductComponentRequirementsResult> products;
            var selectedProductId = (comboBox1.SelectedItem as Product).Id;
            using (var context = new ProductionModel())
            {
                products = context.Products.Include("ProductToComponentRelations").Include("ProductToComponentRelations.Component")
                    .First(product => product.Id == selectedProductId)
                    .ProductToComponentRelations.Select(elem => new ProductComponentRequirementsResult {
                        Name = elem.Component.Name,
                        Amount = elem.ComponentRequiredAmount,
                        Cost = elem.ComponentRequiredAmount * (double)elem.Component.PricePerUnit,
                        UoM = elem.Component.UoM.ShortName
                    }).ToList();
            }
            componentsResultList.Clear();
            componentsResultList.AddRange(products);
        }

        private void RefreshDataGrid()
        {
            productComponentRequirementsResultBindingSource.ResetBindings(false);
        }

        private void yearPlansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WatchProductsForm().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
