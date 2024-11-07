namespace ObjectOrientedPractics
{
    partial class MainForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.priorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cartsTabs1 = new ObjectOrientedPractics.View.Tabs.CartsTabs();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.tabControlI = new System.Windows.Forms.TabControl();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageItems.SuspendLayout();
            this.tabControlI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 509);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.priorityOrdersTab1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1225, 790);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Priorety Orders";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            this.priorityOrdersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityOrdersTab1.Location = new System.Drawing.Point(3, 3);
            this.priorityOrdersTab1.Name = "priorityOrdersTab1";
            this.priorityOrdersTab1.Size = new System.Drawing.Size(1219, 784);
            this.priorityOrdersTab1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ordersTab1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1225, 790);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Orders";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            this.ordersTab1.Customers = null;
            this.ordersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab1.Location = new System.Drawing.Point(3, 3);
            this.ordersTab1.Name = "ordersTab1";
            this.ordersTab1.Size = new System.Drawing.Size(1219, 784);
            this.ordersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cartsTabs1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1225, 790);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Carts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartsTabs1
            // 
            this.cartsTabs1.Customers = null;
            this.cartsTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTabs1.Items = null;
            this.cartsTabs1.Location = new System.Drawing.Point(3, 3);
            this.cartsTabs1.Name = "cartsTabs1";
            this.cartsTabs1.Size = new System.Drawing.Size(1219, 784);
            this.cartsTabs1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customersTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1247, 790);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(0, 0);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(1247, 790);
            this.customersTab1.TabIndex = 0;
            // 
            // tabPageItems
            // 
            this.tabPageItems.Controls.Add(this.itemsTab1);
            this.tabPageItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(1247, 790);
            this.tabPageItems.TabIndex = 0;
            this.tabPageItems.Text = "Items";
            this.tabPageItems.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(1241, 784);
            this.itemsTab1.TabIndex = 0;
            // 
            // tabControlI
            // 
            this.tabControlI.Controls.Add(this.tabPageItems);
            this.tabControlI.Controls.Add(this.tabPage1);
            this.tabControlI.Controls.Add(this.tabPage3);
            this.tabControlI.Controls.Add(this.tabPage4);
            this.tabControlI.Controls.Add(this.tabPage5);
            this.tabControlI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlI.Location = new System.Drawing.Point(0, 0);
            this.tabControlI.Name = "tabControlI";
            this.tabControlI.SelectedIndex = 0;
            this.tabControlI.Size = new System.Drawing.Size(1233, 816);
            this.tabControlI.TabIndex = 0;
            this.tabControlI.SelectedIndexChanged += new System.EventHandler(this.tabControlI_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 816);
            this.Controls.Add(this.tabControlI);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageItems.ResumeLayout(false);
            this.tabControlI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage5;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab1;
        private System.Windows.Forms.TabPage tabPage4;
        private View.Tabs.OrdersTab ordersTab1;
        private System.Windows.Forms.TabPage tabPage3;
        private View.Tabs.CartsTabs cartsTabs1;
        private System.Windows.Forms.TabPage tabPage1;
        private View.Tabs.CustomersTab customersTab1;
        private System.Windows.Forms.TabPage tabPageItems;
        private View.Tabs.ItemsTab itemsTab1;
        private System.Windows.Forms.TabControl tabControlI;
    }
}

