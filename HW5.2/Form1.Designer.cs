namespace HW5._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CheckOut = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.lbl_MoneyLeft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add10M = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Add5M = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Add50Q = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Add1M = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Add20Q = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Add10Q = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tBox_MoneyAmount = new System.Windows.Forms.TextBox();
            this.lbl_MoneyState = new System.Windows.Forms.Label();
            this.tgl_MoneySwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Products = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.product6 = new HW5._2.Product();
            this.product5 = new HW5._2.Product();
            this.product4 = new HW5._2.Product();
            this.product3 = new HW5._2.Product();
            this.product2 = new HW5._2.Product();
            this.product1 = new HW5._2.Product();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_Products.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CheckOut);
            this.panel1.Controls.Add(this.lbl_MoneyLeft);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Add10M);
            this.panel1.Controls.Add(this.btn_Add5M);
            this.panel1.Controls.Add(this.btn_Add50Q);
            this.panel1.Controls.Add(this.btn_Add1M);
            this.panel1.Controls.Add(this.btn_Add20Q);
            this.panel1.Controls.Add(this.btn_Add10Q);
            this.panel1.Controls.Add(this.tBox_MoneyAmount);
            this.panel1.Controls.Add(this.lbl_MoneyState);
            this.panel1.Controls.Add(this.tgl_MoneySwitch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(421, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 426);
            this.panel1.TabIndex = 0;
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Animated = true;
            this.btn_CheckOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CheckOut.BorderThickness = 3;
            this.btn_CheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CheckOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btn_CheckOut.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(244)))), ((int)(((byte)(207)))));
            this.btn_CheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CheckOut.ForeColor = System.Drawing.Color.White;
            this.btn_CheckOut.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btn_CheckOut.Image = global::HW5._2.Properties.Resources.arrow_60px;
            this.btn_CheckOut.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_CheckOut.Location = new System.Drawing.Point(147, 343);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_CheckOut.Size = new System.Drawing.Size(60, 60);
            this.btn_CheckOut.TabIndex = 11;
            this.btn_CheckOut.Tile = false;
            // 
            // lbl_MoneyLeft
            // 
            this.lbl_MoneyLeft.AutoSize = true;
            this.lbl_MoneyLeft.Location = new System.Drawing.Point(112, 311);
            this.lbl_MoneyLeft.Name = "lbl_MoneyLeft";
            this.lbl_MoneyLeft.Size = new System.Drawing.Size(39, 20);
            this.lbl_MoneyLeft.TabIndex = 10;
            this.lbl_MoneyLeft.Text = "0.0₼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Money Left:";
            // 
            // btn_Add10M
            // 
            this.btn_Add10M.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add10M.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add10M.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add10M.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add10M.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add10M.ForeColor = System.Drawing.Color.White;
            this.btn_Add10M.Location = new System.Drawing.Point(239, 197);
            this.btn_Add10M.Name = "btn_Add10M";
            this.btn_Add10M.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Add10M.Size = new System.Drawing.Size(60, 60);
            this.btn_Add10M.TabIndex = 8;
            this.btn_Add10M.Tag = "10";
            this.btn_Add10M.Text = "10₼";
            this.btn_Add10M.Click += new System.EventHandler(this.ChangeMoneyAmount);
            // 
            // btn_Add5M
            // 
            this.btn_Add5M.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add5M.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add5M.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add5M.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add5M.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add5M.ForeColor = System.Drawing.Color.White;
            this.btn_Add5M.Location = new System.Drawing.Point(156, 197);
            this.btn_Add5M.Name = "btn_Add5M";
            this.btn_Add5M.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Add5M.Size = new System.Drawing.Size(60, 60);
            this.btn_Add5M.TabIndex = 8;
            this.btn_Add5M.Tag = "5";
            this.btn_Add5M.Text = "5₼";
            this.btn_Add5M.Click += new System.EventHandler(this.ChangeMoneyAmount);
            // 
            // btn_Add50Q
            // 
            this.btn_Add50Q.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add50Q.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add50Q.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add50Q.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add50Q.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add50Q.ForeColor = System.Drawing.Color.White;
            this.btn_Add50Q.Location = new System.Drawing.Point(239, 131);
            this.btn_Add50Q.Name = "btn_Add50Q";
            this.btn_Add50Q.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Add50Q.Size = new System.Drawing.Size(60, 60);
            this.btn_Add50Q.TabIndex = 8;
            this.btn_Add50Q.Tag = ".5";
            this.btn_Add50Q.Text = "50Q";
            this.btn_Add50Q.Click += new System.EventHandler(this.ChangeMoneyAmount);
            // 
            // btn_Add1M
            // 
            this.btn_Add1M.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add1M.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add1M.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add1M.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add1M.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add1M.ForeColor = System.Drawing.Color.White;
            this.btn_Add1M.Location = new System.Drawing.Point(72, 197);
            this.btn_Add1M.Name = "btn_Add1M";
            this.btn_Add1M.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Add1M.Size = new System.Drawing.Size(60, 60);
            this.btn_Add1M.TabIndex = 8;
            this.btn_Add1M.Tag = "1";
            this.btn_Add1M.Text = "1₼";
            this.btn_Add1M.Click += new System.EventHandler(this.ChangeMoneyAmount);
            // 
            // btn_Add20Q
            // 
            this.btn_Add20Q.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add20Q.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add20Q.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add20Q.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add20Q.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add20Q.ForeColor = System.Drawing.Color.White;
            this.btn_Add20Q.Location = new System.Drawing.Point(156, 131);
            this.btn_Add20Q.Name = "btn_Add20Q";
            this.btn_Add20Q.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Add20Q.Size = new System.Drawing.Size(60, 60);
            this.btn_Add20Q.TabIndex = 8;
            this.btn_Add20Q.Tag = ".2";
            this.btn_Add20Q.Text = "20Q";
            this.btn_Add20Q.Click += new System.EventHandler(this.ChangeMoneyAmount);
            // 
            // btn_Add10Q
            // 
            this.btn_Add10Q.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add10Q.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add10Q.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add10Q.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add10Q.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add10Q.ForeColor = System.Drawing.Color.White;
            this.btn_Add10Q.Location = new System.Drawing.Point(72, 131);
            this.btn_Add10Q.Name = "btn_Add10Q";
            this.btn_Add10Q.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Add10Q.Size = new System.Drawing.Size(60, 60);
            this.btn_Add10Q.TabIndex = 8;
            this.btn_Add10Q.Tag = ".1";
            this.btn_Add10Q.Text = "10Q";
            this.btn_Add10Q.Click += new System.EventHandler(this.ChangeMoneyAmount);
            // 
            // tBox_MoneyAmount
            // 
            this.tBox_MoneyAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBox_MoneyAmount.Location = new System.Drawing.Point(74, 76);
            this.tBox_MoneyAmount.Name = "tBox_MoneyAmount";
            this.tBox_MoneyAmount.Size = new System.Drawing.Size(222, 34);
            this.tBox_MoneyAmount.TabIndex = 7;
            this.tBox_MoneyAmount.Text = "0";
            this.tBox_MoneyAmount.TextChanged += new System.EventHandler(this.tBox_MoneyAmount_TextChanged);
            // 
            // lbl_MoneyState
            // 
            this.lbl_MoneyState.Location = new System.Drawing.Point(5, 15);
            this.lbl_MoneyState.Name = "lbl_MoneyState";
            this.lbl_MoneyState.Size = new System.Drawing.Size(73, 20);
            this.lbl_MoneyState.TabIndex = 6;
            this.lbl_MoneyState.Text = "Add";
            this.lbl_MoneyState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tgl_MoneySwitch
            // 
            this.tgl_MoneySwitch.Checked = true;
            this.tgl_MoneySwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tgl_MoneySwitch.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.tgl_MoneySwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgl_MoneySwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tgl_MoneySwitch.Location = new System.Drawing.Point(20, 39);
            this.tgl_MoneySwitch.Name = "tgl_MoneySwitch";
            this.tgl_MoneySwitch.Size = new System.Drawing.Size(44, 25);
            this.tgl_MoneySwitch.TabIndex = 5;
            this.tgl_MoneySwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgl_MoneySwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgl_MoneySwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgl_MoneySwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tgl_MoneySwitch.CheckedChanged += new System.EventHandler(this.tgl_MoneySwitch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Money Amount:";
            // 
            // pnl_Products
            // 
            this.pnl_Products.AutoScroll = true;
            this.pnl_Products.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Products.Controls.Add(this.product6);
            this.pnl_Products.Controls.Add(this.product5);
            this.pnl_Products.Controls.Add(this.product4);
            this.pnl_Products.Controls.Add(this.product3);
            this.pnl_Products.Controls.Add(this.product2);
            this.pnl_Products.Controls.Add(this.product1);
            this.pnl_Products.FillColor = System.Drawing.Color.White;
            this.pnl_Products.Location = new System.Drawing.Point(15, 38);
            this.pnl_Products.Name = "pnl_Products";
            this.pnl_Products.ShadowColor = System.Drawing.Color.Black;
            this.pnl_Products.Size = new System.Drawing.Size(365, 426);
            this.pnl_Products.TabIndex = 1;
            // 
            // product6
            // 
            this.product6.BuyQuantity = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product6.Location = new System.Drawing.Point(186, 359);
            this.product6.Name = "product6";
            this.product6.Price = 0.5F;
            this.product6.ProductImage = global::HW5._2.Properties.Resources.aquafina_bottle;
            this.product6.Quantity = 52;
            this.product6.Size = new System.Drawing.Size(142, 172);
            this.product6.TabIndex = 0;
            // 
            // product5
            // 
            this.product5.BuyQuantity = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product5.Location = new System.Drawing.Point(3, 359);
            this.product5.Name = "product5";
            this.product5.Price = 0.8F;
            this.product5.ProductImage = global::HW5._2.Properties.Resources.albeni;
            this.product5.Quantity = 40;
            this.product5.Size = new System.Drawing.Size(142, 172);
            this.product5.TabIndex = 0;
            // 
            // product4
            // 
            this.product4.BuyQuantity = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product4.Location = new System.Drawing.Point(186, 181);
            this.product4.Name = "product4";
            this.product4.Price = 1F;
            this.product4.ProductImage = global::HW5._2.Properties.Resources.cola;
            this.product4.Quantity = 21;
            this.product4.Size = new System.Drawing.Size(142, 172);
            this.product4.TabIndex = 0;
            // 
            // product3
            // 
            this.product3.BuyQuantity = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product3.Location = new System.Drawing.Point(3, 181);
            this.product3.Name = "product3";
            this.product3.Price = 1.8F;
            this.product3.ProductImage = global::HW5._2.Properties.Resources.fusetea1;
            this.product3.Quantity = 14;
            this.product3.Size = new System.Drawing.Size(142, 172);
            this.product3.TabIndex = 0;
            // 
            // product2
            // 
            this.product2.BuyQuantity = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product2.Location = new System.Drawing.Point(186, 3);
            this.product2.Name = "product2";
            this.product2.Price = 1.4F;
            this.product2.ProductImage = global::HW5._2.Properties.Resources.bounty1;
            this.product2.Quantity = 32;
            this.product2.Size = new System.Drawing.Size(142, 172);
            this.product2.TabIndex = 0;
            // 
            // product1
            // 
            this.product1.BuyQuantity = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product1.Location = new System.Drawing.Point(3, 3);
            this.product1.Name = "product1";
            this.product1.Price = 1.4F;
            this.product1.ProductImage = global::HW5._2.Properties.Resources.snickers;
            this.product1.Quantity = 20;
            this.product1.Size = new System.Drawing.Size(142, 172);
            this.product1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lbl_Exit);
            this.panel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 37);
            this.panel2.TabIndex = 2;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Exit.Location = new System.Drawing.Point(772, 5);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(25, 28);
            this.lbl_Exit.TabIndex = 0;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Products);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Products.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_MoneyLeft;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Add10M;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Add5M;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Add50Q;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Add1M;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Add20Q;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Add10Q;
        private TextBox tBox_MoneyAmount;
        private Label lbl_MoneyState;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tgl_MoneySwitch;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_CheckOut;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_Products;
        private Product product6;
        private Product product5;
        private Product product4;
        private Product product3;
        private Product product2;
        private Product product1;
        private Panel panel2;
        private Label lbl_Exit;
    }
}