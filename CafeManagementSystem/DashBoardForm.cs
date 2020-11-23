using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }
        public DashBoardForm(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                AddOrderButton.Hide();
                UpdateItemButton.Hide();
                DeleteItemButton.Hide();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Yoy Are Realy Whant To Logout?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm LF = new LoginForm();
                LF.Show();
                this.Hide();
            }
        }
        private Form ActiveForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        //private Form OpenChildForm(Form ChildForm)
        //{
        //    if (ActiveForm != null)
        //        ActiveForm.Close();
        //    ActiveForm = ChildForm;
        //    ChildForm.TopLevel = false;
        //    ChildForm.FormBorderStyle = FormBorderStyle.None;
        //    ChildForm.Dock = DockStyle.Fill;
        //    panel1.Controls.Add(ChildForm);
        //    panel1.Tag = ChildForm;
        //    ChildForm.BringToFront();
        //    ChildForm.Show();
        //    return ChildForm;
        //}

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new WelcomScreenForm());
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddItemsForm());
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PlaceOrderForm());
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateItemsForm());
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteItemForm());
        }

    }
}
