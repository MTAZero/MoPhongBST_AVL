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
        private BST_Tree BST = new BST_Tree() { MaxWidth = 1500, Type = 4 };
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
            Timer.Interval = 300;
        }
        #endregion

        #region Sự kiện
        private void btnThemNode_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            List<Graph> list = BST.Insert(new Student() { StudentCode = ++cnt, Score =  rd.Next(100)});
            display(list);
        }

        private void btnTimNode_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaNode_Click(object sender, EventArgs e)
        {

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
