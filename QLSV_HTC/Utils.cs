using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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

        public static void eventDataChanged()
        {
            ManualResetEvent dataChangedEvent = new ManualResetEvent(false);

            // Start a separate task to simulate data changes
            Task.Run(() =>
            {
                // Simulate data changes
                Thread.Sleep(5000); // Sleep for 5 seconds

                // Set the ManualResetEvent to signal that data changes have occurred
                dataChangedEvent.Set();
            });

            // Wait for the data changes using the ManualResetEvent
            Console.WriteLine("Waiting for data changes...");
            dataChangedEvent.WaitOne(); // This will block the program until the event is signaled

            // Data changes have occurred, continue execution
            Console.WriteLine("Data changes detected. Resuming program execution.");
        }
    }
}
