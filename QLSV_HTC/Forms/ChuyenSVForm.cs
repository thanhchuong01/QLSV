using DevExpress.XtraEditors;
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

namespace QLSV_HTC.Forms
{
    public partial class ChuyenSVForm : DevExpress.XtraEditors.XtraForm
    {
        public static bool chuyen;
        public static string malop;
        private static string masvInput;
        public ChuyenSVForm(string masv)
        {
            InitializeComponent();
            masvInput = masv;
        }



        private void btnDeny_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateInput()
        {
            string query = string.Format(" EXEC sp_CheckSV N'{0}' ", masvInput);

            var check = Program.ExecSqlNonQuery(query);
            if (check == 1)
            {
                MessageBox.Show("Sinh viên đã thi nên không thể chuyển lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ChuyenSVForm.malop = this.txtEditCHUYENLOP.Text.Trim();
            String cmd = "Select MALOP from LOP Where MALOP='" + malop + "'";
            SqlDataReader dr = Program.ExecSqlDataReader(cmd);

            if (!dr.Read())
            {
                MessageBox.Show("Mã số Lớp không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr.Close();
                return;
            }
            dr.Close();

            if (validateInput() == true)
            {
                ChuyenSVForm.chuyen = true;
               
                this.Close();
            }
            
        }

        private void ChuyenSVForm_Closed(object sender, FormClosedEventArgs e)
        {
            ChuyenSVForm.chuyen = false;
            ChuyenSVForm.malop = "";
            ChuyenSVForm.masvInput = "";
            SinhVienForm.stateChildForm = false;
        }

        private void ChuyenSVForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}