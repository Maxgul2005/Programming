using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
            ClearInfo();
        }

        private List <Customer> _customers = new List <Customer>();// Поле для хранения покупателей
        private int selectedIndex = -1;
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {

           if (String.IsNullOrEmpty(textBoxFullName.Text) || String.IsNullOrEmpty(textBoxAdress.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
               
            } 
            Customer _customer = new Customer(textBoxFullName.Text, textBoxAdress.Text);
            _customers.Add(_customer);
            listBoxCustomer.Items.Add(_customer);
            ClearInfo();
        }


        private void ClearInfo()
        {
            textBoxId2.Clear();
            textBoxFullName.Clear();
            textBoxAdress.Clear();
            textBoxFullName.BackColor = Color.White;
            textBoxAdress.BackColor = Color.White;
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            textBoxFullName.BackColor = Color.White;
            if (IsNumeric(textBoxFullName.Text))
            {
                textBoxFullName.BackColor = Color.Red;
            }
            else
            { 
                if (selectedIndex >= 0 && listBoxCustomer.SelectedItem != null)
                {
                    try
                    {
                        Customer selectedCustomer = (Customer)listBoxCustomer.SelectedItem;
                        if (IsNumeric(textBoxFullName.Text))
                        {
                            textBoxFullName.BackColor = Color.Red;
                            MessageBox.Show("Имя не должно содержать числовые значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        selectedCustomer.Fullname = textBoxFullName.Text;
                        int currentIndex = selectedIndex;
                        listBoxCustomer.Items.RemoveAt(currentIndex); // Удаляем старый элемент
                        listBoxCustomer.Items.Insert(currentIndex, selectedCustomer); // Добавляем обновлённый элемент

                        // Выбираем элемент снова для корректного отображения
                        listBoxCustomer.SelectedIndex = currentIndex;

                        // Возвращаем нормальный цвет фона текстбокса
                        textBoxFullName.BackColor = SystemColors.Window;
                    
                    }
                    catch (Exception ex)
                    {
                        textBoxFullName.BackColor = Color.Red;
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void textBoxAdress_TextChanged(object sender, EventArgs e)
        {
            if (selectedIndex>=0 && listBoxCustomer.SelectedItem != null)
            {
                try
                {
                    Customer selectedCustomer = (Customer)listBoxCustomer.SelectedItem;
                    selectedCustomer.Address = textBoxAdress.Text;
                    int currentIndex = selectedIndex;
                    listBoxCustomer.Items.RemoveAt(currentIndex); // Удаляем старый элемент
                    listBoxCustomer.Items.Insert(currentIndex, selectedCustomer); // Добавляем обновлённый элемент

                    // Выбираем элемент снова для корректного отображения
                    listBoxCustomer.SelectedIndex = currentIndex;

                    // Возвращаем нормальный цвет фона текстбокса
                    textBoxAdress.BackColor = SystemColors.Window;
                }
                catch (Exception ex)
                {
                    textBoxAdress.BackColor = Color.Red; 
                }
            }
        }

        private void buttonRemoveCustomer_Click(object sender, EventArgs e)
        {
            
            if (listBoxCustomer.SelectedIndex != -1)
            {
                _customers.RemoveAt(listBoxCustomer.SelectedIndex);
                listBoxCustomer.Items.RemoveAt(listBoxCustomer.SelectedIndex);
                ClearInfo();
            }
        }

        private void listBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listBoxCustomer.SelectedIndex;
            if (listBoxCustomer.SelectedItem != null)
            {
                Customer CurrentCustem = (Customer)listBoxCustomer.SelectedItem;
                textBoxId2.Text = CurrentCustem.Id.ToString();
                textBoxFullName.Text = CurrentCustem.Fullname;
                textBoxAdress.Text = CurrentCustem.Address;
            }
        }

        
        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true; // Если хотя бы один символ — цифра, возвращаем true
                }
            }
            return false; // Если нет цифр, возвращаем false
        }
    }
}
