
namespace plths
{
    partial class frmHousehold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHousehold));
            this.dataGridViewHousehold = new Guna.UI2.WinForms.Guna2DataGridView();
            this.hmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewModelHouseholdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.memberView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHousehold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelHouseholdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHousehold
            // 
            this.dataGridViewHousehold.AllowUserToAddRows = false;
            this.dataGridViewHousehold.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewHousehold.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHousehold.AutoGenerateColumns = false;
            this.dataGridViewHousehold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHousehold.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHousehold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHousehold.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewHousehold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHousehold.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHousehold.ColumnHeadersHeight = 30;
            this.dataGridViewHousehold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hmidDataGridViewTextBoxColumn,
            this.leaderfullnameDataGridViewTextBoxColumn,
            this.Delete,
            this.update});
            this.dataGridViewHousehold.DataSource = this.viewModelHouseholdBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHousehold.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHousehold.EnableHeadersVisualStyles = false;
            this.dataGridViewHousehold.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewHousehold.Location = new System.Drawing.Point(31, 127);
            this.dataGridViewHousehold.Name = "dataGridViewHousehold";
            this.dataGridViewHousehold.ReadOnly = true;
            this.dataGridViewHousehold.RowHeadersVisible = false;
            this.dataGridViewHousehold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHousehold.Size = new System.Drawing.Size(578, 471);
            this.dataGridViewHousehold.TabIndex = 0;
            this.dataGridViewHousehold.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewHousehold.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewHousehold.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewHousehold.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewHousehold.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewHousehold.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewHousehold.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewHousehold.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewHousehold.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewHousehold.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewHousehold.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewHousehold.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewHousehold.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewHousehold.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridViewHousehold.ThemeStyle.ReadOnly = true;
            this.dataGridViewHousehold.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewHousehold.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewHousehold.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewHousehold.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewHousehold.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewHousehold.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewHousehold.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewHousehold.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHousehold_CellClick);
            // 
            // hmidDataGridViewTextBoxColumn
            // 
            this.hmidDataGridViewTextBoxColumn.DataPropertyName = "hmid";
            this.hmidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.hmidDataGridViewTextBoxColumn.Name = "hmidDataGridViewTextBoxColumn";
            this.hmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.hmidDataGridViewTextBoxColumn.Visible = false;
            // 
            // leaderfullnameDataGridViewTextBoxColumn
            // 
            this.leaderfullnameDataGridViewTextBoxColumn.DataPropertyName = "leaderfullname";
            this.leaderfullnameDataGridViewTextBoxColumn.FillWeight = 133.2271F;
            this.leaderfullnameDataGridViewTextBoxColumn.HeaderText = "Household Leader";
            this.leaderfullnameDataGridViewTextBoxColumn.Name = "leaderfullnameDataGridViewTextBoxColumn";
            this.leaderfullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 76.14214F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // update
            // 
            this.update.DataPropertyName = "hmid";
            this.update.HeaderText = "";
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.update.Text = "update";
            this.update.UseColumnTextForButtonValue = true;
            // 
            // viewModelHouseholdBindingSource
            // 
            this.viewModelHouseholdBindingSource.DataSource = typeof(plths.ViewModel.ViewModelHousehold);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 12;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(31, 84);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search..";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(350, 37);
            this.guna2TextBox1.TabIndex = 1;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(480, 84);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(129, 37);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Add household";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // memberView
            // 
            this.memberView.BackColor = System.Drawing.Color.White;
            this.memberView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberView.GridLines = true;
            this.memberView.HideSelection = false;
            this.memberView.Location = new System.Drawing.Point(644, 154);
            this.memberView.Name = "memberView";
            this.memberView.Size = new System.Drawing.Size(305, 444);
            this.memberView.TabIndex = 3;
            this.memberView.UseCompatibleStateImageBehavior = false;
            this.memberView.View = System.Windows.Forms.View.Tile;
            this.memberView.SelectedIndexChanged += new System.EventHandler(this.memberView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Household Members";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(200, 50);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Household";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Panel1.Location = new System.Drawing.Point(634, 154);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(326, 444);
            this.guna2Panel1.TabIndex = 7;
            // 
            // frmHousehold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 621);
            this.Controls.Add(this.memberView);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.dataGridViewHousehold);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHousehold";
            this.ShowInTaskbar = false;
            this.Text = "frmHousehold";
            this.Load += new System.EventHandler(this.frmHousehold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHousehold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelHouseholdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewHousehold;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.BindingSource viewModelHouseholdBindingSource;
        private System.Windows.Forms.ListView memberView;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn update;
    }
}