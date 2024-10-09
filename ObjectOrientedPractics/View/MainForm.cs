using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;
        public MainForm()
        {
            InitializeComponent();
            InitializeStore();


        }

        private void InitializeStore()
        {
            _store = new Store();
            itemsTab1.Items = _store.Items;
            customersTab1.Customer = _store.Customers;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
