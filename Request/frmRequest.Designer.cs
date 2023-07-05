
namespace plths.Request
{
    partial class frmRequest
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
            this.requestGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.requestidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.requestListViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioResident = new Guna.UI2.WinForms.Guna2RadioButton();
            this.notradioResident = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.requestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestListViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // requestGrid
            // 
            this.requestGrid.AllowUserToAddRows = false;
            this.requestGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.requestGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.requestGrid.AutoGenerateColumns = false;
            this.requestGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestGrid.BackgroundColor = System.Drawing.Color.White;
            this.requestGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.requestGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.requestGrid.ColumnHeadersHeight = 21;
            this.requestGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestidDataGridViewTextBoxColumn,
            this.name,
            this.resid,
            this.document,
            this.amountDataGridViewTextBoxColumn,
            this.print});
            this.requestGrid.DataSource = this.requestListViewModelBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.requestGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.requestGrid.EnableHeadersVisualStyles = false;
            this.requestGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.requestGrid.Location = new System.Drawing.Point(12, 110);
            this.requestGrid.Name = "requestGrid";
            this.requestGrid.ReadOnly = true;
            this.requestGrid.RowHeadersVisible = false;
            this.requestGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestGrid.Size = new System.Drawing.Size(756, 340);
            this.requestGrid.TabIndex = 0;
            this.requestGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.requestGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.requestGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.requestGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.requestGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.requestGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.requestGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.requestGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.requestGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.requestGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.requestGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.requestGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.requestGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.requestGrid.ThemeStyle.HeaderStyle.Height = 21;
            this.requestGrid.ThemeStyle.ReadOnly = true;
            this.requestGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.requestGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.requestGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.requestGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.requestGrid.ThemeStyle.RowsStyle.Height = 22;
            this.requestGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.requestGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.requestGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestGrid_CellContentClick);
            // 
            // requestidDataGridViewTextBoxColumn
            // 
            this.requestidDataGridViewTextBoxColumn.DataPropertyName = "request_id";
            this.requestidDataGridViewTextBoxColumn.HeaderText = "request_id";
            this.requestidDataGridViewTextBoxColumn.Name = "requestidDataGridViewTextBoxColumn";
            this.requestidDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestidDataGridViewTextBoxColumn.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "namekaze";
            this.name.FillWeight = 126.5842F;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // resid
            // 
            this.resid.DataPropertyName = "resid";
            this.resid.HeaderText = "resid";
            this.resid.Name = "resid";
            this.resid.ReadOnly = true;
            this.resid.Visible = false;
            // 
            // document
            // 
            this.document.DataPropertyName = "service";
            this.document.FillWeight = 35.09496F;
            this.document.HeaderText = "Document";
            this.document.Name = "document";
            this.document.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.FillWeight = 45.46203F;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // print
            // 
            this.print.FillWeight = 23.31571F;
            this.print.HeaderText = "Action";
            this.print.Name = "print";
            this.print.ReadOnly = true;
            this.print.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.print.Text = "Print";
            this.print.UseColumnTextForButtonValue = true;
            // 
            // requestListViewModelBindingSource
            // 
            this.requestListViewModelBindingSource.DataSource = typeof(plths.ViewModel.requestListViewModel);
            // 
            // radioResident
            // 
            this.radioResident.AutoSize = true;
            this.radioResident.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioResident.CheckedState.BorderThickness = 0;
            this.radioResident.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioResident.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioResident.CheckedState.InnerOffset = -4;
            this.radioResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioResident.Location = new System.Drawing.Point(12, 80);
            this.radioResident.Name = "radioResident";
            this.radioResident.Size = new System.Drawing.Size(120, 24);
            this.radioResident.TabIndex = 2;
            this.radioResident.TabStop = true;
            this.radioResident.Text = "Resident List";
            this.radioResident.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioResident.UncheckedState.BorderThickness = 2;
            this.radioResident.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioResident.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioResident.UseVisualStyleBackColor = true;
            this.radioResident.CheckedChanged += new System.EventHandler(this.radioResident_CheckedChanged);
            // 
            // notradioResident
            // 
            this.notradioResident.AutoSize = true;
            this.notradioResident.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.notradioResident.CheckedState.BorderThickness = 0;
            this.notradioResident.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.notradioResident.CheckedState.InnerColor = System.Drawing.Color.White;
            this.notradioResident.CheckedState.InnerOffset = -4;
            this.notradioResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notradioResident.Location = new System.Drawing.Point(152, 80);
            this.notradioResident.Name = "notradioResident";
            this.notradioResident.Size = new System.Drawing.Size(154, 24);
            this.notradioResident.TabIndex = 3;
            this.notradioResident.TabStop = true;
            this.notradioResident.Text = "Non-Resident List";
            this.notradioResident.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.notradioResident.UncheckedState.BorderThickness = 2;
            this.notradioResident.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.notradioResident.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.notradioResident.UseVisualStyleBackColor = true;
            this.notradioResident.CheckedChanged += new System.EventHandler(this.notradioResident_CheckedChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(153, 50);
            this.gunaLabel2.TabIndex = 22;
            this.gunaLabel2.Text = "Request";
            // 
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.notradioResident);
            this.Controls.Add(this.radioResident);
            this.Controls.Add(this.requestGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRequest";
            this.Load += new System.EventHandler(this.frmRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestListViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView requestGrid;
        private System.Windows.Forms.BindingSource requestListViewModelBindingSource;
        private Guna.UI2.WinForms.Guna2RadioButton radioResident;
        private Guna.UI2.WinForms.Guna2RadioButton notradioResident;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn resid;
        private System.Windows.Forms.DataGridViewTextBoxColumn document;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn print;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}