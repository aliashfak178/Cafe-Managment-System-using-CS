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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GuestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoardForm DBF = new DashBoardForm("Guest");
            DBF.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                bool IsUserNameCurrect, IsPasswordCurrect;
                GetIsUserLoginCurrect(out IsUserNameCurrect, out IsPasswordCurrect);
                if (IsUserNameCurrect && IsPasswordCurrect)
                {
                    DashBoardForm dbf = new DashBoardForm();
                    dbf.Show();
                    this.Hide();
                }
                else
                {
                    if (!IsUserNameCurrect)
                    {
                        MessageBox.Show("UserName is Not Currect.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UserNameTextBox.Clear();
                        PasswordTextBox.Clear();
                        UserNameTextBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Password is Not Currect.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PasswordTextBox.Clear();
                        PasswordTextBox.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter User Name And Password","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void GetIsUserLoginCurrect(out bool IsUserNameCurrect, out bool IsPasswordCurrect)
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UserChackLoginDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //output parameters
                    cmd.Parameters.Add("@IsUserNameCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@IsPasswordCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    //parameters
                    cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                    //Execute The Command
                    cmd.ExecuteNonQuery();

                    //Passed Parameter's Values From Db
                    IsUserNameCurrect = (bool)cmd.Parameters["@IsUserNameCurrect"].Value;
                    IsPasswordCurrect = (bool)cmd.Parameters["@IsPasswordCurrect"].Value;
                }
            }
        }

        private bool isValid()
        {
            if(UserNameTextBox.Text.Trim()==string.Empty)
            {
                return false;
            }
            if(PasswordTextBox.Text.Trim()==string.Empty)
            {
                return false;
            }
            return true;
        }

    }
}
