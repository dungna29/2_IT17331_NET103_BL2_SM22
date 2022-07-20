namespace BAI_1_2_CRUD_OBJ.Views
{
    partial class FrmQLCuaHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrid_CuaHangs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Dc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ThanhPho = new System.Windows.Forms.ComboBox();
            this.rbtn_HoatDong = new System.Windows.Forms.RadioButton();
            this.rbtn_KoHoatDong = new System.Windows.Forms.RadioButton();
            this.rbtn_SuaChua = new System.Windows.Forms.RadioButton();
            this.txt_QuocGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHangs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_QuocGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtn_SuaChua);
            this.groupBox1.Controls.Add(this.rbtn_KoHoatDong);
            this.groupBox1.Controls.Add(this.rbtn_HoatDong);
            this.groupBox1.Controls.Add(this.cmb_ThanhPho);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Dc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Ten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Ma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(396, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 373);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(3, 145);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(338, 43);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(3, 102);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(338, 43);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(3, 59);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(338, 43);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(3, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(338, 43);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.txt_TimKiem);
            this.groupBox3.Controls.Add(this.dgrid_CuaHangs);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 310);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgrid_CuaHangs
            // 
            this.dgrid_CuaHangs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_CuaHangs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_CuaHangs.Location = new System.Drawing.Point(3, 68);
            this.dgrid_CuaHangs.Name = "dgrid_CuaHangs";
            this.dgrid_CuaHangs.Size = new System.Drawing.Size(734, 239);
            this.dgrid_CuaHangs.TabIndex = 0;
            this.dgrid_CuaHangs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CuaHangs_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã: ";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma.Location = new System.Drawing.Point(127, 19);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(199, 31);
            this.txt_Ma.TabIndex = 1;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(127, 65);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(199, 31);
            this.txt_Ten.TabIndex = 3;
            this.txt_Ten.TextChanged += new System.EventHandler(this.txt_Ten_TextChanged);
            this.txt_Ten.Leave += new System.EventHandler(this.txt_Ten_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // txt_Dc
            // 
            this.txt_Dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dc.Location = new System.Drawing.Point(127, 111);
            this.txt_Dc.Name = "txt_Dc";
            this.txt_Dc.Size = new System.Drawing.Size(199, 31);
            this.txt_Dc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thành phố:";
            // 
            // cmb_ThanhPho
            // 
            this.cmb_ThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ThanhPho.FormattingEnabled = true;
            this.cmb_ThanhPho.Location = new System.Drawing.Point(127, 155);
            this.cmb_ThanhPho.Name = "cmb_ThanhPho";
            this.cmb_ThanhPho.Size = new System.Drawing.Size(121, 33);
            this.cmb_ThanhPho.TabIndex = 8;
            // 
            // rbtn_HoatDong
            // 
            this.rbtn_HoatDong.AutoSize = true;
            this.rbtn_HoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_HoatDong.Location = new System.Drawing.Point(127, 252);
            this.rbtn_HoatDong.Name = "rbtn_HoatDong";
            this.rbtn_HoatDong.Size = new System.Drawing.Size(129, 29);
            this.rbtn_HoatDong.TabIndex = 9;
            this.rbtn_HoatDong.TabStop = true;
            this.rbtn_HoatDong.Text = "Hoạt động";
            this.rbtn_HoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtn_KoHoatDong
            // 
            this.rbtn_KoHoatDong.AutoSize = true;
            this.rbtn_KoHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_KoHoatDong.Location = new System.Drawing.Point(127, 287);
            this.rbtn_KoHoatDong.Name = "rbtn_KoHoatDong";
            this.rbtn_KoHoatDong.Size = new System.Drawing.Size(194, 29);
            this.rbtn_KoHoatDong.TabIndex = 10;
            this.rbtn_KoHoatDong.TabStop = true;
            this.rbtn_KoHoatDong.Text = "Không hoạt động";
            this.rbtn_KoHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtn_SuaChua
            // 
            this.rbtn_SuaChua.AutoSize = true;
            this.rbtn_SuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_SuaChua.Location = new System.Drawing.Point(127, 322);
            this.rbtn_SuaChua.Name = "rbtn_SuaChua";
            this.rbtn_SuaChua.Size = new System.Drawing.Size(121, 29);
            this.rbtn_SuaChua.TabIndex = 11;
            this.rbtn_SuaChua.TabStop = true;
            this.rbtn_SuaChua.Text = "Sửa chữa";
            this.rbtn_SuaChua.UseVisualStyleBackColor = true;
            // 
            // txt_QuocGia
            // 
            this.txt_QuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuocGia.Location = new System.Drawing.Point(127, 204);
            this.txt_QuocGia.Name = "txt_QuocGia";
            this.txt_QuocGia.Size = new System.Drawing.Size(199, 31);
            this.txt_QuocGia.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quốc gia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Trạng thái:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(283, 19);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(199, 31);
            this.txt_TimKiem.TabIndex = 15;
            this.txt_TimKiem.Text = "Tìm kiếm.........";
            this.txt_TimKiem.Click += new System.EventHandler(this.txt_TimKiem_Click);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // FrmQLCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 683);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmQLCuaHang";
            this.Text = "FrmQLCuaHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHangs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dgrid_CuaHangs;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Dc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ThanhPho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_QuocGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtn_SuaChua;
        private System.Windows.Forms.RadioButton rbtn_KoHoatDong;
        private System.Windows.Forms.RadioButton rbtn_HoatDong;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}