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
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            Helper.tempSinhVien = new Student();
            InitializeComponent();
        }

        #region Hàm chức năng
        private bool Check()
        {
            if (txtTuKhoa.Text == "")
            {
                MessageBox.Show("Từ khóa không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Data.BST.Type == 2) return true;

            if (Data.BST.Type == 3)
            {
                try
                {
                    DateTime k = DateTime.Parse(txtTuKhoa.Text);
                }
                catch
                {
                    MessageBox.Show("Từ khóa tìm kiếm phải ở dạng ngày tháng năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }

            if (Data.BST.Type == 4)
            {
                /// điểm trung bình chung
                try
                {
                    double dtb = Double.Parse(txtTuKhoa.Text);
                }
                catch
                {
                    MessageBox.Show("Từ khóa tìm kiếm phải ở dạng số thực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }

            if (Data.BST.Type == 5)
            {
                try
                {
                    int k = Int32.Parse(txtTuKhoa.Text);
                }
                catch
                {
                    MessageBox.Show("Từ khóa tìm kiếm phải ở dạng số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }

            return true;
        }
        #endregion

        #region Sự kiện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Check()) {
                switch (Data.BST.Type)
                {
                    case 2: Helper.tempSinhVien.FullName = txtTuKhoa.Text; break;
                    case 3: Helper.tempSinhVien.DateOfBirth = DateTime.Parse(txtTuKhoa.Text); break;
                    case 4: Helper.tempSinhVien.Score = Double.Parse(txtTuKhoa.Text); break;
                    case 5: Helper.tempSinhVien.Count = Int32.Parse(txtTuKhoa.Text); break;
                }

                Helper.tempSinhVien.StudentCode = -1;
                this.Close();
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
