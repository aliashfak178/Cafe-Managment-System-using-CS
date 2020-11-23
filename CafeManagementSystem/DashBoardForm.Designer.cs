namespace CafeManagementSystem
{
    partial class DashBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.LinkLabel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.DeleteItemButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateItemButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.PlaceOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(215, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 515);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.LogOutButton);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.DeleteItemButton);
            this.panel2.Controls.Add(this.UpdateItemButton);
            this.panel2.Controls.Add(this.AddOrderButton);
            this.panel2.Controls.Add(this.PlaceOrderButton);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 515);
            this.panel2.TabIndex = 0;
            // 
            // LogOutButton
            // 
            this.LogOutButton.AutoSize = true;
            this.LogOutButton.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.LinkColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(46, 464);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(88, 28);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.TabStop = true;
            this.LogOutButton.Text = "LogOut";
            this.LogOutButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutButton_LinkClicked);
            // 
            // ExitButton
            // 
            this.ExitButton.Animated = true;
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.CustomImages.Parent = this.ExitButton;
            this.ExitButton.FillColor = System.Drawing.Color.BlueViolet;
            this.ExitButton.FillColor2 = System.Drawing.Color.Cyan;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.Location = new System.Drawing.Point(3, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(47, 43);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Animated = true;
            this.DeleteItemButton.BorderRadius = 14;
            this.DeleteItemButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DeleteItemButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.DeleteItemButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.DeleteItemButton.CheckedState.Parent = this.DeleteItemButton;
            this.DeleteItemButton.CustomImages.Parent = this.DeleteItemButton;
            this.DeleteItemButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.DeleteItemButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItemButton.ForeColor = System.Drawing.Color.White;
            this.DeleteItemButton.HoverState.Parent = this.DeleteItemButton;
            this.DeleteItemButton.Location = new System.Drawing.Point(22, 263);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.ShadowDecoration.Parent = this.DeleteItemButton;
            this.DeleteItemButton.Size = new System.Drawing.Size(202, 41);
            this.DeleteItemButton.TabIndex = 0;
            this.DeleteItemButton.Text = "Delete Items";
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.Animated = true;
            this.UpdateItemButton.BorderRadius = 14;
            this.UpdateItemButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UpdateItemButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.UpdateItemButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.UpdateItemButton.CheckedState.Parent = this.UpdateItemButton;
            this.UpdateItemButton.CustomImages.Parent = this.UpdateItemButton;
            this.UpdateItemButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.UpdateItemButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemButton.ForeColor = System.Drawing.Color.White;
            this.UpdateItemButton.HoverState.Parent = this.UpdateItemButton;
            this.UpdateItemButton.Location = new System.Drawing.Point(22, 200);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.ShadowDecoration.Parent = this.UpdateItemButton;
            this.UpdateItemButton.Size = new System.Drawing.Size(202, 41);
            this.UpdateItemButton.TabIndex = 0;
            this.UpdateItemButton.Text = "Update Items";
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateItemButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Animated = true;
            this.AddOrderButton.BorderRadius = 14;
            this.AddOrderButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddOrderButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddOrderButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.AddOrderButton.CheckedState.Parent = this.AddOrderButton;
            this.AddOrderButton.CustomImages.Parent = this.AddOrderButton;
            this.AddOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.AddOrderButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.HoverState.Parent = this.AddOrderButton;
            this.AddOrderButton.Location = new System.Drawing.Point(22, 138);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.ShadowDecoration.Parent = this.AddOrderButton;
            this.AddOrderButton.Size = new System.Drawing.Size(202, 41);
            this.AddOrderButton.TabIndex = 0;
            this.AddOrderButton.Text = "Add Item";
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Animated = true;
            this.PlaceOrderButton.BorderRadius = 14;
            this.PlaceOrderButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.PlaceOrderButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.PlaceOrderButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.PlaceOrderButton.CheckedState.Parent = this.PlaceOrderButton;
            this.PlaceOrderButton.CustomImages.Parent = this.PlaceOrderButton;
            this.PlaceOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.PlaceOrderButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderButton.ForeColor = System.Drawing.Color.White;
            this.PlaceOrderButton.HoverState.Parent = this.PlaceOrderButton;
            this.PlaceOrderButton.Location = new System.Drawing.Point(22, 83);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.ShadowDecoration.Parent = this.PlaceOrderButton;
            this.PlaceOrderButton.Size = new System.Drawing.Size(202, 41);
            this.PlaceOrderButton.TabIndex = 0;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1050, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardForm";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button UpdateItemButton;
        private Guna.UI2.WinForms.Guna2Button AddOrderButton;
        private Guna.UI2.WinForms.Guna2Button PlaceOrderButton;
        private Guna.UI2.WinForms.Guna2Button DeleteItemButton;
        private Guna.UI2.WinForms.Guna2GradientCircleButton ExitButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel LogOutButton;
    }
}