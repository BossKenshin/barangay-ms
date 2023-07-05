
namespace plths.Clearance
{
    partial class frmAddClearance
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbIssued = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateClearance = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnClearanceCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearnceSave = new Guna.UI2.WinForms.Guna2Button();
            this.tbStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.residentSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.resultgrid = new Guna.UI.WinForms.GunaDataGridView();
            this.residDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewModelResidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.puroklabel = new Guna.UI.WinForms.GunaLabel();
            this.genderlabel = new Guna.UI.WinForms.GunaLabel();
            this.agelabel = new Guna.UI.WinForms.GunaLabel();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Wheat;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 50);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(742, 10);
            this.guna2Separator1.TabIndex = 64;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(742, 50);
            this.guna2Panel1.TabIndex = 63;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(11, 11);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(298, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Create Barangay Clearance";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(388, 78);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(50, 20);
            this.guna2HtmlLabel6.TabIndex = 65;
            this.guna2HtmlLabel6.Text = "Issued:";
            // 
            // tbIssued
            // 
            this.tbIssued.BorderRadius = 12;
            this.tbIssued.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIssued.DefaultText = "";
            this.tbIssued.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIssued.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIssued.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIssued.DisabledState.Parent = this.tbIssued;
            this.tbIssued.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIssued.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIssued.FocusedState.Parent = this.tbIssued;
            this.tbIssued.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIssued.HoverState.Parent = this.tbIssued;
            this.tbIssued.Location = new System.Drawing.Point(388, 105);
            this.tbIssued.Margin = new System.Windows.Forms.Padding(4);
            this.tbIssued.Name = "tbIssued";
            this.tbIssued.PasswordChar = '\0';
            this.tbIssued.PlaceholderText = "";
            this.tbIssued.SelectedText = "";
            this.tbIssued.ShadowDecoration.Parent = this.tbIssued;
            this.tbIssued.Size = new System.Drawing.Size(324, 41);
            this.tbIssued.TabIndex = 66;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(389, 153);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(49, 20);
            this.guna2HtmlLabel2.TabIndex = 68;
            this.guna2HtmlLabel2.Text = "Status:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(388, 228);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(38, 20);
            this.guna2HtmlLabel3.TabIndex = 69;
            this.guna2HtmlLabel3.Text = "Date:";
            // 
            // dateClearance
            // 
            this.dateClearance.BaseColor = System.Drawing.Color.White;
            this.dateClearance.BorderColor = System.Drawing.Color.Silver;
            this.dateClearance.CustomFormat = null;
            this.dateClearance.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateClearance.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateClearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateClearance.ForeColor = System.Drawing.Color.Black;
            this.dateClearance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateClearance.Location = new System.Drawing.Point(389, 254);
            this.dateClearance.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateClearance.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateClearance.Name = "dateClearance";
            this.dateClearance.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateClearance.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateClearance.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateClearance.OnPressedColor = System.Drawing.Color.Black;
            this.dateClearance.Size = new System.Drawing.Size(323, 41);
            this.dateClearance.TabIndex = 70;
            this.dateClearance.Text = "2/22/2023";
            this.dateClearance.Value = new System.DateTime(2023, 2, 22, 14, 10, 17, 172);
            // 
            // btnClearanceCancel
            // 
            this.btnClearanceCancel.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearanceCancel.BorderRadius = 12;
            this.btnClearanceCancel.CheckedState.Parent = this.btnClearanceCancel;
            this.btnClearanceCancel.CustomImages.Parent = this.btnClearanceCancel;
            this.btnClearanceCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearanceCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearanceCancel.ForeColor = System.Drawing.Color.Black;
            this.btnClearanceCancel.HoverState.Parent = this.btnClearanceCancel;
            this.btnClearanceCancel.Location = new System.Drawing.Point(625, 336);
            this.btnClearanceCancel.Name = "btnClearanceCancel";
            this.btnClearanceCancel.ShadowDecoration.Parent = this.btnClearanceCancel;
            this.btnClearanceCancel.Size = new System.Drawing.Size(92, 36);
            this.btnClearanceCancel.TabIndex = 77;
            this.btnClearanceCancel.Text = "Cancel";
            this.btnClearanceCancel.Click += new System.EventHandler(this.btnClearanceCancel_Click);
            // 
            // btnClearnceSave
            // 
            this.btnClearnceSave.BorderRadius = 12;
            this.btnClearnceSave.CheckedState.Parent = this.btnClearnceSave;
            this.btnClearnceSave.CustomImages.Parent = this.btnClearnceSave;
            this.btnClearnceSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(176)))), ((int)(((byte)(241)))));
            this.btnClearnceSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearnceSave.ForeColor = System.Drawing.Color.White;
            this.btnClearnceSave.HoverState.Parent = this.btnClearnceSave;
            this.btnClearnceSave.Location = new System.Drawing.Point(525, 336);
            this.btnClearnceSave.Name = "btnClearnceSave";
            this.btnClearnceSave.ShadowDecoration.Parent = this.btnClearnceSave;
            this.btnClearnceSave.Size = new System.Drawing.Size(94, 36);
            this.btnClearnceSave.TabIndex = 76;
            this.btnClearnceSave.Text = "Save";
            this.btnClearnceSave.Click += new System.EventHandler(this.btnClearnceSave_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.BorderRadius = 12;
            this.tbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStatus.DefaultText = "";
            this.tbStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStatus.DisabledState.Parent = this.tbStatus;
            this.tbStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStatus.FocusedState.Parent = this.tbStatus;
            this.tbStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStatus.HoverState.Parent = this.tbStatus;
            this.tbStatus.Location = new System.Drawing.Point(389, 180);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.PasswordChar = '\0';
            this.tbStatus.PlaceholderText = "";
            this.tbStatus.SelectedText = "";
            this.tbStatus.ShadowDecoration.Parent = this.tbStatus;
            this.tbStatus.Size = new System.Drawing.Size(323, 41);
            this.tbStatus.TabIndex = 78;
            // 
            // residentSearch
            // 
            this.residentSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.residentSearch.DefaultText = "";
            this.residentSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.residentSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.residentSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.residentSearch.DisabledState.Parent = this.residentSearch;
            this.residentSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.residentSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.residentSearch.FocusedState.Parent = this.residentSearch;
            this.residentSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.residentSearch.HoverState.Parent = this.residentSearch;
            this.residentSearch.Location = new System.Drawing.Point(48, 104);
            this.residentSearch.Name = "residentSearch";
            this.residentSearch.PasswordChar = '\0';
            this.residentSearch.PlaceholderText = "";
            this.residentSearch.SelectedText = "";
            this.residentSearch.ShadowDecoration.Parent = this.residentSearch;
            this.residentSearch.Size = new System.Drawing.Size(323, 42);
            this.residentSearch.TabIndex = 83;
            this.residentSearch.TextChanged += new System.EventHandler(this.residentSearch_TextChanged);
            // 
            // resultgrid
            // 
            this.resultgrid.AllowUserToAddRows = false;
            this.resultgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.resultgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultgrid.AutoGenerateColumns = false;
            this.resultgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultgrid.BackgroundColor = System.Drawing.Color.White;
            this.resultgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.resultgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resultgrid.ColumnHeadersHeight = 21;
            this.resultgrid.ColumnHeadersVisible = false;
            this.resultgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn});
            this.resultgrid.DataSource = this.viewModelResidentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.resultgrid.EnableHeadersVisualStyles = false;
            this.resultgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.resultgrid.Location = new System.Drawing.Point(48, 144);
            this.resultgrid.Name = "resultgrid";
            this.resultgrid.ReadOnly = true;
            this.resultgrid.RowHeadersVisible = false;
            this.resultgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultgrid.Size = new System.Drawing.Size(323, 96);
            this.resultgrid.TabIndex = 84;
            this.resultgrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.resultgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.resultgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.resultgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.resultgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.resultgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.resultgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.resultgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.resultgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.resultgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resultgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.resultgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.resultgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.resultgrid.ThemeStyle.HeaderStyle.Height = 21;
            this.resultgrid.ThemeStyle.ReadOnly = true;
            this.resultgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.resultgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.resultgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.resultgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.resultgrid.ThemeStyle.RowsStyle.Height = 22;
            this.resultgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.resultgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.resultgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultgrid_CellClick);
            // 
            // residDataGridViewTextBoxColumn
            // 
            this.residDataGridViewTextBoxColumn.DataPropertyName = "resid";
            this.residDataGridViewTextBoxColumn.FillWeight = 13.19797F;
            this.residDataGridViewTextBoxColumn.HeaderText = "resid";
            this.residDataGridViewTextBoxColumn.MinimumWidth = 3;
            this.residDataGridViewTextBoxColumn.Name = "residDataGridViewTextBoxColumn";
            this.residDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.FillWeight = 186.802F;
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewModelResidentBindingSource
            // 
            this.viewModelResidentBindingSource.DataSource = typeof(plths.ViewModel.ViewModelResident);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(53, 180);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(63, 21);
            this.gunaLabel1.TabIndex = 92;
            this.gunaLabel1.Text = "Details";
            // 
            // puroklabel
            // 
            this.puroklabel.AutoSize = true;
            this.puroklabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puroklabel.Location = new System.Drawing.Point(53, 286);
            this.puroklabel.Name = "puroklabel";
            this.puroklabel.Size = new System.Drawing.Size(58, 21);
            this.puroklabel.TabIndex = 91;
            this.puroklabel.Text = "Purok :";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.Location = new System.Drawing.Point(53, 219);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(68, 21);
            this.genderlabel.TabIndex = 90;
            this.genderlabel.Text = "Gender :";
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelabel.Location = new System.Drawing.Point(53, 254);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(44, 21);
            this.agelabel.TabIndex = 89;
            this.agelabel.Text = "Age :";
            // 
            // printBtn
            // 
            this.printBtn.BorderRadius = 12;
            this.printBtn.CheckedState.Parent = this.printBtn;
            this.printBtn.CustomImages.Parent = this.printBtn;
            this.printBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.HoverState.Parent = this.printBtn;
            this.printBtn.Location = new System.Drawing.Point(425, 336);
            this.printBtn.Name = "printBtn";
            this.printBtn.ShadowDecoration.Parent = this.printBtn;
            this.printBtn.Size = new System.Drawing.Size(94, 36);
            this.printBtn.TabIndex = 93;
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // frmAddClearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 392);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.resultgrid);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.puroklabel);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.residentSearch);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnClearanceCancel);
            this.Controls.Add(this.btnClearnceSave);
            this.Controls.Add(this.dateClearance);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.tbIssued);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddClearance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddClearance";
            this.Load += new System.EventHandler(this.frmAddClearance_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox tbIssued;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI.WinForms.GunaDateTimePicker dateClearance;
        private Guna.UI2.WinForms.Guna2Button btnClearanceCancel;
        private Guna.UI2.WinForms.Guna2Button btnClearnceSave;
        private Guna.UI2.WinForms.Guna2TextBox tbStatus;
        private Guna.UI2.WinForms.Guna2TextBox residentSearch;
        private Guna.UI.WinForms.GunaDataGridView resultgrid;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel puroklabel;
        private Guna.UI.WinForms.GunaLabel genderlabel;
        private Guna.UI.WinForms.GunaLabel agelabel;
        private System.Windows.Forms.BindingSource viewModelResidentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn residDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button printBtn;
    }
}