using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
            ClearInputFields();
            object[] Category = Enum.GetValues(typeof(Category)).Cast<object>().ToArray();
            ComboBoxCategory.Items.AddRange(Category);
        }

        private List<Item> _items = new List<Item>();
        private int selectedIndex = -1; // Переменная для хранения текущего выбранного индекса

        /// <summary>
        /// Добавляет новый товар в список.
        /// </summary>
        private void AddItemsButton_Click(object sender, EventArgs e)
        {
            textBoxCostItem.BackColor = SystemColors.Window;

            if (string.IsNullOrEmpty(textBoxCostItem.Text) || string.IsNullOrEmpty(textBoxItemName.Text) || string.IsNullOrEmpty(textBoxDestr.Text))
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
            Category selectedCategory = Category.Electronics;
            Item newItem = new Item(textBoxItemName.Text, textBoxDestr.Text, cost, selectedCategory);
            _items.Add(newItem);
            ItemsListBox.Items.Add(newItem);
            ClearInputFields();
        }

        /// <summary>
        /// Удаляет выбранный товар из списка.
        /// </summary>
        private void RemoveItemsButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
                ClearInputFields();
            }
        }

        /// <summary>
        /// Обновляет выбранный элемент в списке.
        /// </summary>
        /// <param name="selectedItem">Объект товара для обновления.</param>
        private void UpdateSelectedItem(Item selectedItem)
        {
            int currentIndex = selectedIndex; // Сохраняем индекс
            ItemsListBox.Items.RemoveAt(currentIndex); // Удаляем старый элемент
            ItemsListBox.Items.Insert(currentIndex, selectedItem); // Добавляем обновлённый элемент
            ItemsListBox.SelectedIndex = currentIndex; // Снова выбираем этот элемент
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
            textBoxCostItem.BackColor = SystemColors.Window;
            textBoxItemName.BackColor = SystemColors.Window;
            textBoxDestr.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Обрабатывает выбор элемента в списке.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = ItemsListBox.SelectedIndex;
            if (ItemsListBox.SelectedItem != null)
            {
                Item SelectedItem = (Item)ItemsListBox.SelectedItem;
                ComboBoxCategory.SelectedItem = SelectedItem.Category;
                textBoxId.Text = SelectedItem.Id.ToString();
                textBoxCostItem.Text = SelectedItem.Cost.ToString();
                textBoxItemName.Text = SelectedItem.Name;
                textBoxDestr.Text = SelectedItem.Info;
            }
        }

        /// <summary>
        /// Валидация поля стоимости в реальном времени.
        /// </summary>
        private void textBoxCostItem_TextChanged_1(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxCostItem.Text, out double cost))
            {
                if (cost >= 0 && cost <= 100000)
                {
                    textBoxCostItem.BackColor = SystemColors.Window;
                    if (selectedIndex >= 0 && ItemsListBox.SelectedItem is Item selectedItem)
                    {
                        selectedItem.Cost = cost;
                        UpdateSelectedItem(selectedItem);
                    }
                }
                else
                {
                    textBoxCostItem.BackColor = Color.Pink;
                }
            }
            else
            {
                textBoxCostItem.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Валидация поля имени товара в реальном времени.
        /// </summary>
        private void textBoxItemName_TextChanged(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && ItemsListBox.SelectedItem is Item selectedItem)
            {
                string newName = textBoxItemName.Text;

                if (!string.IsNullOrEmpty(newName) && newName.Length <= 200)
                {
                    textBoxItemName.BackColor = SystemColors.Window;
                    selectedItem.Name = newName;
                    UpdateSelectedItem(selectedItem);
                }
                else
                {
                    textBoxItemName.BackColor = Color.Pink;
                }
            }
        }

        /// <summary>
        /// Валидация поля описания товара в реальном времени.
        /// </summary>
        private void textBoxDestr_TextChanged(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && ItemsListBox.SelectedItem is Item selectedItem)
            {
                string newInfo = textBoxDestr.Text;

                if (!string.IsNullOrEmpty(newInfo) && newInfo.Length <= 1000)
                {
                    textBoxDestr.BackColor = SystemColors.Window;
                    selectedItem.Info = newInfo;
                    UpdateSelectedItem(selectedItem);
                }
                else
                {
                    textBoxDestr.BackColor = Color.Pink;
                }
            }
        }

        /// <summary>
        /// Событие загрузки формы.
        /// </summary>
        private void ItemsTab_Load(object sender, EventArgs e)
        {
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                // Получаем выбранный элемент ComboBox и присваиваем категорию товару
                Category selectedCategory = (Category)ComboBoxCategory.SelectedItem;
                _items[selectedIndex].Category = selectedCategory;

                // Обновляем товар в списке (если нужно обновить отображение в listBox)
                ItemsListBox.Items[selectedIndex] = _items[selectedIndex];
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}