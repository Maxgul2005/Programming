namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedPanel = new System.Windows.Forms.GroupBox();
            this.PriorityOrdersPanel = new System.Windows.Forms.Panel();
            this.DeliveryTimeRangeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.OrderCreatedTextBox = new System.Windows.Forms.TextBox();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SelectedPanel.SuspendLayout();
            this.PriorityOrdersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrdersDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 796);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Location = new System.Drawing.Point(6, 25);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDataGridView.Size = new System.Drawing.Size(373, 742);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.CurrentCellChanged += new System.EventHandler(this.OrdersDataGridView_CurrentCellChanged);
            // 
            // SelectedPanel
            // 
            this.SelectedPanel.Controls.Add(this.PriorityOrdersPanel);
            this.SelectedPanel.Controls.Add(this.addressControl1);
            this.SelectedPanel.Controls.Add(this.label3);
            this.SelectedPanel.Controls.Add(this.label2);
            this.SelectedPanel.Controls.Add(this.label1);
            this.SelectedPanel.Controls.Add(this.OrderStatusComboBox);
            this.SelectedPanel.Controls.Add(this.OrderCreatedTextBox);
            this.SelectedPanel.Controls.Add(this.OrderIdTextBox);
            this.SelectedPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedPanel.Location = new System.Drawing.Point(396, 3);
            this.SelectedPanel.Name = "SelectedPanel";
            this.SelectedPanel.Size = new System.Drawing.Size(822, 461);
            this.SelectedPanel.TabIndex = 1;
            this.SelectedPanel.TabStop = false;
            this.SelectedPanel.Text = "Selected Order";
            // 
            // PriorityOrdersPanel
            // 
            this.PriorityOrdersPanel.Controls.Add(this.DeliveryTimeRangeComboBox);
            this.PriorityOrdersPanel.Controls.Add(this.label7);
            this.PriorityOrdersPanel.Controls.Add(this.label6);
            this.PriorityOrdersPanel.Location = new System.Drawing.Point(226, 34);
            this.PriorityOrdersPanel.Name = "PriorityOrdersPanel";
            this.PriorityOrdersPanel.Size = new System.Drawing.Size(273, 72);
            this.PriorityOrdersPanel.TabIndex = 8;
            this.PriorityOrdersPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PriorityOrdersPanel_Paint);
            // 
            // DeliveryTimeRangeComboBox
            // 
            this.DeliveryTimeRangeComboBox.FormattingEnabled = true;
            this.DeliveryTimeRangeComboBox.Location = new System.Drawing.Point(111, 29);
            this.DeliveryTimeRangeComboBox.Name = "DeliveryTimeRangeComboBox";
            this.DeliveryTimeRangeComboBox.Size = new System.Drawing.Size(159, 28);
            this.DeliveryTimeRangeComboBox.TabIndex = 2;
            this.DeliveryTimeRangeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeRangeComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Delivery Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Priority Options:";
            // 
            // addressControl1
            // 
            this.addressControl1.Location = new System.Drawing.Point(7, 171);
            this.addressControl1.Margin = new System.Windows.Forms.Padding(5);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(817, 302);
            this.addressControl1.TabIndex = 7;
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
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Location = new System.Drawing.Point(90, 135);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(109, 28);
            this.OrderStatusComboBox.TabIndex = 3;
            this.OrderStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderStatusComboBox_SelectedIndexChanged);
            // 
            // OrderCreatedTextBox
            // 
            this.OrderCreatedTextBox.Location = new System.Drawing.Point(90, 84);
            this.OrderCreatedTextBox.Name = "OrderCreatedTextBox";
            this.OrderCreatedTextBox.Size = new System.Drawing.Size(109, 26);
            this.OrderCreatedTextBox.TabIndex = 2;
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Location = new System.Drawing.Point(90, 38);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.Size = new System.Drawing.Size(109, 26);
            this.OrderIdTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(396, 498);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(803, 173);
            this.OrderItemsListBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(396, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(399, 704);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(34, 20);
            this.AmountLabel.TabIndex = 5;
            this.AmountLabel.Text = "0,0";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T.Location = new System.Drawing.Point(494, 684);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(54, 20);
            this.T.TabIndex = 6;
            this.T.Text = "Total:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLabel.Location = new System.Drawing.Point(494, 704);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 20);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "0,0";
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.T);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.SelectedPanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1222, 810);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.SelectedPanel.ResumeLayout(false);
            this.SelectedPanel.PerformLayout();
            this.PriorityOrdersPanel.ResumeLayout(false);
            this.PriorityOrdersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.GroupBox SelectedPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.TextBox OrderCreatedTextBox;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Panel PriorityOrdersPanel;
        private System.Windows.Forms.ComboBox DeliveryTimeRangeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label TotalLabel;
    }
}
