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
    public partial class AddItemsForm : Form
    {
        public AddItemsForm()
        {
            InitializeComponent();
        }

        private void ExistingCategoryButton_Click(object sender, EventArgs e)
        {
            NewCategoryTextBox.Enabled = false;
            NewCatogoryButton.Enabled = true;
            ExistingCategoryButton.Enabled = false;
            CategoryComboBox.Enabled = true;
        }

        private void NewCatogoryButton_Click(object sender, EventArgs e)
        {
            ExistingCategoryButton.Enabled = true;
            CategoryComboBox.Enabled = false;
            NewCategoryTextBox.Enabled = true;
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string TempCategory;
                if (NewCategoryTextBox.Enabled == true)
                {
                    TempCategory = NewCategoryTextBox.Text;
                }
                else
                {
                    TempCategory = CategoryComboBox.Text;
                }
                AddAllItems(TempCategory);
                MessageBox.Show("Record Inserted Seccessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllRecords();
            }
            else
            {
                MessageBox.Show("Please Fill All Records First","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ClearAllRecords();
            }
        }

        private void AddAllItems(string TempCategory)
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_AddItems", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Category", TempCategory);
                    cmd.Parameters.AddWithValue("@ItemName", ItemNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Price", PriceTextBox.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ClearAllRecords()
        {
            
            NewCategoryTextBox.Clear();
            ItemNameTextBox.Clear();
            PriceTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
        }

        private bool IsValid()
        {
            if (NewCategoryTextBox.Enabled==true)
            {
                if (NewCategoryTextBox.Text.Trim() == string.Empty)
                {
                    return false;
                }
            }
            if (CategoryComboBox.Enabled == true)
            {
                if (CategoryComboBox.SelectedIndex == -1)
                {
                    return false;
                }
            }
            if (ItemNameTextBox.Text.Trim() == string.Empty)
            {
                return false;
            }
            if (PriceTextBox.Text.Trim() == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void AddItemsForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = GetCategory();
            CategoryComboBox.DisplayMember = "Category";
            CategoryComboBox.SelectedIndex = -1;
        }

        private DataTable GetCategory()
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

    }
}
