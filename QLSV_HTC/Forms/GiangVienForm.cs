using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using QLSV_HTC.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_HTC.Forms
{
    public partial class GiangVienForm : DevExpress.XtraEditors.XtraForm
    {
        private int position = -1;
        private string state = "";
        Stack<string> undoStack = new Stack<string>();

        private GiangVienClass gv = null;
        public GiangVienForm()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            if (TextBox_MaGV.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mã sinh viên không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TextBox_Ho.Text.Trim() == "" || TextBox_Ten.Text.Trim() == "")
            {
                XtraMessageBox.Show("Họ tên không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
  /**
            if (TextBox_HOCVI.Text.Trim() == "")
            {
                XtraMessageBox.Show("Địa chỉ không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
  **/
            return true;
        }
        private Boolean CheckMaSV(String maSV)
        {
            String query = String.Format("EXEC sp_KiemTraMaSV @MaSV = {0}", maSV);
            int check = Program.ExecSqlNonQuery(query);
            if (check == 1)
                return true;
            return false;
        }

        private void SetButtonState(bool value)
        {
            if (state == "edit")
            {
                barButtonItem_Add.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = GC_GV.Enabled
                    = cmbKhoa.Enabled
                    //= panelControl1.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl3.Enabled
                    = TextBox_MaGV.ReadOnly
                    = value;

                barButtonUndo.Enabled = undoStack.Count > 0;

            }
            else if (state == "add")
            {
                barButtonItem_Add.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = GC_GV.Enabled
                    = TextBox_MaGV.ReadOnly
                    = cmbKhoa.Enabled
                    //= panelControl1.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                   = panelControl3.Enabled
                    = value;

            }
        }

        private void LoadData()
        {
            DS.EnforceConstraints = false;
       
            // TODO: This line of code loads data into the 'dS.GiangVien' table. You can move, or remove it, as needed.
            this.GiangVienTableAdapter.Connection.ConnectionString = Program.ConnStr;
            this.GiangVienTableAdapter.Fill(this.DS.GIANGVIEN);
            // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
       
            barButtonDelete.Enabled = barButtonEdit.Enabled = bdsGiangVien.Count > 0;
        
            if(position > 0 )
            {
                if (position <= bdsGiangVien.Count)
                    bdsGiangVien.Position = position;
                else
                    bdsGiangVien.Position = position = 0;
            }

        }

        private void GiangVienForm_Load(object sender, EventArgs e)
        {       

            //if (Program.AuthGroup == "PGV")
            //{
            //    Program.Bds_Dspm.Filter = "TENKHOA <> 'Phòng Kế Toán'";
            //}
            //else if (Program.AuthGroup == "KHOA")
            //{
            //    Program.Bds_Dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
            //}

            Utils.LoadComboBox(cmbKhoa, Program.Bds_Dspm.DataSource);

            if (Utils.ChangeServer(cmbKhoa))
            {
                LoadData();
            }
        }


        private void GiangVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGiangVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

    
        private void barButtonOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(barButtonUndo.Enabled)
            {
                String message = "Dữ liệu bạn vừa sửa sẽ không thể hoàn tác! Bạn có xác nhận thoát.";
                DialogResult dr = XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No) return;
            }else if(barButtonHuy.Enabled)
            {
                String message = "Dữ liệu bạn đang sửa sẽ bị hủy! Bạn có xác nhận thoát.";
                DialogResult dr = XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No) return;
            }
            
            this.Close();
        }


        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsGiangVien.Position;     
            state = "add";  
            SetButtonState(true);
            TextBox_MaGV.Focus();
            bdsGiangVien.AddNew();
         
        

        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //check các dk của dữ liệu đưa vào
            if (!ValidateForm()) return;
            if (state == "add" && CheckMaSV(TextBox_MaGV.Text) )
            {
                TextBox_MaGV.Focus();
                return;
            }
       
            try
            {
                this.bdsGiangVien.EndEdit();
                this.bdsGiangVien.ResetCurrentItem();
                this.GiangVienTableAdapter.Update(this.DS.GIANGVIEN);

                if (state == "edit")
                {
                    undoStack.Push(string.Format("UPDATE GIANGVIEN SET [MAKHOA] = N'{0}', [HO] =N'{1}',[TEN] = N'{2}', [HOCVI] = N'{3}', [HOCHAM] = N'{4}', [CHUYENMON] = N'{5}' WHERE [MAGV] = N'{6}'", gv.maKhoa, gv.ho, gv.ten, gv.hocVi, gv.hocHam, gv.chuyenMon, gv.maGV));
                    Console.WriteLine(string.Format("UPDATE GIANGVIEN SET [MAKHOA] = N'{0}', [HO] =N'{1}',[TEN] = N'{2}', [HOCVI] = N'{3}', [HOCHAM] = N'{4}', [CHUYENMON] = N'{5}' WHERE [MAGV] = N'{6}'", gv.maKhoa, gv.ho, gv.ten, gv.hocVi, gv.hocHam, gv.chuyenMon, gv.maGV));
                }
            }
            catch (Exception ex)
            {
                bdsGiangVien.RemoveCurrent();
                XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //chỉnh sửa lại các trạng thái nút
            SetButtonState(false);
        }

        private void barButtonUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count == 0) return;
            string command = undoStack.Pop();
            Program.ExecSqlNonQuery(command);
            LoadData();
            barButtonUndo.Enabled = undoStack.Count > 0;
        }


        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsGiangVien.Position;          
            state = "edit";
            SetButtonState(true);         
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGiangVien.CancelEdit();
            SetButtonState(false);
            LoadData();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Utils.ChangeServer(cmbKhoa))
            {
                LoadData();
            }
        }

        private void barButtonRenew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = 0;       
            LoadData();
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBox_MaGV_TextChanged(object sender, EventArgs e)
        {
            TextBox_MaGV.CharacterCasing = CharacterCasing.Upper;
        }


        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {          
            try
            {
                gv = new GiangVienClass(TextBox_MaGV.Text.Trim(), TextBox_MAKHOA.Text.Trim(), TextBox_Ho.Text.Trim(), TextBox_Ten.Text.Trim(), TextBox_HOCVI.Text.Trim(), TextBox_HOCHAM.Text.Trim(), TextBox_CHUYENMON.Text.Trim());
                Console.WriteLine(gv.maGV, gv.maKhoa, gv.ho, gv.ten, gv.hocVi, gv.hocHam, gv.chuyenMon);
            }
            catch { }
            
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa giảng viên này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (bdsGiangVien.Count > 0)
                {
                    try
                    {                                             
                        bdsGiangVien.EndEdit();
                        this.GiangVienTableAdapter.Connection.ConnectionString = Program.ConnStr;
                        this.GiangVienTableAdapter.Update(this.DS.GIANGVIEN);
                        this.bdsGiangVien.ResetCurrentItem();
                        undoStack.Push(string.Format("UPDATE GiangVien SET [DANGHIHOC] ='False' WHERE [MASV] = '{0}'",TextBox_MaGV.Text ));
                        
                        XtraMessageBox.Show("Sinh viên đã được thay đổi thành đã nghỉ học, do đã đăng ký lớp tín chỉ nên không thể xóa.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa giảng viên .\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        //LopForm_Load(sender, e);
                        LoadData();
                    }
                }
                else
                {
                    try
                    {
                        position = bdsGiangVien.Position;
                        bdsGiangVien.RemoveCurrent();
                        this.GiangVienTableAdapter.Connection.ConnectionString = Program.ConnStr;
                        this.GiangVienTableAdapter.Update(this.DS.GIANGVIEN);
                        this.bdsGiangVien.ResetCurrentItem();

                        undoStack.Push(string.Format("INSERT INTO GIANGVIEN([MAGV],[MAKHOA],[HO],[TEN],[HOCVI], [HOCHAM], [CHUYENMON] )VALUES(N'{0}',N'{1}',N'{2}',{3},N'{4}','{5}','{6}', '{7}')", gv.maGV, gv.maKhoa, gv.ho, gv.ten, gv.hocVi, gv.hocHam, gv.chuyenMon));
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa sinh viên .\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        //LopForm_Load(sender, e);
                        LoadData();
                    }
                }
                LoadData();
                barButtonDelete.Enabled = bdsGiangVien.Count > 0;
                barButtonUndo.Enabled = undoStack.Count > 0;
            }


        }

        private void GC_Lop_Click(object sender, EventArgs e)
        {

        }

       

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(bdsGiangVien.Count>0)
            {
        
                try
                {
                   
                    gv = new GiangVienClass(TextBox_MaGV.Text.Trim(), TextBox_MAKHOA.Text.Trim(), TextBox_Ho.Text.Trim(), TextBox_Ten.Text.Trim(), TextBox_HOCVI.Text.Trim(), TextBox_HOCHAM.Text.Trim() ,TextBox_CHUYENMON.Text.Trim());
                }
                catch { }
            }
        }

        private void GC_GV_Click(object sender, EventArgs e)
        {

        }
    }
}
