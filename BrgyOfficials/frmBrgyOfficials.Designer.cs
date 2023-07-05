
namespace plths.BrgyOfficials
{
    partial class frmBrgyOfficials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrgyOfficials));
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.brgyname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.brgyposition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClearanceCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearnceSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Wheat;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 50);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(593, 10);
            this.guna2Separator1.TabIndex = 66;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(593, 50);
            this.guna2Panel1.TabIndex = 65;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(11, 11);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(196, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = " Barangay Officials";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(28, 98);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(115, 20);
            this.guna2HtmlLabel2.TabIndex = 68;
            this.guna2HtmlLabel2.Text = "Complete Name:";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // brgyname
            // 
            this.brgyname.BorderRadius = 12;
            this.brgyname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brgyname.DefaultText = "";
            this.brgyname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.brgyname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.brgyname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.brgyname.DisabledState.Parent = this.brgyname;
            this.brgyname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.brgyname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brgyname.FocusedState.Parent = this.brgyname;
            this.brgyname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brgyname.HoverState.Parent = this.brgyname;
            this.brgyname.Location = new System.Drawing.Point(28, 124);
            this.brgyname.Name = "brgyname";
            this.brgyname.PasswordChar = '\0';
            this.brgyname.PlaceholderText = "";
            this.brgyname.SelectedText = "";
            this.brgyname.ShadowDecoration.Parent = this.brgyname;
            this.brgyname.Size = new System.Drawing.Size(318, 36);
            this.brgyname.TabIndex = 67;
            this.brgyname.TextChanged += new System.EventHandler(this.tbIssuedPlace_TextChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(363, 98);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(61, 20);
            this.guna2HtmlLabel3.TabIndex = 70;
            this.guna2HtmlLabel3.Text = "Position:";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // brgyposition
            // 
            this.brgyposition.BackColor = System.Drawing.Color.Transparent;
            this.brgyposition.BorderRadius = 12;
            this.brgyposition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.brgyposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brgyposition.FocusedColor = System.Drawing.Color.Empty;
            this.brgyposition.FocusedState.Parent = this.brgyposition;
            this.brgyposition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.brgyposition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.brgyposition.FormattingEnabled = true;
            this.brgyposition.HoverState.Parent = this.brgyposition;
            this.brgyposition.ItemHeight = 30;
            this.brgyposition.Items.AddRange(new object[] {
            "Captain",
            "Secretary",
            "Treasurer",
            "Kagawad",
            "SK"});
            this.brgyposition.ItemsAppearance.Parent = this.brgyposition;
            this.brgyposition.Location = new System.Drawing.Point(363, 124);
            this.brgyposition.Name = "brgyposition";
            this.brgyposition.ShadowDecoration.Parent = this.brgyposition;
            this.brgyposition.Size = new System.Drawing.Size(206, 36);
            this.brgyposition.TabIndex = 94;
            this.brgyposition.SelectedIndexChanged += new System.EventHandler(this.brgyposition_SelectedIndexChanged);
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
            this.btnClearanceCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnClearanceCancel.Image")));
            this.btnClearanceCancel.ImageSize = new System.Drawing.Size(23, 23);
            this.btnClearanceCancel.Location = new System.Drawing.Point(477, 202);
            this.btnClearanceCancel.Name = "btnClearanceCancel";
            this.btnClearanceCancel.ShadowDecoration.Parent = this.btnClearanceCancel;
            this.btnClearanceCancel.Size = new System.Drawing.Size(92, 42);
            this.btnClearanceCancel.TabIndex = 96;
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
            this.btnClearnceSave.Image = ((System.Drawing.Image)(resources.GetObject("btnClearnceSave.Image")));
            this.btnClearnceSave.Location = new System.Drawing.Point(375, 202);
            this.btnClearnceSave.Name = "btnClearnceSave";
            this.btnClearnceSave.ShadowDecoration.Parent = this.btnClearnceSave;
            this.btnClearnceSave.Size = new System.Drawing.Size(96, 42);
            this.btnClearnceSave.TabIndex = 95;
            this.btnClearnceSave.Text = "Save";
            this.btnClearnceSave.Click += new System.EventHandler(this.btnClearnceSave_Click);
            // 
            // frmBrgyOfficials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 285);
            this.Controls.Add(this.btnClearanceCancel);
            this.Controls.Add(this.btnClearnceSave);
            this.Controls.Add(this.brgyposition);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.brgyname);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBrgyOfficials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrgyOfficials";
            this.Load += new System.EventHandler(this.frmBrgyOfficials_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox brgyname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox brgyposition;
        private Guna.UI2.WinForms.Guna2Button btnClearanceCancel;
        private Guna.UI2.WinForms.Guna2Button btnClearnceSave;
    }
}