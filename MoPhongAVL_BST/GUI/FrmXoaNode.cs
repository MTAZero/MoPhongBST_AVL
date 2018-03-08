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
    public partial class FrmXoaNode : Form
    {
        public FrmXoaNode()
        {
            Helper.tempSinhVien = new Student();
            InitializeComponent();
            
        }

        #region LoadForm
        private void LoadDgvSinhVien()
        {
            var stt = 0;
            string key = txtTimKiem.Text;

            var listz = new List<Student>();

            if (Data.isBST)
                listz = Data.BST.getListStudent();
            else
                listz = Data.AVL.getListStudent();

            dgvDanhSachSinhVien.DataSource = listz.ToList()
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
            LoadDgvSinhVien();
        }
        #endregion

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvSinhVien();
        }


        #region Sự kiện
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var listz = new List<Student>();

                if (Data.isBST)
                    listz = Data.BST.getListStudent();
                else
                    listz = Data.AVL.getListStudent();
                int StudentCode = (int) dgvDanhSachSinhVien.SelectedRows[0].Cells["StudentCode"].Value;

                Student k = listz.ToList().Where(p => p.StudentCode == StudentCode).FirstOrDefault();
                Helper.tempSinhVien = k;
                this.Close();
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
    }
}
