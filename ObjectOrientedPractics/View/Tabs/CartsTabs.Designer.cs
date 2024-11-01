namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTabs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddCartButton = new System.Windows.Forms.Button();
            this.listBoxForItem = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxForCart = new System.Windows.Forms.ListBox();
            this.Cart = new System.Windows.Forms.Label();
            this.comboBoxForCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCartButton);
            this.groupBox1.Controls.Add(this.listBoxForItem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddCartButton
            // 
            this.AddCartButton.Location = new System.Drawing.Point(18, 457);
            this.AddCartButton.Name = "AddCartButton";
            this.AddCartButton.Size = new System.Drawing.Size(126, 35);
            this.AddCartButton.TabIndex = 1;
            this.AddCartButton.Text = "Add To Cart";
            this.AddCartButton.UseVisualStyleBackColor = true;
            this.AddCartButton.Click += new System.EventHandler(this.AddCartButton_Click);
            // 
            // listBoxForItem
            // 
            this.listBoxForItem.FormattingEnabled = true;
            this.listBoxForItem.ItemHeight = 20;
            this.listBoxForItem.Location = new System.Drawing.Point(6, 35);
            this.listBoxForItem.Name = "listBoxForItem";
            this.listBoxForItem.Size = new System.Drawing.Size(356, 404);
            this.listBoxForItem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClearCart);
            this.groupBox2.Controls.Add(this.RemoveItemButton);
            this.groupBox2.Controls.Add(this.buttonCreateOrder);
            this.groupBox2.Controls.Add(this.AmountLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listBoxForCart);
            this.groupBox2.Controls.Add(this.Cart);
            this.groupBox2.Controls.Add(this.comboBoxForCustomer);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(374, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 511);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Location = new System.Drawing.Point(334, 353);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(87, 35);
            this.buttonClearCart.TabIndex = 8;
            this.buttonClearCart.Text = "Clear Cart";
            this.buttonClearCart.UseVisualStyleBackColor = true;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(208, 353);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(93, 35);
            this.RemoveItemButton.TabIndex = 7;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(13, 353);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(90, 34);
            this.buttonCreateOrder.TabIndex = 6;
            this.buttonCreateOrder.Text = "Create Order";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(317, 320);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(104, 25);
            this.AmountLabel.TabIndex = 5;
            this.AmountLabel.Text = "4 999,90";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(359, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount:";
            // 
            // listBoxForCart
            // 
            this.listBoxForCart.FormattingEnabled = true;
            this.listBoxForCart.Location = new System.Drawing.Point(13, 81);
            this.listBoxForCart.Name = "listBoxForCart";
            this.listBoxForCart.Size = new System.Drawing.Size(408, 212);
            this.listBoxForCart.TabIndex = 3;
            // 
            // Cart
            // 
            this.Cart.AutoSize = true;
            this.Cart.Location = new System.Drawing.Point(10, 59);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(29, 13);
            this.Cart.TabIndex = 2;
            this.Cart.Text = "Cart:";
            // 
            // comboBoxForCustomer
            // 
            this.comboBoxForCustomer.FormattingEnabled = true;
            this.comboBoxForCustomer.Location = new System.Drawing.Point(103, 15);
            this.comboBoxForCustomer.Name = "comboBoxForCustomer";
            this.comboBoxForCustomer.Size = new System.Drawing.Size(318, 21);
            this.comboBoxForCustomer.TabIndex = 1;
            this.comboBoxForCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxForCustomer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // CartsTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CartsTabs";
            this.Size = new System.Drawing.Size(804, 514);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxForItem;
        private System.Windows.Forms.Button AddCartButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Cart;
        private System.Windows.Forms.ComboBox comboBoxForCustomer;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxForCart;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Button buttonClearCart;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
    }
}
