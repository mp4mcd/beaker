using System;
using System.Windows.Forms;

namespace InvoicingBefore
{
    public partial class DataEntryForm : Form
    {
        const decimal TAX_RATE = .08m;
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subTotalAmount = 0;

            foreach (DataGridViewRow row in grdItems.Rows)
            {
                if (row.Cells[1].Value == null)
                {
                    continue;
                }

                decimal tempDecimal = 0;
                bool ok = decimal.TryParse(row.Cells[1].Value.ToString(), out tempDecimal);
                if (!ok)
                {
                    continue;
                }
                subTotalAmount += (tempDecimal);
            }

            decimal discountAmount = subTotalAmount * .05m;
            decimal taxAmount = subTotalAmount * TAX_RATE;
            
            lblSubtotal.Text = subTotalAmount.ToString("#,##0.00");
            lblTax.Text = taxAmount.ToString("#,##0.00");
            lblDiscount.Text = discountAmount.ToString("#,##0.00");
            lblGrandTotal.Text = (subTotalAmount + taxAmount + discountAmount).ToString("#,##0.00");

        }
    }
}
