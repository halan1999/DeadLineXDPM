﻿namespace XayDungPhanMem
{
    partial class frmDatTruoc
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
            this.dgv_dstieude = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_dskhdat = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.btn_dat = new System.Windows.Forms.Button();
            this.txt_cm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dstieude)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskhdat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dstieude);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 290);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tiêu đề";
            // 
            // dgv_dstieude
            // 
            this.dgv_dstieude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dstieude.Location = new System.Drawing.Point(6, 21);
            this.dgv_dstieude.Name = "dgv_dstieude";
            this.dgv_dstieude.Size = new System.Drawing.Size(361, 263);
            this.dgv_dstieude.TabIndex = 1;
            this.dgv_dstieude.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dstieude_CellClick);
            this.dgv_dstieude.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dstieude_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_dskhdat);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 115);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng đã đặt";
            // 
            // dgv_dskhdat
            // 
            this.dgv_dskhdat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dskhdat.Location = new System.Drawing.Point(6, 21);
            this.dgv_dskhdat.Name = "dgv_dskhdat";
            this.dgv_dskhdat.Size = new System.Drawing.Size(355, 87);
            this.dgv_dskhdat.TabIndex = 1;
            this.dgv_dskhdat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dskhdat_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_timkiem);
            this.groupBox3.Controls.Add(this.txt_sdt);
            this.groupBox3.Controls.Add(this.btn_dat);
            this.groupBox3.Controls.Add(this.txt_cm);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_idkh);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_tenkh);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(391, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 169);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đặt đĩa trước ";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(292, 29);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(69, 23);
            this.btn_timkiem.TabIndex = 22;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sdt.Location = new System.Drawing.Point(82, 131);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(199, 22);
            this.txt_sdt.TabIndex = 21;
            // 
            // btn_dat
            // 
            this.btn_dat.Location = new System.Drawing.Point(292, 66);
            this.btn_dat.Name = "btn_dat";
            this.btn_dat.Size = new System.Drawing.Size(69, 83);
            this.btn_dat.TabIndex = 18;
            this.btn_dat.Text = "Đặt";
            this.btn_dat.UseVisualStyleBackColor = true;
            this.btn_dat.Click += new System.EventHandler(this.btn_dat_Click);
            // 
            // txt_cm
            // 
            this.txt_cm.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cm.Location = new System.Drawing.Point(82, 97);
            this.txt_cm.Name = "txt_cm";
            this.txt_cm.Size = new System.Drawing.Size(199, 22);
            this.txt_cm.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "SDT:";
            // 
            // txt_idkh
            // 
            this.txt_idkh.Location = new System.Drawing.Point(82, 29);
            this.txt_idkh.Name = "txt_idkh";
            this.txt_idkh.Size = new System.Drawing.Size(199, 22);
            this.txt_idkh.TabIndex = 14;
            this.txt_idkh.TextChanged += new System.EventHandler(this.txt_idkh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số CM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID KH:";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tenkh.Location = new System.Drawing.Point(82, 63);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(199, 22);
            this.txt_tenkh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ Và Tên:";
            // 
            // frmDatTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 346);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatTruoc";
            this.Text = "DatTruoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDatTruoc_FormClosing);
            this.Load += new System.EventHandler(this.DatTruoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dstieude)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskhdat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dstieude;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_dskhdat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_dat;
        private System.Windows.Forms.TextBox txt_idkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_cm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_timkiem;
    }
}