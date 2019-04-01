namespace Demo2
{
    partial class tac_gia
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
            this.lblIdTacGia = new System.Windows.Forms.Label();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.tbxIdTacGia = new System.Windows.Forms.TextBox();
            this.tbxTenTacGia = new System.Windows.Forms.TextBox();
            this.tbxNgaySinh = new System.Windows.Forms.TextBox();
            this.tbxQueQuan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTacPham = new System.Windows.Forms.Button();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.dgvIdTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdTacGia
            // 
            this.lblIdTacGia.AutoSize = true;
            this.lblIdTacGia.Location = new System.Drawing.Point(46, 20);
            this.lblIdTacGia.Name = "lblIdTacGia";
            this.lblIdTacGia.Size = new System.Drawing.Size(21, 17);
            this.lblIdTacGia.TabIndex = 0;
            this.lblIdTacGia.Text = "ID";
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Location = new System.Drawing.Point(46, 58);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(79, 17);
            this.lblTenTacGia.TabIndex = 1;
            this.lblTenTacGia.Text = "Tên tác giả";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(46, 97);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(71, 17);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(46, 134);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(71, 17);
            this.lblQueQuan.TabIndex = 3;
            this.lblQueQuan.Text = "Quê quán";
            // 
            // tbxIdTacGia
            // 
            this.tbxIdTacGia.Location = new System.Drawing.Point(143, 20);
            this.tbxIdTacGia.Name = "tbxIdTacGia";
            this.tbxIdTacGia.Size = new System.Drawing.Size(351, 22);
            this.tbxIdTacGia.TabIndex = 4;
            // 
            // tbxTenTacGia
            // 
            this.tbxTenTacGia.Location = new System.Drawing.Point(143, 58);
            this.tbxTenTacGia.Name = "tbxTenTacGia";
            this.tbxTenTacGia.Size = new System.Drawing.Size(351, 22);
            this.tbxTenTacGia.TabIndex = 5;
            // 
            // tbxNgaySinh
            // 
            this.tbxNgaySinh.Location = new System.Drawing.Point(143, 97);
            this.tbxNgaySinh.Name = "tbxNgaySinh";
            this.tbxNgaySinh.Size = new System.Drawing.Size(351, 22);
            this.tbxNgaySinh.TabIndex = 6;
            // 
            // tbxQueQuan
            // 
            this.tbxQueQuan.Location = new System.Drawing.Point(145, 134);
            this.tbxQueQuan.Name = "tbxQueQuan";
            this.tbxQueQuan.Size = new System.Drawing.Size(349, 22);
            this.tbxQueQuan.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(109, 403);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 25);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Insert";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(324, 402);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 27);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(546, 403);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 25);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTacPham
            // 
            this.btnTacPham.Location = new System.Drawing.Point(595, 50);
            this.btnTacPham.Name = "btnTacPham";
            this.btnTacPham.Size = new System.Drawing.Size(121, 41);
            this.btnTacPham.TabIndex = 11;
            this.btnTacPham.Text = "Tác Phẩm";
            this.btnTacPham.UseVisualStyleBackColor = true;
            this.btnTacPham.Click += new System.EventHandler(this.btnTacPham_Click);
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdTacGia,
            this.dgvTenTacGia,
            this.dgvNgaySinh,
            this.dgvQueQuan});
            this.dgvTacGia.Location = new System.Drawing.Point(70, 176);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.Size = new System.Drawing.Size(659, 211);
            this.dgvTacGia.TabIndex = 12;
            this.dgvTacGia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvTacGia_MouseClick);
            // 
            // dgvIdTacGia
            // 
            this.dgvIdTacGia.HeaderText = "ID";
            this.dgvIdTacGia.Name = "dgvIdTacGia";
            // 
            // dgvTenTacGia
            // 
            this.dgvTenTacGia.HeaderText = "Tên Tác Giả";
            this.dgvTenTacGia.Name = "dgvTenTacGia";
            // 
            // dgvNgaySinh
            // 
            this.dgvNgaySinh.HeaderText = "Ngày Sinh";
            this.dgvNgaySinh.Name = "dgvNgaySinh";
            // 
            // dgvQueQuan
            // 
            this.dgvQueQuan.HeaderText = "Quê Quán";
            this.dgvQueQuan.Name = "dgvQueQuan";
            // 
            // tac_gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTacGia);
            this.Controls.Add(this.btnTacPham);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbxQueQuan);
            this.Controls.Add(this.tbxNgaySinh);
            this.Controls.Add(this.tbxTenTacGia);
            this.Controls.Add(this.tbxIdTacGia);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblTenTacGia);
            this.Controls.Add(this.lblIdTacGia);
            this.Name = "tac_gia";
            this.Text = "tac_gia";
            this.Load += new System.EventHandler(this.tac_gia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdTacGia;
        private System.Windows.Forms.Label lblTenTacGia;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.TextBox tbxIdTacGia;
        private System.Windows.Forms.TextBox tbxTenTacGia;
        private System.Windows.Forms.TextBox tbxNgaySinh;
        private System.Windows.Forms.TextBox tbxQueQuan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTacPham;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQueQuan;
    }
}