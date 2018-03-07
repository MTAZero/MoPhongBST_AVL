using MoPhongAVL_BST.Model;
using MoPhongAVL_BST.Object;
using MoPhongAVL_BST.Pointer;
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
    public partial class FrmMain : Form
    {
        private AVL_Tree BST = Data.BST;
        private List<Graph> graphDisplay = new List<Graph>();
        private int IndexGraphDisplay = 0;
        private int cnt = 0;

        #region Hàm khởi tạo
        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region LoadForm
        private void BieuDienCay()
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region Hàm chức năng

        private void LockButton()
        {
            btnCapNhatThongTin.Enabled = false;
            btnDuyetCay.Enabled = false;
            btnThemNode.Enabled = false;
            btnTimNode.Enabled = false;
            btnXoaCay.Enabled = false;
            btnXoaNode.Enabled = false;
        }

        private void UnLockButton()
        {
            btnCapNhatThongTin.Enabled = true;
            btnDuyetCay.Enabled = true;
            btnThemNode.Enabled = true;
            btnTimNode.Enabled = true;
            btnXoaCay.Enabled = true;
            btnXoaNode.Enabled = true;
        }
        private void display(List<Graph> list)
        {
            graphDisplay = list;
            IndexGraphDisplay = 0;
            Timer.Enabled = true;
            Timer.Interval = 500;
        }
        #endregion

        #region Sự kiện
        private void btnThemNode_Click(object sender, EventArgs e)
        {
            FrmThemNode form = new FrmThemNode();
            form.ShowDialog();

            if (Helper.tempSinhVien.StudentCode != 0)
            {
                List<Graph> list = BST.Insert(Helper.tempSinhVien);
                display(list);
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;

            IndexGraphDisplay = graphDisplay.Count - 1;
            Graph z = graphDisplay[IndexGraphDisplay];
            FrmDraw draw = new FrmDraw(z);
            draw.TopLevel = false;
            draw.Dock = DockStyle.Fill;
            panelDraw.Controls.Clear();
            panelDraw.Controls.Add(draw);
            draw.Show();

            UnLockButton();
        }

        private void btnTimNode_Click(object sender, EventArgs e)
        {
            FrmTimKiem form = new FrmTimKiem();
            form.ShowDialog();

            if (Helper.tempSinhVien.StudentCode != 0)
            {
                List<Graph> list = BST.Search(Helper.tempSinhVien);
                display(list);
            }
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            FrmCapNhat form = new FrmCapNhat();
            form.ShowDialog();

            if (Helper.tempSinhVien.StudentCode != 0)
            {
                List<Graph> list = BST.Update(Helper.tempSinhVien);
                display(list);
            }
        }

        private void btnXoaNode_Click(object sender, EventArgs e)
        {
            FrmXoaNode form = new FrmXoaNode();
            form.ShowDialog();

            if (Helper.tempSinhVien.StudentCode != 0)
            {
                List<Graph> list = BST.Delete(Helper.tempSinhVien);
                display(list);
            }
        }

        private void btnDuyetCay_Click(object sender, EventArgs e)
        {
            List<Graph> gr = BST.LNR();
            display(gr);
        }

        private void btnXoaCay_Click(object sender, EventArgs e)
        {
            List<Graph> ans = BST.Clear();
            panelDraw.Controls.Clear();
        }
        #endregion

        #region Sự kiện ngầm
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (IndexGraphDisplay > graphDisplay.Count -1)
            {
                UnLockButton();
                Timer.Enabled = false;
                return;
            }

            if (IndexGraphDisplay == 0) LockButton();

            Graph z = graphDisplay[IndexGraphDisplay];
            FrmDraw draw = new FrmDraw(z);
            draw.TopLevel = false;
            draw.Dock = DockStyle.Fill;
            panelDraw.Controls.Clear();
            panelDraw.Controls.Add(draw);
            draw.Show();

            IndexGraphDisplay++;
        }
        #endregion

        
    }
}
