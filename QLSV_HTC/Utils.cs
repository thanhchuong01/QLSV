using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_HTC
{
    class Utils
    {
        public static bool ChangeServer(System.Windows.Forms.ComboBox cmbKhoa)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return false;
            // đoạn code hỗ trợ chuyển chi nhánh
            // ở chi nhánh A qua B thì dùng RemoteLogin,
            if (cmbKhoa.SelectedValue.ToString() != Program.AuthServerName)
            {
                Program.ServerLogin = Program.RemoteLogin;
                Program.ServerPassword = Program.RemotePassword;
            }
            else
            { // ở B về lại A dùng login ban đầu
                Program.ServerLogin = Program.AuthLogin;
                Program.ServerPassword = Program.AuthPassword;
            }

            Program.ServerName = cmbKhoa.SelectedValue.ToString();
           
            try
            {
                Program.KetNoi();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static string GetMaKhoa(string tenkhoa)
        {
            //MessageBox.Show("sdfsd", tenkhoa);
            string ShortName = "";
            string query = string.Format(" SELECT MAKHOA FROM KHOA WHERE TENKHOA = N'{0}' ", tenkhoa.ToString());
            Program.MyReader = Program.ExecSqlDataReader(query);
            Program.MyReader.Read();
            ShortName = Program.MyReader.GetString(0);
            Program.MyReader.Close();
            return ShortName;
        }

        public static void LoadComboBox(System.Windows.Forms.ComboBox cmbServer, Object dt)
        {
            try
            {
                DataTable datatable = (DataTable)dt;
                cmbServer.DataSource = datatable;
            }
            catch {
                cmbServer.DataSource = dt;
            }
            cmbServer.DisplayMember = "TENKHOA";
            cmbServer.ValueMember = "TENSERVER";
            cmbServer.SelectedIndex = 0;
        }
    }
}
