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
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.tabControlI = new System.Windows.Forms.TabControl();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.tabPageItems.SuspendLayout();
            this.tabControlI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageItems
            // 
            this.tabPageItems.Controls.Add(this.itemsTab1);
            this.tabPageItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(749, 482);
            this.tabPageItems.TabIndex = 0;
            this.tabPageItems.Text = "Items";
            this.tabPageItems.UseVisualStyleBackColor = true;
            // 
            // tabControlI
            // 
            this.tabControlI.Controls.Add(this.tabPageItems);
            this.tabControlI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlI.Location = new System.Drawing.Point(0, 0);
            this.tabControlI.Name = "tabControlI";
            this.tabControlI.SelectedIndex = 0;
            this.tabControlI.Size = new System.Drawing.Size(757, 508);
            this.tabControlI.TabIndex = 0;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(743, 476);
            this.itemsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 508);
            this.Controls.Add(this.tabControlI);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.tabPageItems.ResumeLayout(false);
            this.tabControlI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.TabControl tabControlI;
        private View.Tabs.ItemsTab itemsTab1;
    }
}

