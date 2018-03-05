using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoPhongAVL_BST.Object
{
    public static class Helper
    {
        private static float khoangcach(int x1, int y1, int x2, int y2)
        {
            return (float) Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
        public static Line Connect(Circle a, Circle b)
        {
            Line ans = new Line();

            float kc = khoangcach(a.x, a.y, b.x, b.y);
            float ux = (b.x - a.x) / kc;
            float uy = (b.y - a.y) / kc;

            float xz1 = a.x + ux * a.r;
            float yz1 = a.y + uy * a.r;
            float xz2 = b.x - ux * b.r;
            float yz2 = b.y - uy * b.r;

            ans.x1 = (int) xz1;
            ans.y1 = (int) yz1;
            ans.x2 = (int) xz2;
            ans.y2 = (int) yz2;

            ans.Width = 2;
            ans.Color = Color.Black;

            return ans;
        }
    }
}
