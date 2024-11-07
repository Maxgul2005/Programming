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
    public partial class CartsTabs : UserControl
    {
        private Item _items;
        private Customer _customer;
        private Customer _currentCustomer;
        public List<Item> Items { get; set; }
        public List<Customer> Customers { get; set; }


        public void RefrechData()
        {
            if (Items != null)
            {
                listBoxForItem.Items.Clear();
                listBoxForItem.Items.AddRange(Items.ToArray());
            }
            if (Customers != null)
            {
                comboBoxForCustomer.Items.Clear();
                comboBoxForCustomer.Items.AddRange(Customers.ToArray());
            }
        }

        private void UpdateAmount()
        {

            if (_currentCustomer == null)
            {
                AmountLabel.Text = "0";
                return;
            };
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }


        private void ClearCart()
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Clear();
                listBoxForCart.Items.Clear();
            }
        }



        public CartsTabs()
        {
            RefrechData();
            InitializeComponent();
            AddCartButton.Enabled = false;

        }

        private void comboBoxForCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxForCustomer.SelectedIndex != -1)
            {
                AddCartButton.Enabled = true;
                listBoxForCart.Items.Clear();
                _currentCustomer = Customers[comboBoxForCustomer.SelectedIndex];
                listBoxForCart.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
                UpdateAmount();
            }

            else
            {
                AddCartButton.Enabled = false;
            }
        }

        private void AddCartButton_Click(object sender, EventArgs e)
        {
            if (listBoxForItem.SelectedIndex != -1)
            {

                _currentCustomer.Cart.Items.Add((Item)listBoxForItem.SelectedItem);
                listBoxForCart.Items.Add(listBoxForItem.SelectedItem);
                listBoxForItem.SelectedIndex = -1;
                UpdateAmount();
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (listBoxForCart.Items.Count != 0)
            {
                string year = DateTime.Now.Year.ToString();
                string month = DateTime.Now.Month.ToString();
                string day = DateTime.Now.Day.ToString();
                string hour = DateTime.Now.Hour.ToString();
                string minute = DateTime.Now.Minute.ToString();
                string Date = day + "." + month + "." + year + ". " + hour + ":" + minute;
                List<Item> items = _currentCustomer.Cart.Items;
                Order newOrder;
                if (_currentCustomer.IsPriority == true)
                {
                    newOrder = new PriorityOrder(OrderStatus.New, Date, items, _currentCustomer.Address, DateTime.Now, DeliveryTimeRange.Range9To11);
                }
                else
                {
                    newOrder = new Order(OrderStatus.New, Date, items, _currentCustomer.Address);
                }




                _currentCustomer.Orders.Add(newOrder);


                items.Clear();
                ClearCart();
                UpdateAmount();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (listBoxForCart.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.RemoveAt(listBoxForCart.SelectedIndex);
                listBoxForCart.Items.RemoveAt(listBoxForCart.SelectedIndex);
                UpdateAmount();
            }
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            ClearCart();
            UpdateAmount();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxForItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
