using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        //Поля класса.
        private List<Item> _items = new List<Item>();
        private Item _currentItem;
        private List<string> ItemsListBoxItems = new List<string>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        /// <summary>
        /// Свойство для получения или установки списка товаров вкладки.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                
            }
        }
        
        public ItemsTab()
        {
            InitializeComponent();
            // Инициализируем значениями перечесления ComboBox
            object[] Category = Enum.GetValues(typeof(Category)).Cast<object>().ToArray();
            ComboBoxCategory.Items.AddRange(Category);
        }



        /// <summary>
        /// Добавляет новый товар в список.
        /// </summary>
        private void AddItemsButton_Click(object sender, EventArgs e)
        {
            textBoxCostItem.BackColor = SystemColors.Window;

            if (string.IsNullOrEmpty(textBoxCostItem.Text) || string.IsNullOrEmpty(textBoxItemName.Text) || string.IsNullOrEmpty(textBoxDestr.Text) || string.IsNullOrEmpty(ComboBoxCategory.Text))
            {
                MessageBox.Show("Заполните все поля!!!");
                return;
            }

            if (!double.TryParse(textBoxCostItem.Text, out double cost))
            {
                textBoxCostItem.BackColor = Color.Pink;
                MessageBox.Show("Введите корректное числовое значение для стоимости!");
                return;
            }

            if (cost > 1000000)
            {
                textBoxCostItem.BackColor = Color.Pink;
                MessageBox.Show("Стоимость не может быть больше 1,000,000!");
                return;
            }
            Category NewCategory = (Category)Enum.Parse(typeof(Category), ComboBoxCategory.Text);
            Item NewItem = new Item();
            NewItem.Name = textBoxItemName.Text;
            NewItem.Info = textBoxDestr.Text;
            NewItem.Cost = cost;
            NewItem.Category = NewCategory;
            //Добавляем обьект NewItem в список _items Через свойство Items
            Items.Add(NewItem);
            ItemsListBoxItems.Add($"{NewItem.Id.ToString()})");
            ItemsListBox.Items.Add(ItemsListBoxItems[ItemsListBoxItems.Count - 1]);
            ClearInputFields();

        }

        /// <summary>
        /// Удаляет выбранный товар из списка.
        /// </summary>
        private void RemoveItemsButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            Items.RemoveAt(selectedIndex);
            ItemsListBoxItems.RemoveAt(selectedIndex);
            ItemsListBox.Items.RemoveAt(selectedIndex);
            ClearInputFields();
        }

        
        

        /// <summary>
        /// Очищает все поля ввода.
        /// </summary>
        private void ClearInputFields()
        {
            textBoxId.Clear();
            textBoxItemName.Clear();
            textBoxDestr.Clear();
            textBoxCostItem.Clear();
            ComboBoxCategory.SelectedIndex = -1;
            textBoxCostItem.BackColor = SystemColors.Window;
            textBoxItemName.BackColor = SystemColors.Window;
            textBoxDestr.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Обрабатывает выбор элемента в списке.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                AddItemsButton.Enabled = true;
                ClearInputFields();
               
            }
            if (ItemsListBox.SelectedIndex != -1)
            {
                AddItemsButton.Enabled = false;
                int selectedIndex = ItemsListBox.SelectedIndex;
                _currentItem = Items[selectedIndex];
                textBoxId.Text = _currentItem.Id.ToString();
                textBoxCostItem.Text = _currentItem.Cost.ToString();
                textBoxItemName.Text = _currentItem.Name;
                textBoxDestr.Text = _currentItem.Info;
                ComboBoxCategory.Text = _currentItem.Category.ToString();

            }
        }

        /// <summary>
        /// Валидация поля стоимости в реальном времени.
        /// </summary>
        private void textBoxCostItem_TextChanged_1(object sender, EventArgs e)
        {
            if ((ItemsListBox.SelectedIndex != -1))
            {
                _currentItem.Cost = double.Parse(textBoxCostItem.Text);
            }
        }

        /// <summary>
        /// Валидация поля имени товара в реальном времени.
        /// </summary>
        private void textBoxItemName_TextChanged(object sender, EventArgs e)
        {
            if ((ItemsListBox.SelectedIndex != -1))
            {
                _currentItem.Name = textBoxItemName.Text;
            }
        }

        /// <summary>
        /// Валидация поля описания товара в реальном времени.
        /// </summary>
        private void textBoxDestr_TextChanged(object sender, EventArgs e)
        {
            if ((ItemsListBox.SelectedIndex != -1))
            {
                _currentItem.Info = textBoxDestr.Text;
            }
        }


        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                Category category = (Category)ComboBoxCategory.SelectedItem;
                _currentItem.Category = category;
            }
        }

        private void ItemsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ItemsListBox.IndexFromPoint(e.Location) == -1)
            {
                // Если кликнули на пустое место, сбрасываем выбор
                ItemsListBox.ClearSelected();
                ItemsListBox.SelectedIndex = -1;
            }
        }

        private void GroupBoxItems_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}