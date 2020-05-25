namespace PhanSo
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
            this.txtMauSo02 = new System.Windows.Forms.TextBox();
            this.txtTuSo02 = new System.Windows.Forms.TextBox();
            this.txtMauSo01 = new System.Windows.Forms.TextBox();
            this.txtTuSo01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMauSo02
            // 
            this.txtMauSo02.Location = new System.Drawing.Point(409, 89);
            this.txtMauSo02.Margin = new System.Windows.Forms.Padding(5);
            this.txtMauSo02.Name = "txtMauSo02";
            this.txtMauSo02.Size = new System.Drawing.Size(172, 34);
            this.txtMauSo02.TabIndex = 7;
            // 
            // txtTuSo02
            // 
            this.txtTuSo02.Location = new System.Drawing.Point(185, 87);
            this.txtTuSo02.Margin = new System.Windows.Forms.Padding(5);
            this.txtTuSo02.Name = "txtTuSo02";
            this.txtTuSo02.Size = new System.Drawing.Size(172, 34);
            this.txtTuSo02.TabIndex = 6;
            // 
            // txtMauSo01
            // 
            this.txtMauSo01.Location = new System.Drawing.Point(409, 27);
            this.txtMauSo01.Margin = new System.Windows.Forms.Padding(5);
            this.txtMauSo01.Name = "txtMauSo01";
            this.txtMauSo01.Size = new System.Drawing.Size(172, 34);
            this.txtMauSo01.TabIndex = 5;
            // 
            // txtTuSo01
            // 
            this.txtTuSo01.Location = new System.Drawing.Point(185, 27);
            this.txtTuSo01.Margin = new System.Windows.Forms.Padding(5);
            this.txtTuSo01.Name = "txtTuSo01";
            this.txtTuSo01.Size = new System.Drawing.Size(172, 34);
            this.txtTuSo01.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phân Số 01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phân Số 02";
            // 
            // btnSoSanh
            // 
            this.btnSoSanh.Location = new System.Drawing.Point(185, 142);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(172, 39);
            this.btnSoSanh.TabIndex = 10;
            this.btnSoSanh.Text = "So Sánh";
            this.btnSoSanh.UseVisualStyleBackColor = true;
            this.btnSoSanh.Click += new System.EventHandler(this.btnSoSanh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(409, 142);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(172, 39);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 208);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSoSanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMauSo02);
            this.Controls.Add(this.txtTuSo02);
            this.Controls.Add(this.txtMauSo01);
            this.Controls.Add(this.txtTuSo01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMauSo02;
        private System.Windows.Forms.TextBox txtTuSo02;
        private System.Windows.Forms.TextBox txtMauSo01;
        private System.Windows.Forms.TextBox txtTuSo01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSoSanh;
        private System.Windows.Forms.Button btnThoat;
    }
}

