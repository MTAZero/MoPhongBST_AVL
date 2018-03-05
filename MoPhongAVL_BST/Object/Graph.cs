using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongAVL_BST.Object
{
    public class Graph
    {
        public List<Circle> listCircle { get; set; }
        public List<Line> listLine { get; set; }

        public Graph()
        {
            listCircle = new List<Circle>();
            listLine = new List<Line>();
        }

        public void Draw(PaintEventArgs e)
        {
            foreach (var circle in listCircle) circle.Draw(e);
            foreach (var line in listLine) line.Draw(e);
        }
    }
}
