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

namespace MoPhongAVL_BST
{
    public partial class Form1 : Form
    {
        private Node Root = new Node();

        Circle circle = new Circle() { x = 200, y = 200, Color = Color.Red, Text = "Học tập", r = 40, fontSize = 11, Width = 2 };
        Circle circle1 = new Circle() { x = 350, y = 300, Color = Color.Green, Text = "Tình Yêu", r = 45, fontSize = 11, Width = 2 };
        Circle circle2 = new Circle() { x = 550, y = 150, Color = Color.Orange, Text = "Sức khỏe", r = 30, fontSize = 11, Width = 2 };

        Line l, l2, l3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            BST_Tree tree = new BST_Tree();
            tree.Type = 2;
            tree.Insert(new Student() { StudentCode = 1, FullName = "Thủy", DateOfBirth = DateTime.Now, Score = 9, Count = 1 });
            tree.Insert(new Student() { StudentCode = 2, FullName = "Quỳnh", DateOfBirth = DateTime.Now, Score = 10, Count = 1 });
            tree.Insert(new Student() { StudentCode = 1, FullName = "Yến", DateOfBirth = DateTime.Now, Score = 8, Count = 1 });
            tree.Insert(new Student() { StudentCode = 1, FullName = "An", DateOfBirth = DateTime.Now, Score = 9, Count = 1 });
            tree.Insert(new Student() { StudentCode = 1, FullName = "Sơn", DateOfBirth = DateTime.Now, Score = 7, Count = 1 });
            tree.display().Draw(e);
        }
    }
}
