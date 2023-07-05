
namespace plths
{
    partial class frmHomeServices
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.chkResidency = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkCedula = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkB_permit = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkIndigency = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkClearance = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnProceedPayment = new Guna.UI2.WinForms.Guna2Button();
            this.rbtnNotResident = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnResident = new Guna.UI2.WinForms.Guna2RadioButton();
            this.resultGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.residDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewModelResidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.amountphp = new System.Windows.Forms.Label();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.chkResidency);
            this.guna2Panel2.Controls.Add(this.chkCedula);
            this.guna2Panel2.Controls.Add(this.chkB_permit);
            this.guna2Panel2.Controls.Add(this.chkIndigency);
            this.guna2Panel2.Controls.Add(this.chkClearance);
            this.guna2Panel2.Location = new System.Drawing.Point(32, 179);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(695, 207);
            this.guna2Panel2.TabIndex = 16;
            // 
            // chkResidency
            // 
            this.chkResidency.AutoSize = true;
            this.chkResidency.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkResidency.CheckedState.BorderRadius = 2;
            this.chkResidency.CheckedState.BorderThickness = 0;
            this.chkResidency.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkResidency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResidency.Location = new System.Drawing.Point(14, 172);
            this.chkResidency.Name = "chkResidency";
            this.chkResidency.Size = new System.Drawing.Size(145, 33);
            this.chkResidency.TabIndex = 4;
            this.chkResidency.Tag = "5";
            this.chkResidency.Text = "Residency";
            this.chkResidency.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkResidency.UncheckedState.BorderRadius = 2;
            this.chkResidency.UncheckedState.BorderThickness = 0;
            this.chkResidency.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkResidency.UseVisualStyleBackColor = true;
            this.chkResidency.CheckedChanged += new System.EventHandler(this.chkResidency_CheckedChanged);
            // 
            // chkCedula
            // 
            this.chkCedula.AutoSize = true;
            this.chkCedula.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkCedula.CheckedState.BorderRadius = 2;
            this.chkCedula.CheckedState.BorderThickness = 0;
            this.chkCedula.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCedula.Location = new System.Drawing.Point(14, 133);
            this.chkCedula.Name = "chkCedula";
            this.chkCedula.Size = new System.Drawing.Size(109, 33);
            this.chkCedula.TabIndex = 3;
            this.chkCedula.Tag = "4";
            this.chkCedula.Text = "Cedula";
            this.chkCedula.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkCedula.UncheckedState.BorderRadius = 2;
            this.chkCedula.UncheckedState.BorderThickness = 0;
            this.chkCedula.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkCedula.UseVisualStyleBackColor = true;
            this.chkCedula.CheckedChanged += new System.EventHandler(this.chkCedula_CheckedChanged);
            // 
            // chkB_permit
            // 
            this.chkB_permit.AutoSize = true;
            this.chkB_permit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkB_permit.CheckedState.BorderRadius = 2;
            this.chkB_permit.CheckedState.BorderThickness = 0;
            this.chkB_permit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkB_permit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB_permit.Location = new System.Drawing.Point(14, 94);
            this.chkB_permit.Name = "chkB_permit";
            this.chkB_permit.Size = new System.Drawing.Size(206, 33);
            this.chkB_permit.TabIndex = 2;
            this.chkB_permit.Tag = "3";
            this.chkB_permit.Text = "Business Permit";
            this.chkB_permit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkB_permit.UncheckedState.BorderRadius = 2;
            this.chkB_permit.UncheckedState.BorderThickness = 0;
            this.chkB_permit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkB_permit.UseVisualStyleBackColor = true;
            this.chkB_permit.CheckedChanged += new System.EventHandler(this.chkB_permit_CheckedChanged);
            // 
            // chkIndigency
            // 
            this.chkIndigency.AutoSize = true;
            this.chkIndigency.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIndigency.CheckedState.BorderRadius = 2;
            this.chkIndigency.CheckedState.BorderThickness = 0;
            this.chkIndigency.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIndigency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIndigency.Location = new System.Drawing.Point(14, 55);
            this.chkIndigency.Name = "chkIndigency";
            this.chkIndigency.Size = new System.Drawing.Size(135, 33);
            this.chkIndigency.TabIndex = 1;
            this.chkIndigency.Tag = "2";
            this.chkIndigency.Text = "Indigency";
            this.chkIndigency.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIndigency.UncheckedState.BorderRadius = 2;
            this.chkIndigency.UncheckedState.BorderThickness = 0;
            this.chkIndigency.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIndigency.UseVisualStyleBackColor = true;
            // 
            // chkClearance
            // 
            this.chkClearance.AutoSize = true;
            this.chkClearance.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkClearance.CheckedState.BorderRadius = 2;
            this.chkClearance.CheckedState.BorderThickness = 0;
            this.chkClearance.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkClearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClearance.Location = new System.Drawing.Point(14, 16);
            this.chkClearance.Name = "chkClearance";
            this.chkClearance.Size = new System.Drawing.Size(142, 33);
            this.chkClearance.TabIndex = 0;
            this.chkClearance.Tag = "1";
            this.chkClearance.Text = "Clearance";
            this.chkClearance.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkClearance.UncheckedState.BorderRadius = 2;
            this.chkClearance.UncheckedState.BorderThickness = 0;
            this.chkClearance.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkClearance.UseVisualStyleBackColor = true;
            this.chkClearance.CheckedChanged += new System.EventHandler(this.chkClearance_CheckedChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.Location = new System.Drawing.Point(32, 107);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(708, 36);
            this.tbSearch.TabIndex = 15;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnProceedPayment
            // 
            this.btnProceedPayment.CheckedState.Parent = this.btnProceedPayment;
            this.btnProceedPayment.CustomImages.Parent = this.btnProceedPayment;
            this.btnProceedPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedPayment.ForeColor = System.Drawing.Color.White;
            this.btnProceedPayment.HoverState.Parent = this.btnProceedPayment;
            this.btnProceedPayment.Location = new System.Drawing.Point(560, 406);
            this.btnProceedPayment.Name = "btnProceedPayment";
            this.btnProceedPayment.ShadowDecoration.Parent = this.btnProceedPayment;
            this.btnProceedPayment.Size = new System.Drawing.Size(180, 45);
            this.btnProceedPayment.TabIndex = 17;
            this.btnProceedPayment.Text = "Proceed to Payment";
            this.btnProceedPayment.Click += new System.EventHandler(this.btnProceedPayment_Click);
            // 
            // rbtnNotResident
            // 
            this.rbtnNotResident.AutoSize = true;
            this.rbtnNotResident.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnNotResident.CheckedState.BorderThickness = 0;
            this.rbtnNotResident.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnNotResident.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnNotResident.CheckedState.InnerOffset = -4;
            this.rbtnNotResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNotResident.Location = new System.Drawing.Point(160, 73);
            this.rbtnNotResident.Name = "rbtnNotResident";
            this.rbtnNotResident.Size = new System.Drawing.Size(141, 28);
            this.rbtnNotResident.TabIndex = 14;
            this.rbtnNotResident.Text = "Not Resident ";
            this.rbtnNotResident.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnNotResident.UncheckedState.BorderThickness = 2;
            this.rbtnNotResident.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnNotResident.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnNotResident.UseVisualStyleBackColor = true;
            this.rbtnNotResident.CheckedChanged += new System.EventHandler(this.rbtnNotResident_CheckedChanged);
            this.rbtnNotResident.Click += new System.EventHandler(this.rbtnNotResident_Click);
            // 
            // rbtnResident
            // 
            this.rbtnResident.AutoSize = true;
            this.rbtnResident.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnResident.CheckedState.BorderThickness = 0;
            this.rbtnResident.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnResident.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnResident.CheckedState.InnerOffset = -4;
            this.rbtnResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnResident.Location = new System.Drawing.Point(33, 73);
            this.rbtnResident.Name = "rbtnResident";
            this.rbtnResident.Size = new System.Drawing.Size(107, 28);
            this.rbtnResident.TabIndex = 13;
            this.rbtnResident.Text = "Resident ";
            this.rbtnResident.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnResident.UncheckedState.BorderThickness = 2;
            this.rbtnResident.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnResident.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnResident.UseVisualStyleBackColor = true;
            this.rbtnResident.CheckedChanged += new System.EventHandler(this.rbtnResident_CheckedChanged);
            this.rbtnResident.Click += new System.EventHandler(this.rbtnResident_Click);
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.resultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultGrid.AutoGenerateColumns = false;
            this.resultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultGrid.BackgroundColor = System.Drawing.Color.White;
            this.resultGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.resultGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resultGrid.ColumnHeadersHeight = 21;
            this.resultGrid.ColumnHeadersVisible = false;
            this.resultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn});
            this.resultGrid.DataSource = this.viewModelResidentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.resultGrid.EnableHeadersVisualStyles = false;
            this.resultGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.resultGrid.Location = new System.Drawing.Point(32, 136);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.RowHeadersVisible = false;
            this.resultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultGrid.Size = new System.Drawing.Size(708, 81);
            this.resultGrid.TabIndex = 18;
            this.resultGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.resultGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.resultGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.resultGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.resultGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resultGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.resultGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.resultGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.resultGrid.ThemeStyle.HeaderStyle.Height = 21;
            this.resultGrid.ThemeStyle.ReadOnly = true;
            this.resultGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.resultGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.resultGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.resultGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.resultGrid.ThemeStyle.RowsStyle.Height = 22;
            this.resultGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.resultGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.resultGrid.Visible = false;
            this.resultGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultGrid_CellClick);
            // 
            // residDataGridViewTextBoxColumn
            // 
            this.residDataGridViewTextBoxColumn.DataPropertyName = "resid";
            this.residDataGridViewTextBoxColumn.HeaderText = "resid";
            this.residDataGridViewTextBoxColumn.Name = "residDataGridViewTextBoxColumn";
            this.residDataGridViewTextBoxColumn.ReadOnly = true;
            this.residDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewModelResidentBindingSource
            // 
            this.viewModelResidentBindingSource.DataSource = typeof(plths.ViewModel.ViewModelResident);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Amount :";
            // 
            // amountphp
            // 
            this.amountphp.AutoSize = true;
            this.amountphp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountphp.Location = new System.Drawing.Point(132, 406);
            this.amountphp.Name = "amountphp";
            this.amountphp.Size = new System.Drawing.Size(21, 24);
            this.amountphp.TabIndex = 20;
            this.amountphp.Text = "0";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(153, 50);
            this.gunaLabel2.TabIndex = 21;
            this.gunaLabel2.Text = "Services";
            // 
            // frmHomeServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 468);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.amountphp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnProceedPayment);
            this.Controls.Add(this.rbtnNotResident);
            this.Controls.Add(this.rbtnResident);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeServices";
            this.Text = "frmHomeServices";
            this.Load += new System.EventHandler(this.frmHomeServices_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CheckBox chkResidency;
        private Guna.UI2.WinForms.Guna2CheckBox chkCedula;
        private Guna.UI2.WinForms.Guna2CheckBox chkB_permit;
        private Guna.UI2.WinForms.Guna2CheckBox chkIndigency;
        private Guna.UI2.WinForms.Guna2CheckBox chkClearance;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2Button btnProceedPayment;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnNotResident;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnResident;
        private System.Windows.Forms.BindingSource viewModelResidentBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView resultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn residDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amountphp;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}