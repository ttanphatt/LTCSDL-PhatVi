
namespace LTCSDL_QuanLyShop
{
    partial class fThanhToan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaoKH = new System.Windows.Forms.Button();
            this.cbbTenKH = new System.Windows.Forms.ComboBox();
            this.gbTTHD = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lbTongTienHD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoTienTraKhach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTienKhachDua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSPTT = new System.Windows.Forms.DataGridView();
            this.pnTTSP = new System.Windows.Forms.Panel();
            this.numSLSP = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGiaSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.XóaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.cbbTimSanPham = new System.Windows.Forms.ComboBox();
            this.lbIDHD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbTTHD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPTT)).BeginInit();
            this.pnTTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.gbTTHD);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pnTTSP);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 675);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSDTKH);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnTaoKH);
            this.groupBox3.Controls.Add(this.cbbTenKH);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(736, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 160);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên khách hàng: ";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(154, 78);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(259, 30);
            this.txtSDTKH.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số điện thoại: ";
            // 
            // btnTaoKH
            // 
            this.btnTaoKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoKH.Location = new System.Drawing.Point(313, 120);
            this.btnTaoKH.Name = "btnTaoKH";
            this.btnTaoKH.Size = new System.Drawing.Size(100, 30);
            this.btnTaoKH.TabIndex = 1;
            this.btnTaoKH.Text = "Tạo";
            this.btnTaoKH.UseVisualStyleBackColor = true;
            this.btnTaoKH.Click += new System.EventHandler(this.btnTaoKH_Click);
            // 
            // cbbTenKH
            // 
            this.cbbTenKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTenKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenKH.FormattingEnabled = true;
            this.cbbTenKH.Location = new System.Drawing.Point(154, 33);
            this.cbbTenKH.Name = "cbbTenKH";
            this.cbbTenKH.Size = new System.Drawing.Size(259, 30);
            this.cbbTenKH.TabIndex = 0;
            // 
            // gbTTHD
            // 
            this.gbTTHD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbTTHD.Controls.Add(this.btnThanhToan);
            this.gbTTHD.Controls.Add(this.lbTongTienHD);
            this.gbTTHD.Controls.Add(this.label7);
            this.gbTTHD.Controls.Add(this.txtSoTienTraKhach);
            this.gbTTHD.Controls.Add(this.label2);
            this.gbTTHD.Controls.Add(this.txtSoTienKhachDua);
            this.gbTTHD.Controls.Add(this.label4);
            this.gbTTHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTHD.Location = new System.Drawing.Point(736, 169);
            this.gbTTHD.Name = "gbTTHD";
            this.gbTTHD.Size = new System.Drawing.Size(419, 506);
            this.gbTTHD.TabIndex = 3;
            this.gbTTHD.TabStop = false;
            this.gbTTHD.Text = "Thông tin hóa đơn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(269, 450);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(130, 45);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lbTongTienHD
            // 
            this.lbTongTienHD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbTongTienHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTienHD.Location = new System.Drawing.Point(189, 50);
            this.lbTongTienHD.Name = "lbTongTienHD";
            this.lbTongTienHD.Size = new System.Drawing.Size(224, 30);
            this.lbTongTienHD.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng tiền: ";
            // 
            // txtSoTienTraKhach
            // 
            this.txtSoTienTraKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienTraKhach.Location = new System.Drawing.Point(189, 190);
            this.txtSoTienTraKhach.Name = "txtSoTienTraKhach";
            this.txtSoTienTraKhach.Size = new System.Drawing.Size(224, 30);
            this.txtSoTienTraKhach.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số tiền trả khách: ";
            // 
            // txtSoTienKhachDua
            // 
            this.txtSoTienKhachDua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienKhachDua.Location = new System.Drawing.Point(189, 124);
            this.txtSoTienKhachDua.Name = "txtSoTienKhachDua";
            this.txtSoTienKhachDua.Size = new System.Drawing.Size(224, 30);
            this.txtSoTienKhachDua.TabIndex = 7;
            this.txtSoTienKhachDua.TextChanged += new System.EventHandler(this.txtSoTienKhachDua_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tiền khách đưa: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSPTT);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 506);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvSPTT
            // 
            this.dgvSPTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSPTT.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSPTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPTT.Location = new System.Drawing.Point(7, 22);
            this.dgvSPTT.Name = "dgvSPTT";
            this.dgvSPTT.RowHeadersWidth = 51;
            this.dgvSPTT.RowTemplate.Height = 24;
            this.dgvSPTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSPTT.Size = new System.Drawing.Size(713, 478);
            this.dgvSPTT.TabIndex = 0;
            // 
            // pnTTSP
            // 
            this.pnTTSP.Controls.Add(this.numSLSP);
            this.pnTTSP.Controls.Add(this.label9);
            this.pnTTSP.Controls.Add(this.txtDonGiaSP);
            this.pnTTSP.Controls.Add(this.label8);
            this.pnTTSP.Controls.Add(this.label6);
            this.pnTTSP.Controls.Add(this.XóaSP);
            this.pnTTSP.Controls.Add(this.btnThemSP);
            this.pnTTSP.Controls.Add(this.cbbTimSanPham);
            this.pnTTSP.Location = new System.Drawing.Point(0, 3);
            this.pnTTSP.Name = "pnTTSP";
            this.pnTTSP.Size = new System.Drawing.Size(721, 160);
            this.pnTTSP.TabIndex = 0;
            // 
            // numSLSP
            // 
            this.numSLSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSLSP.Location = new System.Drawing.Point(107, 103);
            this.numSLSP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSLSP.Name = "numSLSP";
            this.numSLSP.Size = new System.Drawing.Size(91, 30);
            this.numSLSP.TabIndex = 7;
            this.numSLSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số lượng";
            // 
            // txtDonGiaSP
            // 
            this.txtDonGiaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaSP.Location = new System.Drawing.Point(107, 60);
            this.txtDonGiaSP.Name = "txtDonGiaSP";
            this.txtDonGiaSP.ReadOnly = true;
            this.txtDonGiaSP.Size = new System.Drawing.Size(307, 30);
            this.txtDonGiaSP.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Đơn Gía";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sản Phẩm:";
            // 
            // XóaSP
            // 
            this.XóaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XóaSP.Location = new System.Drawing.Point(606, 120);
            this.XóaSP.Name = "XóaSP";
            this.XóaSP.Size = new System.Drawing.Size(100, 30);
            this.XóaSP.TabIndex = 2;
            this.XóaSP.Text = "Xóa";
            this.XóaSP.UseVisualStyleBackColor = true;
            this.XóaSP.Click += new System.EventHandler(this.XóaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Location = new System.Drawing.Point(490, 120);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(100, 30);
            this.btnThemSP.TabIndex = 1;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // cbbTimSanPham
            // 
            this.cbbTimSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTimSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTimSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimSanPham.FormattingEnabled = true;
            this.cbbTimSanPham.Location = new System.Drawing.Point(107, 19);
            this.cbbTimSanPham.Name = "cbbTimSanPham";
            this.cbbTimSanPham.Size = new System.Drawing.Size(307, 30);
            this.cbbTimSanPham.TabIndex = 0;
            this.cbbTimSanPham.SelectedIndexChanged += new System.EventHandler(this.cbbTimSanPham_SelectedIndexChanged);
            // 
            // lbIDHD
            // 
            this.lbIDHD.BackColor = System.Drawing.Color.Transparent;
            this.lbIDHD.Location = new System.Drawing.Point(133, 700);
            this.lbIDHD.Name = "lbIDHD";
            this.lbIDHD.Size = new System.Drawing.Size(54, 30);
            this.lbIDHD.TabIndex = 5;
            this.lbIDHD.Text = ".";
            this.lbIDHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 703);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã hóa đơn: ";
            // 
            // fThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1182, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbIDHD);
            this.Controls.Add(this.label5);
            this.Name = "fThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThanhToan";
            this.Load += new System.EventHandler(this.fThanhToan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbTTHD.ResumeLayout(false);
            this.gbTTHD.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPTT)).EndInit();
            this.pnTTSP.ResumeLayout(false);
            this.pnTTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSPTT;
        private System.Windows.Forms.Panel pnTTSP;
        private System.Windows.Forms.Button XóaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.ComboBox cbbTimSanPham;
        private System.Windows.Forms.GroupBox gbTTHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lbTongTienHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoTienTraKhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTienKhachDua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIDHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NumericUpDown numSLSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonGiaSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaoKH;
        private System.Windows.Forms.ComboBox cbbTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDTKH;
    }
}