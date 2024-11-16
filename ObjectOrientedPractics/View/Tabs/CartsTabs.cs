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
                DiscountCheckedListBox.Items.Clear();
                _currentCustomer = Customers[comboBoxForCustomer.SelectedIndex];
                listBoxForCart.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
                for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
                {
                    DiscountCheckedListBox.Items.Add(_currentCustomer.Discounts[i].Info);
                    DiscountCheckedListBox.SetItemChecked(i, true);
                }
                UpdateAmount();
                UpdateDiscountAndTotalAmount();
            }

            else
            {
                AddCartButton.Enabled = false;
                DiscountCheckedListBox.Items.Clear();
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
                UpdateDiscountAndTotalAmount();
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
                    newOrder = new PriorityOrder(OrderStatus.New, Date, items, _currentCustomer.Address,  DateTime.Now, Convert.ToDouble(DiscountAmountLabel.Text), DeliveryTimeRange.Range9To11);
                }
                else
                {
                   newOrder = new Order(OrderStatus.New, Date, items, _currentCustomer.Address, Convert.ToDouble(DiscountAmountLabel.Text));
                }




               _currentCustomer.Orders.Add(newOrder);
                CreateOrder();
                ClearDiscountAndTotalLabels();


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
                UpdateDiscountAndTotalAmount();
            }
        }
        private void ClearDiscountAndTotalLabels()
        {
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = "0";
        }


        /// <summary>
        /// Обновляет сумму скидки и итоговую сумму заказа.
        /// </summary>
        private void UpdateDiscountAndTotalAmount()
        {
            int discountAmount = 0;
            ClearDiscountAndTotalLabels();
            if (_currentCustomer == null) return;
            foreach (int indexOfDiscount in DiscountCheckedListBox.CheckedIndices)
            {
                discountAmount += (int)_currentCustomer.Discounts[indexOfDiscount].Calculate(_currentCustomer.Cart.Items);
            }
            DiscountAmountLabel.Text = discountAmount.ToString();
            TotalLabel.Text = ((_currentCustomer.Cart.Amount - discountAmount).ToString());
        }

        /// <summary>
        /// Устанавливает флажки для всех элементов в списке скидок.
        /// </summary>
        private void CheckAllItems()
        {
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                DiscountCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            ClearCart();
            UpdateAmount();
            UpdateDiscountAndTotalAmount();
        }
        public int CreateOrder()
        {
            int discountAmount = 0;
            ClearDiscountAndTotalLabels();
            if (_currentCustomer == null) return 0;
            foreach (int indexOfDiscount in DiscountCheckedListBox.CheckedIndices)
            {
                discountAmount += (int)_currentCustomer.Discounts[indexOfDiscount].Apply(_currentCustomer.Cart.Items);
            }

            
            for (int indexOfDiscount = 0; indexOfDiscount < DiscountCheckedListBox.Items.Count; indexOfDiscount++)
            {
                _currentCustomer.Discounts[indexOfDiscount].Update(_currentCustomer.Cart.Items);
            }
            UpdateDiscountsCheckedListBox();
            return discountAmount;
        }
        /// <summary>
        /// Обновляет список доступных скидок в CheckedListBox.
        /// Устанавливает флажки для всех скидок.
        /// </summary>
        private void UpdateDiscountsCheckedListBox()
        {
            DiscountCheckedListBox.Items.Clear();
            if (_currentCustomer == null) return;
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                DiscountCheckedListBox.Items.Add(_currentCustomer.Discounts[i].Info);
            }
            CheckAllItems();
            UpdateDiscountAndTotalAmount();
        }
        private void DiscountCheckedListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateDiscountAndTotalAmount();
        }
    }
}
