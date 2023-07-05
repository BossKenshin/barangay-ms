
namespace plths
{
    partial class frmResidents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResidents));
            this.residentGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.residDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purokname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewModelResidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.searchRes = new Guna.UI2.WinForms.Guna2TextBox();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.purokcombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.viewModelPurokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.residentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelPurokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // residentGrid
            // 
            this.residentGrid.AllowUserToAddRows = false;
            this.residentGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.residentGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.residentGrid.AutoGenerateColumns = false;
            this.residentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.residentGrid.BackgroundColor = System.Drawing.Color.White;
            this.residentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.residentGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.residentGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.residentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.residentGrid.ColumnHeadersHeight = 40;
            this.residentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.residentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residDataGridViewTextBoxColumn,
            this.fnDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.lnDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.cstatDataGridViewTextBoxColumn,
            this.lstatDataGridViewTextBoxColumn,
            this.purokname});
            this.residentGrid.DataSource = this.viewModelResidentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.residentGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.residentGrid.EnableHeadersVisualStyles = false;
            this.residentGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.residentGrid.Location = new System.Drawing.Point(21, 129);
            this.residentGrid.Name = "residentGrid";
            this.residentGrid.ReadOnly = true;
            this.residentGrid.RowHeadersVisible = false;
            this.residentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.residentGrid.Size = new System.Drawing.Size(963, 480);
            this.residentGrid.TabIndex = 1;
            this.residentGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.residentGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.residentGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.residentGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.residentGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.residentGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.residentGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.residentGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.residentGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.residentGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.residentGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.residentGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.residentGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.residentGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.residentGrid.ThemeStyle.ReadOnly = true;
            this.residentGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.residentGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.residentGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.residentGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.residentGrid.ThemeStyle.RowsStyle.Height = 22;
            this.residentGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.residentGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.residentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.residentGrid_CellClick);
            this.residentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.residentGrid_CellContentClick);
            // 
            // residDataGridViewTextBoxColumn
            // 
            this.residDataGridViewTextBoxColumn.DataPropertyName = "resid";
            this.residDataGridViewTextBoxColumn.FillWeight = 22.05041F;
            this.residDataGridViewTextBoxColumn.HeaderText = "ID";
            this.residDataGridViewTextBoxColumn.Name = "residDataGridViewTextBoxColumn";
            this.residDataGridViewTextBoxColumn.ReadOnly = true;
            this.residDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.residDataGridViewTextBoxColumn.Visible = false;
            // 
            // fnDataGridViewTextBoxColumn
            // 
            this.fnDataGridViewTextBoxColumn.DataPropertyName = "fn";
            this.fnDataGridViewTextBoxColumn.FillWeight = 105.842F;
            this.fnDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fnDataGridViewTextBoxColumn.Name = "fnDataGridViewTextBoxColumn";
            this.fnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "mn";
            this.mnDataGridViewTextBoxColumn.FillWeight = 137.0558F;
            this.mnDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnDataGridViewTextBoxColumn
            // 
            this.lnDataGridViewTextBoxColumn.DataPropertyName = "ln";
            this.lnDataGridViewTextBoxColumn.FillWeight = 105.842F;
            this.lnDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lnDataGridViewTextBoxColumn.Name = "lnDataGridViewTextBoxColumn";
            this.lnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.FillWeight = 105.842F;
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.FillWeight = 105.842F;
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cstatDataGridViewTextBoxColumn
            // 
            this.cstatDataGridViewTextBoxColumn.DataPropertyName = "cstat";
            this.cstatDataGridViewTextBoxColumn.FillWeight = 105.842F;
            this.cstatDataGridViewTextBoxColumn.HeaderText = "Civil Status";
            this.cstatDataGridViewTextBoxColumn.Name = "cstatDataGridViewTextBoxColumn";
            this.cstatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lstatDataGridViewTextBoxColumn
            // 
            this.lstatDataGridViewTextBoxColumn.DataPropertyName = "lstat";
            this.lstatDataGridViewTextBoxColumn.FillWeight = 105.842F;
            this.lstatDataGridViewTextBoxColumn.HeaderText = "Status";
            this.lstatDataGridViewTextBoxColumn.Name = "lstatDataGridViewTextBoxColumn";
            this.lstatDataGridViewTextBoxColumn.ReadOnly = true;
            this.lstatDataGridViewTextBoxColumn.Visible = false;
            // 
            // purokname
            // 
            this.purokname.DataPropertyName = "purokname";
            this.purokname.FillWeight = 105.842F;
            this.purokname.HeaderText = "Purok";
            this.purokname.Name = "purokname";
            this.purokname.ReadOnly = true;
            // 
            // viewModelResidentBindingSource
            // 
            this.viewModelResidentBindingSource.DataSource = typeof(plths.ViewModel.ViewModelResident);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(176)))), ((int)(((byte)(241)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(862, 80);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(122, 43);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Add Residents";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // searchRes
            // 
            this.searchRes.BorderRadius = 12;
            this.searchRes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchRes.DefaultText = "";
            this.searchRes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchRes.DisabledState.Parent = this.searchRes;
            this.searchRes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchRes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchRes.FocusedState.Parent = this.searchRes;
            this.searchRes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchRes.HoverState.Parent = this.searchRes;
            this.searchRes.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchRes.IconLeft")));
            this.searchRes.Location = new System.Drawing.Point(21, 82);
            this.searchRes.Name = "searchRes";
            this.searchRes.PasswordChar = '\0';
            this.searchRes.PlaceholderText = "Search";
            this.searchRes.SelectedText = "";
            this.searchRes.ShadowDecoration.Parent = this.searchRes;
            this.searchRes.Size = new System.Drawing.Size(316, 41);
            this.searchRes.TabIndex = 3;
            this.searchRes.TextChanged += new System.EventHandler(this.searchRes_TextChanged);
            // 
            // printBtn
            // 
            this.printBtn.BorderRadius = 12;
            this.printBtn.CheckedState.Parent = this.printBtn;
            this.printBtn.CustomImages.Parent = this.printBtn;
            this.printBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.HoverState.Parent = this.printBtn;
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.Location = new System.Drawing.Point(862, 626);
            this.printBtn.Name = "printBtn";
            this.printBtn.ShadowDecoration.Parent = this.printBtn;
            this.printBtn.Size = new System.Drawing.Size(122, 39);
            this.printBtn.TabIndex = 177;
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(178, 50);
            this.gunaLabel1.TabIndex = 178;
            this.gunaLabel1.Text = "Residents";
            // 
            // purokcombobox
            // 
            this.purokcombobox.BackColor = System.Drawing.Color.Transparent;
            this.purokcombobox.DataSource = this.viewModelPurokBindingSource;
            this.purokcombobox.DisplayMember = "PurokName";
            this.purokcombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.purokcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purokcombobox.FocusedColor = System.Drawing.Color.Empty;
            this.purokcombobox.FocusedState.Parent = this.purokcombobox;
            this.purokcombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.purokcombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.purokcombobox.FormattingEnabled = true;
            this.purokcombobox.HoverState.Parent = this.purokcombobox;
            this.purokcombobox.ItemHeight = 30;
            this.purokcombobox.ItemsAppearance.Parent = this.purokcombobox;
            this.purokcombobox.Location = new System.Drawing.Point(352, 87);
            this.purokcombobox.Name = "purokcombobox";
            this.purokcombobox.ShadowDecoration.Parent = this.purokcombobox;
            this.purokcombobox.Size = new System.Drawing.Size(195, 36);
            this.purokcombobox.TabIndex = 179;
            this.purokcombobox.ValueMember = "Purok_Id";
            this.purokcombobox.SelectionChangeCommitted += new System.EventHandler(this.purokcombobox_SelectionChangeCommitted);
            // 
            // viewModelPurokBindingSource
            // 
            this.viewModelPurokBindingSource.DataSource = typeof(plths.ViewModel.ViewModelPurok);
            // 
            // frmResidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 693);
            this.Controls.Add(this.purokcombobox);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.searchRes);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.residentGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResidents";
            this.Text = "frmResidents";
            this.Load += new System.EventHandler(this.frmResidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.residentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelPurokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView residentGrid;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox searchRes;
        private System.Windows.Forms.BindingSource viewModelResidentBindingSource;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox purokcombobox;
        private System.Windows.Forms.BindingSource viewModelPurokBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn residDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purokname;
    }
}