using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
            addressControl = new AddressControl();
            ClearInfo();
        }

        private List<Customer> _customers = new List<Customer>(); // Поле для хранения покупателей
        private Customer _currentCustomer;
        private AddressControl addressControl;

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFullName.Text) || addressControl.Address == null)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (IsNumeric(textBoxFullName.Text))
            {
                MessageBox.Show("FullName имеет только строковой тип");
                return;
            }

            Customer _customer = new Customer(textBoxFullName.Text, addressControl.Address); // Используем AddressControl
            _customers.Add(_customer);
            listBoxCustomer.Items.Add(_customer);
            _currentCustomer = null;
            ClearInfo();
        }

        private void ClearInfo()
        {
            textBoxId2.Clear();
            textBoxFullName.Clear();
            addressControl.Address = new Address(); // Сбрасываем AddressControl
            textBoxFullName.BackColor = Color.White;
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                string newFullName = textBoxFullName.Text;
                if (IsNumeric(newFullName))
                {
                    textBoxFullName.BackColor = Color.Pink;
                    return;
                }
                else
                {
                    textBoxFullName.BackColor = Color.White;
                    _currentCustomer.Fullname = newFullName;
                    int selectedIndex = listBoxCustomer.SelectedIndex;
                    listBoxCustomer.Items[selectedIndex] = _currentCustomer;
                }
            }
        }

        private void buttonRemoveCustomer_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCustomer.SelectedIndex;
            if (selectedIndex != -1)
            {
                _customers.RemoveAt(selectedIndex);
                listBoxCustomer.Items.RemoveAt(selectedIndex);
                _currentCustomer = null;
                ClearInfo();
            }
        }

        private void listBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCustomer.SelectedIndex;
            if (selectedIndex != -1)
            {
                _currentCustomer = _customers[selectedIndex];
                textBoxId2.Text = _currentCustomer.Id.ToString();
                textBoxFullName.Text = _currentCustomer.Fullname;
                addressControl.Address = _currentCustomer.Address; // Передаем адрес в AddressControl
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
