using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongAVL_BST.Object
{
    public class Line:ICloneable
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }

        // Function
        public void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color);
            pen.Width = Width==0 ? 1 : Width;
            e.Graphics.DrawLine(pen, x1, y1, x2, y2);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
