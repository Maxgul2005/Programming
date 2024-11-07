namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatusOrder = new System.Windows.Forms.ComboBox();
            this.textBoxCreatOrder = new System.Windows.Forms.TextBox();
            this.textBoxIdOrder = new System.Windows.Forms.TextBox();
            this.OrderItems = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RemoveItemOrder = new System.Windows.Forms.Button();
            this.ClearOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPrioretyOrders = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxPrioretyOrders);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.addressControl1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxStatusOrder);
            this.groupBox2.Controls.Add(this.textBoxCreatOrder);
            this.groupBox2.Controls.Add(this.textBoxIdOrder);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 478);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Created:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // comboBoxStatusOrder
            // 
            this.comboBoxStatusOrder.FormattingEnabled = true;
            this.comboBoxStatusOrder.Location = new System.Drawing.Point(90, 135);
            this.comboBoxStatusOrder.Name = "comboBoxStatusOrder";
            this.comboBoxStatusOrder.Size = new System.Drawing.Size(109, 28);
            this.comboBoxStatusOrder.TabIndex = 3;
            // 
            // textBoxCreatOrder
            // 
            this.textBoxCreatOrder.Location = new System.Drawing.Point(90, 84);
            this.textBoxCreatOrder.Name = "textBoxCreatOrder";
            this.textBoxCreatOrder.ReadOnly = true;
            this.textBoxCreatOrder.Size = new System.Drawing.Size(109, 26);
            this.textBoxCreatOrder.TabIndex = 2;
            // 
            // textBoxIdOrder
            // 
            this.textBoxIdOrder.Location = new System.Drawing.Point(90, 38);
            this.textBoxIdOrder.Name = "textBoxIdOrder";
            this.textBoxIdOrder.ReadOnly = true;
            this.textBoxIdOrder.Size = new System.Drawing.Size(109, 26);
            this.textBoxIdOrder.TabIndex = 0;
            // 
            // OrderItems
            // 
            this.OrderItems.FormattingEnabled = true;
            this.OrderItems.Location = new System.Drawing.Point(5, 484);
            this.OrderItems.Name = "OrderItems";
            this.OrderItems.Size = new System.Drawing.Size(837, 186);
            this.OrderItems.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(766, 673);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(758, 693);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "4 999, 90";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RemoveItemOrder
            // 
            this.RemoveItemOrder.Location = new System.Drawing.Point(152, 690);
            this.RemoveItemOrder.Name = "RemoveItemOrder";
            this.RemoveItemOrder.Size = new System.Drawing.Size(101, 23);
            this.RemoveItemOrder.TabIndex = 8;
            this.RemoveItemOrder.Text = "Remove Item";
            this.RemoveItemOrder.UseVisualStyleBackColor = true;
            // 
            // ClearOrder
            // 
            this.ClearOrder.Location = new System.Drawing.Point(741, 716);
            this.ClearOrder.Name = "ClearOrder";
            this.ClearOrder.Size = new System.Drawing.Size(101, 23);
            this.ClearOrder.TabIndex = 9;
            this.ClearOrder.Text = "Clear Order";
            this.ClearOrder.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Priority Options";
            // 
            // comboBoxPrioretyOrders
            // 
            this.comboBoxPrioretyOrders.FormattingEnabled = true;
            this.comboBoxPrioretyOrders.Location = new System.Drawing.Point(607, 45);
            this.comboBoxPrioretyOrders.Name = "comboBoxPrioretyOrders";
            this.comboBoxPrioretyOrders.Size = new System.Drawing.Size(127, 28);
            this.comboBoxPrioretyOrders.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Delivery Time:";
            // 
            // addressControl1
            // 
            this.addressControl1.Location = new System.Drawing.Point(8, 174);
            this.addressControl1.Margin = new System.Windows.Forms.Padding(8);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(837, 549);
            this.addressControl1.TabIndex = 7;
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClearOrder);
            this.Controls.Add(this.RemoveItemOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderItems);
            this.Controls.Add(this.groupBox2);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(845, 772);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatusOrder;
        private System.Windows.Forms.TextBox textBoxCreatOrder;
        private System.Windows.Forms.TextBox textBoxIdOrder;
        private System.Windows.Forms.ListBox OrderItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button RemoveItemOrder;
        private System.Windows.Forms.Button ClearOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPrioretyOrders;
        private System.Windows.Forms.Label label6;
    }
}
