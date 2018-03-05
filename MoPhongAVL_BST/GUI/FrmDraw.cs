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
    public partial class FrmDraw : Form
    {
        private Graph graph = new Graph();
        public FrmDraw(Graph gr)
        {
            graph = gr;
            InitializeComponent();
        }

        private void FrmDraw_Paint(object sender, PaintEventArgs e)
        {
            graph.Draw(e);
        }
    }
}
