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
    public partial class FrmThemNode : Form
    {
        public FrmThemNode()
        {
            Helper.tempSinhVien = new Student();
            InitializeComponent();
        }


        #region Sự kiện

        private bool Check()
        {
            if (txtStudentCode.Text == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int studentCode = Int32.Parse(txtStudentCode.Text);

                if (!Data.CodeIsOk(studentCode))
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch {
                MessageBox.Show("Mã sinh viên phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Student st = new Student();
                st.StudentCode = Int32.Parse(txtStudentCode.Text);
                st.FullName = txtFullName.Text;
                st.DateOfBirth = dateNgaySinh.Value;
                st.Score = Double.Parse(txtDTB.Text);
                st.Count = Int32.Parse(txtTinChi.Text);

                Helper.tempSinhVien = st;
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
