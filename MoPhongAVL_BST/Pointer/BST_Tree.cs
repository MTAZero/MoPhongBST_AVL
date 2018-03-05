using MoPhongAVL_BST.Model;
using MoPhongAVL_BST.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoPhongAVL_BST.Pointer
{
    public class BST_Tree
    {
        public int Type { get; set; }
        private Node Root;
        public int MaxWidth { get; set; }

        #region Các hàm khởi tạo
        BST_Tree()
        {

        }

        BST_Tree(List<Student> list)
        {

        }

        BST_Tree(BST_Tree a, int newType)
        {

        }
        #endregion

        #region Các thao tác với dữ liệu thêm, xóa, sửa
        public List<Graph> Insert(Student a)
        {
            Node z = new Node();
            z.Parent = null;
            z.LeftChild = null;
            z.RightChild = null;
            z.Info = a;
            return Insert(z);
        }

        public List<Graph> Insert(Node a)
        {
            List<Graph> ans = new List<Graph>();

            Node p = this.Root;

            return new List<Graph>();
        }

        public List<Graph> Delete(Student a)
        {
            return new List<Graph>();
        }

        public List<Graph> Search(Student a)
        {
            return new List<Graph>();
        }

        public List<Graph> Update(Student a)
        {
            return new List<Graph>();
        }
        #endregion

        #region Các thao tác duyệt cây
        public List<Graph> LNR()
        {
            return new List<Graph>();
        }

        public List<Graph> LRN()
        {
            return new List<Graph>();
        }

        public List<Graph> NLR()
        {
            return new List<Graph>();
        }
        #endregion

        #region Hàm để biểu diễn trực quan
        public Graph display()
        {
            if (this.MaxWidth == 0) this.MaxWidth = 1100;

            return getGraph(Root, 30, 30, MaxWidth);
        }

        private Graph getGraph(Node a, int Y, int miX, int maX)
        {
            if (a == null)
            {
                return new Graph();
            }

            /// Hình dạng của đỉnh hiện tại
            Circle currentNode =
                new Circle()
                {
                    Text = getText(a),
                    r = 15,
                    y = Y,
                    x = (miX + maX) / 2,
                    fontSize = 11,
                    Width = 2,
                    Color = System.Drawing.Color.Green
                };


            Graph ans = new Graph();
            int mid = (miX + maX) / 2;
            if (a.LeftChild == null) mid = miX; else mid = maX;

            if (a.LeftChild != null)
            {
                Graph z = getGraph(a.LeftChild, Y + 100, miX, mid);
                ans.listCircle.AddRange(z.listCircle);
                ans.listLine.AddRange(z.listLine);

                Circle temp = new Circle() { y = Y + 100, x = (miX + mid) / 2, r = 15 };
                Line line = Helper.Connect(currentNode, temp);

                ans.listLine.Add(line);
            }

           
            ans.listCircle.Add(currentNode);
            

            if (a.RightChild != null)
            {
                Graph z = getGraph(a.RightChild, Y + 100, mid, maX);
                ans.listCircle.AddRange(z.listCircle);
                ans.listLine.AddRange(z.listLine);

                Circle temp = new Circle() { y = Y + 100, x = (maX + mid) / 2, r = 15 };
                Line line = Helper.Connect(currentNode, temp);
                ans.listLine.Add(line);
            }

            return ans;
        }
        #endregion

        #region Hàm lấy tất cả các sinh viên trong cây ra
        public List<Student> getListStudent()
        {
            var ans = getStudent(Root);
            return ans;
        }

        private List<Student> getStudent(Node node)
        {
            var ans = new List<Student>();

            if (node.LeftChild != null) ans.AddRange(getStudent(node.LeftChild));
            ans.Add(node.Info);
            if (node.RightChild != null) ans.AddRange(getStudent(node.RightChild));

            return ans;
        }

        #endregion

        #region Các hàm hỗ trợ
        private string getText(Node a)
        {
            if (Type == 1) return a.Info.StudentCode.ToString();
            if (Type == 2) return a.Info.FullName;
            if (Type == 3) return a.Info.DateOfBirth.ToString("dd/MM/yyyy");
            if (Type == 4) return a.Info.Score.ToString();
            if (Type == 5) return a.Info.Count.ToString();
            return "";
        }
        #endregion

    }
}
