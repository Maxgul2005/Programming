namespace Programming_1.Model
{
    partial class ClassesRectangles
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBoxRectabglesCenterY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBoxRectabglesCenterX = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxClassesRectanglesColor = new System.Windows.Forms.TextBox();
            this.TextBoxClassesRectanglesWidth = new System.Windows.Forms.TextBox();
            this.TextBoxClassesRectanglesLength = new System.Windows.Forms.TextBox();
            this.TextBoxClassesRectanglesListBox = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ID);
            this.groupBox3.Controls.Add(this.TextBoxId);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TextBoxRectabglesCenterY);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TextBoxRectabglesCenterX);
            this.groupBox3.Controls.Add(this.Find);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TextBoxClassesRectanglesColor);
            this.groupBox3.Controls.Add(this.TextBoxClassesRectanglesWidth);
            this.groupBox3.Controls.Add(this.TextBoxClassesRectanglesLength);
            this.groupBox3.Controls.Add(this.TextBoxClassesRectanglesListBox);
            this.groupBox3.Location = new System.Drawing.Point(-65, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 343);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rectangles";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(335, 257);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 14;
            this.ID.Text = "ID";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Enabled = false;
            this.TextBoxId.Location = new System.Drawing.Point(300, 273);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.ReadOnly = true;
            this.TextBoxId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxId.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(305, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Coordinates Y";
            // 
            // TextBoxRectabglesCenterY
            // 
            this.TextBoxRectabglesCenterY.Enabled = false;
            this.TextBoxRectabglesCenterY.Location = new System.Drawing.Point(300, 234);
            this.TextBoxRectabglesCenterY.Name = "TextBoxRectabglesCenterY";
            this.TextBoxRectabglesCenterY.ReadOnly = true;
            this.TextBoxRectabglesCenterY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectabglesCenterY.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(305, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Coordinates X";
            // 
            // TextBoxRectabglesCenterX
            // 
            this.TextBoxRectabglesCenterX.Enabled = false;
            this.TextBoxRectabglesCenterX.Location = new System.Drawing.Point(300, 195);
            this.TextBoxRectabglesCenterX.Name = "TextBoxRectabglesCenterX";
            this.TextBoxRectabglesCenterX.ReadOnly = true;
            this.TextBoxRectabglesCenterX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectabglesCenterX.TabIndex = 9;
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(308, 299);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 7;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Length:";
            // 
            // TextBoxClassesRectanglesColor
            // 
            this.TextBoxClassesRectanglesColor.Location = new System.Drawing.Point(300, 146);
            this.TextBoxClassesRectanglesColor.Name = "TextBoxClassesRectanglesColor";
            this.TextBoxClassesRectanglesColor.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesColor.TabIndex = 3;
            // 
            // TextBoxClassesRectanglesWidth
            // 
            this.TextBoxClassesRectanglesWidth.Location = new System.Drawing.Point(300, 97);
            this.TextBoxClassesRectanglesWidth.Name = "TextBoxClassesRectanglesWidth";
            this.TextBoxClassesRectanglesWidth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesWidth.TabIndex = 2;
            this.TextBoxClassesRectanglesWidth.TextChanged += new System.EventHandler(this.TextBoxClassesRectanglesWidth_TextChanged);
            // 
            // TextBoxClassesRectanglesLength
            // 
            this.TextBoxClassesRectanglesLength.Location = new System.Drawing.Point(300, 48);
            this.TextBoxClassesRectanglesLength.Name = "TextBoxClassesRectanglesLength";
            this.TextBoxClassesRectanglesLength.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesLength.TabIndex = 1;
            this.TextBoxClassesRectanglesLength.TextChanged += new System.EventHandler(this.TextBoxClassesRectanglesLength_TextChanged);
            // 
            // TextBoxClassesRectanglesListBox
            // 
            this.TextBoxClassesRectanglesListBox.FormattingEnabled = true;
            this.TextBoxClassesRectanglesListBox.Location = new System.Drawing.Point(68, 42);
            this.TextBoxClassesRectanglesListBox.Name = "TextBoxClassesRectanglesListBox";
            this.TextBoxClassesRectanglesListBox.Size = new System.Drawing.Size(228, 212);
            this.TextBoxClassesRectanglesListBox.TabIndex = 0;
            this.TextBoxClassesRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.TextBoxClassesRectanglesListBox_SelectedIndexChanged);
            // 
            // ClassesRectangles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "ClassesRectangles";
            this.Size = new System.Drawing.Size(356, 360);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TextBoxRectabglesCenterY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextBoxRectabglesCenterX;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesColor;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesWidth;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesLength;
        private System.Windows.Forms.ListBox TextBoxClassesRectanglesListBox;
    }
}
