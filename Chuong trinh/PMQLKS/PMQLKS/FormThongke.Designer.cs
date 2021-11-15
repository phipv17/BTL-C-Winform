
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTungay = new System.Windows.Forms.DateTimePicker();
            this.dtDenngay = new System.Windows.Forms.DateTimePicker();
            this.btnTaobaocao = new System.Windows.Forms.Button();
            this.pnDoanhthu = new System.Windows.Forms.Panel();
            this.rpvDoanhthu = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.label1.Location = new System.Drawing.Point(393, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnDoanhthu);
            this.tabPage3.Controls.Add(this.btnTaobaocao);
            this.tabPage3.Controls.Add(this.dtDenngay);
            this.tabPage3.Controls.Add(this.dtTungay);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1133, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Báo cáo Doanh thu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "THỐNG KÊ DOANH THU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đến ngày:";
            // 
            // dtTungay
            // 
            this.dtTungay.CustomFormat = "dd/MM/yyyy";
            this.dtTungay.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTungay.Location = new System.Drawing.Point(254, 97);
            this.dtTungay.Name = "dtTungay";
            this.dtTungay.Size = new System.Drawing.Size(200, 26);
            this.dtTungay.TabIndex = 4;
            // 
            // dtDenngay
            // 
            this.dtDenngay.CustomFormat = "dd/MM/yyyy";
            this.dtDenngay.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenngay.Location = new System.Drawing.Point(616, 97);
            this.dtDenngay.Name = "dtDenngay";
            this.dtDenngay.Size = new System.Drawing.Size(200, 26);
            this.dtDenngay.TabIndex = 5;
            // 
            // btnTaobaocao
            // 
            this.btnTaobaocao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaobaocao.Location = new System.Drawing.Point(884, 97);
            this.btnTaobaocao.Name = "btnTaobaocao";
            this.btnTaobaocao.Size = new System.Drawing.Size(141, 26);
            this.btnTaobaocao.TabIndex = 6;
            this.btnTaobaocao.Text = "Tạo báo cáo";
            this.btnTaobaocao.UseVisualStyleBackColor = true;
            this.btnTaobaocao.Click += new System.EventHandler(this.btnTaobaocao_Click);
            // 
            // pnDoanhthu
            // 
            this.pnDoanhthu.Controls.Add(this.rpvDoanhthu);
            this.pnDoanhthu.Location = new System.Drawing.Point(-4, 172);
            this.pnDoanhthu.Name = "pnDoanhthu";
            this.pnDoanhthu.Size = new System.Drawing.Size(1137, 366);
            this.pnDoanhthu.TabIndex = 7;
            // 
            // rpvDoanhthu
            // 
            this.rpvDoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvDoanhthu.Location = new System.Drawing.Point(0, 0);
            this.rpvDoanhthu.Name = "rpvDoanhthu";
            this.rpvDoanhthu.ServerReport.BearerToken = null;
            this.rpvDoanhthu.Size = new System.Drawing.Size(1137, 366);
            this.rpvDoanhthu.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1141, 653);
            this.tabControl1.TabIndex = 1;
            // 
            // FormThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 645);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}