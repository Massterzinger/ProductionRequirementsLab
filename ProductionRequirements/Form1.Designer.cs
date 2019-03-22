namespace ProductionRequirements
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглянутиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearPlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uoMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productComponentRequirementsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productComponentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productComponentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentUoMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productComponentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUoMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentAmountPerProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentAmountPerPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productComponentsCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productRequirementsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productComponentRequirementsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productRequirementsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productComponentIdDataGridViewTextBoxColumn,
            this.productComponentNameDataGridViewTextBoxColumn,
            this.componentUoMDataGridViewTextBoxColumn,
            this.productComponentPriceDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productCountDataGridViewTextBoxColumn,
            this.productUoMDataGridViewTextBoxColumn,
            this.componentAmountPerProductDataGridViewTextBoxColumn,
            this.componentAmountPerPlanDataGridViewTextBoxColumn,
            this.productComponentsCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productRequirementsResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(879, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Машинограма (ТЕП-32) планової потреби покупних комплектуючих виробів на рік:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(436, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.переглянутиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearPlanToolStripMenuItem});
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.додатиToolStripMenuItem.Text = "Додати";
            // 
            // yearPlanToolStripMenuItem
            // 
            this.yearPlanToolStripMenuItem.Name = "yearPlanToolStripMenuItem";
            this.yearPlanToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.yearPlanToolStripMenuItem.Text = "Річний план";
            this.yearPlanToolStripMenuItem.Click += new System.EventHandler(this.yearPlanToolStripMenuItem_Click);
            // 
            // переглянутиToolStripMenuItem
            // 
            this.переглянутиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearPlansToolStripMenuItem});
            this.переглянутиToolStripMenuItem.Name = "переглянутиToolStripMenuItem";
            this.переглянутиToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.переглянутиToolStripMenuItem.Text = "Переглянути";
            // 
            // yearPlansToolStripMenuItem
            // 
            this.yearPlansToolStripMenuItem.Name = "yearPlansToolStripMenuItem";
            this.yearPlansToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.yearPlansToolStripMenuItem.Text = "Річні плани";
            this.yearPlansToolStripMenuItem.Click += new System.EventHandler(this.yearPlansToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(891, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Потреба у комплектуючих виробах:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.uoMDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productComponentRequirementsResultBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(894, 48);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(403, 400);
            this.dataGridView2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1129, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сума:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1171, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 13);
            this.textBox1.TabIndex = 8;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Найменування ПКВ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uoMDataGridViewTextBoxColumn
            // 
            this.uoMDataGridViewTextBoxColumn.DataPropertyName = "UoM";
            this.uoMDataGridViewTextBoxColumn.HeaderText = "Одиниця виміру";
            this.uoMDataGridViewTextBoxColumn.Name = "uoMDataGridViewTextBoxColumn";
            this.uoMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Вартість";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productComponentRequirementsResultBindingSource
            // 
            this.productComponentRequirementsResultBindingSource.DataSource = typeof(ProductionRequirements.ViewModels.ProductComponentRequirementsResult);
            // 
            // productComponentIdDataGridViewTextBoxColumn
            // 
            this.productComponentIdDataGridViewTextBoxColumn.DataPropertyName = "ProductComponentId";
            this.productComponentIdDataGridViewTextBoxColumn.HeaderText = "Код ПКВ";
            this.productComponentIdDataGridViewTextBoxColumn.Name = "productComponentIdDataGridViewTextBoxColumn";
            this.productComponentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productComponentNameDataGridViewTextBoxColumn
            // 
            this.productComponentNameDataGridViewTextBoxColumn.DataPropertyName = "ProductComponentName";
            this.productComponentNameDataGridViewTextBoxColumn.HeaderText = "Назва ПКВ";
            this.productComponentNameDataGridViewTextBoxColumn.Name = "productComponentNameDataGridViewTextBoxColumn";
            this.productComponentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // componentUoMDataGridViewTextBoxColumn
            // 
            this.componentUoMDataGridViewTextBoxColumn.DataPropertyName = "ComponentUoM";
            this.componentUoMDataGridViewTextBoxColumn.HeaderText = "Одиниця виміру ПКВ";
            this.componentUoMDataGridViewTextBoxColumn.Name = "componentUoMDataGridViewTextBoxColumn";
            this.componentUoMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productComponentPriceDataGridViewTextBoxColumn
            // 
            this.productComponentPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductComponentPrice";
            this.productComponentPriceDataGridViewTextBoxColumn.HeaderText = "Ціна за одиницю ПКВ";
            this.productComponentPriceDataGridViewTextBoxColumn.Name = "productComponentPriceDataGridViewTextBoxColumn";
            this.productComponentPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Код Продукту";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Назва Продукту";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productCountDataGridViewTextBoxColumn
            // 
            this.productCountDataGridViewTextBoxColumn.DataPropertyName = "ProductCount";
            this.productCountDataGridViewTextBoxColumn.HeaderText = "План виробництва продукту";
            this.productCountDataGridViewTextBoxColumn.Name = "productCountDataGridViewTextBoxColumn";
            this.productCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productUoMDataGridViewTextBoxColumn
            // 
            this.productUoMDataGridViewTextBoxColumn.DataPropertyName = "ProductUoM";
            this.productUoMDataGridViewTextBoxColumn.HeaderText = "Одиниця виміру продукту";
            this.productUoMDataGridViewTextBoxColumn.Name = "productUoMDataGridViewTextBoxColumn";
            this.productUoMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // componentAmountPerProductDataGridViewTextBoxColumn
            // 
            this.componentAmountPerProductDataGridViewTextBoxColumn.DataPropertyName = "ComponentAmountPerProduct";
            this.componentAmountPerProductDataGridViewTextBoxColumn.HeaderText = "Норма витрат ПКВ на одиницю продукту";
            this.componentAmountPerProductDataGridViewTextBoxColumn.Name = "componentAmountPerProductDataGridViewTextBoxColumn";
            this.componentAmountPerProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // componentAmountPerPlanDataGridViewTextBoxColumn
            // 
            this.componentAmountPerPlanDataGridViewTextBoxColumn.DataPropertyName = "ComponentAmountPerPlan";
            this.componentAmountPerPlanDataGridViewTextBoxColumn.HeaderText = "Планова потреба ПКВ на тип продукту";
            this.componentAmountPerPlanDataGridViewTextBoxColumn.Name = "componentAmountPerPlanDataGridViewTextBoxColumn";
            this.componentAmountPerPlanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productComponentsCostDataGridViewTextBoxColumn
            // 
            this.productComponentsCostDataGridViewTextBoxColumn.DataPropertyName = "ProductComponentsCost";
            this.productComponentsCostDataGridViewTextBoxColumn.HeaderText = "Вартість ПКВ";
            this.productComponentsCostDataGridViewTextBoxColumn.Name = "productComponentsCostDataGridViewTextBoxColumn";
            this.productComponentsCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productRequirementsResultBindingSource
            // 
            this.productRequirementsResultBindingSource.DataSource = typeof(ProductionRequirements.ViewModels.ProductRequirementsResult);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 459);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ТЕП-32";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productComponentRequirementsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productRequirementsResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переглянутиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearPlansToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productComponentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productComponentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentUoMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productComponentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUoMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentAmountPerProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentAmountPerPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productComponentsCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productRequirementsResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uoMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productComponentRequirementsResultBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

