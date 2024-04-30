using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForStudent
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Array ComboBoxStudyOfFor = Enum.GetValues(typeof(StudentFormOfStudy));
            foreach(StudentFormOfStudy run in ComboBoxStudyOfFor)
            {
                comboBoxFormStudyStudent.Items.Add(run);
            }

            Array ComboBoxFakultet = Enum.GetValues(typeof(Facultet));
            foreach(Facultet f in ComboBoxFakultet)
            {
                comboBoxEducation.Items.Add(f);
            }
        }
       // Student student1 = new Student("Иван", 123446, "12345"); 
        private void MainForm_Load(object sender, EventArgs e)
        {
             
        }

        private void TextBoxFullName_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(TextBoxFullName.Text, out int NewFullName))
            {
                if (NewFullName < 0)
                {
                    TextBoxFullName.BackColor = Color.LightPink;
                }
                else if(NewFullName > 0)
                {
                    TextBoxFullName.BackColor = Color.White;
                }
            }

            else
            {
                TextBoxFullName.BackColor = Color.LightPink;
            }
        }

        private void TextBoxRecordNumber_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxRecordNumber.Text, out int NewRecordNumber))
            {
                if (NewRecordNumber < 0)
                {
                    TextBoxRecordNumber.BackColor = Color.LightPink;
                }
                else if (NewRecordNumber > 0)
                {
                    TextBoxRecordNumber.BackColor = Color.White;
                }
            }

            else
            {
                TextBoxRecordNumber.BackColor = Color.LightPink;
            }

            if (TextBoxRecordNumber.Text.Length > 6)
            {
                MessageBox.Show("Номер зачетки должен содержать ровно шесть символов");
            }
        }
    }
}
