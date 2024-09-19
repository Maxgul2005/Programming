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
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemoveCustomer = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.Customers = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            // textBoxAdress
            // 
            this.textBoxAdress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxAdress.Location = new System.Drawing.Point(68, 118);
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(249, 246);
            this.textBoxAdress.TabIndex = 3;
            this.textBoxAdress.TextChanged += new System.EventHandler(this.textBoxAdress_TextChanged);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxFullName);
            this.panel2.Controls.Add(this.labelAdress);
            this.panel2.Controls.Add(this.labelFullName);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.textBoxAdress);
            this.panel2.Controls.Add(this.textBoxId2);
            this.panel2.Controls.Add(this.SelectedCustomer);
            this.panel2.Location = new System.Drawing.Point(296, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 458);
            this.panel2.TabIndex = 1;
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
            this.panel1.Size = new System.Drawing.Size(290, 458);
            this.panel1.TabIndex = 0;
            // 
            // buttonRemoveCustomer
            // 
            this.buttonRemoveCustomer.Location = new System.Drawing.Point(84, 420);
            this.buttonRemoveCustomer.Name = "buttonRemoveCustomer";
            this.buttonRemoveCustomer.Size = new System.Drawing.Size(95, 28);
            this.buttonRemoveCustomer.TabIndex = 1;
            this.buttonRemoveCustomer.Text = "Remove";
            this.buttonRemoveCustomer.UseVisualStyleBackColor = true;
            this.buttonRemoveCustomer.Click += new System.EventHandler(this.buttonRemoveCustomer_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(3, 420);
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
            this.listBoxCustomer.Size = new System.Drawing.Size(284, 381);
            this.listBoxCustomer.TabIndex = 1;
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
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(629, 459);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SelectedCustomer;
        private System.Windows.Forms.TextBox textBoxId2;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRemoveCustomer;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.Label Customers;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
