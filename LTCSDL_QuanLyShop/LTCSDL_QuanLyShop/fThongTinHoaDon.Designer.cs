
namespace LTCSDL_QuanLyShop
{
    partial class fThongTinHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIDHD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCTSP = new System.Windows.Forms.DataGridView();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 1;
            // 
            // lbIDHD
            // 
            this.lbIDHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIDHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDHD.Location = new System.Drawing.Point(304, 43);
            this.lbIDHD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbIDHD.Name = "lbIDHD";
            this.lbIDHD.Size = new System.Drawing.Size(83, 48);
            this.lbIDHD.TabIndex = 2;
            this.lbIDHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khách hàng:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(323, 102);
            this.lbTenKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(220, 33);
            this.lbTenKH.TabIndex = 4;
            this.lbTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSDT
            // 
            this.lbSDT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(323, 151);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(220, 33);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại:";
            // 
            // dgvCTSP
            // 
            this.dgvCTSP.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCTSP.ColumnHeadersHeight = 29;
            this.dgvCTSP.Location = new System.Drawing.Point(113, 265);
            this.dgvCTSP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvCTSP.Name = "dgvCTSP";
            this.dgvCTSP.RowHeadersWidth = 51;
            this.dgvCTSP.RowTemplate.Height = 24;
            this.dgvCTSP.Size = new System.Drawing.Size(460, 298);
            this.dgvCTSP.TabIndex = 7;
            // 
            // lbTongTien
            // 
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(323, 205);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(220, 33);
            this.lbTongTien.TabIndex = 9;
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(156, 209);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tổng tiền:";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(586, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 28);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fThongTinHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 596);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvCTSP);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbIDHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fThongTinHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThongTinHoaDon";
            this.Load += new System.EventHandler(this.fThongTinHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIDHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvCTSP;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnThoat;
    }
}