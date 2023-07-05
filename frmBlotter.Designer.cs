
namespace plths
{
    partial class frmBlotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlotter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.searchbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridBlotter = new Guna.UI.WinForms.GunaDataGridView();
            this.blotterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defendant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncidentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIncident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentNarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puroknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewModelBlotterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlotter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBlotterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blotter Report";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(22, 22);
            this.guna2Button1.Location = new System.Drawing.Point(799, 93);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(157, 40);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Add New";
            this.guna2Button1.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // searchbl
            // 
            this.searchbl.BorderRadius = 12;
            this.searchbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbl.DefaultText = "";
            this.searchbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbl.DisabledState.Parent = this.searchbl;
            this.searchbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbl.FocusedState.Parent = this.searchbl;
            this.searchbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbl.HoverState.Parent = this.searchbl;
            this.searchbl.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchbl.IconLeft")));
            this.searchbl.Location = new System.Drawing.Point(29, 97);
            this.searchbl.Name = "searchbl";
            this.searchbl.PasswordChar = '\0';
            this.searchbl.PlaceholderText = "Search...";
            this.searchbl.SelectedText = "";
            this.searchbl.ShadowDecoration.Parent = this.searchbl;
            this.searchbl.Size = new System.Drawing.Size(351, 36);
            this.searchbl.TabIndex = 5;
            this.searchbl.TextChanged += new System.EventHandler(this.searchbl_TextChanged);
            // 
            // dataGridBlotter
            // 
            this.dataGridBlotter.AllowUserToAddRows = false;
            this.dataGridBlotter.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridBlotter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBlotter.AutoGenerateColumns = false;
            this.dataGridBlotter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBlotter.BackgroundColor = System.Drawing.Color.White;
            this.dataGridBlotter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBlotter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridBlotter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBlotter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBlotter.ColumnHeadersHeight = 22;
            this.dataGridBlotter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridBlotter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blotterIdDataGridViewTextBoxColumn,
            this.complain,
            this.Defendant,
            this.incidentLocDataGridViewTextBoxColumn,
            this.IncidentType,
            this.prkDataGridViewTextBoxColumn,
            this.dateIncident,
            this.incidentNarra,
            this.puroknameDataGridViewTextBoxColumn});
            this.dataGridBlotter.DataSource = this.viewModelBlotterBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBlotter.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridBlotter.EnableHeadersVisualStyles = false;
            this.dataGridBlotter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridBlotter.Location = new System.Drawing.Point(29, 139);
            this.dataGridBlotter.Name = "dataGridBlotter";
            this.dataGridBlotter.ReadOnly = true;
            this.dataGridBlotter.RowHeadersVisible = false;
            this.dataGridBlotter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBlotter.Size = new System.Drawing.Size(927, 477);
            this.dataGridBlotter.TabIndex = 6;
            this.dataGridBlotter.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridBlotter.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridBlotter.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridBlotter.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridBlotter.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridBlotter.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridBlotter.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridBlotter.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridBlotter.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridBlotter.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridBlotter.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridBlotter.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridBlotter.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridBlotter.ThemeStyle.HeaderStyle.Height = 22;
            this.dataGridBlotter.ThemeStyle.ReadOnly = true;
            this.dataGridBlotter.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridBlotter.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridBlotter.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridBlotter.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridBlotter.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridBlotter.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridBlotter.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridBlotter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBlotter_CellClick);
            this.dataGridBlotter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBlotter_CellContentClick);
            // 
            // blotterIdDataGridViewTextBoxColumn
            // 
            this.blotterIdDataGridViewTextBoxColumn.DataPropertyName = "Blotter_Id";
            this.blotterIdDataGridViewTextBoxColumn.HeaderText = "Blotter No.";
            this.blotterIdDataGridViewTextBoxColumn.Name = "blotterIdDataGridViewTextBoxColumn";
            this.blotterIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complain
            // 
            this.complain.DataPropertyName = "complain";
            this.complain.HeaderText = "Complainant";
            this.complain.Name = "complain";
            this.complain.ReadOnly = true;
            // 
            // Defendant
            // 
            this.Defendant.DataPropertyName = "Defend";
            this.Defendant.HeaderText = "Defendant";
            this.Defendant.Name = "Defendant";
            this.Defendant.ReadOnly = true;
            // 
            // incidentLocDataGridViewTextBoxColumn
            // 
            this.incidentLocDataGridViewTextBoxColumn.DataPropertyName = "incidentLoc";
            this.incidentLocDataGridViewTextBoxColumn.HeaderText = "Incident Location";
            this.incidentLocDataGridViewTextBoxColumn.Name = "incidentLocDataGridViewTextBoxColumn";
            this.incidentLocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IncidentType
            // 
            this.IncidentType.DataPropertyName = "incidentType";
            this.IncidentType.HeaderText = "Incident Type";
            this.IncidentType.Name = "IncidentType";
            this.IncidentType.ReadOnly = true;
            // 
            // prkDataGridViewTextBoxColumn
            // 
            this.prkDataGridViewTextBoxColumn.DataPropertyName = "prk";
            this.prkDataGridViewTextBoxColumn.HeaderText = "prk";
            this.prkDataGridViewTextBoxColumn.Name = "prkDataGridViewTextBoxColumn";
            this.prkDataGridViewTextBoxColumn.ReadOnly = true;
            this.prkDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateIncident
            // 
            this.dateIncident.DataPropertyName = "dateIncident";
            this.dateIncident.HeaderText = "Date Incident";
            this.dateIncident.Name = "dateIncident";
            this.dateIncident.ReadOnly = true;
            // 
            // incidentNarra
            // 
            this.incidentNarra.DataPropertyName = "incidentNarra";
            this.incidentNarra.HeaderText = "Narrative";
            this.incidentNarra.Name = "incidentNarra";
            this.incidentNarra.ReadOnly = true;
            // 
            // puroknameDataGridViewTextBoxColumn
            // 
            this.puroknameDataGridViewTextBoxColumn.DataPropertyName = "purokname";
            this.puroknameDataGridViewTextBoxColumn.HeaderText = "Purok";
            this.puroknameDataGridViewTextBoxColumn.Name = "puroknameDataGridViewTextBoxColumn";
            this.puroknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.puroknameDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewModelBlotterBindingSource
            // 
            this.viewModelBlotterBindingSource.DataSource = typeof(plths.ViewModel.ViewModelBlotter);
            // 
            // frmBlotter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 650);
            this.Controls.Add(this.dataGridBlotter);
            this.Controls.Add(this.searchbl);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBlotter";
            this.Text = "frmBlotter";
            this.Load += new System.EventHandler(this.frmBlotter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlotter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBlotterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox searchbl;
        private System.Windows.Forms.BindingSource viewModelBlotterBindingSource;
        private Guna.UI.WinForms.GunaDataGridView dataGridBlotter;
        private System.Windows.Forms.DataGridViewTextBoxColumn blotterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Defendant;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncidentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn prkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIncident;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentNarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn puroknameDataGridViewTextBoxColumn;
    }
}