namespace XayDungPhanMem
{
    partial class frmQuanlydia
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttgthue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgiathue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_iddia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tragthai = new System.Windows.Forms.TextBox();
            this.txt_tendia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsdia = new System.Windows.Forms.DataGridView();
            this.nhapid = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nhapid);
            this.groupBox2.Controls.Add(this.txttgthue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtgiathue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.txt_iddia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_tragthai);
            this.groupBox2.Controls.Add(this.txt_tendia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 289);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đĩa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txttgthue
            // 
            this.txttgthue.Location = new System.Drawing.Point(154, 194);
            this.txttgthue.Name = "txttgthue";
            this.txttgthue.Size = new System.Drawing.Size(199, 22);
            this.txttgthue.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Thời gian thuê tối đa:";
            // 
            // txtgiathue
            // 
            this.txtgiathue.Location = new System.Drawing.Point(154, 154);
            this.txtgiathue.Name = "txtgiathue";
            this.txtgiathue.Size = new System.Drawing.Size(199, 22);
            this.txtgiathue.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Giá thuê:";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(306, 230);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.Text = "Thoát";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(206, 230);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 17;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(106, 230);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(6, 230);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 15;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_iddia
            // 
            this.txt_iddia.Location = new System.Drawing.Point(154, 34);
            this.txt_iddia.Name = "txt_iddia";
            this.txt_iddia.Size = new System.Drawing.Size(199, 22);
            this.txt_iddia.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID Đĩa:";
            // 
            // txt_tragthai
            // 
            this.txt_tragthai.Location = new System.Drawing.Point(154, 114);
            this.txt_tragthai.Name = "txt_tragthai";
            this.txt_tragthai.Size = new System.Drawing.Size(199, 22);
            this.txt_tragthai.TabIndex = 9;
            // 
            // txt_tendia
            // 
            this.txt_tendia.Location = new System.Drawing.Point(154, 74);
            this.txt_tendia.Name = "txt_tendia";
            this.txt_tendia.Size = new System.Drawing.Size(199, 22);
            this.txt_tendia.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trạng Thái:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Đĩa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsdia);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 263);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đĩa";
            // 
            // dgv_dsdia
            // 
            this.dgv_dsdia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsdia.Location = new System.Drawing.Point(6, 21);
            this.dgv_dsdia.Name = "dgv_dsdia";
            this.dgv_dsdia.Size = new System.Drawing.Size(327, 268);
            this.dgv_dsdia.TabIndex = 1;
            this.dgv_dsdia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsdia_CellClick);
            this.dgv_dsdia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsdia_CellContentClick);
            this.dgv_dsdia.Click += new System.EventHandler(this.clickDGVDia);
            // 
            // nhapid
            // 
            this.nhapid.Location = new System.Drawing.Point(6, 263);
            this.nhapid.Name = "nhapid";
            this.nhapid.Size = new System.Drawing.Size(80, 22);
            this.nhapid.TabIndex = 23;
            // 
            // frmQuanlydia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanlydia";
            this.Text = "QuanLyDia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanlydia_FormClosing);
            this.Load += new System.EventHandler(this.QuanLyDia_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_iddia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tragthai;
        private System.Windows.Forms.TextBox txt_tendia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dsdia;
        private System.Windows.Forms.TextBox txttgthue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgiathue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nhapid;
    }
}