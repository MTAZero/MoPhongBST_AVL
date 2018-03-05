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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Root.Parent = null;
            Root.Number = 0;

            Node a = new Node() { Number = 1 };
            Node b = new Node() { Number = 2 };
            Node c = new Node() { Number = 3 };

            Root.Child = a; a.Parent = Root;
            a.Child = b; b.Parent = a;
            b.Child = c; c.Parent = b;

            txt1.Text = Root.Child.Child.Number.ToString();

            //MessageBox.Show(c.Parent.Parent.Parent.Number.ToString());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Circle circle = new Circle() { x = 200, y = 200, Color = Color.Red, Text = "MTAZero", d=40, fontSize = 12, Width = 2 };
            

            Circle circle1 = new Circle() { x = 350, y = 300, Color = Color.Green, Text = "Silver Arrow", d = 45, fontSize = 12, Width = 2 };
            

            Line l = new Line { x1 = circle.x, y1 = circle.y, x2 = circle1.x, y2 = circle1.y, Color = Color.Blue };


            l.Draw(e);
            circle1.Draw(e);
            circle.Draw(e);
        }
    }
}
