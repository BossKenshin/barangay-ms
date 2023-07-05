
namespace plths.Borrow
{
    partial class frmBorrowerlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrowerlist));
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.borrowerGrid = new Guna.UI.WinForms.GunaDataGridView();
            this.returnItemBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.doneBtn = new Guna.UI2.WinForms.Guna2Button();
            this.borrowidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewModelBorrowersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBorrowersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Wheat;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 50);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(592, 10);
            this.guna2Separator1.TabIndex = 70;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(592, 50);
            this.guna2Panel1.TabIndex = 69;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(146, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Borrower List";
            // 
            // borrowerGrid
            // 
            this.borrowerGrid.AllowUserToAddRows = false;
            this.borrowerGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.borrowerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.borrowerGrid.AutoGenerateColumns = false;
            this.borrowerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.borrowerGrid.BackgroundColor = System.Drawing.Color.White;
            this.borrowerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.borrowerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.borrowerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.borrowerGrid.ColumnHeadersHeight = 21;
            this.borrowerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowidDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.borrowerDataGridViewTextBoxColumn,
            this.borrowedquantityDataGridViewTextBoxColumn,
            this.returnItemBtn});
            this.borrowerGrid.DataSource = this.viewModelBorrowersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowerGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.borrowerGrid.EnableHeadersVisualStyles = false;
            this.borrowerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.borrowerGrid.Location = new System.Drawing.Point(37, 96);
            this.borrowerGrid.Name = "borrowerGrid";
            this.borrowerGrid.ReadOnly = true;
            this.borrowerGrid.RowHeadersVisible = false;
            this.borrowerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowerGrid.Size = new System.Drawing.Size(513, 273);
            this.borrowerGrid.TabIndex = 71;
            this.borrowerGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.borrowerGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.borrowerGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.borrowerGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.borrowerGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.borrowerGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.borrowerGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.borrowerGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.borrowerGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.borrowerGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.borrowerGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.borrowerGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.borrowerGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.borrowerGrid.ThemeStyle.HeaderStyle.Height = 21;
            this.borrowerGrid.ThemeStyle.ReadOnly = true;
            this.borrowerGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.borrowerGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.borrowerGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.borrowerGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.borrowerGrid.ThemeStyle.RowsStyle.Height = 22;
            this.borrowerGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.borrowerGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.borrowerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowerGrid_CellClick);
            // 
            // returnItemBtn
            // 
            this.returnItemBtn.HeaderText = "Action";
            this.returnItemBtn.Name = "returnItemBtn";
            this.returnItemBtn.ReadOnly = true;
            this.returnItemBtn.Text = "Return Item";
            this.returnItemBtn.UseColumnTextForButtonValue = true;
            // 
            // doneBtn
            // 
            this.doneBtn.BorderRadius = 12;
            this.doneBtn.CheckedState.Parent = this.doneBtn;
            this.doneBtn.CustomImages.Parent = this.doneBtn;
            this.doneBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.doneBtn.ForeColor = System.Drawing.Color.White;
            this.doneBtn.HoverState.Parent = this.doneBtn;
            this.doneBtn.Image = ((System.Drawing.Image)(resources.GetObject("doneBtn.Image")));
            this.doneBtn.Location = new System.Drawing.Point(450, 393);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.ShadowDecoration.Parent = this.doneBtn;
            this.doneBtn.Size = new System.Drawing.Size(100, 45);
            this.doneBtn.TabIndex = 72;
            this.doneBtn.Text = "Done";
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // borrowidDataGridViewTextBoxColumn
            // 
            this.borrowidDataGridViewTextBoxColumn.DataPropertyName = "borrowid";
            this.borrowidDataGridViewTextBoxColumn.HeaderText = "borrowid";
            this.borrowidDataGridViewTextBoxColumn.Name = "borrowidDataGridViewTextBoxColumn";
            this.borrowidDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowidDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "itemname";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "itemname";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            this.itemnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "itemid";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "itemid";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemidDataGridViewTextBoxColumn.Visible = false;
            // 
            // borrowerDataGridViewTextBoxColumn
            // 
            this.borrowerDataGridViewTextBoxColumn.DataPropertyName = "borrower";
            this.borrowerDataGridViewTextBoxColumn.HeaderText = "borrower";
            this.borrowerDataGridViewTextBoxColumn.Name = "borrowerDataGridViewTextBoxColumn";
            this.borrowerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowedquantityDataGridViewTextBoxColumn
            // 
            this.borrowedquantityDataGridViewTextBoxColumn.DataPropertyName = "borrowedquantity";
            this.borrowedquantityDataGridViewTextBoxColumn.HeaderText = "borrowedquantity";
            this.borrowedquantityDataGridViewTextBoxColumn.Name = "borrowedquantityDataGridViewTextBoxColumn";
            this.borrowedquantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewModelBorrowersBindingSource
            // 
            this.viewModelBorrowersBindingSource.DataSource = typeof(plths.ViewModel.ViewModelBorrowers);
            // 
            // frmBorrowerlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.borrowerGrid);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBorrowerlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBorrowerlist";
            this.Load += new System.EventHandler(this.frmBorrowerlist_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBorrowersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaDataGridView borrowerGrid;
        private Guna.UI2.WinForms.Guna2Button doneBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn returnItemBtn;
        private System.Windows.Forms.BindingSource viewModelBorrowersBindingSource;
    }
}