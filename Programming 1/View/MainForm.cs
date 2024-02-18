using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        public enum Collor
        {
            Black,
            White,
            Red,
            Orange,
            Pink,
        }
        public enum StudentFormOfStudy
        {
            FullTime,
            Correspondence,
            Evening,
            Remote,
        }
        public enum Genre
        {
            Comedy,
            Dramas,
            Thriller,
            Militants,
            Horror,
            Blockbusters,
        }
        public enum Smartphone
        {
            Apple,
            Samsung,
            Poco,
            Honor,
        }
        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
        }
        public enum Weekday
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var collor = Enum.GetValues(typeof(Collor));
            var StudentFormOfStudy = Enum.GetValues(typeof(StudentFormOfStudy));
            var Genre = Enum.GetValues(typeof(Genre));
            var Smartphone = Enum.GetValues(typeof(Smartphone));
            var Season = Enum.GetValues(typeof(Season));
            var Weekday = Enum.GetValues(typeof(Weekday));
            ValuesListBox.Items.Clear();
            if (EnumsListBox.SelectedItem.ToString() == "Collor")
            {
                foreach (var value in collor)
                {
                    ValuesListBox.Items.Add(value);
                }
            }

            if (EnumsListBox.SelectedItem.ToString() == "StudentFormOfStudy")
            {
                foreach (var value in StudentFormOfStudy)
                {
                    ValuesListBox.Items.Add(value);
                }
            }

            if (EnumsListBox.SelectedItem.ToString() == "Genre")
            {
                foreach (var value in Genre)
                {
                    ValuesListBox.Items.Add(value);
                }
            }
            if (EnumsListBox.SelectedItem.ToString() == "Smartphone")
            {
                foreach (var value in Smartphone)
                {
                    ValuesListBox.Items.Add(value);
                }
            }
            if (EnumsListBox.SelectedItem.ToString() == "Season")
            {
                foreach (var value in Season)
                {
                    ValuesListBox.Items.Add(value);
                }
            }
            if (EnumsListBox.SelectedItem.ToString() == "Weekday")
            {
                foreach (var value in Weekday)
                {
                    ValuesListBox.Items.Add(value);
                }
            }
        }

     





    }
}
