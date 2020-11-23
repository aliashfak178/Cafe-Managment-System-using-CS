using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace CafeManagementSystem
{
    public partial class PlaceOrderForm : Form
    {
        public PlaceOrderForm()
        {
            InitializeComponent();
            
        }

        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = GetCategorys();
            CategoryComboBox.DisplayMember = "Category";
            CategoryComboBox.SelectedIndex = -1;
        }

        private DataTable GetCategorys()
        {
            DataTable DtCategory = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetCategory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtCategory.Load(reader);
                }
            }
            return DtCategory;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemsListBox.DataSource = GetItems(CategoryComboBox.Text);
            ItemsListBox.DisplayMember = "ItemName";
        }

        private DataTable DtItems;
        private DataTable GetItems(string p)
        {
            DtItems = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllItems", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Categorys", p);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtItems.Load(reader);
                }
            }
            return DtItems;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView DVitems = DtItems.DefaultView;
            DVitems.RowFilter = "ItemName LIKE '%"+SearchTextBox.Text+"%'";
        }

        private void ItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            QuantityNumericUpDown.ResetText();
            TotalTextBox.Clear();
            string itemName = ItemsListBox.GetItemText(ItemsListBox.SelectedItem);
            ItemNameTextBox.Text = itemName;
            try
            {
                DataTable Dtitemprice = GetAndSetItemAndPrice(itemName);
                DataRow row = Dtitemprice.Rows[0];
                PriceTextBox.Text = row["price"].ToString();
            }
            catch { }
        }

        private DataTable GetAndSetItemAndPrice(string itemName)
        {
            DataTable Dtinfo = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_SetItemPrice", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dtinfo.Load(reader);
                }
            }
            return Dtinfo;
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int quan = Int32.Parse(QuantityNumericUpDown.Value.ToString());
            int price = Int32.Parse(PriceTextBox.Text);
            TotalTextBox.Text = (quan * price).ToString();
        }
        protected int n, total = 0;
        private void AddtoCartButton_Click(object sender, EventArgs e)
        {
            if (isValid() && TotalTextBox.Text != "0")
            {
                n = DataGridView1.Rows.Add();
                DataGridView1.Rows[n].Cells[0].Value = ItemNameTextBox.Text;
                DataGridView1.Rows[n].Cells[1].Value = PriceTextBox.Text;
                DataGridView1.Rows[n].Cells[2].Value = QuantityNumericUpDown.Value;
                DataGridView1.Rows[n].Cells[3].Value = TotalTextBox.Text;

                total += int.Parse(TotalTextBox.Text);
                GrandTotallabel.Text = "R.S " + total;
            }
            else
            {
                MessageBox.Show("Please Enter Valid Values","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private bool isValid()
        {
            if (PriceTextBox.Text.Trim() == string.Empty)
            {
                return false;
            }
            if (TotalTextBox.Text.Trim() == string.Empty)
            {
                return false;
            }
            return true;
        }

        private int amount;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView1.Rows.RemoveAt(this.DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            GrandTotallabel.Text = "R.S " + total;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer="Total Payble Amount : " +GrandTotallabel.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DataGridView1);
            total = 0;
            DataGridView1.Rows.Clear();
            GrandTotallabel.Text = "R.S " + total;

        }

        

    }
}
