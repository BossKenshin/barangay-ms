
namespace plths.Cedula
{
    partial class frmCedula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCedula));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.comboCivil = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbproff = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbtax = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpDOB = new Guna.UI.WinForms.GunaDateTimePicker();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbheight = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbweight = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearanceCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbcitizen = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pob = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dsex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Sex = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(80, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Cedula";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Wheat;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 50);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(719, 10);
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
            this.guna2Panel1.Size = new System.Drawing.Size(719, 50);
            this.guna2Panel1.TabIndex = 65;
            // 
            // comboCivil
            // 
            this.comboCivil.BackColor = System.Drawing.Color.Transparent;
            this.comboCivil.BorderRadius = 12;
            this.comboCivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCivil.FocusedColor = System.Drawing.Color.Empty;
            this.comboCivil.FocusedState.Parent = this.comboCivil;
            this.comboCivil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboCivil.FormattingEnabled = true;
            this.comboCivil.HoverState.Parent = this.comboCivil;
            this.comboCivil.ItemHeight = 30;
            this.comboCivil.Items.AddRange(new object[] {
            "Single ",
            "Married",
            "Separated"});
            this.comboCivil.ItemsAppearance.Parent = this.comboCivil;
            this.comboCivil.Location = new System.Drawing.Point(298, 201);
            this.comboCivil.Name = "comboCivil";
            this.comboCivil.ShadowDecoration.Parent = this.comboCivil;
            this.comboCivil.Size = new System.Drawing.Size(140, 36);
            this.comboCivil.TabIndex = 86;
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(297, 175);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(80, 20);
            this.guna2HtmlLabel19.TabIndex = 85;
            this.guna2HtmlLabel19.Text = "Civil Status:";
            // 
            // tbproff
            // 
            this.tbproff.BorderRadius = 12;
            this.tbproff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbproff.DefaultText = "";
            this.tbproff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbproff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbproff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbproff.DisabledState.Parent = this.tbproff;
            this.tbproff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbproff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbproff.FocusedState.Parent = this.tbproff;
            this.tbproff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbproff.HoverState.Parent = this.tbproff;
            this.tbproff.Location = new System.Drawing.Point(245, 109);
            this.tbproff.Margin = new System.Windows.Forms.Padding(4);
            this.tbproff.Name = "tbproff";
            this.tbproff.PasswordChar = '\0';
            this.tbproff.PlaceholderText = "";
            this.tbproff.SelectedText = "";
            this.tbproff.ShadowDecoration.Parent = this.tbproff;
            this.tbproff.Size = new System.Drawing.Size(227, 41);
            this.tbproff.TabIndex = 88;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(245, 82);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(79, 20);
            this.guna2HtmlLabel4.TabIndex = 87;
            this.guna2HtmlLabel4.Text = "Profession:";
            // 
            // tbtax
            // 
            this.tbtax.BorderRadius = 12;
            this.tbtax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtax.DefaultText = "";
            this.tbtax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtax.DisabledState.Parent = this.tbtax;
            this.tbtax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtax.FocusedState.Parent = this.tbtax;
            this.tbtax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtax.HoverState.Parent = this.tbtax;
            this.tbtax.Location = new System.Drawing.Point(12, 201);
            this.tbtax.Margin = new System.Windows.Forms.Padding(4);
            this.tbtax.Name = "tbtax";
            this.tbtax.PasswordChar = '\0';
            this.tbtax.PlaceholderText = "";
            this.tbtax.SelectedText = "";
            this.tbtax.ShadowDecoration.Parent = this.tbtax;
            this.tbtax.Size = new System.Drawing.Size(270, 41);
            this.tbtax.TabIndex = 90;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 174);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(173, 20);
            this.guna2HtmlLabel5.TabIndex = 89;
            this.guna2HtmlLabel5.Text = "Tax Identification Number:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.BaseColor = System.Drawing.Color.White;
            this.dtpDOB.BorderColor = System.Drawing.Color.Silver;
            this.dtpDOB.CustomFormat = null;
            this.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDOB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOB.ForeColor = System.Drawing.Color.Black;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(492, 109);
            this.dtpDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDOB.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDOB.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDOB.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDOB.Size = new System.Drawing.Size(201, 41);
            this.dtpDOB.TabIndex = 92;
            this.dtpDOB.Text = "3/10/2023";
            this.dtpDOB.Value = new System.DateTime(2023, 3, 10, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(492, 84);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(89, 20);
            this.guna2HtmlLabel17.TabIndex = 91;
            this.guna2HtmlLabel17.Text = "Date of Birth:";
            // 
            // tbheight
            // 
            this.tbheight.BorderRadius = 12;
            this.tbheight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbheight.DefaultText = "";
            this.tbheight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbheight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbheight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbheight.DisabledState.Parent = this.tbheight;
            this.tbheight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbheight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbheight.FocusedState.Parent = this.tbheight;
            this.tbheight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbheight.HoverState.Parent = this.tbheight;
            this.tbheight.Location = new System.Drawing.Point(560, 202);
            this.tbheight.Margin = new System.Windows.Forms.Padding(4);
            this.tbheight.Name = "tbheight";
            this.tbheight.PasswordChar = '\0';
            this.tbheight.PlaceholderText = "";
            this.tbheight.SelectedText = "";
            this.tbheight.ShadowDecoration.Parent = this.tbheight;
            this.tbheight.Size = new System.Drawing.Size(133, 41);
            this.tbheight.TabIndex = 94;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(560, 175);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(49, 20);
            this.guna2HtmlLabel7.TabIndex = 93;
            this.guna2HtmlLabel7.Text = "Height:";
            // 
            // tbweight
            // 
            this.tbweight.BorderRadius = 12;
            this.tbweight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbweight.DefaultText = "";
            this.tbweight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbweight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbweight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbweight.DisabledState.Parent = this.tbweight;
            this.tbweight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbweight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbweight.FocusedState.Parent = this.tbweight;
            this.tbweight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbweight.HoverState.Parent = this.tbweight;
            this.tbweight.Location = new System.Drawing.Point(455, 201);
            this.tbweight.Margin = new System.Windows.Forms.Padding(4);
            this.tbweight.Name = "tbweight";
            this.tbweight.PasswordChar = '\0';
            this.tbweight.PlaceholderText = "";
            this.tbweight.SelectedText = "";
            this.tbweight.ShadowDecoration.Parent = this.tbweight;
            this.tbweight.Size = new System.Drawing.Size(97, 41);
            this.tbweight.TabIndex = 96;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(455, 174);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(53, 20);
            this.guna2HtmlLabel8.TabIndex = 95;
            this.guna2HtmlLabel8.Text = "Weight:";
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
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.ImageSize = new System.Drawing.Size(21, 21);
            this.printBtn.Location = new System.Drawing.Point(499, 362);
            this.printBtn.Name = "printBtn";
            this.printBtn.ShadowDecoration.Parent = this.printBtn;
            this.printBtn.Size = new System.Drawing.Size(94, 36);
            this.printBtn.TabIndex = 99;
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
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
            this.btnClearanceCancel.Location = new System.Drawing.Point(599, 362);
            this.btnClearanceCancel.Name = "btnClearanceCancel";
            this.btnClearanceCancel.ShadowDecoration.Parent = this.btnClearanceCancel;
            this.btnClearanceCancel.Size = new System.Drawing.Size(94, 36);
            this.btnClearanceCancel.TabIndex = 98;
            this.btnClearanceCancel.Text = "Cancel";
            this.btnClearanceCancel.Click += new System.EventHandler(this.btnClearanceCancel_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(13, 82);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(79, 20);
            this.guna2HtmlLabel3.TabIndex = 83;
            this.guna2HtmlLabel3.Text = "Citizenship:";
            // 
            // tbcitizen
            // 
            this.tbcitizen.BorderRadius = 12;
            this.tbcitizen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbcitizen.DefaultText = "";
            this.tbcitizen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbcitizen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbcitizen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcitizen.DisabledState.Parent = this.tbcitizen;
            this.tbcitizen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcitizen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcitizen.FocusedState.Parent = this.tbcitizen;
            this.tbcitizen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcitizen.HoverState.Parent = this.tbcitizen;
            this.tbcitizen.Location = new System.Drawing.Point(13, 109);
            this.tbcitizen.Margin = new System.Windows.Forms.Padding(4);
            this.tbcitizen.Name = "tbcitizen";
            this.tbcitizen.PasswordChar = '\0';
            this.tbcitizen.PlaceholderText = "";
            this.tbcitizen.SelectedText = "";
            this.tbcitizen.ShadowDecoration.Parent = this.tbcitizen;
            this.tbcitizen.Size = new System.Drawing.Size(211, 41);
            this.tbcitizen.TabIndex = 84;
            // 
            // tbaddress
            // 
            this.tbaddress.BorderRadius = 12;
            this.tbaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbaddress.DefaultText = "";
            this.tbaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbaddress.DisabledState.Parent = this.tbaddress;
            this.tbaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbaddress.FocusedState.Parent = this.tbaddress;
            this.tbaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbaddress.HoverState.Parent = this.tbaddress;
            this.tbaddress.Location = new System.Drawing.Point(12, 285);
            this.tbaddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.PasswordChar = '\0';
            this.tbaddress.PlaceholderText = "";
            this.tbaddress.SelectedText = "";
            this.tbaddress.ShadowDecoration.Parent = this.tbaddress;
            this.tbaddress.Size = new System.Drawing.Size(312, 41);
            this.tbaddress.TabIndex = 103;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 258);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 20);
            this.guna2HtmlLabel2.TabIndex = 102;
            this.guna2HtmlLabel2.Text = "Address";
            // 
            // pob
            // 
            this.pob.BorderRadius = 12;
            this.pob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pob.DefaultText = "";
            this.pob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pob.DisabledState.Parent = this.pob;
            this.pob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pob.FocusedState.Parent = this.pob;
            this.pob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pob.HoverState.Parent = this.pob;
            this.pob.Location = new System.Drawing.Point(333, 285);
            this.pob.Margin = new System.Windows.Forms.Padding(4);
            this.pob.Name = "pob";
            this.pob.PasswordChar = '\0';
            this.pob.PlaceholderText = "";
            this.pob.SelectedText = "";
            this.pob.ShadowDecoration.Parent = this.pob;
            this.pob.Size = new System.Drawing.Size(193, 41);
            this.pob.TabIndex = 105;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(333, 258);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(94, 20);
            this.guna2HtmlLabel6.TabIndex = 104;
            this.guna2HtmlLabel6.Text = "Place Of Birth";
            // 
            // dsex
            // 
            this.dsex.BackColor = System.Drawing.Color.Transparent;
            this.dsex.BorderRadius = 12;
            this.dsex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dsex.FocusedColor = System.Drawing.Color.Empty;
            this.dsex.FocusedState.Parent = this.dsex;
            this.dsex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dsex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dsex.FormattingEnabled = true;
            this.dsex.HoverState.Parent = this.dsex;
            this.dsex.ItemHeight = 30;
            this.dsex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.dsex.ItemsAppearance.Parent = this.dsex;
            this.dsex.Location = new System.Drawing.Point(533, 285);
            this.dsex.Name = "dsex";
            this.dsex.ShadowDecoration.Parent = this.dsex;
            this.dsex.Size = new System.Drawing.Size(160, 36);
            this.dsex.TabIndex = 107;
            // 
            // Sex
            // 
            this.Sex.BackColor = System.Drawing.Color.Transparent;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(533, 259);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(28, 20);
            this.Sex.TabIndex = 106;
            this.Sex.Text = "Sex";
            // 
            // frmCedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 438);
            this.Controls.Add(this.dsex);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.pob);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.btnClearanceCancel);
            this.Controls.Add(this.tbweight);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.tbheight);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.guna2HtmlLabel17);
            this.Controls.Add(this.tbtax);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.tbproff);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.comboCivil);
            this.Controls.Add(this.guna2HtmlLabel19);
            this.Controls.Add(this.tbcitizen);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCedula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCedula";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboCivil;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2TextBox tbproff;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox tbtax;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDOB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2TextBox tbheight;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox tbweight;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private Guna.UI2.WinForms.Guna2Button btnClearanceCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox tbcitizen;
        private Guna.UI2.WinForms.Guna2TextBox tbaddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox pob;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox dsex;
        private Guna.UI2.WinForms.Guna2HtmlLabel Sex;
    }
}