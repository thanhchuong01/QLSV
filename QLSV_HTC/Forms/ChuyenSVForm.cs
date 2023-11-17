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

            string malopInput0 = "D16CQVT01";

            String query = string.Format("EXEC SP_CheckLopChuyenSV N'{0}'", malopInput0);
            int check = Program.ExecSqlNonQueryInt(query);
            Console.WriteLine(query);
            Console.WriteLine(check);
            //if (check == 0)
           // {
            //    SinhVienForm.undoStack.Push(string.Format("EXEC SP_ChuyenLopSV '{0}' '{1}'", masvInput, malopInput));
              //  string chuyenSV = string.Format("EXEC SP_ChuyenLopSV '{0}' '{1}'", masvInput, malop);
              
                //    ChuyenSVForm.chuyen = true;
                  //  return;
                
          //  }
            //else
           // {
           //     string loptc = string.Format("EXEC SP_XoaDkLtcSV {0}", masvInput);
             //   SqlDataReader dsltc = Program.ExecSqlDataReader(loptc);
               // dsltc.Read();
           //     Console.WriteLine(dsltc.GetString(0), dsltc.GetString(1), dsltc.GetString(2), dsltc.GetString(3), dsltc.GetString(4));
              //  string undo = string.Format("INSER INTO DANGKY (MALTC, MASV, DIEMCC, DIEMGK, DIEMCC, HUYDK) VALUES ({0}, {1}, {2}, {3}, {4}, 0)", dsltc.GetString(0), dsltc.GetString(1), dsltc.GetString(2), dsltc.GetString(3), dsltc.GetString(4));
        //        SinhVienForm.undoStack.Push(undo);
         //       string chuyenSV = string.Format("EXEC SP_ChuyenLopSV {0} {1}", masvInput, malop);
         //       var check2 = Program.ExecSqlNonQuery(chuyenSV);
           //     if (check2 == 1)
           //
             //   {
           //         ChuyenSVForm.chuyen = true;
             //       return;
           //     }

           // }
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