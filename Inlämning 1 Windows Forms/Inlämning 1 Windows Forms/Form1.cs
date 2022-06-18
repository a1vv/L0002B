using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämning_1_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // make columns fill up the available space
            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = listView.Width / listView.Columns.Count;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pris = pris_text.Text;
            string betalt = betalt_text.Text;

            // clear the list before adding new items
            listView.Items.Clear();

            if (string.IsNullOrEmpty(pris) || string.IsNullOrEmpty(betalt))
                return;
            
            int parsedPrice = int.Parse(pris);
            int parsedAmount = int.Parse(betalt);

            // show a dialog if the entered amount is smaller than the price
            if (parsedAmount < parsedPrice)
            {
                MessageBox.Show($"Ingen växel möjlig! Det saknas {parsedPrice - parsedAmount}kr.");
                return;
            }


            // denominations
            Int32[] denoms = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            // create array to hold values of change
            Int32[] change = new Int32[denoms.Length];
            int remainingAmount = parsedAmount - parsedPrice;

            // loop through all denominators, descending order, and calculate the count of each. 
            for (int i = denoms.Length - 1; i >= 0; i--)
            {
                change[i] = (remainingAmount) / denoms[i];
                remainingAmount = remainingAmount - change[i] * denoms[i];

                // Add to listview if the denominator is used at least once
                if (change[i] > 0)
                {
                    ListViewItem item = new ListViewItem(denoms[i].ToString());
                    item.SubItems.Add(change[i].ToString());
                    listView.Items.Add(item);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pris_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputAllowed(e);
        }

        private void betalt_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputAllowed(e);
        }

        private Boolean InputAllowed(KeyPressEventArgs e)
        {
            // set KeyPressEvent as handled if the char isn't a Digit or Backspace.
            return  !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
