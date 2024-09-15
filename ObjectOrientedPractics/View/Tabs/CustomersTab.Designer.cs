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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customers = new System.Windows.Forms.Label();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonRemoveCustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectedCustomer = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRemoveCustomer);
            this.panel1.Controls.Add(this.buttonAddCustomer);
            this.panel1.Controls.Add(this.listBoxCustomer);
            this.panel1.Controls.Add(this.Customers);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 511);
            this.panel1.TabIndex = 0;
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
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.Location = new System.Drawing.Point(3, 33);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(314, 433);
            this.listBoxCustomer.TabIndex = 1;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(3, 472);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(90, 34);
            this.buttonAddCustomer.TabIndex = 2;
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonRemoveCustomer
            // 
            this.buttonRemoveCustomer.Location = new System.Drawing.Point(99, 472);
            this.buttonRemoveCustomer.Name = "buttonRemoveCustomer";
            this.buttonRemoveCustomer.Size = new System.Drawing.Size(99, 34);
            this.buttonRemoveCustomer.TabIndex = 1;
            this.buttonRemoveCustomer.Text = "Remove";
            this.buttonRemoveCustomer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelAdress);
            this.panel2.Controls.Add(this.labelFullName);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.textBoxAdress);
            this.panel2.Controls.Add(this.textBoxFullName);
            this.panel2.Controls.Add(this.textBoxId);
            this.panel2.Controls.Add(this.SelectedCustomer);
            this.panel2.Location = new System.Drawing.Point(323, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 463);
            this.panel2.TabIndex = 1;
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
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(68, 42);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(123, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(68, 77);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(232, 20);
            this.textBoxFullName.TabIndex = 2;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxAdress.Location = new System.Drawing.Point(68, 118);
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(232, 106);
            this.textBoxAdress.TabIndex = 3;
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
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(4, 125);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(48, 13);
            this.labelAdress.TabIndex = 6;
            this.labelAdress.Text = "Address:";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(629, 514);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Customers;
        private System.Windows.Forms.Button buttonRemoveCustomer;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label SelectedCustomer;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelId;
    }
}
