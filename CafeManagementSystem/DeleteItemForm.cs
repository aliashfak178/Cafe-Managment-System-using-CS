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
    public partial class DeleteItemForm : Form
    {
        public DeleteItemForm()
        {
            InitializeComponent();
        }

        private void DeleteItemForm_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How To Delete?";
            DelLabel.ForeColor = Color.Blue;

            GetItremInGridView();
        }

        private void GetItremInGridView()
        {
            ItemsDataGridView.DataSource = GetAllDatas();
        }

        private DataTable DtItems;
        private DataTable GetAllDatas()
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

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.Text = "Double Click on Row To Delete items...";
            DelLabel.ForeColor = Color.Red;
        }
        
        private void ItemsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int RowToUpdate = ItemsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int ItemID = (int)ItemsDataGridView.Rows[RowToUpdate].Cells["ItemID"].Value;

            DialogResult result= MessageBox.Show("Are You Really Want To Delete This Item","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result== DialogResult.Yes)
            {
                DeleteItems(ItemID);
                GetItremInGridView();
            }
        }

        private void DeleteItems(int ItemID)
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DeleteItems", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@ItemID", ItemID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
