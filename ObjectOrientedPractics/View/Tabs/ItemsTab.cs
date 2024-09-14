using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        

        public ItemsTab()
        {
            InitializeComponent();
            ClearInputFields();
        }

        // Это поле для хранения списка товаров
        private List<Item> _items = new List<Item>();
        private int selectedIndex = -1; // Переменная для хранения текущего выбранного индекса
        private void AddItemsButton_Click(object sender, EventArgs e)
        {

            textBoxCostItem.BackColor = SystemColors.Window;

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(textBoxCostItem.Text) || string.IsNullOrEmpty(textBoxItemName.Text) || string.IsNullOrEmpty(textBoxDestr.Text))
            {
                MessageBox.Show("Заполните все поля!!!");
                return;
            }

            // Попытка преобразования текста в число
            if (!double.TryParse(textBoxCostItem.Text, out double cost))
            {
                textBoxCostItem.BackColor = Color.Pink;
                MessageBox.Show("Введите корректное числовое значение для стоимости!");
                return;
            }

            // Проверка стоимости
            if (cost > 1000000)
            {
                textBoxCostItem.BackColor = Color.Pink;
                MessageBox.Show("Стоимость не может быть больше 1,000,000!");
                return;
            }

            // Если всё корректно, создаем новый объект Item и добавляем его в список
            Item newItem = new Item(textBoxItemName.Text, textBoxDestr.Text, cost);
            _items.Add(newItem);
            ItemsListBox.Items.Add(newItem);
            ClearInputFields();


        }


        /// <summary>
        /// Метод для очистки текстовых полей после добавления товара
        /// </summary>
        private void ClearInputFields()
        {
            textBoxId.Clear();
            textBoxItemName.Clear();
            textBoxDestr.Clear();
            textBoxCostItem.Clear();
        }

        private void RemoveItemsButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
                ClearInputFields();

            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = ItemsListBox.SelectedIndex;
            if (ItemsListBox.SelectedItem != null)
            {
                Item SelectedItem = (Item)ItemsListBox.SelectedItem;
                textBoxId.Text = SelectedItem.Id.ToString();
                textBoxCostItem.Text = SelectedItem.Cost.ToString();
                textBoxItemName.Text = SelectedItem.Name;
                textBoxDestr.Text = SelectedItem.Info;
            }
            

        }

        private void textBoxCostItem_TextChanged_1(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && ItemsListBox.SelectedItem is Item selectedItem)
            {
                // Попытка преобразовать значение текстбокса в число
                if (double.TryParse(textBoxCostItem.Text, out double cost))
                {
                    // Обновляем стоимость у выбранного элемента
                    selectedItem.Cost = cost;

                    // Удаляем старый элемент и добавляем обновлённый на ту же позицию
                    int currentIndex = selectedIndex; // Сохраняем индекс
                    ItemsListBox.Items.RemoveAt(currentIndex); // Удаляем старый элемент
                    ItemsListBox.Items.Insert(currentIndex, selectedItem); // Добавляем обновлённый элемент

                    // Выбираем элемент снова для корректного отображения
                    ItemsListBox.SelectedIndex = currentIndex;

                    // Возвращаем нормальный цвет фона текстбокса
                    textBoxCostItem.BackColor = SystemColors.Window;
                }
                else
                {
                    // Некорректный ввод числа, показываем красный фон
                    textBoxCostItem.BackColor = Color.Pink;
                }
            }
        }
    }
}
