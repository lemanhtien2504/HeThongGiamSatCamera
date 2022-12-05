
namespace Camera
{
    partial class GiaoDien
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
            this.btQLDVHC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2TaoTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btQLCamera = new System.Windows.Forms.Button();
            this.btXemCamera = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btQLDVHC
            // 
            this.btQLDVHC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btQLDVHC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLDVHC.Location = new System.Drawing.Point(27, 212);
            this.btQLDVHC.Name = "btQLDVHC";
            this.btQLDVHC.Size = new System.Drawing.Size(284, 210);
            this.btQLDVHC.TabIndex = 0;
            this.btQLDVHC.Text = "Quản lý Đơn vị hành chính";
            this.btQLDVHC.UseVisualStyleBackColor = false;
            this.btQLDVHC.Click += new System.EventHandler(this.btQLDVHC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(330, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "HỆ THỐNG GIÁM SÁT CAMERA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
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
            this.Menu2TaoTaiKhoan.Click += new System.EventHandler(this.Menu2TaoTaiKhoan_Click);
            // 
            // Menu2DoiMatKhau
            // 
            this.Menu2DoiMatKhau.Name = "Menu2DoiMatKhau";
            this.Menu2DoiMatKhau.Size = new System.Drawing.Size(145, 22);
            this.Menu2DoiMatKhau.Text = "Đổi mật khẩu";
            this.Menu2DoiMatKhau.Click += new System.EventHandler(this.Menu2DoiMatKhau_Click);
            // 
            // Menu2DangXuat
            // 
            this.Menu2DangXuat.Name = "Menu2DangXuat";
            this.Menu2DangXuat.Size = new System.Drawing.Size(145, 22);
            this.Menu2DangXuat.Text = "Đăng xuất";
            this.Menu2DangXuat.Click += new System.EventHandler(this.Menu2DangXuat_Click);
            // 
            // btQLCamera
            // 
            this.btQLCamera.BackColor = System.Drawing.SystemColors.Info;
            this.btQLCamera.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLCamera.Location = new System.Drawing.Point(347, 212);
            this.btQLCamera.Name = "btQLCamera";
            this.btQLCamera.Size = new System.Drawing.Size(299, 210);
            this.btQLCamera.TabIndex = 11;
            this.btQLCamera.Text = "Quản lý Camera";
            this.btQLCamera.UseVisualStyleBackColor = false;
            this.btQLCamera.Click += new System.EventHandler(this.btQLCamera_Click);
            // 
            // btXemCamera
            // 
            this.btXemCamera.BackColor = System.Drawing.SystemColors.Highlight;
            this.btXemCamera.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemCamera.Location = new System.Drawing.Point(675, 212);
            this.btXemCamera.Name = "btXemCamera";
            this.btXemCamera.Size = new System.Drawing.Size(294, 210);
            this.btXemCamera.TabIndex = 12;
            this.btXemCamera.Text = "Xem Camera";
            this.btXemCamera.UseVisualStyleBackColor = false;
            this.btXemCamera.Click += new System.EventHandler(this.btXemCamera_Click);
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 530);
            this.Controls.Add(this.btXemCamera);
            this.Controls.Add(this.btQLCamera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btQLDVHC);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GiaoDien";
            this.Text = "GiaoDien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GiaoDien_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQLDVHC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem Menu2TaoTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem Menu2DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem Menu2DangXuat;
        private System.Windows.Forms.Button btQLCamera;
        private System.Windows.Forms.Button btXemCamera;
    }
}