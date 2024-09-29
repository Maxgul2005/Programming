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
        private Customer _currentCustomer;
        
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {

           if (String.IsNullOrEmpty(textBoxFullName.Text) || String.IsNullOrEmpty(textBoxAdress.Text))
           {
                MessageBox.Show("Заполните все поля");
                return;
               
           } 
           if (IsNumeric(textBoxFullName.Text))
           {
                MessageBox.Show("FullName имеет только строковой тип");
                return;
           }
           Customer _customer = new Customer(textBoxFullName.Text, textBoxAdress.Text);
           _customers.Add(_customer);
           listBoxCustomer.Items.Add(_customer);
           _currentCustomer = null;
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
                if (_currentCustomer!= null)
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

        private void textBoxAdress_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                string newAdress = textBoxAdress.Text;
                _currentCustomer.Address = newAdress;
                int selectedIndex = listBoxCustomer.SelectedIndex;
                listBoxCustomer.Items[selectedIndex] = _currentCustomer;
            }
        }

        private void buttonRemoveCustomer_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxCustomer.SelectedIndex;
            if (SelectedIndex != -1)
            {
                _customers.RemoveAt(SelectedIndex);
                listBoxCustomer.Items.RemoveAt(SelectedIndex);
                _currentCustomer = null;
                ClearInfo() ;
            }
        }

        private void listBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxCustomer.SelectedIndex;
            if (SelectedIndex != -1)
            {
                _currentCustomer = _customers[SelectedIndex];
                textBoxId2.Text = _currentCustomer.Id.ToString();
                textBoxFullName.Text = _currentCustomer.Fullname;
                textBoxAdress.Text = _currentCustomer.Address;

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
