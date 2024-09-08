namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.GroupBoxItems = new System.Windows.Forms.GroupBox();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddItemsButton = new System.Windows.Forms.Button();
            this.RemoveItemsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelItemSelected = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.LabelItemsCost = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelItemDiscription = new System.Windows.Forms.Label();
            this.GroupBoxItems.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxItems
            // 
            this.GroupBoxItems.Controls.Add(this.RemoveItemsButton);
            this.GroupBoxItems.Controls.Add(this.AddItemsButton);
            this.GroupBoxItems.Controls.Add(this.ItemsListBox);
            this.GroupBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxItems.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxItems.Name = "GroupBoxItems";
            this.GroupBoxItems.Size = new System.Drawing.Size(290, 464);
            this.GroupBoxItems.TabIndex = 0;
            this.GroupBoxItems.TabStop = false;
            this.GroupBoxItems.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 25);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(278, 381);
            this.ItemsListBox.TabIndex = 0;
            // 
            // AddItemsButton
            // 
            this.AddItemsButton.Location = new System.Drawing.Point(16, 423);
            this.AddItemsButton.Name = "AddItemsButton";
            this.AddItemsButton.Size = new System.Drawing.Size(75, 28);
            this.AddItemsButton.TabIndex = 1;
            this.AddItemsButton.Text = "Add";
            this.AddItemsButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemsButton
            // 
            this.RemoveItemsButton.Location = new System.Drawing.Point(97, 423);
            this.RemoveItemsButton.Name = "RemoveItemsButton";
            this.RemoveItemsButton.Size = new System.Drawing.Size(95, 28);
            this.RemoveItemsButton.TabIndex = 2;
            this.RemoveItemsButton.Text = "Remove";
            this.RemoveItemsButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelItemDiscription);
            this.panel1.Controls.Add(this.labelItemName);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.LabelItemsCost);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelItemSelected);
            this.panel1.Location = new System.Drawing.Point(299, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 456);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(750, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // labelItemSelected
            // 
            this.labelItemSelected.AutoSize = true;
            this.labelItemSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItemSelected.Location = new System.Drawing.Point(14, 4);
            this.labelItemSelected.Name = "labelItemSelected";
            this.labelItemSelected.Size = new System.Drawing.Size(121, 20);
            this.labelItemSelected.TabIndex = 0;
            this.labelItemSelected.Text = "Selected Item";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 2;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(18, 43);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 16);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID:";
            // 
            // LabelItemsCost
            // 
            this.LabelItemsCost.AutoSize = true;
            this.LabelItemsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelItemsCost.Location = new System.Drawing.Point(18, 67);
            this.LabelItemsCost.Name = "LabelItemsCost";
            this.LabelItemsCost.Size = new System.Drawing.Size(37, 16);
            this.LabelItemsCost.TabIndex = 4;
            this.LabelItemsCost.Text = "Cost:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 117);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(360, 111);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(21, 268);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(360, 71);
            this.textBox4.TabIndex = 6;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItemName.Location = new System.Drawing.Point(18, 101);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(47, 16);
            this.labelItemName.TabIndex = 7;
            this.labelItemName.Text = "Name:";
            // 
            // labelItemDiscription
            // 
            this.labelItemDiscription.AutoSize = true;
            this.labelItemDiscription.Location = new System.Drawing.Point(21, 249);
            this.labelItemDiscription.Name = "labelItemDiscription";
            this.labelItemDiscription.Size = new System.Drawing.Size(63, 13);
            this.labelItemDiscription.TabIndex = 8;
            this.labelItemDiscription.Text = "Description:";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBoxItems);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(686, 471);
            this.GroupBoxItems.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxItems;
        private System.Windows.Forms.Button RemoveItemsButton;
        private System.Windows.Forms.Button AddItemsButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelItemSelected;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LabelItemsCost;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelItemDiscription;
        private System.Windows.Forms.Label labelItemName;
    }
}
