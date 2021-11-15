using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLKS
{
    public partial class formQuanLyHoaDon : Form
    {
        public formQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                dbDataContext db = new dbDataContext();
                IQueryable<hoadon> table = db.hoadons.AsQueryable();
                if (!string.IsNullOrWhiteSpace(tbMahd.Text))
                    table = table.Where(hd => hd.mahd.Contains(tbMahd.Text));

                if (!string.IsNullOrWhiteSpace(tbMadp.Text))
                    table = table.Where(hd => hd.madp.Contains(tbMadp.Text));

                if (!string.IsNullOrWhiteSpace(tbMadv.Text))
                    table = table.Where(hd => hd.madv.Contains(tbMadv.Text));

                if (!string.IsNullOrWhiteSpace(tbNgaylap.Text))
                    table = table.Where(hd => hd.ngaylap.ToString().Contains(tbNgaylap.Text));

                if (!string.IsNullOrWhiteSpace(tbTongtien.Text))
                    table = table.Where(hd => hd.tongtien == Int32.Parse(tbNgaylap.Text));

                dataGridViewHoaDon.DataSource = table.Select(hd => hd);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm!" + ex);
            }
        }
        private void dataGridViewQLHoaDon_Load()
        {
            dbDataContext db = new dbDataContext();
            var hoadon = from hd in db.hoadons
                         select hd;
            dataGridViewHoaDon.DataSource = hoadon;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridViewQLHoaDon_Load();
        }

        private void formQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dataGridViewQLHoaDon_Load();
        }
    }
}
