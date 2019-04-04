namespace WindowsFormsApp2
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
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.lbltacGia = new System.Windows.Forms.Label();
            this.dgvTacPham = new System.Windows.Forms.DataGridView();
            this.dgvColTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColNamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxTenSach = new System.Windows.Forms.TextBox();
            this.tbxNamXuatBan = new System.Windows.Forms.TextBox();
            this.tbxTacGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(32, 53);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(69, 17);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Location = new System.Drawing.Point(6, 109);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(95, 17);
            this.lblNamXuatBan.TabIndex = 1;
            this.lblNamXuatBan.Text = "Năm xuất bản";
            // 
            // lbltacGia
            // 
            this.lbltacGia.AutoSize = true;
            this.lbltacGia.Location = new System.Drawing.Point(46, 169);
            this.lbltacGia.Name = "lbltacGia";
            this.lbltacGia.Size = new System.Drawing.Size(55, 17);
            this.lbltacGia.TabIndex = 2;
            this.lbltacGia.Text = "Tác giả";
            // 
            // dgvTacPham
            // 
            this.dgvTacPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColTenSach,
            this.dgvColNamXuatBan,
            this.dgvColTacGia});
            this.dgvTacPham.Location = new System.Drawing.Point(396, 20);
            this.dgvTacPham.Name = "dgvTacPham";
            this.dgvTacPham.RowTemplate.Height = 24;
            this.dgvTacPham.Size = new System.Drawing.Size(596, 485);
            this.dgvTacPham.TabIndex = 3;
            this.dgvTacPham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvTacPham_MouseClick);
            // 
            // dgvColTenSach
            // 
            this.dgvColTenSach.HeaderText = "Tên Sách";
            this.dgvColTenSach.Name = "dgvColTenSach";
            // 
            // dgvColNamXuatBan
            // 
            this.dgvColNamXuatBan.HeaderText = "Năm xuất bản";
            this.dgvColNamXuatBan.Name = "dgvColNamXuatBan";
            // 
            // dgvColTacGia
            // 
            this.dgvColTacGia.HeaderText = "Tác Giả";
            this.dgvColTacGia.Name = "dgvColTacGia";
            // 
            // tbxTenSach
            // 
            this.tbxTenSach.Location = new System.Drawing.Point(119, 50);
            this.tbxTenSach.Name = "tbxTenSach";
            this.tbxTenSach.Size = new System.Drawing.Size(239, 22);
            this.tbxTenSach.TabIndex = 4;
            // 
            // tbxNamXuatBan
            // 
            this.tbxNamXuatBan.Location = new System.Drawing.Point(119, 106);
            this.tbxNamXuatBan.Name = "tbxNamXuatBan";
            this.tbxNamXuatBan.Size = new System.Drawing.Size(239, 22);
            this.tbxNamXuatBan.TabIndex = 5;
            // 
            // tbxTacGia
            // 
            this.tbxTacGia.Location = new System.Drawing.Point(119, 166);
            this.tbxTacGia.Name = "tbxTacGia";
            this.tbxTacGia.Size = new System.Drawing.Size(239, 22);
            this.tbxTacGia.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 271);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(151, 271);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 271);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 531);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbxTacGia);
            this.Controls.Add(this.tbxNamXuatBan);
            this.Controls.Add(this.tbxTenSach);
            this.Controls.Add(this.dgvTacPham);
            this.Controls.Add(this.lbltacGia);
            this.Controls.Add(this.lblNamXuatBan);
            this.Controls.Add(this.lblTenSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblNamXuatBan;
        private System.Windows.Forms.Label lbltacGia;
        private System.Windows.Forms.DataGridView dgvTacPham;
        private System.Windows.Forms.TextBox tbxTenSach;
        private System.Windows.Forms.TextBox tbxNamXuatBan;
        private System.Windows.Forms.TextBox tbxTacGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColNamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColTacGia;
    }
}

