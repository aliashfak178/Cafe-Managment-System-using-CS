namespace CafeManagementSystem
{
    partial class UpdateItemsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 45);
            this.label2.TabIndex = 16;
            this.label2.Text = "Update Items";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.Parent = this.SearchTextBox;
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.FocusedState.Parent = this.SearchTextBox;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.HoverState.Parent = this.SearchTextBox;
            this.SearchTextBox.Location = new System.Drawing.Point(530, 62);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "Search";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.ShadowDecoration.Parent = this.SearchTextBox;
            this.SearchTextBox.Size = new System.Drawing.Size(245, 36);
            this.SearchTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchTextBox.TabIndex = 18;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(524, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Item Name";
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToAddRows = false;
            this.DataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView2.ColumnHeadersHeight = 21;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView2.EnableHeadersVisualStyles = false;
            this.DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView2.Location = new System.Drawing.Point(24, 107);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.ReadOnly = true;
            this.DataGridView2.RowHeadersVisible = false;
            this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView2.Size = new System.Drawing.Size(751, 194);
            this.DataGridView2.TabIndex = 20;
            this.DataGridView2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView2.ThemeStyle.HeaderStyle.Height = 21;
            this.DataGridView2.ThemeStyle.ReadOnly = true;
            this.DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView2.DoubleClick += new System.EventHandler(this.DataGridView2_DoubleClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Animated = true;
            this.UpdateButton.BorderRadius = 15;
            this.UpdateButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.UpdateButton.CheckedState.Parent = this.UpdateButton;
            this.UpdateButton.CustomImages.Parent = this.UpdateButton;
            this.UpdateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.HoverState.Parent = this.UpdateButton;
            this.UpdateButton.Location = new System.Drawing.Point(499, 400);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.ShadowDecoration.Parent = this.UpdateButton;
            this.UpdateButton.Size = new System.Drawing.Size(246, 46);
            this.UpdateButton.TabIndex = 23;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(51, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Item Name";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ItemNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemNameTextBox.DefaultText = "";
            this.ItemNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ItemNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ItemNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemNameTextBox.DisabledState.Parent = this.ItemNameTextBox;
            this.ItemNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemNameTextBox.FocusedState.Parent = this.ItemNameTextBox;
            this.ItemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ItemNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.ItemNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemNameTextBox.HoverState.Parent = this.ItemNameTextBox;
            this.ItemNameTextBox.Location = new System.Drawing.Point(56, 415);
            this.ItemNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.PasswordChar = '\0';
            this.ItemNameTextBox.PlaceholderText = "Start Typing...";
            this.ItemNameTextBox.ReadOnly = true;
            this.ItemNameTextBox.SelectedText = "";
            this.ItemNameTextBox.ShadowDecoration.Parent = this.ItemNameTextBox;
            this.ItemNameTextBox.Size = new System.Drawing.Size(256, 36);
            this.ItemNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ItemNameTextBox.TabIndex = 22;
            this.ItemNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(494, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextBox.DefaultText = "";
            this.PriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTextBox.DisabledState.Parent = this.PriceTextBox;
            this.PriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTextBox.FocusedState.Parent = this.PriceTextBox;
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceTextBox.ForeColor = System.Drawing.Color.Black;
            this.PriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTextBox.HoverState.Parent = this.PriceTextBox;
            this.PriceTextBox.Location = new System.Drawing.Point(499, 344);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.PlaceholderText = "Start Typing...";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.ShadowDecoration.Parent = this.PriceTextBox;
            this.PriceTextBox.Size = new System.Drawing.Size(256, 36);
            this.PriceTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PriceTextBox.TabIndex = 22;
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CategoryComboBox.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryComboBox.FocusedState.Parent = this.CategoryComboBox;
            this.CategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.ForeColor = System.Drawing.Color.Black;
            this.CategoryComboBox.HoverState.Parent = this.CategoryComboBox;
            this.CategoryComboBox.ItemHeight = 30;
            this.CategoryComboBox.ItemsAppearance.Parent = this.CategoryComboBox;
            this.CategoryComboBox.Location = new System.Drawing.Point(56, 341);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.ShadowDecoration.Parent = this.CategoryComboBox;
            this.CategoryComboBox.Size = new System.Drawing.Size(281, 36);
            this.CategoryComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CategoryComboBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(51, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Category";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(807, 477);
            this.shapeContainer1.TabIndex = 26;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.YellowGreen;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 21;
            this.rectangleShape1.Location = new System.Drawing.Point(7, 11);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(784, 455);
            // 
            // UpdateItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UpdateItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateItemsForm";
            this.Load += new System.EventHandler(this.UpdateItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView2;
        private Guna.UI2.WinForms.Guna2Button UpdateButton;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox ItemNameTextBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox PriceTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}