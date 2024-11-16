namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SelectedCustomer = new System.Windows.Forms.Label();
            this.textBoxId2 = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemoveCustomer = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.Customers = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.AddPercentDiscountButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RemovePercentDiscountButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedCustomer
            // 
            this.SelectedCustomer.AutoSize = true;
            this.SelectedCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomer.Location = new System.Drawing.Point(3, 7);
            this.SelectedCustomer.Name = "SelectedCustomer";
            this.SelectedCustomer.Size = new System.Drawing.Size(162, 20);
            this.SelectedCustomer.TabIndex = 0;
            this.SelectedCustomer.Text = "Selected Customer";
            // 
            // textBoxId2
            // 
            this.textBoxId2.Location = new System.Drawing.Point(68, 42);
            this.textBoxId2.Name = "textBoxId2";
            this.textBoxId2.Size = new System.Drawing.Size(249, 20);
            this.textBoxId2.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(5, 45);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "ID:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(5, 80);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(57, 13);
            this.labelFullName.TabIndex = 5;
            this.labelFullName.Text = "Full Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IsPriorityCheckBox);
            this.panel2.Controls.Add(this.addressControl1);
            this.panel2.Controls.Add(this.textBoxFullName);
            this.panel2.Controls.Add(this.labelFullName);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.textBoxId2);
            this.panel2.Controls.Add(this.SelectedCustomer);
            this.panel2.Location = new System.Drawing.Point(296, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 332);
            this.panel2.TabIndex = 1;
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(68, 106);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(91, 20);
            this.IsPriorityCheckBox.TabIndex = 9;
            this.IsPriorityCheckBox.Text = "is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // addressControl1
            // 
            this.addressControl1.Location = new System.Drawing.Point(7, 133);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(555, 176);
            this.addressControl1.TabIndex = 8;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(68, 80);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(249, 20);
            this.textBoxFullName.TabIndex = 7;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRemoveCustomer);
            this.panel1.Controls.Add(this.buttonAddCustomer);
            this.panel1.Controls.Add(this.listBoxCustomer);
            this.panel1.Controls.Add(this.Customers);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 570);
            this.panel1.TabIndex = 0;
            // 
            // buttonRemoveCustomer
            // 
            this.buttonRemoveCustomer.Location = new System.Drawing.Point(96, 542);
            this.buttonRemoveCustomer.Name = "buttonRemoveCustomer";
            this.buttonRemoveCustomer.Size = new System.Drawing.Size(95, 28);
            this.buttonRemoveCustomer.TabIndex = 1;
            this.buttonRemoveCustomer.Text = "Remove";
            this.buttonRemoveCustomer.UseVisualStyleBackColor = true;
            this.buttonRemoveCustomer.Click += new System.EventHandler(this.buttonRemoveCustomer_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(3, 539);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(75, 28);
            this.buttonAddCustomer.TabIndex = 2;
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.Location = new System.Drawing.Point(3, 33);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(284, 498);
            this.listBoxCustomer.TabIndex = 1;
            this.listBoxCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCustomer_MouseClick);
            this.listBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomer_SelectedIndexChanged);
            // 
            // Customers
            // 
            this.Customers.AutoSize = true;
            this.Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Customers.Location = new System.Drawing.Point(3, 10);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(95, 20);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(301, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discounts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.Location = new System.Drawing.Point(303, 381);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(344, 134);
            this.DiscountsListBox.TabIndex = 3;
            // 
            // AddPercentDiscountButton
            // 
            this.AddPercentDiscountButton.Location = new System.Drawing.Point(653, 381);
            this.AddPercentDiscountButton.Name = "AddPercentDiscountButton";
            this.AddPercentDiscountButton.Size = new System.Drawing.Size(105, 39);
            this.AddPercentDiscountButton.TabIndex = 4;
            this.AddPercentDiscountButton.Text = "Add";
            this.AddPercentDiscountButton.UseVisualStyleBackColor = true;
            this.AddPercentDiscountButton.Click += new System.EventHandler(this.AddPercentDiscountButton_Click);
            // 
            // RemovePercentDiscountButton
            // 
            this.RemovePercentDiscountButton.Location = new System.Drawing.Point(653, 426);
            this.RemovePercentDiscountButton.Name = "RemovePercentDiscountButton";
            this.RemovePercentDiscountButton.Size = new System.Drawing.Size(105, 43);
            this.RemovePercentDiscountButton.TabIndex = 5;
            this.RemovePercentDiscountButton.Text = "Remove";
            this.RemovePercentDiscountButton.UseVisualStyleBackColor = true;
            this.RemovePercentDiscountButton.Click += new System.EventHandler(this.RemovePercentDiscountButton_Click);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemovePercentDiscountButton);
            this.Controls.Add(this.AddPercentDiscountButton);
            this.Controls.Add(this.DiscountsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(858, 573);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectedCustomer;
        private System.Windows.Forms.TextBox textBoxId2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRemoveCustomer;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.Label Customers;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.Button AddPercentDiscountButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button RemovePercentDiscountButton;
    }
}
