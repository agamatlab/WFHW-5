namespace WFHW_5
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
            this.pic_Car = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_Vendor = new System.Windows.Forms.TextBox();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.tBox_Model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_Engine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_Year = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Car
            // 
            this.pic_Car.Location = new System.Drawing.Point(225, 23);
            this.pic_Car.Name = "pic_Car";
            this.pic_Car.Size = new System.Drawing.Size(280, 162);
            this.pic_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Car.TabIndex = 0;
            this.pic_Car.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendor:";
            // 
            // tBox_Vendor
            // 
            this.tBox_Vendor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Vendor.Location = new System.Drawing.Point(12, 37);
            this.tBox_Vendor.Name = "tBox_Vendor";
            this.tBox_Vendor.ReadOnly = true;
            this.tBox_Vendor.Size = new System.Drawing.Size(167, 38);
            this.tBox_Vendor.TabIndex = 2;
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Model.Location = new System.Drawing.Point(12, 82);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(73, 28);
            this.lbl_Model.TabIndex = 1;
            this.lbl_Model.Text = "Model:";
            // 
            // tBox_Model
            // 
            this.tBox_Model.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Model.Location = new System.Drawing.Point(12, 113);
            this.tBox_Model.Name = "tBox_Model";
            this.tBox_Model.ReadOnly = true;
            this.tBox_Model.Size = new System.Drawing.Size(167, 38);
            this.tBox_Model.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Engine:";
            // 
            // tBox_Engine
            // 
            this.tBox_Engine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Engine.Location = new System.Drawing.Point(12, 188);
            this.tBox_Engine.Name = "tBox_Engine";
            this.tBox_Engine.ReadOnly = true;
            this.tBox_Engine.Size = new System.Drawing.Size(167, 38);
            this.tBox_Engine.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Year:";
            // 
            // tBox_Year
            // 
            this.tBox_Year.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Year.Location = new System.Drawing.Point(12, 260);
            this.tBox_Year.Name = "tBox_Year";
            this.tBox_Year.ReadOnly = true;
            this.tBox_Year.Size = new System.Drawing.Size(167, 38);
            this.tBox_Year.TabIndex = 2;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(301, 217);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(115, 40);
            this.btn_Change.TabIndex = 3;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 308);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.tBox_Year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBox_Engine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBox_Model);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.tBox_Vendor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Car);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_Car;
        private Label label1;
        private TextBox tBox_Vendor;
        private Label lbl_Model;
        private TextBox tBox_Model;
        private Label label3;
        private TextBox tBox_Engine;
        private Label label4;
        private TextBox tBox_Year;
        private Button btn_Change;
    }
}