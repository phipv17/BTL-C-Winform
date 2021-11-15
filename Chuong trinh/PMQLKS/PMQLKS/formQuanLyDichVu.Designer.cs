
namespace PMQLKS
{
    partial class formQuanLyDichVu
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
            this.labelTittleForm = new System.Windows.Forms.Label();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbGiaDich = new System.Windows.Forms.TextBox();
            this.tbTenDichVu = new System.Windows.Forms.TextBox();
            this.tbMadv = new System.Windows.Forms.TextBox();
            this.btnxoaDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTimKIem = new System.Windows.Forms.GroupBox();
            this.rbGiaDV = new System.Windows.Forms.RadioButton();
            this.rbTenDV = new System.Windows.Forms.RadioButton();
            this.btnHuy = new System.Windows.Forms.Button();
            this.rbMaDV = new System.Windows.Forms.RadioButton();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btimKiem = new System.Windows.Forms.Button();
            this.dgvListDichVu = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxChucNang.SuspendLayout();
            this.groupBoxTimKIem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTittleForm
            // 
            this.labelTittleForm.AutoSize = true;
            this.labelTittleForm.BackColor = System.Drawing.Color.Transparent;
            this.labelTittleForm.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleForm.ForeColor = System.Drawing.Color.IndianRed;
            this.labelTittleForm.Location = new System.Drawing.Point(309, 20);
            this.labelTittleForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittleForm.Name = "labelTittleForm";
            this.labelTittleForm.Size = new System.Drawing.Size(255, 32);
            this.labelTittleForm.TabIndex = 19;
            this.labelTittleForm.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxChucNang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxChucNang.Controls.Add(this.btnReset);
            this.groupBoxChucNang.Controls.Add(this.tbGiaDich);
            this.groupBoxChucNang.Controls.Add(this.tbTenDichVu);
            this.groupBoxChucNang.Controls.Add(this.tbMadv);
            this.groupBoxChucNang.Controls.Add(this.btnxoaDV);
            this.groupBoxChucNang.Controls.Add(this.btnSuaDV);
            this.groupBoxChucNang.Controls.Add(this.btnthem);
            this.groupBoxChucNang.Controls.Add(this.label4);
            this.groupBoxChucNang.Controls.Add(this.label3);
            this.groupBoxChucNang.Controls.Add(this.label2);
            this.groupBoxChucNang.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChucNang.Location = new System.Drawing.Point(24, 77);
            this.groupBoxChucNang.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxChucNang.Size = new System.Drawing.Size(587, 184);
            this.groupBoxChucNang.TabIndex = 20;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Pink;
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(452, 148);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 32);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Nhập Lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbGiaDich
            // 
            this.tbGiaDich.Location = new System.Drawing.Point(147, 148);
            this.tbGiaDich.Margin = new System.Windows.Forms.Padding(2);
            this.tbGiaDich.Name = "tbGiaDich";
            this.tbGiaDich.Size = new System.Drawing.Size(237, 29);
            this.tbGiaDich.TabIndex = 8;
            // 
            // tbTenDichVu
            // 
            this.tbTenDichVu.Location = new System.Drawing.Point(147, 89);
            this.tbTenDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenDichVu.Name = "tbTenDichVu";
            this.tbTenDichVu.Size = new System.Drawing.Size(237, 29);
            this.tbTenDichVu.TabIndex = 7;
            // 
            // tbMadv
            // 
            this.tbMadv.Location = new System.Drawing.Point(147, 37);
            this.tbMadv.Margin = new System.Windows.Forms.Padding(2);
            this.tbMadv.Name = "tbMadv";
            this.tbMadv.Size = new System.Drawing.Size(237, 29);
            this.tbMadv.TabIndex = 6;
            // 
            // btnxoaDV
            // 
            this.btnxoaDV.BackColor = System.Drawing.Color.Pink;
            this.btnxoaDV.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoaDV.Location = new System.Drawing.Point(452, 70);
            this.btnxoaDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoaDV.Name = "btnxoaDV";
            this.btnxoaDV.Size = new System.Drawing.Size(97, 36);
            this.btnxoaDV.TabIndex = 5;
            this.btnxoaDV.Text = "Xóa";
            this.btnxoaDV.UseVisualStyleBackColor = false;
            this.btnxoaDV.Click += new System.EventHandler(this.btnxoaDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.BackColor = System.Drawing.Color.Pink;
            this.btnSuaDV.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDV.Location = new System.Drawing.Point(452, 110);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(97, 34);
            this.btnSuaDV.TabIndex = 4;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.UseVisualStyleBackColor = false;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Pink;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthem.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(452, 31);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(97, 33);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá DV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên DV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã DV:";
            // 
            // groupBoxTimKIem
            // 
            this.groupBoxTimKIem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxTimKIem.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTimKIem.Controls.Add(this.rbGiaDV);
            this.groupBoxTimKIem.Controls.Add(this.rbTenDV);
            this.groupBoxTimKIem.Controls.Add(this.btnHuy);
            this.groupBoxTimKIem.Controls.Add(this.rbMaDV);
            this.groupBoxTimKIem.Controls.Add(this.tbTimKiem);
            this.groupBoxTimKIem.Controls.Add(this.btimKiem);
            this.groupBoxTimKIem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTimKIem.Location = new System.Drawing.Point(665, 84);
            this.groupBoxTimKIem.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTimKIem.Name = "groupBoxTimKIem";
            this.groupBoxTimKIem.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTimKIem.Size = new System.Drawing.Size(235, 173);
            this.groupBoxTimKIem.TabIndex = 26;
            this.groupBoxTimKIem.TabStop = false;
            this.groupBoxTimKIem.Text = "Tìm kiếm ";
            // 
            // rbGiaDV
            // 
            this.rbGiaDV.AutoSize = true;
            this.rbGiaDV.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGiaDV.Location = new System.Drawing.Point(163, 93);
            this.rbGiaDV.Margin = new System.Windows.Forms.Padding(2);
            this.rbGiaDV.Name = "rbGiaDV";
            this.rbGiaDV.Size = new System.Drawing.Size(66, 21);
            this.rbGiaDV.TabIndex = 28;
            this.rbGiaDV.TabStop = true;
            this.rbGiaDV.Text = "Giá DV";
            this.rbGiaDV.UseVisualStyleBackColor = true;
            // 
            // rbTenDV
            // 
            this.rbTenDV.AutoSize = true;
            this.rbTenDV.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTenDV.Location = new System.Drawing.Point(87, 93);
            this.rbTenDV.Margin = new System.Windows.Forms.Padding(2);
            this.rbTenDV.Name = "rbTenDV";
            this.rbTenDV.Size = new System.Drawing.Size(64, 21);
            this.rbTenDV.TabIndex = 27;
            this.rbTenDV.TabStop = true;
            this.rbTenDV.Text = "Tên DV";
            this.rbTenDV.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Pink;
            this.btnHuy.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(149, 118);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 44);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // rbMaDV
            // 
            this.rbMaDV.AutoSize = true;
            this.rbMaDV.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaDV.Location = new System.Drawing.Point(12, 93);
            this.rbMaDV.Margin = new System.Windows.Forms.Padding(2);
            this.rbMaDV.Name = "rbMaDV";
            this.rbMaDV.Size = new System.Drawing.Size(64, 21);
            this.rbMaDV.TabIndex = 26;
            this.rbMaDV.TabStop = true;
            this.rbMaDV.Text = "Mã DV";
            this.rbMaDV.UseVisualStyleBackColor = true;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.AutoCompleteCustomSource.AddRange(new string[] {
            "Phục vụ đồ ăn 24/24",
            "Spa làm đẹp",
            "Phòng họp",
            "xe đưa đón sân bay",
            "sân goft, sân tennis",
            "Massage tại chỗ",
            "Dịch vụ giặt,ủi,là"});
            this.tbTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbTimKiem.Location = new System.Drawing.Point(35, 45);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(167, 29);
            this.tbTimKiem.TabIndex = 10;
            // 
            // btimKiem
            // 
            this.btimKiem.BackColor = System.Drawing.Color.Pink;
            this.btimKiem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btimKiem.Location = new System.Drawing.Point(12, 118);
            this.btimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btimKiem.Name = "btimKiem";
            this.btimKiem.Size = new System.Drawing.Size(80, 44);
            this.btimKiem.TabIndex = 10;
            this.btimKiem.Text = "Tìm";
            this.btimKiem.UseVisualStyleBackColor = false;
            this.btimKiem.Click += new System.EventHandler(this.btimKiem_Click);
            // 
            // dgvListDichVu
            // 
            this.dgvListDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.madv,
            this.tendv,
            this.gia});
            this.dgvListDichVu.Location = new System.Drawing.Point(167, 289);
            this.dgvListDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListDichVu.Name = "dgvListDichVu";
            this.dgvListDichVu.RowHeadersWidth = 51;
            this.dgvListDichVu.RowTemplate.Height = 24;
            this.dgvListDichVu.Size = new System.Drawing.Size(574, 223);
            this.dgvListDichVu.TabIndex = 27;
            this.dgvListDichVu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDichVu_RowEnter);
            this.dgvListDichVu.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvListDichVu_RowPrePaint);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "stt";
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 80;
            // 
            // madv
            // 
            this.madv.DataPropertyName = "madv";
            this.madv.HeaderText = "Mã DV";
            this.madv.MinimumWidth = 6;
            this.madv.Name = "madv";
            this.madv.Width = 125;
            // 
            // tendv
            // 
            this.tendv.DataPropertyName = "tendv";
            this.tendv.HeaderText = "Tên DV";
            this.tendv.MinimumWidth = 6;
            this.tendv.Name = "tendv";
            this.tendv.Width = 190;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 130;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Pink;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(653, 521);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 38);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 570);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvListDichVu);
            this.Controls.Add(this.groupBoxTimKIem);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.labelTittleForm);
            this.Name = "formQuanLyDichVu";
            this.Text = "formQuanLyDichVu";
            this.Load += new System.EventHandler(this.formQuanLyDichVu_Load);
            this.groupBoxChucNang.ResumeLayout(false);
            this.groupBoxChucNang.PerformLayout();
            this.groupBoxTimKIem.ResumeLayout(false);
            this.groupBoxTimKIem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTittleForm;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbGiaDich;
        private System.Windows.Forms.TextBox tbTenDichVu;
        private System.Windows.Forms.TextBox tbMadv;
        private System.Windows.Forms.Button btnxoaDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTimKIem;
        private System.Windows.Forms.RadioButton rbGiaDV;
        private System.Windows.Forms.RadioButton rbTenDV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.RadioButton rbMaDV;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btimKiem;
        private System.Windows.Forms.DataGridView dgvListDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.Button btnSave;
    }
}