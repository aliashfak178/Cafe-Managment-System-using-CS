namespace CafeManagementSystem
{
    partial class PlaceOrderForm
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
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddtoCartButton = new Guna.UI2.WinForms.Guna2Button();
            this.QuantityNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintButton = new Guna.UI2.WinForms.Guna2Button();
            this.GrandTotallabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.SearchTextBox.Location = new System.Drawing.Point(12, 110);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "Search";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.ShadowDecoration.Parent = this.SearchTextBox;
            this.SearchTextBox.Size = new System.Drawing.Size(165, 36);
            this.SearchTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchTextBox.TabIndex = 17;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
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
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.ForeColor = System.Drawing.Color.Black;
            this.CategoryComboBox.HoverState.Parent = this.CategoryComboBox;
            this.CategoryComboBox.ItemHeight = 30;
            this.CategoryComboBox.ItemsAppearance.Parent = this.CategoryComboBox;
            this.CategoryComboBox.Location = new System.Drawing.Point(12, 56);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.ShadowDecoration.Parent = this.CategoryComboBox;
            this.CategoryComboBox.Size = new System.Drawing.Size(165, 36);
            this.CategoryComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CategoryComboBox.TabIndex = 16;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Place Orders";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Animated = true;
            this.RemoveButton.BorderRadius = 10;
            this.RemoveButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.RemoveButton.CheckedState.Parent = this.RemoveButton;
            this.RemoveButton.CustomImages.Parent = this.RemoveButton;
            this.RemoveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.HoverState.Parent = this.RemoveButton;
            this.RemoveButton.Location = new System.Drawing.Point(195, 411);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.ShadowDecoration.Parent = this.RemoveButton;
            this.RemoveButton.Size = new System.Drawing.Size(156, 43);
            this.RemoveButton.TabIndex = 14;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Category";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 26;
            this.ItemsListBox.Location = new System.Drawing.Point(12, 164);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(155, 290);
            this.ItemsListBox.TabIndex = 18;
            this.ItemsListBox.DoubleClick += new System.EventHandler(this.ItemsListBox_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(215, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Item Name";
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
            this.ItemNameTextBox.Location = new System.Drawing.Point(220, 54);
            this.ItemNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.PasswordChar = '\0';
            this.ItemNameTextBox.PlaceholderText = "Item Name";
            this.ItemNameTextBox.ReadOnly = true;
            this.ItemNameTextBox.SelectedText = "";
            this.ItemNameTextBox.ShadowDecoration.Parent = this.ItemNameTextBox;
            this.ItemNameTextBox.Size = new System.Drawing.Size(256, 36);
            this.ItemNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ItemNameTextBox.TabIndex = 17;
            this.ItemNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(525, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
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
            this.PriceTextBox.Location = new System.Drawing.Point(530, 51);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.PlaceholderText = "Price";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.ShadowDecoration.Parent = this.PriceTextBox;
            this.PriceTextBox.Size = new System.Drawing.Size(246, 36);
            this.PriceTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PriceTextBox.TabIndex = 17;
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(225, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quantity";
            // 
            // AddtoCartButton
            // 
            this.AddtoCartButton.Animated = true;
            this.AddtoCartButton.BorderRadius = 10;
            this.AddtoCartButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddtoCartButton.CheckedState.Parent = this.AddtoCartButton;
            this.AddtoCartButton.CustomImages.Parent = this.AddtoCartButton;
            this.AddtoCartButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.AddtoCartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddtoCartButton.ForeColor = System.Drawing.Color.White;
            this.AddtoCartButton.HoverState.Parent = this.AddtoCartButton;
            this.AddtoCartButton.Location = new System.Drawing.Point(523, 170);
            this.AddtoCartButton.Name = "AddtoCartButton";
            this.AddtoCartButton.ShadowDecoration.Parent = this.AddtoCartButton;
            this.AddtoCartButton.Size = new System.Drawing.Size(246, 43);
            this.AddtoCartButton.TabIndex = 14;
            this.AddtoCartButton.Text = "Add To Cart";
            this.AddtoCartButton.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.QuantityNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityNumericUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityNumericUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityNumericUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityNumericUpDown.DisabledState.Parent = this.QuantityNumericUpDown;
            this.QuantityNumericUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.QuantityNumericUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.QuantityNumericUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityNumericUpDown.FocusedState.Parent = this.QuantityNumericUpDown;
            this.QuantityNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityNumericUpDown.ForeColor = System.Drawing.Color.Black;
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(220, 124);
            this.QuantityNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.ShadowDecoration.Parent = this.QuantityNumericUpDown;
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(256, 36);
            this.QuantityNumericUpDown.TabIndex = 19;
            this.QuantityNumericUpDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(807, 477);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 30;
            this.rectangleShape1.Location = new System.Drawing.Point(183, 11);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(618, 215);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.ColumnHeadersHeight = 21;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.Location = new System.Drawing.Point(183, 232);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(619, 150);
            this.DataGridView1.TabIndex = 21;
            this.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.DataGridView1.ThemeStyle.ReadOnly = true;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Animated = true;
            this.PrintButton.BorderRadius = 10;
            this.PrintButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.PrintButton.CheckedState.Parent = this.PrintButton;
            this.PrintButton.CustomImages.Parent = this.PrintButton;
            this.PrintButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.HoverState.Parent = this.PrintButton;
            this.PrintButton.Location = new System.Drawing.Point(639, 411);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.ShadowDecoration.Parent = this.PrintButton;
            this.PrintButton.Size = new System.Drawing.Size(156, 43);
            this.PrintButton.TabIndex = 14;
            this.PrintButton.Text = "Print";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // GrandTotallabel
            // 
            this.GrandTotallabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GrandTotallabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotallabel.ForeColor = System.Drawing.Color.Black;
            this.GrandTotallabel.Location = new System.Drawing.Point(403, 418);
            this.GrandTotallabel.Name = "GrandTotallabel";
            this.GrandTotallabel.Size = new System.Drawing.Size(163, 39);
            this.GrandTotallabel.TabIndex = 15;
            this.GrandTotallabel.Text = "R.S:- 0.0";
            this.GrandTotallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(420, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Grand Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(525, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalTextBox.DefaultText = "";
            this.TotalTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TotalTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TotalTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotalTextBox.DisabledState.Parent = this.TotalTextBox;
            this.TotalTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotalTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TotalTextBox.FocusedState.Parent = this.TotalTextBox;
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TotalTextBox.ForeColor = System.Drawing.Color.Black;
            this.TotalTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TotalTextBox.HoverState.Parent = this.TotalTextBox;
            this.TotalTextBox.Location = new System.Drawing.Point(530, 119);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.PasswordChar = '\0';
            this.TotalTextBox.PlaceholderText = "Total";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.SelectedText = "";
            this.TotalTextBox.ShadowDecoration.Parent = this.TotalTextBox;
            this.TotalTextBox.Size = new System.Drawing.Size(246, 36);
            this.TotalTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TotalTextBox.TabIndex = 17;
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlaceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GrandTotallabel);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddtoCartButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "PlaceOrderForm";
            this.Text = "PlaceOrderForm";
            this.Load += new System.EventHandler(this.PlaceOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button RemoveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox ItemNameTextBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox PriceTextBox;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button AddtoCartButton;
        private Guna.UI2.WinForms.Guna2NumericUpDown QuantityNumericUpDown;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private Guna.UI2.WinForms.Guna2Button PrintButton;
        private System.Windows.Forms.Label GrandTotallabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TotalTextBox;
    }
}