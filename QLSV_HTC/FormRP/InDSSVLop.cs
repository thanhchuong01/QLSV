using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLSV_HTC.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_HTC.FormRP
{
    public partial class InDSSVLop : DevExpress.XtraEditors.XtraForm
    {
        public InDSSVLop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit_NK_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void InPhieuDiemForm_Load(object sender, EventArgs e)
        {
            if (Program.AuthGroup == "KHOA")
            {
                Program.Bds_Dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
            }
            Utils.LoadComboBox(cmbKhoa, Program.Bds_Dspm.DataSource);
        }

        private void button_preview_Click(object sender, EventArgs e)
        {
            String malop = textEdit_MALOP.Text.Trim();
            String Khoa = cmbKhoa.Text.Trim();
            if (malop.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (malop.Length != 9)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng vd:D15CQCP01", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String cmd = "Select MALOP, TENLOP from LOP Where MALOP='" + malop + "'";
            SqlDataReader dr = Program.ExecSqlDataReader(cmd);
            
            if (!dr.Read())
            {
                MessageBox.Show("Mã số Lớp không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr.Close();
                return;
            }
            String tenlop = dr.GetString(1);
            dr.Close();
            InDSSVLop_RP rpt = new InDSSVLop_RP(Khoa, malop, tenlop);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }



        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ChangeServer(cmbKhoa);
        }
    }
}