using MoPhongAVL_BST.Model;
using MoPhongAVL_BST.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongAVL_BST.GUI
{
    public partial class FrmCapNhat : Form
    {
        public FrmCapNhat()
        {
            Helper.tempSinhVien = new Student();
            InitializeComponent();
            
        }

        #region LoadForm
        private void LoadInitControl()
        {
            switch (Data.BST.Type){
                case 2: txtFullName.Enabled = false; break;
                case 3: dateNgaySinh.Enabled = false; break;
                case 4: txtDTB.Enabled = false; break;
                case 5: txtTinChi.Enabled = false; break;
            }
        }
        private void LoadDgvSinhVien()
        {
            var stt = 0;
            string key = txtTimKiem.Text;

            dgvDanhSachSinhVien.DataSource = Data.BST.getListStudent()
                                             .Where(p=>p.FullName.Contains(key) || p.DateOfBirth.ToString("dd/MM/yyyy").Contains(key) || p.Score.ToString().Contains(key) || p.Count.ToString().Contains(key))
                                             .Select(p => new
                                             {
                                                 STT = ++stt,
                                                 StudentCode = p.StudentCode,
                                                 FullName = p.FullName,
                                                 DateOfBirth = p.DateOfBirth.ToString("dd/MM/yyyy"),
                                                 Score = p.Score,
                                                 Count = p.Count
                                             })
                                             .ToList();
        }
        private void FrmXoaNode_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvSinhVien();
        }
        #endregion

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvSinhVien();
        }

        #region Hàm chức năng
        private bool Check()
        {

            if (txtFullName.Text == "")
            {
                MessageBox.Show("Tên sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDTB.Text == "")
            {
                MessageBox.Show("Điểm trung bình không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Double dtb = Double.Parse(txtDTB.Text);
                if (dtb < 0 || dtb > 10) dtb = dtb / (2 - 2);
            }
            catch
            {
                MessageBox.Show("Điểm trung bình phải là số nguyên từ 0 đến 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTinChi.Text == "")
            {
                MessageBox.Show("Số lượng tín chỉ tích lũy không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int sl = Int32.Parse(txtTinChi.Text);
                if (sl < 0) sl = sl / (3 - 3);
            }
            catch
            {
                MessageBox.Show("Số lượng tín chỉ tích lũy phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion


        #region Sự kiện
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //var listStudent = Data.BST.getListStudent();
                int StudentCode = (int) dgvDanhSachSinhVien.SelectedRows[0].Cells["StudentCode"].Value;

                if (Check())
                {
                    var kz = new Student();
                    kz.StudentCode = StudentCode;

                    kz.FullName = txtFullName.Text;
                    kz.DateOfBirth = dateNgaySinh.Value;
                    kz.Score = Double.Parse(txtDTB.Text);
                    kz.Count = Int32.Parse(txtTinChi.Text);

                    Helper.tempSinhVien = kz;
                    this.Close();
                }    

            }
            catch
            {
                MessageBox.Show("Chưa có sinh viên nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Sự kiện ngầm
        private void dgvDanhSachSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int k = (int) dgvDanhSachSinhVien.SelectedRows[0].Cells["StudentCode"].Value;
                Student sv = Data.BST.getListStudent().Where(p => p.StudentCode == k).FirstOrDefault();

                txtFullName.Text = sv.FullName;
                dateNgaySinh.Value = sv.DateOfBirth;
                txtDTB.Text = sv.Score.ToString();
                txtTinChi.Text = sv.Count.ToString();
            }
            catch
            {

            }
        }
        #endregion
    }
}
