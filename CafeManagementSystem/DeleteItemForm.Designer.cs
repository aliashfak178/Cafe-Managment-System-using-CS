namespace CafeManagementSystem
{
    partial class DeleteItemForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ItemsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(807, 477);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.DarkCyan;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 31;
            this.rectangleShape1.Location = new System.Drawing.Point(13, 11);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(778, 455);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(524, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Item Name";
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
            this.SearchTextBox.Location = new System.Drawing.Point(530, 76);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "Search";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.ShadowDecoration.Parent = this.SearchTextBox;
            this.SearchTextBox.Size = new System.Drawing.Size(245, 36);
            this.SearchTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchTextBox.TabIndex = 20;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AllowUserToAddRows = false;
            this.ItemsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ItemsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsDataGridView.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsDataGridView.EnableHeadersVisualStyles = false;
            this.ItemsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDataGridView.Location = new System.Drawing.Point(27, 147);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.ReadOnly = true;
            this.ItemsDataGridView.RowHeadersVisible = false;
            this.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGridView.Size = new System.Drawing.Size(748, 251);
            this.ItemsDataGridView.TabIndex = 22;
            this.ItemsDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.Height = 31;
            this.ItemsDataGridView.ThemeStyle.ReadOnly = true;
            this.ItemsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ItemsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ItemsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsDataGridView.DoubleClick += new System.EventHandler(this.ItemsDataGridView_DoubleClick);
            // 
            // DelLabel
            // 
            this.DelLabel.AutoSize = true;
            this.DelLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelLabel.ForeColor = System.Drawing.Color.Black;
            this.DelLabel.Location = new System.Drawing.Point(430, 426);
            this.DelLabel.Name = "DelLabel";
            this.DelLabel.Size = new System.Drawing.Size(104, 25);
            this.DelLabel.TabIndex = 21;
            this.DelLabel.Text = "Item Name";
            this.DelLabel.Click += new System.EventHandler(this.DelLabel_Click);
            // 
            // DeleteItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.DelLabel);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "DeleteItemForm";
            this.Text = "DeleteItemForm";
            this.Load += new System.EventHandler(this.DeleteItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsDataGridView;
        private System.Windows.Forms.Label DelLabel;
    }
}