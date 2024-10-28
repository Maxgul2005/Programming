using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
           
        }

        private List<Customer> _customers = new List<Customer>(); // Поле для хранения покупателей
        private Customer _currentCustomer;
        private List <string> CustomersListBoxItems = new List<string>();


        /// <summary>
        /// Получает или задает список клиентов.
        /// При установке значения добавляет клиентов в ListBox.
        /// </summary>
        /// <value>Список объектов <see cref="Customer"/>, представляющий клиентов.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customer
        {
            get { return _customers; }
            set
            {
                _customers = value;
               
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
           if (String.IsNullOrEmpty(textBoxFullName.Text) || addressControl1.AddressIsNullOrEmpty())
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (IsNumeric(textBoxFullName.Text))
            {
                MessageBox.Show("FullName имеет только строковой тип");
                return;
            } 

            Customer NewCustomer = new Customer();
            NewCustomer.Fullname = textBoxFullName.Text;
            NewCustomer.Address = addressControl1.GiveValues();

            Customer.Add(NewCustomer);
            CustomersListBoxItems.Add($"{NewCustomer.Id.ToString()})");
            listBoxCustomer.Items.Add(CustomersListBoxItems[CustomersListBoxItems.Count - 1]);
            ClearInfo();


        }

        private void ClearInfo()
        {
            textBoxId2.Clear();
            textBoxFullName.Clear();
            addressControl1.ClearTextBox();
            textBoxFullName.BackColor = Color.White;
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            if (listBoxCustomer.SelectedIndex != -1)
            {
                
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
            
            if (listBoxCustomer.SelectedIndex == -1 || listBoxCustomer.Items.Count ==0)
            {
                addressControl1.IsUpdatingFieldFlag = true;
                buttonAddCustomer.Enabled = true;
                ClearInfo();    
            }
            else
            {
                addressControl1.IsUpdatingFieldFlag = false;
                buttonAddCustomer.Enabled = false;
                int selectedIndex = listBoxCustomer.SelectedIndex;
                if (selectedIndex == -1) return;
                _currentCustomer = Customer[selectedIndex];
                textBoxId2.Text = _currentCustomer.Id.ToString();
                textBoxFullName.Text = _currentCustomer.Fullname;

                addressControl1.UpdateData(_currentCustomer.Address);

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

        /// <summary>
        /// Обработчик события клика мыши по списку клиентов.
        /// Очищает выделение, если кликнули не по элементу списка.
        /// </summary>
        private void listBoxCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxCustomer.IndexFromPoint(e.Location) == -1)
            {
                addressControl1.IsUpdatingFieldFlag = false;
                listBoxCustomer.ClearSelected();
                ClearInfo();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
