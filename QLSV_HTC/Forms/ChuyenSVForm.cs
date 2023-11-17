using DevExpress.Xpo.DB.Helpers;
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
        private static string malopInput;
        public ChuyenSVForm(string masv, string malop)
        {
            InitializeComponent();
            masvInput = masv;
            malopInput = malop;
        }



        private void btnDeny_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateInput(string masv)
        {
            string query = string.Format(" EXEC sp_CheckChuyenLopSV N'{0}' ", masv);
            SqlDataReader dr = Program.ExecSqlDataReader(query);

            if (!dr.Read())
            {
                dr.Close();
                return false;
            }
            if (dr.GetString(0) == "0")
            {
                MessageBox.Show("Sinh viên đã thi nên không thể chuyển lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                return false;
            }
            dr.Close();
            return true;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ChuyenSVForm.chuyen = false;
            ChuyenSVForm.malop = this.txtEditCHUYENLOP.Text.Trim();
            String cmd = "Select MALOP from LOP Where MALOP='" + malop + "'";
            SqlDataReader dr = Program.ExecSqlDataReader(cmd);

            if (!dr.Read())
            {
                MessageBox.Show("Mã số Lớp không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr.Close();
                return;
            }

            if (dr.GetString(0) == malopInput)
            {
                MessageBox.Show("Mã số lớp trùng với mã số lớp hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr.Close();
                return;
            }    
            dr.Close();

            if (validateInput(masvInput) == true)
            {
                ChuyenSVForm.chuyen = true;
                this.Close();
            }

            // Check lớp chuyển
            String query2 = string.Format("EXEC SP_CheckLopChuyenSV N'{0}' ", malop);            
            SqlDataReader dr2 = Program.ExecSqlDataReader(query2);
            if (!dr2.Read())
            {
                dr2.Close();
                return;
            }
            if (dr2.GetString(0) == "1")
            {
                dr2.Close();
                Console.WriteLine("CUNG SITE");
                SinhVienForm.undoStack.Push(string.Format("EXEC SP_ChuyenLopSV N'{0}', N'{1}'", masvInput, malopInput));
                string chuyenSV = string.Format("EXEC SP_ChuyenLopSV N'{0}', N'{1}'", masvInput, malop);
                Console.WriteLine(chuyenSV);
                int kq = Program.ExecSqlNonQuery(chuyenSV);
                ChuyenSVForm.chuyen = true;
                
                return;
            }
            else
            {
                dr2.Close();
                Console.WriteLine("KHAC SITE");
                string loptc = string.Format("EXEC SP_XoaDkLtcSV {0}", masvInput);
                SqlDataReader dsltc = Program.ExecSqlDataReader(loptc);
                dsltc.Read();
                Console.WriteLine(dsltc.GetString(0), dsltc.GetString(1), dsltc.GetString(2), dsltc.GetString(3), dsltc.GetString(4));
                string undo = string.Format("INSER INTO DANGKY (MALTC, MASV, DIEMCC, DIEMGK, DIEMCC, HUYDK) VALUES ({0}, {1}, {2}, {3}, {4}, 0)", dsltc.GetString(0), dsltc.GetString(1), dsltc.GetString(2), dsltc.GetString(3), dsltc.GetString(4));
                SinhVienForm.undoStack.Push(undo);
                string chuyenSV = string.Format("EXEC SP_ChuyenLopSV N'{0}', N'{1}'", masvInput, malop);
                int kq = Program.ExecSqlNonQuery(chuyenSV);
                ChuyenSVForm.chuyen = true;
                
                return;
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