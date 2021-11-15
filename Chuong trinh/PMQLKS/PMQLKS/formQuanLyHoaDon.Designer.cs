
namespace PMQLKS
{
    partial class formQuanLyHoaDon
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.tbTongtien = new System.Windows.Forms.TextBox();
            this.tbNgaylap = new System.Windows.Forms.TextBox();
            this.tbMadv = new System.Windows.Forms.TextBox();
            this.tbMadp = new System.Windows.Forms.TextBox();
            this.tbMahd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimkiem);
            this.groupBox3.Controls.Add(this.tbTongtien);
            this.groupBox3.Controls.Add(this.tbNgaylap);
            this.groupBox3.Controls.Add(this.tbMadv);
            this.groupBox3.Controls.Add(this.tbMadp);
            this.groupBox3.Controls.Add(this.tbMahd);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(33, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(849, 111);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTimkiem.Location = new System.Drawing.Point(726, 79);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // tbTongtien
            // 
            this.tbTongtien.Location = new System.Drawing.Point(685, 46);
            this.tbTongtien.Name = "tbTongtien";
            this.tbTongtien.Size = new System.Drawing.Size(125, 20);
            this.tbTongtien.TabIndex = 9;
            // 
            // tbNgaylap
            // 
            this.tbNgaylap.Location = new System.Drawing.Point(519, 46);
            this.tbNgaylap.Name = "tbNgaylap";
            this.tbNgaylap.Size = new System.Drawing.Size(119, 20);
            this.tbNgaylap.TabIndex = 8;
            // 
            // tbMadv
            // 
            this.tbMadv.Location = new System.Drawing.Point(362, 46);
            this.tbMadv.Name = "tbMadv";
            this.tbMadv.Size = new System.Drawing.Size(122, 20);
            this.tbMadv.TabIndex = 7;
            // 
            // tbMadp
            // 
            this.tbMadp.Location = new System.Drawing.Point(208, 46);
            this.tbMadp.Name = "tbMadp";
            this.tbMadp.Size = new System.Drawing.Size(118, 20);
            this.tbMadp.TabIndex = 6;
            // 
            // tbMahd
            // 
            this.tbMahd.Location = new System.Drawing.Point(52, 46);
            this.tbMahd.Name = "tbMahd";
            this.tbMahd.Size = new System.Drawing.Size(121, 20);
            this.tbMahd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đặt phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(58, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 226);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.madp,
            this.madv,
            this.ngaylap,
            this.tongtien});
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(23, 19);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(753, 195);
            this.dataGridViewHoaDon.TabIndex = 0;
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.HeaderText = "Mã HD";
            this.mahd.Name = "mahd";
            this.mahd.Width = 130;
            // 
            // madp
            // 
            this.madp.DataPropertyName = "madp";
            this.madp.HeaderText = "Mã DP";
            this.madp.Name = "madp";
            this.madp.Width = 150;
            // 
            // madv
            // 
            this.madv.DataPropertyName = "madv";
            this.madv.HeaderText = "Ma DV";
            this.madv.Name = "madv";
            this.madv.Width = 150;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.Width = 150;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 130;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(759, 215);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(308, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Quản lý hóa đơn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 491);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "formQuanLyHoaDon";
            this.Text = "formQuanLyHoaDon";
            this.Load += new System.EventHandler(this.formQuanLyHoaDon_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox tbTongtien;
        private System.Windows.Forms.TextBox tbNgaylap;
        private System.Windows.Forms.TextBox tbMadv;
        private System.Windows.Forms.TextBox tbMadp;
        private System.Windows.Forms.TextBox tbMahd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn madp;
        private System.Windows.Forms.DataGridViewTextBoxColumn madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.Label label7;
    }
}