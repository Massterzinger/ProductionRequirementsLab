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
        List<ProductRequirementsResult> resultList;
        List<ProductComponentRequirementsResult> componentsResultList;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitData()
        {
            RefreshYears();
            resultList = new List<ProductRequirementsResult>();
            componentsResultList= new List<ProductComponentRequirementsResult>();
            productRequirementsResultBindingSource.DataSource = resultList;
            productComponentRequirementsResultBindingSource.DataSource = componentsResultList;
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

        private void yearPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addPlanForm = new AddYearPlanForm();
            addPlanForm.ShowDialog();
            RefreshYears();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            FillPlanningResult(comboBox1.Text, resultList);
            FillPlanningComponentRequirementsResult(resultList, componentsResultList);
            textBox1.Text = componentsResultList.Sum(component => component.Cost).ToString();

            RefreshDataGrid();
        }

        private void FillPlanningResult(string planningYear, List<ProductRequirementsResult> resultList)
        {
            List<ProductRequirementsResult> planinngResult = null;
            resultList.Clear();
            using (var context = new ProductionModel())
            {
                planinngResult = context.ProductionPlans.Include(plan => plan.Product.ProductToComponentRelations)
                    .Where(plan => plan.PlanningPeriod == planningYear)
                    .SelectMany(elem => elem.Product.ProductToComponentRelations, (prod, rela) => new ProductRequirementsResult {
                        //Year = prod.PlanningPeriod,
                        ProductId = prod.ProductId,
                        ProductName = prod.Product.Name,
                        ProductComponentId = rela.ProductComponentId,
                        ProductComponentName = rela.Component.Name,
                        ProductUoM = prod.Product.UoM.ShortName,
                        ComponentUoM = rela.Component.UoM.ShortName,
                        ProductCount = prod.PlannedAmount,
                        ComponentAmountPerProduct = rela.ComponentRequiredAmount,
                        ComponentAmountPerPlan = rela.ComponentRequiredAmount * prod.PlannedAmount,
                        ProductComponentPrice = rela.Component.PricePerUnit,
                        ProductComponentsCost = (double)rela.Component.PricePerUnit * rela.ComponentRequiredAmount * prod.PlannedAmount
                    }).OrderBy(elem => elem.ProductComponentName).ToList();
            }
            resultList.AddRange(planinngResult);
        }

        private void FillPlanningComponentRequirementsResult(List<ProductRequirementsResult> sourcePlanningResult, List<ProductComponentRequirementsResult> targetComponentRequirementsResult)
        {
            var componentResult = sourcePlanningResult.GroupBy(plan => plan.ProductComponentName).Select(elem => new ProductComponentRequirementsResult {
                Name = elem.Key,
                UoM = elem.FirstOrDefault().ComponentUoM,
                Amount = elem.Sum(a => a.ComponentAmountPerPlan),
                Cost = elem.Sum(a => a.ProductComponentsCost)
            }).ToList();

            targetComponentRequirementsResult.Clear();
            targetComponentRequirementsResult.AddRange(componentResult);
        }

        private void RefreshDataGrid()
        {
            productComponentRequirementsResultBindingSource.ResetBindings(false);
            productRequirementsResultBindingSource.ResetBindings(false);
        }

        private void yearPlansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WatchYearPlansForm().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
