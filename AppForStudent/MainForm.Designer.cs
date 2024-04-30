namespace AppForStudent
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
            this.TextBoxFullName = new System.Windows.Forms.TextBox();
            this.TextBoxRecordNumber = new System.Windows.Forms.TextBox();
            this.TextBoxGroupNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.comboBoxFormStudyStudent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButonStudent = new System.Windows.Forms.Button();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextBoxFullName
            // 
            this.TextBoxFullName.Location = new System.Drawing.Point(15, 158);
            this.TextBoxFullName.Name = "TextBoxFullName";
            this.TextBoxFullName.Size = new System.Drawing.Size(307, 20);
            this.TextBoxFullName.TabIndex = 0;
            this.TextBoxFullName.TextChanged += new System.EventHandler(this.TextBoxFullName_TextChanged);
            // 
            // TextBoxRecordNumber
            // 
            this.TextBoxRecordNumber.Location = new System.Drawing.Point(15, 214);
            this.TextBoxRecordNumber.Name = "TextBoxRecordNumber";
            this.TextBoxRecordNumber.Size = new System.Drawing.Size(307, 20);
            this.TextBoxRecordNumber.TabIndex = 1;
            this.TextBoxRecordNumber.TextChanged += new System.EventHandler(this.TextBoxRecordNumber_TextChanged);
            // 
            // TextBoxGroupNumber
            // 
            this.TextBoxGroupNumber.Location = new System.Drawing.Point(15, 273);
            this.TextBoxGroupNumber.Name = "TextBoxGroupNumber";
            this.TextBoxGroupNumber.Size = new System.Drawing.Size(307, 20);
            this.TextBoxGroupNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите полное имя ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите номер зачетки ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите номер группы";
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(15, 38);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(165, 21);
            this.comboBoxEducation.TabIndex = 6;
            // 
            // comboBoxFormStudyStudent
            // 
            this.comboBoxFormStudyStudent.FormattingEnabled = true;
            this.comboBoxFormStudyStudent.Location = new System.Drawing.Point(15, 94);
            this.comboBoxFormStudyStudent.Name = "comboBoxFormStudyStudent";
            this.comboBoxFormStudyStudent.Size = new System.Drawing.Size(165, 21);
            this.comboBoxFormStudyStudent.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите направление";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выберите форму обучения";
            // 
            // AddButonStudent
            // 
            this.AddButonStudent.Location = new System.Drawing.Point(105, 316);
            this.AddButonStudent.Name = "AddButonStudent";
            this.AddButonStudent.Size = new System.Drawing.Size(75, 23);
            this.AddButonStudent.TabIndex = 10;
            this.AddButonStudent.Text = "Добавить";
            this.AddButonStudent.UseVisualStyleBackColor = true;
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(386, 12);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(283, 407);
            this.listBoxStudent.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 422);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.AddButonStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxFormStudyStudent);
            this.Controls.Add(this.comboBoxEducation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxGroupNumber);
            this.Controls.Add(this.TextBoxRecordNumber);
            this.Controls.Add(this.TextBoxFullName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFullName;
        private System.Windows.Forms.TextBox TextBoxRecordNumber;
        private System.Windows.Forms.TextBox TextBoxGroupNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.ComboBox comboBoxFormStudyStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButonStudent;
        private System.Windows.Forms.ListBox listBoxStudent;
    }
}

