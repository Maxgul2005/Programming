using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_1.Model
{
    public partial class ClassesRectangles : UserControl
    {
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;
        private string[] List_Box_Recangle = new string[5];
        private string[] RectangleColor = new string[6] { "Black", "White", "Orange", "Purple", "Green", "Blue" };

        public ClassesRectangles()
        {
            InitializeComponent();
            RectangleInitiaziation();
        }
        //Генерация рандомных полей в прямоугольник
        Random _random = new Random();
        public void RectangleInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                int length = _random.Next(200);
                int widtht = _random.Next(200);
                double x = _random.Next(200);
                double y = _random.Next(200);
                double centrX = x + widtht / 2;
                double centrY = y + length / 2;
                Point2D center = new Point2D(centrX, centrY);
                _rectangles[i] = new Rectangle(length, widtht, RectangleColor[i], center);
                List_Box_Recangle[i] = ($"Rectangle {i + 1}");

            }

            TextBoxClassesRectanglesListBox.Items.AddRange(List_Box_Recangle);
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

        private void TextBoxClassesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                int SelectedIndex = TextBoxClassesRectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[SelectedIndex];
                TextBoxClassesRectanglesLength.Text = _currentRectangle.Length.ToString();
                TextBoxClassesRectanglesWidth.Text = _currentRectangle.Widtht.ToString();
                TextBoxClassesRectanglesColor.Text = _currentRectangle.Color;
                TextBoxRectabglesCenterX.Text = _currentRectangle.Center.X.ToString();
                TextBoxRectabglesCenterY.Text = _currentRectangle.Center.Y.ToString();
                TextBoxId.Text = _currentRectangle.Id.ToString();
            
        }

        private void TextBoxClassesRectanglesLength_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                TextBoxClassesRectanglesLength.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            try
            {
                _currentRectangle.Length = int.Parse(TextBoxClassesRectanglesLength.Text);
                TextBoxClassesRectanglesLength.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                TextBoxClassesRectanglesLength.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void TextBoxClassesRectanglesWidth_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                TextBoxClassesRectanglesWidth.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            try
            {
                _currentRectangle.Widtht = int.Parse(TextBoxClassesRectanglesWidth.Text);
                TextBoxClassesRectanglesWidth.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                TextBoxClassesRectanglesWidth.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            TextBoxClassesRectanglesListBox.SelectedIndex = RectangleMaxWidthIndex;
        }
    }
}
