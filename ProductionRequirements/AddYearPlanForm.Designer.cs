namespace ProductionRequirements
{
    partial class AddYearPlanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.addedPlans = new System.Windows.Forms.DataGridView();
            this.savePlanButton = new System.Windows.Forms.Button();
            this.addProductToPlanButton = new System.Windows.Forms.Button();
            this.removeProductFromPlanButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.availablePlans = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.availablePlansSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedPlansSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePlansSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedPlansSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рік";
            // 
            // addedPlans
            // 
            this.addedPlans.AllowUserToAddRows = false;
            this.addedPlans.AllowUserToDeleteRows = false;
            this.addedPlans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addedPlans.AutoGenerateColumns = false;
            this.addedPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addedPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn1,
            this.productAmountDataGridViewTextBoxColumn1,
            this.uoMDataGridViewTextBoxColumn1});
            this.addedPlans.DataSource = this.addedPlansSource;
            this.addedPlans.Location = new System.Drawing.Point(12, 316);
            this.addedPlans.Name = "addedPlans";
            this.addedPlans.ReadOnly = true;
            this.addedPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addedPlans.Size = new System.Drawing.Size(536, 184);
            this.addedPlans.TabIndex = 2;
            // 
            // savePlanButton
            // 
            this.savePlanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savePlanButton.Location = new System.Drawing.Point(474, 508);
            this.savePlanButton.Name = "savePlanButton";
            this.savePlanButton.Size = new System.Drawing.Size(75, 23);
            this.savePlanButton.TabIndex = 3;
            this.savePlanButton.Text = "Зберегти";
            this.savePlanButton.UseVisualStyleBackColor = true;
            this.savePlanButton.Click += new System.EventHandler(this.savePlanButton_Click);
            // 
            // addProductToPlanButton
            // 
            this.addProductToPlanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductToPlanButton.Location = new System.Drawing.Point(357, 26);
            this.addProductToPlanButton.Name = "addProductToPlanButton";
            this.addProductToPlanButton.Size = new System.Drawing.Size(192, 23);
            this.addProductToPlanButton.TabIndex = 4;
            this.addProductToPlanButton.Text = "Додати план продукту";
            this.addProductToPlanButton.UseVisualStyleBackColor = true;
            this.addProductToPlanButton.Click += new System.EventHandler(this.addProductToPlanButton_Click);
            // 
            // removeProductFromPlanButton
            // 
            this.removeProductFromPlanButton.Location = new System.Drawing.Point(138, 26);
            this.removeProductFromPlanButton.Name = "removeProductFromPlanButton";
            this.removeProductFromPlanButton.Size = new System.Drawing.Size(213, 23);
            this.removeProductFromPlanButton.TabIndex = 5;
            this.removeProductFromPlanButton.Text = "Видалити доданий план продукту";
            this.removeProductFromPlanButton.UseVisualStyleBackColor = true;
            this.removeProductFromPlanButton.Click += new System.EventHandler(this.removeProductFromPlanButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Одиниць";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(371, 61);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            -1943132160,
            209,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // availablePlans
            // 
            this.availablePlans.AllowUserToAddRows = false;
            this.availablePlans.AllowUserToDeleteRows = false;
            this.availablePlans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePlans.AutoGenerateColumns = false;
            this.availablePlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availablePlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availablePlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn,
            this.uoMDataGridViewTextBoxColumn});
            this.availablePlans.DataSource = this.availablePlansSource;
            this.availablePlans.Location = new System.Drawing.Point(12, 106);
            this.availablePlans.MultiSelect = false;
            this.availablePlans.Name = "availablePlans";
            this.availablePlans.ReadOnly = true;
            this.availablePlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availablePlans.Size = new System.Drawing.Size(536, 184);
            this.availablePlans.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Наявні плани виробництва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Додані плани виробництва";
            // 
            // yearProductsPlanViewModelBindingSource
            // 
            this.availablePlansSource.DataSource = typeof(ProductionRequirements.ViewModels.YearProductsPlanViewModel);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Найменування продукту";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productAmountDataGridViewTextBoxColumn
            // 
            this.productAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            this.productAmountDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.productAmountDataGridViewTextBoxColumn.Name = "productAmountDataGridViewTextBoxColumn";
            this.productAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uoMDataGridViewTextBoxColumn
            // 
            this.uoMDataGridViewTextBoxColumn.DataPropertyName = "UoM";
            this.uoMDataGridViewTextBoxColumn.HeaderText = "Одиниця виміру";
            this.uoMDataGridViewTextBoxColumn.Name = "uoMDataGridViewTextBoxColumn";
            this.uoMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearProductsPlanViewModelBindingSource1
            // 
            this.addedPlansSource.DataSource = typeof(ProductionRequirements.ViewModels.YearProductsPlanViewModel);
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn1.HeaderText = "Найменування продукту";
            this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            this.productNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productAmountDataGridViewTextBoxColumn1
            // 
            this.productAmountDataGridViewTextBoxColumn1.DataPropertyName = "ProductAmount";
            this.productAmountDataGridViewTextBoxColumn1.HeaderText = "Кількість";
            this.productAmountDataGridViewTextBoxColumn1.Name = "productAmountDataGridViewTextBoxColumn1";
            this.productAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // uoMDataGridViewTextBoxColumn1
            // 
            this.uoMDataGridViewTextBoxColumn1.DataPropertyName = "UoM";
            this.uoMDataGridViewTextBoxColumn1.HeaderText = "Одиниця виміру";
            this.uoMDataGridViewTextBoxColumn1.Name = "uoMDataGridViewTextBoxColumn1";
            this.uoMDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // AddYearPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.availablePlans);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.removeProductFromPlanButton);
            this.Controls.Add(this.addProductToPlanButton);
            this.Controls.Add(this.savePlanButton);
            this.Controls.Add(this.addedPlans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "AddYearPlanForm";
            this.Text = "Створити річний план";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePlansSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedPlansSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView addedPlans;
        private System.Windows.Forms.Button savePlanButton;
        private System.Windows.Forms.Button addProductToPlanButton;
        private System.Windows.Forms.Button removeProductFromPlanButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridView availablePlans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource addedPlansSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoMDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource availablePlansSource;
    }
}