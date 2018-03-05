using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongAVL_BST.Object
{
    public class Circle:ICloneable
    {
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }
        public string Text { get; set; }
        public Color Color { get; set; }
        public int fontSize { get; set; }
        public int Width { get; set; }

        // Function
        public void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color);
            pen.Width = Width!=0 ? Width : 1;

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            //e.Graphics.FillEllipse(new SolidBrush(Color), x - d, y - d, d * 2, d * 2);

            e.Graphics.DrawEllipse(pen, x-r, y-r, r*2,r*2);
            e.Graphics.DrawString(this.Text, new Font("Times New Roman", fontSize), new SolidBrush(Color.Black), new PointF(x, y), format);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
