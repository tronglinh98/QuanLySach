namespace Demo2
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
            this.btnadd = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lblauthor = new System.Windows.Forms.Label();
            this.dgvbook = new System.Windows.Forms.DataGridView();
            this.dgvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.tbxyear = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTacGia = new System.Windows.Forms.Button();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(116, 402);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(110, 31);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Insert";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(45, 31);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(77, 17);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Tên Sách: ";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Location = new System.Drawing.Point(45, 75);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(103, 17);
            this.lblyear.TabIndex = 2;
            this.lblyear.Text = "Năm xuất bản: ";
            // 
            // lblauthor
            // 
            this.lblauthor.AutoSize = true;
            this.lblauthor.Location = new System.Drawing.Point(45, 117);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(66, 17);
            this.lblauthor.TabIndex = 3;
            this.lblauthor.Text = "Tác Giả: ";
            // 
            // dgvbook
            // 
            this.dgvbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColName,
            this.dgvColYear,
            this.dgvColAuthor});
            this.dgvbook.Location = new System.Drawing.Point(85, 167);
            this.dgvbook.Name = "dgvbook";
            this.dgvbook.RowTemplate.Height = 24;
            this.dgvbook.Size = new System.Drawing.Size(620, 225);
            this.dgvbook.TabIndex = 4;
            this.dgvbook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvbook_MouseClick);
            // 
            // dgvColName
            // 
            this.dgvColName.HeaderText = "Tên Sách";
            this.dgvColName.Name = "dgvColName";
            this.dgvColName.Width = 150;
            // 
            // dgvColYear
            // 
            this.dgvColYear.HeaderText = "Năm Xuất Bản";
            this.dgvColYear.Name = "dgvColYear";
            // 
            // dgvColAuthor
            // 
            this.dgvColAuthor.HeaderText = "Tác Giả";
            this.dgvColAuthor.Name = "dgvColAuthor";
            this.dgvColAuthor.Width = 150;
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(146, 28);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(335, 22);
            this.tbxname.TabIndex = 5;
            // 
            // tbxyear
            // 
            this.tbxyear.Location = new System.Drawing.Point(146, 72);
            this.tbxyear.Name = "tbxyear";
            this.tbxyear.Size = new System.Drawing.Size(178, 22);
            this.tbxyear.TabIndex = 6;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(328, 402);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 31);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(539, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 31);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTacGia
            // 
            this.btnTacGia.Location = new System.Drawing.Point(581, 51);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(105, 41);
            this.btnTacGia.TabIndex = 10;
            this.btnTacGia.Text = "Tác Giả";
            this.btnTacGia.UseVisualStyleBackColor = true;
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Location = new System.Drawing.Point(146, 117);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(335, 24);
            this.cbbTacGia.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.cbbTacGia);
            this.Controls.Add(this.btnTacGia);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.tbxyear);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.dgvbook);
            this.Controls.Add(this.lblauthor);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lblauthor;
        private System.Windows.Forms.DataGridView dgvbook;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.TextBox tbxyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColAuthor;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTacGia;
        private System.Windows.Forms.ComboBox cbbTacGia;
    }
}

