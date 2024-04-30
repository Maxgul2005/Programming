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
        // Определение события SeasonChanged
        public event EventHandler SeasonChanged;

        /// <summary>
        /// Метод для вызова события SeasonChanged.
        /// </summary>
        protected virtual void OnSeasonChanged(EventArgs e)
        {
            SeasonChanged?.Invoke(this, e);
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
                    this.BackColor = Color.FromArgb(226, 156, 69); 
                    break;
                  case Season.Winter:
                      MessageBox.Show("БРР, Холодно");
                      break;
                  case Season.Spring:
                    this.BackColor = Color.FromArgb(85, 156, 69); 
                    break;

              }
            // После обработки изменения времени года вызываем метод OnSeasonChanged для генерации события
            OnSeasonChanged(EventArgs.Empty);
        }

        /// <summary>
        /// Возвращает выбранный сезон.
        /// </summary>
        public Season SelectedSeason
        {
            get
            {
                return (Season)SeasonComboBox.SelectedItem;
            }
        }

        private void SeasonsHandle_Load(object sender, EventArgs e)
        {

        }
    }
    }
