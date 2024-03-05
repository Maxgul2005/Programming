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
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;
        private string[] RectangleColor = new string[6] { "Black", "White", "Orange", "Purple", "Green", "Blue" };

        //Генерация рандомных полей в прямоугольник
        Random _random = new Random();
        public void RectangleInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                int length = _random.Next(200);
                int widtht = _random.Next(200);
                _rectangles[i] = new Rectangle(length, widtht, RectangleColor[i]);
            }
            TextBoxClassesRectanglesListBox.Items.AddRange(_rectangles);
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double MaxWidth = _rectangles[0].Widtht;
            int MaxWidthIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Widtht > MaxWidth)
                {
                    MaxWidth = rectangles[i].Widtht;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;

        }

        public MainForm()
        {
            InitializeComponent();
            RectangleInitiaziation();
            ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Collor)).Cast<object>().ToArray());
            // выбор по умолчанию
            object[] seasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(seasonValues);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValuesListBox .SelectedIndex.ToString();
        }

        private void Parse_Click(object sender, EventArgs e)
        {
            string ParsingText = ParsingTextBox.Text;
            Weekday ParsedDay;
            if (!int.TryParse(ParsingText, out _) && Enum.TryParse<Weekday>(ParsingText, true, out ParsedDay))
            {
                int Weekdayorder = (int)ParsedDay;
                ParsedValueLabel.Text = $"Этот день недели ({ParsedDay} = {Weekdayorder}) ";
            }
            else
            {
                ParsedValueLabel.Text = "Нет такого дня недели";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SeasonComboBox.SelectedItem == null)
            {
                SeasonComboBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            SeasonComboBox.BackColor = System.Drawing.Color.White;
            switch (SeasonComboBox.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура, солнце");
                    break;
                case Season.Autumn:
                    SetBackColor(SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#e29c45"));
                    break;
                case Season.Winter:
                    MessageBox.Show("БРР, Холодно");
                    break;
                case Season.Spring:
                    SetBackColor(SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#559c45"));
                    break;

            }
        }
        private void SetBackColor(System.Drawing.Color color)
        {
            groupBox1.BackColor = color;
            groupBox2.BackColor = color;
            SeasonComboBox.BackColor = color;
            this.BackColor = color;
        }

        // Обработка исключений длины
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if(_currentRectangle == null )
           {
                TextBoxClassesRectanglesLength.BackColor = System.Drawing.Color.LightPink;
                return;
           }

           try
            {
                _currentRectangle.Length = double.Parse(TextBoxClassesRectanglesLength.Text);
                TextBoxClassesRectanglesLength.BackColor = System.Drawing.Color.White;
            } catch (Exception)
            {
                TextBoxClassesRectanglesLength.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // Обработка исключений ширины
        private void TextBoxClassesRectanglesWidth_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                TextBoxClassesRectanglesWidth.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            try
            {
                _currentRectangle.Widtht= double.Parse(TextBoxClassesRectanglesWidth.Text);
                TextBoxClassesRectanglesWidth.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                TextBoxClassesRectanglesWidth.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void TextBoxClassesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rectangle rectangle = (Rectangle)TextBoxClassesRectanglesListBox.SelectedItem;
            _currentRectangle = rectangle;
            TextBoxClassesRectanglesLength.Text = rectangle.Length.ToString();
            TextBoxClassesRectanglesWidth.Text = rectangle.Widtht.ToString();
            TextBoxClassesRectanglesColor.Text = rectangle.Color;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            TextBoxClassesRectanglesListBox.SelectedIndex = RectangleMaxWidthIndex;
        }
    }
}
