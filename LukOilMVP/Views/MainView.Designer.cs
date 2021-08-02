namespace LukOilMVP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PetrolCmbBx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PriceTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.PriceNPDwn = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.LitrNPDwn = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.PriceRdBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.LitrRdBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TotalPaymentLbl = new System.Windows.Forms.Label();
            this.PayCrclBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RemoveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PaymentLstBx = new System.Windows.Forms.ListBox();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNPDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LitrNPDwn)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PetrolCmbBx
            // 
            this.PetrolCmbBx.BorderColor = System.Drawing.Color.Empty;
            this.PetrolCmbBx.BorderThickness = 0;
            this.PetrolCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.PetrolCmbBx.FillColor = System.Drawing.Color.Empty;
            this.PetrolCmbBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetrolCmbBx.FocusedColor = System.Drawing.Color.Empty;
            this.PetrolCmbBx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PetrolCmbBx.ForeColor = System.Drawing.Color.Black;
            this.PetrolCmbBx.ItemHeight = 17;
            this.PetrolCmbBx.Location = new System.Drawing.Point(151, 27);
            this.PetrolCmbBx.Name = "PetrolCmbBx";
            this.PetrolCmbBx.Size = new System.Drawing.Size(140, 25);
            this.PetrolCmbBx.StartIndex = 0;
            this.PetrolCmbBx.TabIndex = 1;
            this.PetrolCmbBx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.PetrolCmbBx.SelectedIndexChanged += new System.EventHandler(this.PetrolCmbBx_SelectedIndexChanged);
            // 
            // PriceTxtBx
            // 
            this.PriceTxtBx.BackColor = System.Drawing.Color.White;
            this.PriceTxtBx.BorderColor = System.Drawing.Color.Empty;
            this.PriceTxtBx.BorderThickness = 0;
            this.PriceTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTxtBx.DefaultText = null;
            this.PriceTxtBx.Enabled = false;
            this.PriceTxtBx.FillColor = System.Drawing.Color.Empty;
            this.PriceTxtBx.ForeColor = System.Drawing.Color.Empty;
            this.PriceTxtBx.HideSelection = false;
            this.PriceTxtBx.IconLeftCursor = null;
            this.PriceTxtBx.IconLeftSize = new System.Drawing.Size(0, 0);
            this.PriceTxtBx.IconRightCursor = null;
            this.PriceTxtBx.IconRightSize = new System.Drawing.Size(0, 0);
            this.PriceTxtBx.Location = new System.Drawing.Point(151, 92);
            this.PriceTxtBx.MaxLength = 0;
            this.PriceTxtBx.Name = "PriceTxtBx";
            this.PriceTxtBx.PasswordChar = '\0';
            this.PriceTxtBx.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PriceTxtBx.PlaceholderText = null;
            this.PriceTxtBx.SelectedText = null;
            this.PriceTxtBx.ShortcutsEnabled = false;
            this.PriceTxtBx.Size = new System.Drawing.Size(140, 36);
            this.PriceTxtBx.TabIndex = 2;
            this.PriceTxtBx.WordWrap = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Empty;
            this.guna2GroupBox1.BorderThickness = 0;
            this.guna2GroupBox1.Controls.Add(this.PriceNPDwn);
            this.guna2GroupBox1.Controls.Add(this.LitrNPDwn);
            this.guna2GroupBox1.Controls.Add(this.PriceRdBtn);
            this.guna2GroupBox1.Controls.Add(this.LitrRdBtn);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Empty;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Empty;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.Location = new System.Drawing.Point(47, 171);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(300, 174);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = null;
            this.guna2GroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // PriceNPDwn
            // 
            this.PriceNPDwn.BackColor = System.Drawing.Color.White;
            this.PriceNPDwn.BorderColor = System.Drawing.Color.Empty;
            this.PriceNPDwn.BorderThickness = 0;
            this.PriceNPDwn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceNPDwn.FillColor = System.Drawing.Color.Empty;
            this.PriceNPDwn.ForeColor = System.Drawing.Color.Empty;
            this.PriceNPDwn.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PriceNPDwn.Location = new System.Drawing.Point(176, 126);
            this.PriceNPDwn.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PriceNPDwn.Name = "PriceNPDwn";
            this.PriceNPDwn.Size = new System.Drawing.Size(100, 36);
            this.PriceNPDwn.TabIndex = 3;
            this.PriceNPDwn.UpDownButtonBorderVisible = false;
            this.PriceNPDwn.UpDownButtonFillColor = System.Drawing.Color.Empty;
            this.PriceNPDwn.UpDownButtonForeColor = System.Drawing.Color.Empty;
            this.PriceNPDwn.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // LitrNPDwn
            // 
            this.LitrNPDwn.BackColor = System.Drawing.Color.White;
            this.LitrNPDwn.BorderColor = System.Drawing.Color.Empty;
            this.LitrNPDwn.BorderThickness = 0;
            this.LitrNPDwn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LitrNPDwn.FillColor = System.Drawing.Color.Empty;
            this.LitrNPDwn.ForeColor = System.Drawing.Color.Empty;
            this.LitrNPDwn.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LitrNPDwn.Location = new System.Drawing.Point(176, 67);
            this.LitrNPDwn.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LitrNPDwn.Name = "LitrNPDwn";
            this.LitrNPDwn.Size = new System.Drawing.Size(100, 36);
            this.LitrNPDwn.TabIndex = 2;
            this.LitrNPDwn.UpDownButtonBorderVisible = false;
            this.LitrNPDwn.UpDownButtonFillColor = System.Drawing.Color.Empty;
            this.LitrNPDwn.UpDownButtonForeColor = System.Drawing.Color.Empty;
            this.LitrNPDwn.ValueChanged += new System.EventHandler(this.LitrNPDwn_ValueChanged);
            // 
            // PriceRdBtn
            // 
            this.PriceRdBtn.BackColor = System.Drawing.Color.Transparent;
            this.PriceRdBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceRdBtn.Location = new System.Drawing.Point(30, 126);
            this.PriceRdBtn.Name = "PriceRdBtn";
            this.PriceRdBtn.Size = new System.Drawing.Size(92, 29);
            this.PriceRdBtn.TabIndex = 1;
            this.PriceRdBtn.Text = "Price";
            this.PriceRdBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.PriceRdBtn.UseVisualStyleBackColor = false;
            this.PriceRdBtn.CheckedChanged += new System.EventHandler(this.PriceRdBtn_CheckedChanged);
            // 
            // LitrRdBtn
            // 
            this.LitrRdBtn.BackColor = System.Drawing.Color.White;
            this.LitrRdBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LitrRdBtn.Location = new System.Drawing.Point(30, 67);
            this.LitrRdBtn.Name = "LitrRdBtn";
            this.LitrRdBtn.Size = new System.Drawing.Size(76, 29);
            this.LitrRdBtn.TabIndex = 0;
            this.LitrRdBtn.Text = "Litr";
            this.LitrRdBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.LitrRdBtn.UseVisualStyleBackColor = false;
            this.LitrRdBtn.CheckedChanged += new System.EventHandler(this.LitrRdBtn_CheckedChanged);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Controls.Add(this.TotalPaymentLbl);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Empty;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(92, 416);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Empty;
            this.guna2ShadowPanel1.ShadowDepth = 0;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(231, 100);
            this.guna2ShadowPanel1.TabIndex = 4;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // TotalPaymentLbl
            // 
            this.TotalPaymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPaymentLbl.Location = new System.Drawing.Point(26, 33);
            this.TotalPaymentLbl.Name = "TotalPaymentLbl";
            this.TotalPaymentLbl.Size = new System.Drawing.Size(35, 25);
            this.TotalPaymentLbl.TabIndex = 0;
            this.TotalPaymentLbl.Text = "0";
            this.TotalPaymentLbl.Click += new System.EventHandler(this.TotalPaymentLbl_Click);
            // 
            // PayCrclBtn
            // 
            this.PayCrclBtn.BorderColor = System.Drawing.Color.Empty;
            this.PayCrclBtn.FillColor = System.Drawing.Color.Empty;
            this.PayCrclBtn.FillColor2 = System.Drawing.Color.Empty;
            this.PayCrclBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayCrclBtn.ForeColor = System.Drawing.Color.Red;
            this.PayCrclBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PayCrclBtn.ImageSize = new System.Drawing.Size(0, 0);
            this.PayCrclBtn.Location = new System.Drawing.Point(0, 0);
            this.PayCrclBtn.Name = "PayCrclBtn";
            this.PayCrclBtn.PressedColor = System.Drawing.Color.Empty;
            this.PayCrclBtn.PressedDepth = 0;
            this.PayCrclBtn.Size = new System.Drawing.Size(0, 0);
            this.PayCrclBtn.TabIndex = 5;
            this.PayCrclBtn.Text = null;
            this.PayCrclBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PayCrclBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.PayCrclBtn.Click += new System.EventHandler(this.PayCrclBtn_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Empty;
            this.guna2GroupBox2.BorderThickness = 0;
            this.guna2GroupBox2.Controls.Add(this.ClearBtn);
            this.guna2GroupBox2.Controls.Add(this.RemoveBtn);
            this.guna2GroupBox2.Controls.Add(this.PaymentLstBx);
            this.guna2GroupBox2.Controls.Add(this.InfoLbl);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Empty;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Empty;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Red;
            this.guna2GroupBox2.Location = new System.Drawing.Point(459, 57);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(641, 505);
            this.guna2GroupBox2.TabIndex = 6;
            this.guna2GroupBox2.Text = null;
            this.guna2GroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BorderColor = System.Drawing.Color.Empty;
            this.ClearBtn.FillColor = System.Drawing.Color.Empty;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.Gold;
            this.ClearBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClearBtn.ImageSize = new System.Drawing.Size(0, 0);
            this.ClearBtn.Location = new System.Drawing.Point(0, 0);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.PressedColor = System.Drawing.Color.Empty;
            this.ClearBtn.PressedDepth = 0;
            this.ClearBtn.Size = new System.Drawing.Size(0, 0);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = null;
            this.ClearBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClearBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BorderColor = System.Drawing.Color.Empty;
            this.RemoveBtn.FillColor = System.Drawing.Color.Empty;
            this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.Gold;
            this.RemoveBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemoveBtn.ImageSize = new System.Drawing.Size(0, 0);
            this.RemoveBtn.Location = new System.Drawing.Point(0, 0);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.PressedColor = System.Drawing.Color.Empty;
            this.RemoveBtn.PressedDepth = 0;
            this.RemoveBtn.Size = new System.Drawing.Size(0, 0);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = null;
            this.RemoveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemoveBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            this.RemoveBtn.MouseLeave += new System.EventHandler(this.RemoveBtn_MouseLeave);
            this.RemoveBtn.MouseHover += new System.EventHandler(this.RemoveBtn_MouseHover);
            // 
            // PaymentLstBx
            // 
            this.PaymentLstBx.FormattingEnabled = true;
            this.PaymentLstBx.ItemHeight = 21;
            this.PaymentLstBx.Location = new System.Drawing.Point(22, 77);
            this.PaymentLstBx.Name = "PaymentLstBx";
            this.PaymentLstBx.Size = new System.Drawing.Size(547, 340);
            this.PaymentLstBx.TabIndex = 1;
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.InfoLbl.Location = new System.Drawing.Point(18, 50);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(172, 21);
            this.InfoLbl.TabIndex = 0;
            this.InfoLbl.Text = "There is no payment*";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fuel";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1154, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.PayCrclBtn);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.PriceTxtBx);
            this.Controls.Add(this.PetrolCmbBx);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PriceNPDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LitrNPDwn)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    
        private Guna.UI2.WinForms.Guna2ComboBox PetrolCmbBx;
        private Guna.UI2.WinForms.Guna2TextBox PriceTxtBx;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown PriceNPDwn;
        private Guna.UI2.WinForms.Guna2NumericUpDown LitrNPDwn;
        private Guna.UI2.WinForms.Guna2RadioButton PriceRdBtn;
        private Guna.UI2.WinForms.Guna2RadioButton LitrRdBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton PayCrclBtn;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button RemoveBtn;
        private System.Windows.Forms.ListBox PaymentLstBx;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalPaymentLbl;
    }
}

