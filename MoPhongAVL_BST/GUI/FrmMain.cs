﻿using MoPhongAVL_BST.Model;
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
        private BST_Tree BST = Data.BST;
        private AVL_Tree AVL = Data.AVL;
        private List<Graph> graphDisplay = new List<Graph>();
        private int IndexGraphDisplay = 0;
        private bool isBST = Data.isBST;

        #region Hàm khởi tạo
        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region LoadForm
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
                List<Graph> list;
                if (Data.isBST)
                    list = BST.Insert(Helper.tempSinhVien);
                else
                    list = AVL.Insert(Helper.tempSinhVien);
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
                List<Graph> list;
                if (Data.isBST)
                    list = BST.Search(Helper.tempSinhVien);
                else
                    list = AVL.Search(Helper.tempSinhVien);
                display(list);
            }
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            FrmCapNhat form = new FrmCapNhat();
            form.ShowDialog();

            if (Helper.tempSinhVien.StudentCode != 0)
            {
                List<Graph> list;
                if (Data.isBST)
                    list = BST.Update(Helper.tempSinhVien);
                else
                    list = AVL.Update(Helper.tempSinhVien);
                display(list);
            }
        }

        private void btnXoaNode_Click(object sender, EventArgs e)
        {
            FrmXoaNode form = new FrmXoaNode();
            form.ShowDialog();

            if (Helper.tempSinhVien.StudentCode != 0)
            {
                List<Graph> list;
                if (Data.isBST)
                    list = BST.Delete(Helper.tempSinhVien);
                else
                    list = AVL.Delete(Helper.tempSinhVien);
                display(list);
            }
        }

        private void btnDuyetCay_Click(object sender, EventArgs e)
        {
            List<Graph> gr;
            if (Data.isBST)
                gr = BST.LNR();
            else
                gr = AVL.LNR();
            display(gr);
        }

        private void btnXoaCay_Click(object sender, EventArgs e)
        {
            List<Graph> ans;
            if (Data.isBST)
                ans = BST.Clear();
            else
                ans = AVL.Clear();
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

        private void rdAVL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBST.Checked)
                Data.isBST = true;
            else
                Data.isBST = false;

            List<Graph> list = new List<Graph>();
            if (Data.isBST)
            {
                switch (Data.BST.Type)
                {
                    case 2: rdHoTen.Checked = true; break;
                    case 3: rdNgaySinh.Checked = true; break;
                    case 4: rdDTB.Checked = true; break;
                    case 5: rdTinChi.Checked = true; break;
                }
                list.Add(Data.BST.display());
            }
            else
            {
                switch (Data.AVL.Type)
                {
                    case 2: rdHoTen.Checked = true; break;
                    case 3: rdNgaySinh.Checked = true; break;
                    case 4: rdDTB.Checked = true; break;
                    case 5: rdTinChi.Checked = true; break;
                }
                list.Add(Data.AVL.display());
            }
            display(list);
        }

        private void rdNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            int Type = 0;
            if (rdHoTen.Checked) Type = 2;
            if (rdNgaySinh.Checked) Type = 3;
            if (rdDTB.Checked) Type = 4;
            if (rdTinChi.Checked) Type = 5;

            if (Data.isBST)
            {
                Data.BST.Type = Type;
                List<Student> data = Data.BST.getListStudent();
                Data.BST.Clear();
                foreach (var item in data) Data.BST.Insert(item);
            }
            else
            {
                Data.AVL.Type = Type;
                List<Student> data = Data.AVL.getListStudent();
                Data.AVL.Clear();
                foreach (var item in data) Data.AVL.Insert(item);
            }

            List<Graph> list = new List<Graph>();
            if (Data.isBST)
                list.Add(Data.BST.display());
            else
                list.Add(Data.AVL.display());

            display(list);
        }
    }
}
