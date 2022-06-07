namespace HW5._2
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Product = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.num_BuyQuantity = new System.Windows.Forms.NumericUpDown();
            this.pic_ProductImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cBox_Count = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnl_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BuyQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Product
            // 
            this.pnl_Product.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Product.Controls.Add(this.lbl_Price);
            this.pnl_Product.Controls.Add(this.num_BuyQuantity);
            this.pnl_Product.Controls.Add(this.pic_ProductImage);
            this.pnl_Product.Enabled = false;
            this.pnl_Product.FillColor = System.Drawing.Color.White;
            this.pnl_Product.Location = new System.Drawing.Point(3, 3);
            this.pnl_Product.Name = "pnl_Product";
            this.pnl_Product.ShadowColor = System.Drawing.Color.Black;
            this.pnl_Product.Size = new System.Drawing.Size(134, 131);
            this.pnl_Product.TabIndex = 0;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(79, 92);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(39, 20);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "0.0₼";
            // 
            // num_BuyQuantity
            // 
            this.num_BuyQuantity.Location = new System.Drawing.Point(17, 90);
            this.num_BuyQuantity.Name = "num_BuyQuantity";
            this.num_BuyQuantity.ReadOnly = true;
            this.num_BuyQuantity.Size = new System.Drawing.Size(56, 27);
            this.num_BuyQuantity.TabIndex = 1;
            this.num_BuyQuantity.ValueChanged += new System.EventHandler(this.num_BuyQuantity_ValueChanged);
            // 
            // pic_ProductImage
            // 
            this.pic_ProductImage.ImageRotate = 0F;
            this.pic_ProductImage.Location = new System.Drawing.Point(32, 13);
            this.pic_ProductImage.Name = "pic_ProductImage";
            this.pic_ProductImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_ProductImage.Size = new System.Drawing.Size(70, 70);
            this.pic_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ProductImage.TabIndex = 0;
            this.pic_ProductImage.TabStop = false;
            // 
            // cBox_Count
            // 
            this.cBox_Count.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_Count.CheckedState.BorderRadius = 0;
            this.cBox_Count.CheckedState.BorderThickness = 0;
            this.cBox_Count.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_Count.Location = new System.Drawing.Point(11, 140);
            this.cBox_Count.Name = "cBox_Count";
            this.cBox_Count.Size = new System.Drawing.Size(110, 30);
            this.cBox_Count.TabIndex = 1;
            this.cBox_Count.Text = "0 pcs";
            this.cBox_Count.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cBox_Count.UncheckedState.BorderRadius = 0;
            this.cBox_Count.UncheckedState.BorderThickness = 0;
            this.cBox_Count.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cBox_Count.CheckedChanged += new System.EventHandler(this.cBox_Count_CheckedChanged);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBox_Count);
            this.Controls.Add(this.pnl_Product);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(140, 171);
            this.pnl_Product.ResumeLayout(false);
            this.pnl_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BuyQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_Product;
        private Label lbl_Price;
        private NumericUpDown num_BuyQuantity;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_ProductImage;
        public Guna.UI2.WinForms.Guna2CheckBox cBox_Count;
    }
}
