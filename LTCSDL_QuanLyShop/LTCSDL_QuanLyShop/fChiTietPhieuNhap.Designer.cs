namespace LTCSDL_QuanLyShop
{
    partial class fChiTietPhieuNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongTienNhap = new System.Windows.Forms.TextBox();
            this.numSLNhap = new System.Windows.Forms.NumericUpDown();
            this.btThemCTPN = new System.Windows.Forms.Button();
            this.cbbTenSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDPN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLNhap)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Controls.Add(this.txtTongTienNhap);
            this.panel1.Controls.Add(this.numSLNhap);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btThemCTPN);
            this.panel1.Controls.Add(this.cbbTenSP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGiaNhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(241, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 207);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtTongTienNhap
            // 
            this.txtTongTienNhap.Location = new System.Drawing.Point(667, 49);
            this.txtTongTienNhap.Name = "txtTongTienNhap";
            this.txtTongTienNhap.ReadOnly = true;
            this.txtTongTienNhap.Size = new System.Drawing.Size(129, 26);
            this.txtTongTienNhap.TabIndex = 8;
            // 
            // numSLNhap
            // 
            this.numSLNhap.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSLNhap.Location = new System.Drawing.Point(215, 152);
            this.numSLNhap.Name = "numSLNhap";
            this.numSLNhap.Size = new System.Drawing.Size(120, 26);
            this.numSLNhap.TabIndex = 7;
            // 
            // btThemCTPN
            // 
            this.btThemCTPN.Location = new System.Drawing.Point(496, 121);
            this.btThemCTPN.Name = "btThemCTPN";
            this.btThemCTPN.Size = new System.Drawing.Size(146, 57);
            this.btThemCTPN.TabIndex = 5;
            this.btThemCTPN.Text = "Thêm ";
            this.btThemCTPN.UseVisualStyleBackColor = true;
            this.btThemCTPN.Click += new System.EventHandler(this.btThemCTPN_Click);
            // 
            // cbbTenSP
            // 
            this.cbbTenSP.FormattingEnabled = true;
            this.cbbTenSP.Location = new System.Drawing.Point(215, 52);
            this.cbbTenSP.Name = "cbbTenSP";
            this.cbbTenSP.Size = new System.Drawing.Size(173, 28);
            this.cbbTenSP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chi tiết Phiếu Nhâp";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(215, 108);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(173, 26);
            this.txtGiaNhap.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên sản phẩm nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đơn giá nhập/sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // txtIDPN
            // 
            this.txtIDPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPN.Location = new System.Drawing.Point(38, 48);
            this.txtIDPN.Name = "txtIDPN";
            this.txtIDPN.ReadOnly = true;
            this.txtIDPN.Size = new System.Drawing.Size(100, 37);
            this.txtIDPN.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIDPN);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 101);
            this.panel2.TabIndex = 9;
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Location = new System.Drawing.Point(4, 231);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.RowHeadersWidth = 62;
            this.dgvCTPN.RowTemplate.Height = 28;
            this.dgvCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPN.Size = new System.Drawing.Size(1093, 401);
            this.dgvCTPN.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng tiền";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(690, 121);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(146, 57);
            this.btLuu.TabIndex = 9;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // fChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 674);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fChiTietPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.fChiTietPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLNhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongTienNhap;
        private System.Windows.Forms.NumericUpDown numSLNhap;
        private System.Windows.Forms.Button btThemCTPN;
        private System.Windows.Forms.ComboBox cbbTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDPN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btLuu;
    }
}