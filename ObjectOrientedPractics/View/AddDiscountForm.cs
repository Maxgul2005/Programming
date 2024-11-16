using ObjectOrientedPractics.Model.Discounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class AddDiscountForm : Form
    {
        public PercentDiscount Discount { get; set; } = new PercentDiscount();
        public AddDiscountForm()
        {
            InitializeComponent();
            DiscountCategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (DiscountCategoryComboBox.SelectedItem != null)
            {
               
                Discount.DiscountCategory = (Category)DiscountCategoryComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
