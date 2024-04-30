using Programming_1.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Programming_1
{
    public partial class MainForm : Form
    {


       
        public MainForm()
        {
            
            InitializeComponent();
            seasonsHandle1.SeasonChanged += seasonsHandle1_SeasonChanged; // Подписываемся на событие SeasonChanged

           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private Season selectedSeason;

        /// <summary>
        /// Обрабатывает событие SeasonChanged элемента управления seasonsHandle1.
        /// </summary>
        private void seasonsHandle1_SeasonChanged(object sender, EventArgs e)
        {
            selectedSeason = seasonsHandle1.SelectedSeason;
            switch (selectedSeason)
            {
                case Season.Summer:
                    MessageBox.Show("Ура, солнце");
                    break;
                case Season.Autumn:
                    // Меняем цвета для контролов внутри GroupBox на вкладке "Enum"
                    ChangeBackColorForGroupBoxControls(groupBox1, Color.Orange); // Измените на ваш выбранный оранжевый цвет
                    ChangeBackColorForGroupBoxControls(groupBox2, Color.Orange); // Измените на ваш выбранный оранжевый цвет
                    ChangeBackColorForGroupBoxControls(SeasonGroupBox, Color.Orange); // Измените на ваш выбранный оранжевый цвет
                    break;
                case Season.Winter:
                    MessageBox.Show("БРР, Холодно");
                    break;
                case Season.Spring:
                    // Меняем цвета для контролов внутри GroupBox на вкладке "Enum"
                    ChangeBackColorForGroupBoxControls(groupBox1, Color.Green); // Измените на ваш выбранный оранжевый цвет
                    ChangeBackColorForGroupBoxControls(groupBox2, Color.Green); // Измените на ваш выбранный оранжевый цвет
                    ChangeBackColorForGroupBoxControls(SeasonGroupBox, Color.Green); // Измените на ваш выбранный оранжевый цвет
                    break;


            }
            
        }

        /// <summary>
        /// Меняет цвет фона для элементов управления внутри указанной GroupBox.
        /// </summary>
        /// <param name="groupBox">GroupBox, элементы управления внутри которого нужно изменить.</param>
        /// <param name="color">Новый цвет фона.</param>
        private void ChangeBackColorForGroupBoxControls(GroupBox groupBox, Color color)
        {
            foreach (Control control in groupBox.Controls)
            {
                control.BackColor = color;
            }
        }


    }
}


