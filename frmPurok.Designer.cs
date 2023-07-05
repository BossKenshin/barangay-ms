
namespace plths
{
    partial class frmPurok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.purokDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.viewModelPurokBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purokDataset = new plths.purokDataset();
            this.purokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purokTableAdapter = new plths.purokDatasetTableAdapters.PurokTableAdapter();
            this.viewModelPurokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Purok_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurokName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurokLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purokIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purokNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purokLeaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.purokDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelPurokBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purokDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelPurokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(857, 97);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(117, 42);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Add Purok";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // purokDataGridView
            // 
            this.purokDataGridView.AllowUserToAddRows = false;
            this.purokDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.purokDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purokDataGridView.AutoGenerateColumns = false;
            this.purokDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purokDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.purokDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purokDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purokDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purokDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purokDataGridView.ColumnHeadersHeight = 22;
            this.purokDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Purok_Id,
            this.PurokName,
            this.PurokLeader,
            this.Contact,
            this.Status,
            this.purokIdDataGridViewTextBoxColumn,
            this.purokNameDataGridViewTextBoxColumn,
            this.purokLeaderDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.purokDataGridView.DataSource = this.viewModelPurokBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purokDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.purokDataGridView.EnableHeadersVisualStyles = false;
            this.purokDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purokDataGridView.Location = new System.Drawing.Point(12, 145);
            this.purokDataGridView.Name = "purokDataGridView";
            this.purokDataGridView.ReadOnly = true;
            this.purokDataGridView.RowHeadersVisible = false;
            this.purokDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purokDataGridView.Size = new System.Drawing.Size(962, 351);
            this.purokDataGridView.TabIndex = 4;
            this.purokDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.purokDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.purokDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.purokDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.purokDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.purokDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.purokDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.purokDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purokDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.purokDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.purokDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.purokDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.purokDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.purokDataGridView.ThemeStyle.HeaderStyle.Height = 22;
            this.purokDataGridView.ThemeStyle.ReadOnly = true;
            this.purokDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.purokDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purokDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.purokDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.purokDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.purokDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purokDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.purokDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purokDataGridView_CellClick);
            this.purokDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purokDataGridView_CellContentClick);
            // 
            // viewModelPurokBindingSource1
            // 
            this.viewModelPurokBindingSource1.DataSource = typeof(plths.ViewModel.ViewModelPurok);
            // 
            // purokDataset
            // 
            this.purokDataset.DataSetName = "purokDataset";
            this.purokDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purokBindingSource
            // 
            this.purokBindingSource.DataMember = "Purok";
            this.purokBindingSource.DataSource = this.purokDataset;
            // 
            // purokTableAdapter
            // 
            this.purokTableAdapter.ClearBeforeFill = true;
            // 
            // viewModelPurokBindingSource
            // 
            this.viewModelPurokBindingSource.DataSource = typeof(plths.ViewModel.ViewModelPurok);
            this.viewModelPurokBindingSource.CurrentChanged += new System.EventHandler(this.viewModelPurokBindingSource_CurrentChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(182, 50);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Purok List";
            // 
            // Purok_Id
            // 
            this.Purok_Id.DataPropertyName = "Purok_Id";
            this.Purok_Id.HeaderText = "ID";
            this.Purok_Id.Name = "Purok_Id";
            this.Purok_Id.ReadOnly = true;
            this.Purok_Id.Visible = false;
            // 
            // PurokName
            // 
            this.PurokName.DataPropertyName = "PurokName";
            this.PurokName.HeaderText = "Purok";
            this.PurokName.Name = "PurokName";
            this.PurokName.ReadOnly = true;
            this.PurokName.Visible = false;
            // 
            // PurokLeader
            // 
            this.PurokLeader.DataPropertyName = "PurokLeader";
            this.PurokLeader.HeaderText = "Leader";
            this.PurokLeader.Name = "PurokLeader";
            this.PurokLeader.ReadOnly = true;
            this.PurokLeader.Visible = false;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            this.Contact.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // purokIdDataGridViewTextBoxColumn
            // 
            this.purokIdDataGridViewTextBoxColumn.DataPropertyName = "Purok_Id";
            this.purokIdDataGridViewTextBoxColumn.HeaderText = "Purok_Id";
            this.purokIdDataGridViewTextBoxColumn.Name = "purokIdDataGridViewTextBoxColumn";
            this.purokIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.purokIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // purokNameDataGridViewTextBoxColumn
            // 
            this.purokNameDataGridViewTextBoxColumn.DataPropertyName = "PurokName";
            this.purokNameDataGridViewTextBoxColumn.HeaderText = "PurokName";
            this.purokNameDataGridViewTextBoxColumn.Name = "purokNameDataGridViewTextBoxColumn";
            this.purokNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purokLeaderDataGridViewTextBoxColumn
            // 
            this.purokLeaderDataGridViewTextBoxColumn.DataPropertyName = "PurokLeader";
            this.purokLeaderDataGridViewTextBoxColumn.HeaderText = "PurokLeader";
            this.purokLeaderDataGridViewTextBoxColumn.Name = "purokLeaderDataGridViewTextBoxColumn";
            this.purokLeaderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPurok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 518);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.purokDataGridView);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurok";
            this.Text = "frmPurok";
            this.Load += new System.EventHandler(this.frmPurok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purokDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelPurokBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purokDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelPurokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView purokDataGridView;
        private System.Windows.Forms.BindingSource viewModelPurokBindingSource;
        private purokDataset purokDataset;
        private System.Windows.Forms.BindingSource purokBindingSource;
        private purokDatasetTableAdapters.PurokTableAdapter purokTableAdapter;
        private System.Windows.Forms.BindingSource viewModelPurokBindingSource1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purok_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurokName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurokLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn purokIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purokNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purokLeaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}