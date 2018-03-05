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

        Circle circle = new Circle() { x = 200, y = 200, Color = Color.Red, Text = "MTAZero", r = 40, fontSize = 12, Width = 2 };
        Circle circle1 = new Circle() { x = 350, y = 300, Color = Color.Green, Text = "Zindo", r = 45, fontSize = 12, Width = 2 };
        Circle circle2 = new Circle() { x = 550, y = 150, Color = Color.Orange, Text = "Rs", r = 30, fontSize = 12, Width = 2 };

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
            Line l = Helper.Connect(circle, circle1);
            Line l2 = Helper.Connect(circle1, circle2);
            Line l3 = Helper.Connect(circle2, circle);

            circle1.Draw(e);
            circle.Draw(e);
            circle2.Draw(e);
            l.Draw(e);
            l3.Draw(e);
            l2.Draw(e);
        }
    }
}
