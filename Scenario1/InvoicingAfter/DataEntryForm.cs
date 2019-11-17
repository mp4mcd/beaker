using InvoicingAfter.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoicingAfter
{
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> entries = new Dictionary<string, decimal>();
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
                entries.Add(row.Cells[0].Value.ToString(), tempDecimal);
            }

            InvoiceOutput output = new Invoice(entries).CalculateOutput();
            lblSubtotal.Text = output.SubTotal.ToString("#,##0.00");
            lblTax.Text = output.Tax.ToString("#,##0.00");
            lblDiscount.Text = output.Discount.ToString("#,##0.00");
            lblGrandTotal.Text = output.GrandTotal.ToString("#,##0.00");
        }

    }
}
