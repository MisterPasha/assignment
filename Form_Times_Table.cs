using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Programming_Design
{
    public partial class frmTimesTable : Form
    {
        public frmTimesTable()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function generates columns in times table of the particular size based on the user input.
        /// </summary>

        private void spnCols_ValueChanged(object sender, EventArgs e)
        {
            String[] arr = new string[Convert.ToInt32(spnCols.Value) + 1];      // Array that stores all values in one row
            lstViewTable.Items.Clear();                                         // Clears the table.
            int TimesCounter = 0;                                               // Counter that used for multiplications within the table
            int TimesCounterVertical = 0;                                       // Counter that used to build a yellow borders for the table
            int RedCellCounter = -1;                                            // Counter to draw red cells

            while (lstViewTable.Columns.Count < spnCols.Value + 1)              // Adds columns in the ListView
            {                                                                   //
                                                                                //
                lstViewTable.Columns.Add("", 36);                               // Size of 36 pixels

            }

            lstViewTable.GridLines = true;

            lstViewTable.Size = new Size(36 * Convert.ToInt32(spnCols.Value + 1), 22 * Convert.ToInt32(spnRows.Value + 1));  // Sets the size of the table

            for (int row = 0; row < spnRows.Value + 1; row++)
            {
                if (row > 0)                              // When row is 0 counters don't increase
                {
                    TimesCounter++;
                    TimesCounterVertical++;
                }

                for (int col = 0; col < spnCols.Value + 1; col++)
                {
                    if (row == 0)                                     // Draws first line of numbers only
                    {
                        if (col == 0)
                        {
                            arr[col] = "X";
                        }
                        else
                        {
                            arr[col] = Convert.ToString(col);
                        }
                    }
                    else                                                         // Calculates the multiplied numbers
                    {
                        if (col == 0)
                        {
                            arr[col] = Convert.ToString(TimesCounterVertical);
                        }
                        else
                        {
                            arr[col] = Convert.ToString((col) * TimesCounter);
                        }
                    }
                }
                ListViewItem itm = new ListViewItem(arr);
                lstViewTable.Items.Add(itm);
            }

            for (int row = 0; row < spnRows.Value + 1; row++)                     // Paint particular cells in particular colours
            {
                RedCellCounter++;
                lstViewTable.Items[row].UseItemStyleForSubItems = false;

                for (int col = 0; col < spnCols.Value + 1; col++)
                {
                    if (row == 0)
                    {
                        lstViewTable.Items[row].SubItems[col].BackColor = Color.Yellow;
                    }
                    else if (col == 0)
                    {
                        lstViewTable.Items[row].SubItems[col].BackColor = Color.Yellow;
                    }
                    else if (col == RedCellCounter)
                    {
                        lstViewTable.Items[row].SubItems[col].BackColor = Color.Red;
                    }
                }
            }
        }

        /// <summary>
        /// This function generates rows in times table of the particular size based on the user input.
        /// </summary>

        private void spnRows_ValueChanged(object sender, EventArgs e)
        {
            String[] arr = new string[Convert.ToInt32(spnCols.Value) + 1];      // Array that stores all values in one row
            lstViewTable.Items.Clear();                                         // Clears the table.
            int TimesCounter = 0;                                               // Counter that used for multiplications within the table
            int TimesCounterVertical = 0;                                       // Counter that used to build a yellow borders for the table
            int RedCellCounter = -1;                                            // Counter to draw red cells

            while (lstViewTable.Columns.Count < spnCols.Value + 1)              // Adds columns in the ListView
            {                                                                   //
                                                                                //
                lstViewTable.Columns.Add("", 36);                               // Size of 36 pixels

            }

            lstViewTable.GridLines = true;

            lstViewTable.Size = new Size(36 * Convert.ToInt32(spnCols.Value + 1), 22 * Convert.ToInt32(spnRows.Value + 1));  // Sets the size of the table

            for (int row = 0; row < spnRows.Value + 1; row++)
            {
                if (row > 0)                              // When row is 0 counters don't increase
                {
                    TimesCounter++;
                    TimesCounterVertical++;
                }

                for (int col = 0; col < spnCols.Value + 1; col++)
                {
                    if (row == 0)                                     // Draws first line of numbers only
                    {
                        if (col == 0)
                        {
                            arr[col] = "X";
                        }
                        else
                        {
                            arr[col] = Convert.ToString(col);
                        }
                    }
                    else                                                         // Calculates the multiplied numbers
                    {
                        if (col == 0)
                        {
                            arr[col] = Convert.ToString(TimesCounterVertical);
                        }
                        else
                        {
                            arr[col] = Convert.ToString((col) * TimesCounter);
                        }
                    }
                }
                ListViewItem itm = new ListViewItem(arr);
                lstViewTable.Items.Add(itm);
            }

            for (int row = 0; row < spnRows.Value + 1; row++)                     // Paint particular cells in particular colours
            {
                RedCellCounter++;
                lstViewTable.Items[row].UseItemStyleForSubItems = false;

                for (int col = 0; col < spnCols.Value + 1; col++)
                {
                    if (row == 0)
                    {
                        lstViewTable.Items[row].SubItems[col].BackColor = Color.Yellow;
                    }
                    else if (col == 0)
                    {
                        lstViewTable.Items[row].SubItems[col].BackColor = Color.Yellow;
                    }
                    else if (col == RedCellCounter)
                    {
                        lstViewTable.Items[row].SubItems[col].BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
