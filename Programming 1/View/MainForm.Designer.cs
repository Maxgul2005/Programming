namespace Programming_1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ParsedValueLabel = new System.Windows.Forms.Label();
            this.Parse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Movie = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxMovieRaiting = new System.Windows.Forms.TextBox();
            this.TextBoxMovieGenre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TextBoxMovieYear = new System.Windows.Forms.TextBox();
            this.TextBoxMovieMinutes = new System.Windows.Forms.TextBox();
            this.TextBoxMovieName = new System.Windows.Forms.TextBox();
            this.ListBoxClassesMovie = new System.Windows.Forms.ListBox();
            this.Find = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxClassesRectanglesColor = new System.Windows.Forms.TextBox();
            this.TextBoxClassesRectanglesWidth = new System.Windows.Forms.TextBox();
            this.TextBoxClassesRectanglesLength = new System.Windows.Forms.TextBox();
            this.TextBoxClassesRectanglesListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Movie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SeasonGroupBox);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enum";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.label5);
            this.SeasonGroupBox.Controls.Add(this.button1);
            this.SeasonGroupBox.Location = new System.Drawing.Point(393, 274);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(234, 104);
            this.SeasonGroupBox.TabIndex = 2;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "SeasonHand";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(0, 33);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeasonComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "HooseSeason";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ParsedValueLabel);
            this.groupBox2.Controls.Add(this.Parse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ParsingTextBox);
            this.groupBox2.Location = new System.Drawing.Point(42, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WeekdayParsing";
            // 
            // ParsedValueLabel
            // 
            this.ParsedValueLabel.AutoSize = true;
            this.ParsedValueLabel.Location = new System.Drawing.Point(10, 65);
            this.ParsedValueLabel.Name = "ParsedValueLabel";
            this.ParsedValueLabel.Size = new System.Drawing.Size(10, 13);
            this.ParsedValueLabel.TabIndex = 3;
            this.ParsedValueLabel.Text = ".";
            // 
            // Parse
            // 
            this.Parse.Location = new System.Drawing.Point(165, 34);
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(75, 23);
            this.Parse.TabIndex = 2;
            this.Parse.Text = "Parse";
            this.Parse.UseVisualStyleBackColor = true;
            this.Parse.Click += new System.EventHandler(this.Parse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type value to parsing";
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(13, 37);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(139, 20);
            this.ParsingTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IntTextBox);
            this.groupBox1.Controls.Add(this.ValuesListBox);
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Int Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose enumaration";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(389, 50);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(242, 50);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(120, 95);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Collor",
            "StudentFormOfStudy",
            "Genre",
            "Smartphone",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(19, 50);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(120, 95);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Movie);
            this.groupBox3.Controls.Add(this.Find);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TextBoxClassesRectanglesColor);
            this.groupBox3.Controls.Add(this.TextBoxClassesRectanglesWidth);
            this.groupBox3.Controls.Add(this.TextBoxClassesRectanglesLength);
            this.groupBox3.Controls.Add(this.TextBoxClassesRectanglesListBox);
            this.groupBox3.Location = new System.Drawing.Point(8, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(764, 374);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rectangles";
            // 
            // Movie
            // 
            this.Movie.Controls.Add(this.label13);
            this.Movie.Controls.Add(this.label12);
            this.Movie.Controls.Add(this.label11);
            this.Movie.Controls.Add(this.label10);
            this.Movie.Controls.Add(this.label9);
            this.Movie.Controls.Add(this.TextBoxMovieRaiting);
            this.Movie.Controls.Add(this.TextBoxMovieGenre);
            this.Movie.Controls.Add(this.button2);
            this.Movie.Controls.Add(this.TextBoxMovieYear);
            this.Movie.Controls.Add(this.TextBoxMovieMinutes);
            this.Movie.Controls.Add(this.TextBoxMovieName);
            this.Movie.Controls.Add(this.ListBoxClassesMovie);
            this.Movie.Location = new System.Drawing.Point(366, 0);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(398, 408);
            this.Movie.TabIndex = 8;
            this.Movie.TabStop = false;
            this.Movie.Text = "Movie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(243, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Raiting";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Genre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Minutes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Name";
            // 
            // TextBoxMovieRaiting
            // 
            this.TextBoxMovieRaiting.Location = new System.Drawing.Point(243, 195);
            this.TextBoxMovieRaiting.Name = "TextBoxMovieRaiting";
            this.TextBoxMovieRaiting.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieRaiting.TabIndex = 6;
            this.TextBoxMovieRaiting.TextChanged += new System.EventHandler(this.TextBoxMovieRaiting_TextChanged);
            // 
            // TextBoxMovieGenre
            // 
            this.TextBoxMovieGenre.Location = new System.Drawing.Point(243, 155);
            this.TextBoxMovieGenre.Name = "TextBoxMovieGenre";
            this.TextBoxMovieGenre.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieGenre.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextBoxMovieYear
            // 
            this.TextBoxMovieYear.Location = new System.Drawing.Point(243, 111);
            this.TextBoxMovieYear.Name = "TextBoxMovieYear";
            this.TextBoxMovieYear.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieYear.TabIndex = 3;
            this.TextBoxMovieYear.TextChanged += new System.EventHandler(this.TextBoxMovieYear_TextChanged);
            // 
            // TextBoxMovieMinutes
            // 
            this.TextBoxMovieMinutes.Location = new System.Drawing.Point(243, 74);
            this.TextBoxMovieMinutes.Name = "TextBoxMovieMinutes";
            this.TextBoxMovieMinutes.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieMinutes.TabIndex = 2;
            this.TextBoxMovieMinutes.TextChanged += new System.EventHandler(this.TextBoxMovieMinutes_TextChanged);
            // 
            // TextBoxMovieName
            // 
            this.TextBoxMovieName.Location = new System.Drawing.Point(243, 32);
            this.TextBoxMovieName.Name = "TextBoxMovieName";
            this.TextBoxMovieName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieName.TabIndex = 1;
            // 
            // ListBoxClassesMovie
            // 
            this.ListBoxClassesMovie.FormattingEnabled = true;
            this.ListBoxClassesMovie.Location = new System.Drawing.Point(6, 32);
            this.ListBoxClassesMovie.Name = "ListBoxClassesMovie";
            this.ListBoxClassesMovie.Size = new System.Drawing.Size(205, 199);
            this.ListBoxClassesMovie.TabIndex = 0;
            this.ListBoxClassesMovie.SelectedIndexChanged += new System.EventHandler(this.ListBoxClassesMovie_SelectedIndexChanged);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(249, 181);
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
            this.label8.Location = new System.Drawing.Point(267, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Length:";
            // 
            // TextBoxClassesRectanglesColor
            // 
            this.TextBoxClassesRectanglesColor.Location = new System.Drawing.Point(240, 146);
            this.TextBoxClassesRectanglesColor.Name = "TextBoxClassesRectanglesColor";
            this.TextBoxClassesRectanglesColor.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesColor.TabIndex = 3;
            // 
            // TextBoxClassesRectanglesWidth
            // 
            this.TextBoxClassesRectanglesWidth.Location = new System.Drawing.Point(240, 97);
            this.TextBoxClassesRectanglesWidth.Name = "TextBoxClassesRectanglesWidth";
            this.TextBoxClassesRectanglesWidth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesWidth.TabIndex = 2;
            this.TextBoxClassesRectanglesWidth.TextChanged += new System.EventHandler(this.TextBoxClassesRectanglesWidth_TextChanged);
            // 
            // TextBoxClassesRectanglesLength
            // 
            this.TextBoxClassesRectanglesLength.Location = new System.Drawing.Point(240, 48);
            this.TextBoxClassesRectanglesLength.Name = "TextBoxClassesRectanglesLength";
            this.TextBoxClassesRectanglesLength.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesLength.TabIndex = 1;
            this.TextBoxClassesRectanglesLength.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxClassesRectanglesListBox
            // 
            this.TextBoxClassesRectanglesListBox.FormattingEnabled = true;
            this.TextBoxClassesRectanglesListBox.Location = new System.Drawing.Point(6, 32);
            this.TextBoxClassesRectanglesListBox.Name = "TextBoxClassesRectanglesListBox";
            this.TextBoxClassesRectanglesListBox.Size = new System.Drawing.Size(228, 212);
            this.TextBoxClassesRectanglesListBox.TabIndex = 0;
            this.TextBoxClassesRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.TextBoxClassesRectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Movie.ResumeLayout(false);
            this.Movie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Parse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Label ParsedValueLabel;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox TextBoxClassesRectanglesListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesColor;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesWidth;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesLength;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.GroupBox Movie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TextBoxMovieYear;
        private System.Windows.Forms.TextBox TextBoxMovieMinutes;
        private System.Windows.Forms.TextBox TextBoxMovieName;
        private System.Windows.Forms.ListBox ListBoxClassesMovie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxMovieRaiting;
        private System.Windows.Forms.TextBox TextBoxMovieGenre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

