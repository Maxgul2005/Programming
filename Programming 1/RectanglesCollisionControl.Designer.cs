namespace Programming_1
{
    partial class RectanglesCollisionControl
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
            this.label16 = new System.Windows.Forms.Label();
            this.listBoxRectangels = new System.Windows.Forms.ListBox();
            this.ButtonAddRectangle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TextBoxIdRectangels = new System.Windows.Forms.TextBox();
            this.TextBoxX_Rectangels = new System.Windows.Forms.TextBox();
            this.TextBoxY_Rectangels = new System.Windows.Forms.TextBox();
            this.TextBoxWidthRectangels = new System.Windows.Forms.TextBox();
            this.TextBoxLengthRectangels = new System.Windows.Forms.TextBox();
            this.PanelRectangels = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Rectangles";
            // 
            // listBoxRectangels
            // 
            this.listBoxRectangels.FormattingEnabled = true;
            this.listBoxRectangels.Location = new System.Drawing.Point(22, 44);
            this.listBoxRectangels.Name = "listBoxRectangels";
            this.listBoxRectangels.Size = new System.Drawing.Size(235, 95);
            this.listBoxRectangels.TabIndex = 17;
            this.listBoxRectangels.SelectedIndexChanged += new System.EventHandler(this.listBoxRectangels_SelectedIndexChanged);
            // 
            // ButtonAddRectangle
            // 
            this.ButtonAddRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddRectangle.Location = new System.Drawing.Point(22, 157);
            this.ButtonAddRectangle.Name = "ButtonAddRectangle";
            this.ButtonAddRectangle.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddRectangle.TabIndex = 18;
            this.ButtonAddRectangle.Text = "Добавить ";
            this.ButtonAddRectangle.UseVisualStyleBackColor = true;
            this.ButtonAddRectangle.Click += new System.EventHandler(this.ButtonAddRectangle_Click);
            this.ButtonAddRectangle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonAddRectangle_MouseDown);
            this.ButtonAddRectangle.MouseEnter += new System.EventHandler(this.ButtonAddRectangle_MouseEnter);
            this.ButtonAddRectangle.MouseLeave += new System.EventHandler(this.ButtonAddRectangle_MouseLeave);
            this.ButtonAddRectangle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonAddRectangle_MouseUp);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(178, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 212);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Selected Rectangle:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Id:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 262);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "X:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 292);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Y:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 313);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Width:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 347);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Length:";
            // 
            // TextBoxIdRectangels
            // 
            this.TextBoxIdRectangels.Location = new System.Drawing.Point(53, 231);
            this.TextBoxIdRectangels.Name = "TextBoxIdRectangels";
            this.TextBoxIdRectangels.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIdRectangels.TabIndex = 26;
            // 
            // TextBoxX_Rectangels
            // 
            this.TextBoxX_Rectangels.Location = new System.Drawing.Point(53, 262);
            this.TextBoxX_Rectangels.Name = "TextBoxX_Rectangels";
            this.TextBoxX_Rectangels.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX_Rectangels.TabIndex = 27;
            this.TextBoxX_Rectangels.TextChanged += new System.EventHandler(this.TextBoxX_Rectangels_TextChanged);
            // 
            // TextBoxY_Rectangels
            // 
            this.TextBoxY_Rectangels.Location = new System.Drawing.Point(53, 288);
            this.TextBoxY_Rectangels.Name = "TextBoxY_Rectangels";
            this.TextBoxY_Rectangels.Size = new System.Drawing.Size(100, 20);
            this.TextBoxY_Rectangels.TabIndex = 28;
            this.TextBoxY_Rectangels.TextChanged += new System.EventHandler(this.TextBoxY_Rectangels_TextChanged);
            // 
            // TextBoxWidthRectangels
            // 
            this.TextBoxWidthRectangels.Location = new System.Drawing.Point(53, 313);
            this.TextBoxWidthRectangels.Name = "TextBoxWidthRectangels";
            this.TextBoxWidthRectangels.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWidthRectangels.TabIndex = 29;
            this.TextBoxWidthRectangels.TextChanged += new System.EventHandler(this.TextBoxWidthRectangels_TextChanged);
            // 
            // TextBoxLengthRectangels
            // 
            this.TextBoxLengthRectangels.Location = new System.Drawing.Point(53, 344);
            this.TextBoxLengthRectangels.Name = "TextBoxLengthRectangels";
            this.TextBoxLengthRectangels.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLengthRectangels.TabIndex = 30;
            this.TextBoxLengthRectangels.TextChanged += new System.EventHandler(this.TextBoxLengthRectangels_TextChanged);
            // 
            // PanelRectangels
            // 
            this.PanelRectangels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRectangels.Location = new System.Drawing.Point(291, 44);
            this.PanelRectangels.Name = "PanelRectangels";
            this.PanelRectangels.Size = new System.Drawing.Size(476, 349);
            this.PanelRectangels.TabIndex = 31;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelRectangels);
            this.Controls.Add(this.TextBoxLengthRectangels);
            this.Controls.Add(this.TextBoxWidthRectangels);
            this.Controls.Add(this.TextBoxY_Rectangels);
            this.Controls.Add(this.TextBoxX_Rectangels);
            this.Controls.Add(this.TextBoxIdRectangels);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonAddRectangle);
            this.Controls.Add(this.listBoxRectangels);
            this.Controls.Add(this.label16);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(812, 446);
            this.Load += new System.EventHandler(this.RectanglesCollisionControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBoxRectangels;
        private System.Windows.Forms.Button ButtonAddRectangle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TextBoxIdRectangels;
        private System.Windows.Forms.TextBox TextBoxX_Rectangels;
        private System.Windows.Forms.TextBox TextBoxY_Rectangels;
        private System.Windows.Forms.TextBox TextBoxWidthRectangels;
        private System.Windows.Forms.TextBox TextBoxLengthRectangels;
        private System.Windows.Forms.Panel PanelRectangels;
    }
}
