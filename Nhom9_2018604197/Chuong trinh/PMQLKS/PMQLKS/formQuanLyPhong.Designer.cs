
namespace PMQLKS
{
    partial class formQuanLyPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttrong = new System.Windows.Forms.TextBox();
            this.radioButtonDeluxe = new System.Windows.Forms.RadioButton();
            this.radioButtonSuite = new System.Windows.Forms.RadioButton();
            this.radioButtonSuperio = new System.Windows.Forms.RadioButton();
            this.radioBtnStandard = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.maphong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txttrong);
            this.panel1.Controls.Add(this.radioButtonDeluxe);
            this.panel1.Controls.Add(this.radioButtonSuite);
            this.panel1.Controls.Add(this.radioButtonSuperio);
            this.panel1.Controls.Add(this.radioBtnStandard);
            this.panel1.Location = new System.Drawing.Point(87, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 33);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số phòng trống";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn loại phòng:";
            // 
            // txttrong
            // 
            this.txttrong.Location = new System.Drawing.Point(716, 8);
            this.txttrong.Name = "txttrong";
            this.txttrong.Size = new System.Drawing.Size(30, 20);
            this.txttrong.TabIndex = 4;
            // 
            // radioButtonDeluxe
            // 
            this.radioButtonDeluxe.AutoSize = true;
            this.radioButtonDeluxe.Location = new System.Drawing.Point(530, 8);
            this.radioButtonDeluxe.Name = "radioButtonDeluxe";
            this.radioButtonDeluxe.Size = new System.Drawing.Size(58, 17);
            this.radioButtonDeluxe.TabIndex = 3;
            this.radioButtonDeluxe.TabStop = true;
            this.radioButtonDeluxe.Text = "Deluxe";
            this.radioButtonDeluxe.UseVisualStyleBackColor = true;
            this.radioButtonDeluxe.Click += new System.EventHandler(this.radioButtonDeluxe_Click);
            // 
            // radioButtonSuite
            // 
            this.radioButtonSuite.AutoSize = true;
            this.radioButtonSuite.Location = new System.Drawing.Point(397, 8);
            this.radioButtonSuite.Name = "radioButtonSuite";
            this.radioButtonSuite.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSuite.TabIndex = 2;
            this.radioButtonSuite.TabStop = true;
            this.radioButtonSuite.Text = "Suite";
            this.radioButtonSuite.UseVisualStyleBackColor = true;
            this.radioButtonSuite.Click += new System.EventHandler(this.radioButtonSuite_Click);
            // 
            // radioButtonSuperio
            // 
            this.radioButtonSuperio.AutoSize = true;
            this.radioButtonSuperio.Location = new System.Drawing.Point(262, 8);
            this.radioButtonSuperio.Name = "radioButtonSuperio";
            this.radioButtonSuperio.Size = new System.Drawing.Size(61, 17);
            this.radioButtonSuperio.TabIndex = 1;
            this.radioButtonSuperio.TabStop = true;
            this.radioButtonSuperio.Text = "Superio";
            this.radioButtonSuperio.UseVisualStyleBackColor = true;
            this.radioButtonSuperio.Click += new System.EventHandler(this.radioButtonSuperio_Click);
            // 
            // radioBtnStandard
            // 
            this.radioBtnStandard.AutoSize = true;
            this.radioBtnStandard.Location = new System.Drawing.Point(130, 8);
            this.radioBtnStandard.Name = "radioBtnStandard";
            this.radioBtnStandard.Size = new System.Drawing.Size(68, 17);
            this.radioBtnStandard.TabIndex = 0;
            this.radioBtnStandard.TabStop = true;
            this.radioBtnStandard.Text = "Standard";
            this.radioBtnStandard.UseVisualStyleBackColor = true;
            this.radioBtnStandard.Click += new System.EventHandler(this.radioBtnStandard_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cập nhật tình trạng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong1,
            this.tenlp,
            this.tt,
            this.gia});
            this.dataGridViewPhong.Location = new System.Drawing.Point(87, 95);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.Size = new System.Drawing.Size(763, 249);
            this.dataGridViewPhong.TabIndex = 6;
            this.dataGridViewPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhong_CellClick);
            // 
            // maphong1
            // 
            this.maphong1.DataPropertyName = "maphong";
            this.maphong1.HeaderText = "Mã Phòng";
            this.maphong1.Name = "maphong1";
            this.maphong1.Width = 190;
            // 
            // tenlp
            // 
            this.tenlp.DataPropertyName = "tenlp";
            this.tenlp.HeaderText = "Tên LP";
            this.tenlp.Name = "tenlp";
            this.tenlp.Width = 190;
            // 
            // tt
            // 
            this.tt.DataPropertyName = "tinhtrang";
            this.tt.HeaderText = "Tình Trạng";
            this.tt.Name = "tt";
            this.tt.Width = 190;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "giaphong";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.Width = 190;
            // 
            // formQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(922, 440);
            this.Controls.Add(this.dataGridViewPhong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formQuanLyPhong";
            this.Text = "formQuanLyPhong";
            this.Load += new System.EventHandler(this.formQuanLyPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttrong;
        private System.Windows.Forms.RadioButton radioButtonDeluxe;
        private System.Windows.Forms.RadioButton radioButtonSuite;
        private System.Windows.Forms.RadioButton radioButtonSuperio;
        private System.Windows.Forms.RadioButton radioBtnStandard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}