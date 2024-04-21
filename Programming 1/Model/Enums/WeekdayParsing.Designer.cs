namespace Programming_1.Model.Enums
{
    partial class WeekdayParsing
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
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.Parse = new System.Windows.Forms.Button();
            this.ParsedValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(12, 39);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(139, 20);
            this.ParsingTextBox.TabIndex = 1;
            // 
            // Parse
            // 
            this.Parse.Location = new System.Drawing.Point(170, 39);
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(75, 23);
            this.Parse.TabIndex = 3;
            this.Parse.Text = "Parse";
            this.Parse.UseVisualStyleBackColor = true;
            this.Parse.Click += new System.EventHandler(this.Parse_Click);
            // 
            // ParsedValueLabel
            // 
            this.ParsedValueLabel.AutoSize = true;
            this.ParsedValueLabel.Location = new System.Drawing.Point(18, 62);
            this.ParsedValueLabel.Name = "ParsedValueLabel";
            this.ParsedValueLabel.Size = new System.Drawing.Size(10, 13);
            this.ParsedValueLabel.TabIndex = 4;
            this.ParsedValueLabel.Text = ".";
            // 
            // WeekdayParsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParsedValueLabel);
            this.Controls.Add(this.Parse);
            this.Controls.Add(this.ParsingTextBox);
            this.Name = "WeekdayParsing";
            this.Size = new System.Drawing.Size(258, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Button Parse;
        private System.Windows.Forms.Label ParsedValueLabel;
    }
}
