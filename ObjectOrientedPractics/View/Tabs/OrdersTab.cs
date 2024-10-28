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
    public partial class OrdersTab : UserControl
    {
         private List<Customer> _customers;
        private Customer _currentCustomer;
        public List<Customer> Customers { get; set; }
        public void UpdateOrders()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Created", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Full Name", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Amount", typeof(string));
            foreach (DataGridViewColumn column in OrdersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0;i<Customers.Count;i++)
            {
                _currentCustomer = Customers[i];
                for(int j = 0; j <_currentCustomer.Orders.Count; j++)
                {
                    dataTable.Rows.Add(_currentCustomer.Id, _currentCustomer.Orders[j].DateOfCreation, _currentCustomer.Orders[j].Status, _currentCustomer.Fullname, _currentCustomer.Address.AddressToString(), _currentCustomer.Orders[j].TotalCost.ToString());
                }
            }
            OrdersDataGridView.DataSource = dataTable;
        }
        public OrdersTab()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
