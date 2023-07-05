
namespace plths.Purok
{
    partial class frmAddPurok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPurok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.prkname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prkleader = new Guna.UI2.WinForms.Guna2TextBox();
            this.prkcontact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sbtPurok = new Guna.UI2.WinForms.Guna2Button();
            this.prkCancel = new Guna.UI2.WinForms.Guna2Button();
            this.residentResultGrid = new Guna.UI.WinForms.GunaDataGridView();
            this.residDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewModelResidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewModelResidentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentResultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Purok";
            // 
            // prkname
            // 
            this.prkname.BorderRadius = 10;
            this.prkname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prkname.DefaultText = "";
            this.prkname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prkname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prkname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prkname.DisabledState.Parent = this.prkname;
            this.prkname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prkname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prkname.FocusedState.Parent = this.prkname;
            this.prkname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prkname.HoverState.Parent = this.prkname;
            this.prkname.Location = new System.Drawing.Point(16, 145);
            this.prkname.Name = "prkname";
            this.prkname.PasswordChar = '\0';
            this.prkname.PlaceholderText = "";
            this.prkname.SelectedText = "";
            this.prkname.ShadowDecoration.Parent = this.prkname;
            this.prkname.Size = new System.Drawing.Size(253, 36);
            this.prkname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purok Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purok Leader:";
            // 
            // prkleader
            // 
            this.prkleader.BorderRadius = 10;
            this.prkleader.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prkleader.DefaultText = "";
            this.prkleader.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prkleader.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prkleader.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prkleader.DisabledState.Parent = this.prkleader;
            this.prkleader.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prkleader.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prkleader.FocusedState.Parent = this.prkleader;
            this.prkleader.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prkleader.HoverState.Parent = this.prkleader;
            this.prkleader.Location = new System.Drawing.Point(290, 145);
            this.prkleader.Name = "prkleader";
            this.prkleader.PasswordChar = '\0';
            this.prkleader.PlaceholderText = "";
            this.prkleader.SelectedText = "";
            this.prkleader.ShadowDecoration.Parent = this.prkleader;
            this.prkleader.Size = new System.Drawing.Size(241, 36);
            this.prkleader.TabIndex = 4;
            this.prkleader.TextChanged += new System.EventHandler(this.prkleader_TextChanged);
            // 
            // prkcontact
            // 
            this.prkcontact.BorderRadius = 10;
            this.prkcontact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prkcontact.DefaultText = "";
            this.prkcontact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prkcontact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prkcontact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prkcontact.DisabledState.Parent = this.prkcontact;
            this.prkcontact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prkcontact.Enabled = false;
            this.prkcontact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prkcontact.FocusedState.Parent = this.prkcontact;
            this.prkcontact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prkcontact.HoverState.Parent = this.prkcontact;
            this.prkcontact.Location = new System.Drawing.Point(557, 145);
            this.prkcontact.Name = "prkcontact";
            this.prkcontact.PasswordChar = '\0';
            this.prkcontact.PlaceholderText = "";
            this.prkcontact.SelectedText = "";
            this.prkcontact.ShadowDecoration.Parent = this.prkcontact;
            this.prkcontact.Size = new System.Drawing.Size(242, 36);
            this.prkcontact.TabIndex = 5;
            this.prkcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prkcontact_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact:";
            // 
            // sbtPurok
            // 
            this.sbtPurok.BorderRadius = 12;
            this.sbtPurok.CheckedState.Parent = this.sbtPurok;
            this.sbtPurok.CustomImages.Parent = this.sbtPurok;
            this.sbtPurok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sbtPurok.ForeColor = System.Drawing.Color.White;
            this.sbtPurok.HoverState.Parent = this.sbtPurok;
            this.sbtPurok.Image = ((System.Drawing.Image)(resources.GetObject("sbtPurok.Image")));
            this.sbtPurok.Location = new System.Drawing.Point(581, 295);
            this.sbtPurok.Name = "sbtPurok";
            this.sbtPurok.ShadowDecoration.Parent = this.sbtPurok;
            this.sbtPurok.Size = new System.Drawing.Size(104, 40);
            this.sbtPurok.TabIndex = 7;
            this.sbtPurok.Text = "Submit";
            this.sbtPurok.Click += new System.EventHandler(this.sbtPurok_Click);
            // 
            // prkCancel
            // 
            this.prkCancel.BackColor = System.Drawing.SystemColors.Control;
            this.prkCancel.BorderRadius = 12;
            this.prkCancel.CheckedState.Parent = this.prkCancel;
            this.prkCancel.CustomImages.Parent = this.prkCancel;
            this.prkCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prkCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prkCancel.ForeColor = System.Drawing.Color.Black;
            this.prkCancel.HoverState.Parent = this.prkCancel;
            this.prkCancel.Image = ((System.Drawing.Image)(resources.GetObject("prkCancel.Image")));
            this.prkCancel.ImageSize = new System.Drawing.Size(23, 23);
            this.prkCancel.Location = new System.Drawing.Point(691, 295);
            this.prkCancel.Name = "prkCancel";
            this.prkCancel.ShadowDecoration.Parent = this.prkCancel;
            this.prkCancel.Size = new System.Drawing.Size(104, 40);
            this.prkCancel.TabIndex = 8;
            this.prkCancel.Text = "Cancel";
            this.prkCancel.Click += new System.EventHandler(this.prkCancel_Click);
            // 
            // residentResultGrid
            // 
            this.residentResultGrid.AllowUserToAddRows = false;
            this.residentResultGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.residentResultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.residentResultGrid.AutoGenerateColumns = false;
            this.residentResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.residentResultGrid.BackgroundColor = System.Drawing.Color.White;
            this.residentResultGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.residentResultGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.residentResultGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.residentResultGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.residentResultGrid.ColumnHeadersHeight = 4;
            this.residentResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.residentResultGrid.DataSource = this.viewModelResidentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.residentResultGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.residentResultGrid.EnableHeadersVisualStyles = false;
            this.residentResultGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.residentResultGrid.Location = new System.Drawing.Point(290, 173);
            this.residentResultGrid.MultiSelect = false;
            this.residentResultGrid.Name = "residentResultGrid";
            this.residentResultGrid.ReadOnly = true;
            this.residentResultGrid.RowHeadersVisible = false;
            this.residentResultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.residentResultGrid.Size = new System.Drawing.Size(241, 129);
            this.residentResultGrid.TabIndex = 10;
            this.residentResultGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.residentResultGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.residentResultGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.residentResultGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.residentResultGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.residentResultGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.residentResultGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.residentResultGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.residentResultGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.residentResultGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.residentResultGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.residentResultGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.residentResultGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.residentResultGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.residentResultGrid.ThemeStyle.ReadOnly = true;
            this.residentResultGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.residentResultGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.residentResultGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.residentResultGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.residentResultGrid.ThemeStyle.RowsStyle.Height = 22;
            this.residentResultGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.residentResultGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.residentResultGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.residentResultGrid_CellClick);
            this.residentResultGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.residentResultGrid_CellContentClick);
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
            this.fullnameDataGridViewTextBoxColumn.FillWeight = 152.2843F;
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.FillWeight = 47.71573F;
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewModelResidentBindingSource
            // 
            this.viewModelResidentBindingSource.DataSource = typeof(plths.ViewModel.ViewModelResident);
            // 
            // viewModelResidentBindingSource1
            // 
            this.viewModelResidentBindingSource1.DataSource = typeof(plths.ViewModel.ViewModelResident);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Wheat;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 75);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(824, 10);
            this.guna2Separator1.TabIndex = 192;
            // 
            // frmAddPurok
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(824, 372);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.prkleader);
            this.Controls.Add(this.prkCancel);
            this.Controls.Add(this.sbtPurok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prkcontact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prkname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.residentResultGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPurok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPurok";
            this.Load += new System.EventHandler(this.frmAddPurok_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentResultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelResidentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox prkname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox prkleader;
        private Guna.UI2.WinForms.Guna2TextBox prkcontact;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button sbtPurok;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button prkCancel;
        private System.Windows.Forms.BindingSource viewModelResidentBindingSource;
        private System.Windows.Forms.BindingSource viewModelResidentBindingSource1;
        private Guna.UI.WinForms.GunaDataGridView residentResultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn residDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}