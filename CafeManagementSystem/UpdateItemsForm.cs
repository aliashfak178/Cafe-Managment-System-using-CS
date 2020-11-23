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

namespace CafeManagementSystem
{
    public partial class UpdateItemsForm : Form
    {
        public UpdateItemsForm()
        {
            InitializeComponent();
        }

        private void UpdateItemsForm_Load(object sender, EventArgs e)
        {
            DataGridView2.DataSource = GetAllData();
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

        private DataTable DtItems;
        private DataTable GetAllData()
        {
            DtItems = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_SelectAllItems", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtItems.Load(reader);
                }
            }
            return DtItems;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView DVitems = DtItems.DefaultView;
            DVitems.RowFilter = "ItemName LIKE '%" + SearchTextBox.Text + "%'";
        }

        private int ItemID;
        private void DataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int RowToUpdate = DataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected);
             ItemID= (int)DataGridView2.Rows[RowToUpdate].Cells["ItemID"].Value;

            DataTable DtItemInfo = GetItemByID(ItemID);
            DataRow row = DtItemInfo.Rows[0];
            CategoryComboBox.Text = row["Category"].ToString();
            ItemNameTextBox.Text = row["ItemName"].ToString();
            PriceTextBox.Text = row["price"].ToString();

        }

        private DataTable GetItemByID(int ItemID)
        {
            DataTable Dtinfo = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_SelectIteminfo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ItemID", ItemID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dtinfo.Load(reader);
                }
            }
            return Dtinfo;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Really Want To Update This Record", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                UpdateAllItems();
                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CategoryComboBox.SelectedIndex = -1;
                ItemNameTextBox.Clear();
                PriceTextBox.Clear();
            }
        }

        private void UpdateAllItems()
        {
            
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UpdateAllRecords", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@ItemID", ItemID);
                    cmd.Parameters.AddWithValue("@Category", CategoryComboBox.Text);
                    cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Price",PriceTextBox.Text);
                    //Execute The Command
                    cmd.ExecuteNonQuery(); 
                }
            }
        }
        


    }
}
