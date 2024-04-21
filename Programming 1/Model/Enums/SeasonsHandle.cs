using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_1.Model.Enums
{
    public partial class SeasonsHandle : UserControl
    {
        public SeasonsHandle()
        {
            InitializeComponent();
            object[] seasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(seasonValues);

        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (SeasonComboBox.SelectedItem == null)
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
                    this.BackColor = Color.FromArgb(226, 156, 69); // Оранжевый цвет фона окна
                    break;
                  case Season.Winter:
                      MessageBox.Show("БРР, Холодно");
                      break;
                  case Season.Spring:
                    this.BackColor = Color.FromArgb(85, 156, 69); // Зеленый цвет фона окна
                    break;

              }
          }
          
        }
    }
