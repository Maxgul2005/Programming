namespace Programming_1.Model
{
    partial class Movies
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
            this.ListBoxClassesMovie = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxMovieName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxMovieMinutes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxMovieYear = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TextBoxMovieGenre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBoxMovieRaiting = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxClassesMovie
            // 
            this.ListBoxClassesMovie.FormattingEnabled = true;
            this.ListBoxClassesMovie.Location = new System.Drawing.Point(3, 33);
            this.ListBoxClassesMovie.Name = "ListBoxClassesMovie";
            this.ListBoxClassesMovie.Size = new System.Drawing.Size(205, 238);
            this.ListBoxClassesMovie.TabIndex = 1;
            this.ListBoxClassesMovie.SelectedIndexChanged += new System.EventHandler(this.ListBoxClassesMovie_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name";
            // 
            // TextBoxMovieName
            // 
            this.TextBoxMovieName.Location = new System.Drawing.Point(228, 49);
            this.TextBoxMovieName.Name = "TextBoxMovieName";
            this.TextBoxMovieName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Minutes";
            // 
            // TextBoxMovieMinutes
            // 
            this.TextBoxMovieMinutes.Location = new System.Drawing.Point(228, 99);
            this.TextBoxMovieMinutes.Name = "TextBoxMovieMinutes";
            this.TextBoxMovieMinutes.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieMinutes.TabIndex = 11;
            this.TextBoxMovieMinutes.TextChanged += new System.EventHandler(this.TextBoxMovieMinutes_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Year";
            // 
            // TextBoxMovieYear
            // 
            this.TextBoxMovieYear.Location = new System.Drawing.Point(228, 147);
            this.TextBoxMovieYear.Name = "TextBoxMovieYear";
            this.TextBoxMovieYear.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieYear.TabIndex = 13;
            this.TextBoxMovieYear.TextChanged += new System.EventHandler(this.TextBoxMovieYear_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Genre";
            // 
            // TextBoxMovieGenre
            // 
            this.TextBoxMovieGenre.Location = new System.Drawing.Point(228, 198);
            this.TextBoxMovieGenre.Name = "TextBoxMovieGenre";
            this.TextBoxMovieGenre.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieGenre.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(248, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Raiting";
            // 
            // TextBoxMovieRaiting
            // 
            this.TextBoxMovieRaiting.Location = new System.Drawing.Point(228, 237);
            this.TextBoxMovieRaiting.Name = "TextBoxMovieRaiting";
            this.TextBoxMovieRaiting.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMovieRaiting.TabIndex = 17;
            this.TextBoxMovieRaiting.TextChanged += new System.EventHandler(this.TextBoxMovieRaiting_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextBoxMovieRaiting);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TextBoxMovieGenre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TextBoxMovieYear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TextBoxMovieMinutes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBoxMovieName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ListBoxClassesMovie);
            this.Name = "Movies";
            this.Size = new System.Drawing.Size(345, 304);
            this.Load += new System.EventHandler(this.Movies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxClassesMovie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxMovieName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxMovieMinutes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxMovieYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextBoxMovieGenre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TextBoxMovieRaiting;
        private System.Windows.Forms.Button button2;
    }
}
