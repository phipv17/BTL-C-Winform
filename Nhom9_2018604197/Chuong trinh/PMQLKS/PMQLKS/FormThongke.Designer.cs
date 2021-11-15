
namespace PMQLKS
{
    partial class FormThongke
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnDoanhthu = new System.Windows.Forms.Panel();
            this.rpvDoanhthu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnTaobaocao = new System.Windows.Forms.Button();
            this.dtDenngay = new System.Windows.Forms.DateTimePicker();
            this.dtTungay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.pnDoanhthu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.pnDoanhthu);
            this.tabPage3.Controls.Add(this.btnTaobaocao);
            this.tabPage3.Controls.Add(this.dtDenngay);
            this.tabPage3.Controls.Add(this.dtTungay);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(848, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Báo cáo Doanh thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = " --- Cầu Diễn ---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Khách sạn HAUI";
            // 
            // pnDoanhthu
            // 
            this.pnDoanhthu.Controls.Add(this.rpvDoanhthu);
            this.pnDoanhthu.Location = new System.Drawing.Point(-3, 140);
            this.pnDoanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.pnDoanhthu.Name = "pnDoanhthu";
            this.pnDoanhthu.Size = new System.Drawing.Size(853, 297);
            this.pnDoanhthu.TabIndex = 7;
            // 
            // rpvDoanhthu
            // 
            this.rpvDoanhthu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rpvDoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvDoanhthu.Location = new System.Drawing.Point(0, 0);
            this.rpvDoanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.rpvDoanhthu.Name = "rpvDoanhthu";
            this.rpvDoanhthu.ServerReport.BearerToken = null;
            this.rpvDoanhthu.Size = new System.Drawing.Size(853, 297);
            this.rpvDoanhthu.TabIndex = 0;
            // 
            // btnTaobaocao
            // 
            this.btnTaobaocao.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaobaocao.Location = new System.Drawing.Point(740, 87);
            this.btnTaobaocao.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaobaocao.Name = "btnTaobaocao";
            this.btnTaobaocao.Size = new System.Drawing.Size(106, 33);
            this.btnTaobaocao.TabIndex = 6;
            this.btnTaobaocao.Text = "Tạo báo cáo";
            this.btnTaobaocao.UseVisualStyleBackColor = true;
            this.btnTaobaocao.Click += new System.EventHandler(this.btnTaobaocao_Click);
            // 
            // dtDenngay
            // 
            this.dtDenngay.CustomFormat = "dd/MM/yyyy";
            this.dtDenngay.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenngay.Location = new System.Drawing.Point(501, 99);
            this.dtDenngay.Margin = new System.Windows.Forms.Padding(2);
            this.dtDenngay.Name = "dtDenngay";
            this.dtDenngay.Size = new System.Drawing.Size(151, 22);
            this.dtDenngay.TabIndex = 5;
            // 
            // dtTungay
            // 
            this.dtTungay.CustomFormat = "dd/MM/yyyy";
            this.dtTungay.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTungay.Location = new System.Drawing.Point(154, 98);
            this.dtTungay.Margin = new System.Windows.Forms.Padding(2);
            this.dtTungay.Name = "dtTungay";
            this.dtTungay.Size = new System.Drawing.Size(151, 22);
            this.dtTungay.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "THỐNG KÊ DOANH THU";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 531);
            this.tabControl1.TabIndex = 1;
            // 
            // FormThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 524);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormThongke";
            this.Text = "Báo cáo Thống kê";
            this.Load += new System.EventHandler(this.FormThongke_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnDoanhthu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnDoanhthu;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDoanhthu;
        private System.Windows.Forms.Button btnTaobaocao;
        private System.Windows.Forms.DateTimePicker dtDenngay;
        private System.Windows.Forms.DateTimePicker dtTungay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}