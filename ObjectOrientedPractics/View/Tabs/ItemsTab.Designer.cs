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
            this.RemoveItemsButton = new System.Windows.Forms.Button();
            this.AddItemsButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelItemDiscription = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.textBoxDestr = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.LabelItemsCost = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxCostItem = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelItemSelected = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBoxItems.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxItems
            // 
            this.GroupBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            // RemoveItemsButton
            // 
            this.RemoveItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemsButton.Location = new System.Drawing.Point(97, 423);
            this.RemoveItemsButton.Name = "RemoveItemsButton";
            this.RemoveItemsButton.Size = new System.Drawing.Size(95, 28);
            this.RemoveItemsButton.TabIndex = 2;
            this.RemoveItemsButton.Text = "Remove";
            this.RemoveItemsButton.UseVisualStyleBackColor = true;
            this.RemoveItemsButton.Click += new System.EventHandler(this.RemoveItemsButton_Click);
            // 
            // AddItemsButton
            // 
            this.AddItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemsButton.Location = new System.Drawing.Point(16, 423);
            this.AddItemsButton.Name = "AddItemsButton";
            this.AddItemsButton.Size = new System.Drawing.Size(75, 28);
            this.AddItemsButton.TabIndex = 1;
            this.AddItemsButton.Text = "Add";
            this.AddItemsButton.UseVisualStyleBackColor = true;
            this.AddItemsButton.Click += new System.EventHandler(this.AddItemsButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 25);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(278, 381);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ItemsListBox_MouseClick);
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ComboBoxCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelItemDiscription);
            this.panel1.Controls.Add(this.labelItemName);
            this.panel1.Controls.Add(this.textBoxDestr);
            this.panel1.Controls.Add(this.textBoxItemName);
            this.panel1.Controls.Add(this.LabelItemsCost);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.textBoxCostItem);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.labelItemSelected);
            this.panel1.Location = new System.Drawing.Point(299, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 456);
            this.panel1.TabIndex = 1;
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(81, 75);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCategory.TabIndex = 10;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category:";
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
            // textBoxDestr
            // 
            this.textBoxDestr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestr.Location = new System.Drawing.Point(21, 268);
            this.textBoxDestr.Multiline = true;
            this.textBoxDestr.Name = "textBoxDestr";
            this.textBoxDestr.Size = new System.Drawing.Size(360, 175);
            this.textBoxDestr.TabIndex = 6;
            this.textBoxDestr.TextChanged += new System.EventHandler(this.textBoxDestr_TextChanged);
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItemName.Location = new System.Drawing.Point(21, 117);
            this.textBoxItemName.Multiline = true;
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(360, 111);
            this.textBoxItemName.TabIndex = 5;
            this.textBoxItemName.TextChanged += new System.EventHandler(this.textBoxItemName_TextChanged);
            // 
            // LabelItemsCost
            // 
            this.LabelItemsCost.AutoSize = true;
            this.LabelItemsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelItemsCost.Location = new System.Drawing.Point(18, 49);
            this.LabelItemsCost.Name = "LabelItemsCost";
            this.LabelItemsCost.Size = new System.Drawing.Size(37, 16);
            this.LabelItemsCost.TabIndex = 4;
            this.LabelItemsCost.Text = "Cost:";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(18, 24);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 16);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID:";
            // 
            // textBoxCostItem
            // 
            this.textBoxCostItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCostItem.Location = new System.Drawing.Point(81, 49);
            this.textBoxCostItem.Name = "textBoxCostItem";
            this.textBoxCostItem.Size = new System.Drawing.Size(121, 20);
            this.textBoxCostItem.TabIndex = 2;
            this.textBoxCostItem.TextChanged += new System.EventHandler(this.textBoxCostItem_TextChanged_1);
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxId.Location = new System.Drawing.Point(81, 23);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(121, 20);
            this.textBoxId.TabIndex = 1;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(750, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 2;
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
        private System.Windows.Forms.TextBox textBoxCostItem;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelItemSelected;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LabelItemsCost;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxDestr;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelItemDiscription;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.Label label1;
    }
}
