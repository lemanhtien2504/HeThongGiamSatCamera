
namespace Camera
{
    partial class QLCamera
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
            this.DgviewDanhSachCamera = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txtTenCamera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2TaoTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2QLDVHC = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2QLCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2XemCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRtspUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgviewDanhSachCamera)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgviewDanhSachCamera
            // 
            this.DgviewDanhSachCamera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgviewDanhSachCamera.Location = new System.Drawing.Point(84, 460);
            this.DgviewDanhSachCamera.Name = "DgviewDanhSachCamera";
            this.DgviewDanhSachCamera.Size = new System.Drawing.Size(1000, 450);
            this.DgviewDanhSachCamera.TabIndex = 13;
            this.DgviewDanhSachCamera.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgviewDanhSachCamera_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ CAMERA THEO ĐƠN VỊ HÀNH CHÍNH";
            // 
            // btQuayLai
            // 
            this.btQuayLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLai.Location = new System.Drawing.Point(984, 352);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(100, 50);
            this.btQuayLai.TabIndex = 10;
            this.btQuayLai.Text = "Quay lại";
            this.btQuayLai.UseVisualStyleBackColor = true;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(878, 352);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 50);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(772, 352);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 50);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(666, 352);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 50);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(560, 352);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(100, 50);
            this.btTimKiem.TabIndex = 6;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // txtTenCamera
            // 
            this.txtTenCamera.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCamera.Location = new System.Drawing.Point(288, 172);
            this.txtTenCamera.Name = "txtTenCamera";
            this.txtTenCamera.Size = new System.Drawing.Size(796, 32);
            this.txtTenCamera.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Danh sách Camera";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên camera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vị trí:";
            // 
            // txtViTri
            // 
            this.txtViTri.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTri.Location = new System.Drawing.Point(288, 249);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(796, 32);
            this.txtViTri.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(288, 287);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(796, 59);
            this.txtGhiChu.TabIndex = 5;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTaiKhoan,
            this.MenuChucNang,
            this.MenuTroGiup});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip2.TabIndex = 26;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuTaiKhoan
            // 
            this.MenuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu2TaoTaiKhoan,
            this.Menu2DoiMatKhau,
            this.Menu2DangXuat});
            this.MenuTaiKhoan.Name = "MenuTaiKhoan";
            this.MenuTaiKhoan.Size = new System.Drawing.Size(69, 20);
            this.MenuTaiKhoan.Text = "Tài khoản";
            // 
            // Menu2TaoTaiKhoan
            // 
            this.Menu2TaoTaiKhoan.Name = "Menu2TaoTaiKhoan";
            this.Menu2TaoTaiKhoan.Size = new System.Drawing.Size(145, 22);
            this.Menu2TaoTaiKhoan.Text = "Tạo tài khoản";
            // 
            // Menu2DoiMatKhau
            // 
            this.Menu2DoiMatKhau.Name = "Menu2DoiMatKhau";
            this.Menu2DoiMatKhau.Size = new System.Drawing.Size(145, 22);
            this.Menu2DoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // Menu2DangXuat
            // 
            this.Menu2DangXuat.Name = "Menu2DangXuat";
            this.Menu2DangXuat.Size = new System.Drawing.Size(145, 22);
            this.Menu2DangXuat.Text = "Đăng xuất";
            // 
            // MenuChucNang
            // 
            this.MenuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu2QLDVHC,
            this.Menu2QLCamera,
            this.Menu2XemCamera});
            this.MenuChucNang.Name = "MenuChucNang";
            this.MenuChucNang.Size = new System.Drawing.Size(77, 20);
            this.MenuChucNang.Text = "Chức năng";
            // 
            // Menu2QLDVHC
            // 
            this.Menu2QLDVHC.Name = "Menu2QLDVHC";
            this.Menu2QLDVHC.Size = new System.Drawing.Size(215, 22);
            this.Menu2QLDVHC.Text = "Quản lý Đơn vị hành chính";
            this.Menu2QLDVHC.Click += new System.EventHandler(this.Menu2QLDVHC_Click);
            // 
            // Menu2QLCamera
            // 
            this.Menu2QLCamera.Name = "Menu2QLCamera";
            this.Menu2QLCamera.Size = new System.Drawing.Size(215, 22);
            this.Menu2QLCamera.Text = "Quản lý Camera";
            this.Menu2QLCamera.Click += new System.EventHandler(this.Menu2QLCamera_Click);
            // 
            // Menu2XemCamera
            // 
            this.Menu2XemCamera.Name = "Menu2XemCamera";
            this.Menu2XemCamera.Size = new System.Drawing.Size(215, 22);
            this.Menu2XemCamera.Text = "Xem Camera";
            this.Menu2XemCamera.Click += new System.EventHandler(this.Menu2XemCamera_Click);
            // 
            // MenuTroGiup
            // 
            this.MenuTroGiup.Name = "MenuTroGiup";
            this.MenuTroGiup.Size = new System.Drawing.Size(62, 20);
            this.MenuTroGiup.Text = "Trợ giúp";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(288, 134);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(141, 32);
            this.txtMa.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã:";
            // 
            // txtRtspUrl
            // 
            this.txtRtspUrl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtspUrl.Location = new System.Drawing.Point(288, 210);
            this.txtRtspUrl.Name = "txtRtspUrl";
            this.txtRtspUrl.Size = new System.Drawing.Size(796, 32);
            this.txtRtspUrl.TabIndex = 3;
            this.txtRtspUrl.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "RtspUrl:";
            // 
            // QLCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRtspUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenCamera);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgviewDanhSachCamera);
            this.Name = "QLCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLCamera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLCamera_FormClosing);
            this.Load += new System.EventHandler(this.QLCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgviewDanhSachCamera)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgviewDanhSachCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtTenCamera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem Menu2TaoTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem Menu2DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem Menu2DangXuat;
        private System.Windows.Forms.ToolStripMenuItem MenuChucNang;
        private System.Windows.Forms.ToolStripMenuItem Menu2QLDVHC;
        private System.Windows.Forms.ToolStripMenuItem Menu2QLCamera;
        private System.Windows.Forms.ToolStripMenuItem Menu2XemCamera;
        private System.Windows.Forms.ToolStripMenuItem MenuTroGiup;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRtspUrl;
        private System.Windows.Forms.Label label7;
    }
}