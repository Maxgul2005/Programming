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
    public partial class RectanglesCollisionControl : UserControl
    {
        List<Rectangle> _rectangels = new List<Rectangle>();
        private Rectangle _currentRectangle;
        private List<Panel> _rectanglePanels = new List<Panel>();
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void ButtonAddRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize();
            _rectangels.Add(rectangle);
            Panel panel = new Panel();
            panel.Location = new Point(rectangle.X, rectangle.Y);
            panel.Size = new Size(rectangle.Widtht, rectangle.Length);
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);


            PanelRectangels.Controls.Add(panel);


            _rectanglePanels.Add(panel);
            UpdateListBox();
            FindCollisions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRectangels.SelectedIndex;
            if (selectedIndex != -1)
            {

                _rectangels.RemoveAt(selectedIndex);


                if (selectedIndex < _rectanglePanels.Count)
                {
                    PanelRectangels.Controls.Remove(_rectanglePanels[selectedIndex]);


                    _rectanglePanels.RemoveAt(selectedIndex);

                }



                listBoxRectangels.Items.RemoveAt(selectedIndex);
                FindCollisions();
            }

            TextBoxX_Rectangels.BackColor = SystemColors.Window;
            TextBoxY_Rectangels.BackColor = SystemColors.Window;
            TextBoxWidthRectangels.BackColor = SystemColors.Window;
            TextBoxLengthRectangels.BackColor = SystemColors.Window;
        }
        private void UpdateListBox()
        {

            if (listBoxRectangels != null)
            {
                listBoxRectangels.Items.Clear();
                foreach (Rectangle rectangle in _rectangels)
                {
                    listBoxRectangels.Items.Add($"Id: {rectangle.Id}, X: {rectangle.X}, Y: {rectangle.Y}, Width: {rectangle.Widtht}, Height: {rectangle.Length}");
                }
            }
        }
        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = Color.Green;
            }


            for (int i = 0; i < _rectangels.Count; i++)
            {

                for (int j = i + 1; j < _rectangels.Count; j++)
                {

                    if (CollisionManager.IsCollision(_rectangels[i], _rectangels[j]))
                    {

                        _rectanglePanels[i].BackColor = Color.Red;
                        _rectanglePanels[j].BackColor = Color.Red;
                    }
                }
            }
        }

        private void listBoxRectangels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRectangels.SelectedIndex != -1)
            {
                _currentRectangle = _rectangels[listBoxRectangels.SelectedIndex];

                TextBoxIdRectangels.Text = _currentRectangle.Id.ToString();
                TextBoxX_Rectangels.Text = _currentRectangle.X.ToString();
                TextBoxY_Rectangels.Text = _currentRectangle.Y.ToString();
                TextBoxWidthRectangels.Text = _currentRectangle.Widtht.ToString();
                TextBoxLengthRectangels.Text = _currentRectangle.Length.ToString();



            }
            else
            {

                ClearRectangleInfo();
            }
        }

        private void ClearRectangleInfo()
        {
            if (listBoxRectangels != null)
            {
                TextBoxIdRectangels.Text = "";
                TextBoxX_Rectangels.Text = "";
                TextBoxY_Rectangels.Text = "";
                TextBoxWidthRectangels.Text = "";
                TextBoxLengthRectangels.Text = "";
            }
        }

        private void TextBoxX_Rectangels_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxX_Rectangels.Text, out int newX))
            {
                if (newX >= 0)
                {
                    _currentRectangle.X = newX;

                    if (listBoxRectangels.SelectedIndex != -1 && listBoxRectangels.SelectedIndex < _rectanglePanels.Count)
                    {
                        _rectanglePanels[listBoxRectangels.SelectedIndex].Location = new Point(newX, _currentRectangle.Y);
                    }

                    UpdateListBox();
                    FindCollisions();
                    TextBoxX_Rectangels.BackColor = SystemColors.Window;
                }
                else
                {
                    TextBoxX_Rectangels.BackColor = Color.LightPink;
                }
            }
            else
            {
                TextBoxX_Rectangels.BackColor = Color.LightPink;
            }
        }

        private void TextBoxY_Rectangels_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxY_Rectangels.Text, out int newY))
            {
                if (newY >= 0)
                {
                    _currentRectangle.Y = newY;

                    if (listBoxRectangels.SelectedIndex != -1 && listBoxRectangels.SelectedIndex < _rectanglePanels.Count)
                    {
                        _rectanglePanels[listBoxRectangels.SelectedIndex].Location = new Point(_currentRectangle.X, newY);
                    }

                    UpdateListBox();
                    FindCollisions();
                    TextBoxY_Rectangels.BackColor = SystemColors.Window;
                }
                else
                {
                    TextBoxY_Rectangels.BackColor = Color.LightPink;
                }
            }
            else
            {
                TextBoxY_Rectangels.BackColor = Color.LightPink;
            }
        }

        private void TextBoxWidthRectangels_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxWidthRectangels.Text, out int newWidth))
            {
                if (newWidth >= 0)
                {
                    _currentRectangle.Widtht = newWidth;

                    if (listBoxRectangels.SelectedIndex != -1 && listBoxRectangels.SelectedIndex < _rectanglePanels.Count)
                    {
                        _rectanglePanels[listBoxRectangels.SelectedIndex].Size = new Size(newWidth, _currentRectangle.Length);
                    }

                    UpdateListBox();
                    FindCollisions();
                    TextBoxWidthRectangels.BackColor = SystemColors.Window;
                }
                else
                {
                    TextBoxWidthRectangels.BackColor = Color.LightPink;
                }
            }
            else
            {
                TextBoxWidthRectangels.BackColor = Color.LightPink;
            }
        }

        private void TextBoxLengthRectangels_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxLengthRectangels.Text, out int newHeight))
            {
                if (newHeight >= 0)
                {
                    _currentRectangle.Length = newHeight;

                    if (listBoxRectangels.SelectedIndex != -1 && listBoxRectangels.SelectedIndex < _rectanglePanels.Count)
                    {
                        _rectanglePanels[listBoxRectangels.SelectedIndex].Size = new Size(_currentRectangle.Widtht, newHeight);
                    }

                    UpdateListBox();
                    FindCollisions();
                    TextBoxLengthRectangels.BackColor = SystemColors.Window;
                }
                else
                {
                    TextBoxLengthRectangels.BackColor = Color.LightPink;
                }
            }
            else
            {
                TextBoxLengthRectangels.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// События для кнопки добавить 
        /// </summary>
        private void ButtonAddRectangle_MouseEnter(object sender, EventArgs e)
        {
            ButtonAddRectangle.BackColor = Color.Blue;
            ButtonAddRectangle.FlatStyle = FlatStyle.Flat;
            ButtonAddRectangle.FlatAppearance.BorderSize = 0;
        }

        private void ButtonAddRectangle_MouseLeave(object sender, EventArgs e)
        {
            ButtonAddRectangle.BackColor = Color.White;
        }

        private void ButtonAddRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonAddRectangle.BackColor = ControlPaint.Light(ButtonAddRectangle.BackColor, 0.3f);
        }

        private void ButtonAddRectangle_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonAddRectangle.BackColor = ControlPaint.Dark(ButtonAddRectangle.BackColor, 0.3f);
        }

        /// <summary>
        /// События для кнопки удалить
        /// </summary>
        
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.BackColor = ControlPaint.Light(button3.BackColor, 0.3f);
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.BackColor = ControlPaint.Dark(ButtonAddRectangle.BackColor, 0.3f);
        }

        private void RectanglesCollisionControl_Load(object sender, EventArgs e)
        {

        }
    }


}
