﻿using MoPhongAVL_BST.Model;
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
        public BST_Tree()
        {
            Type = 2;
            MaxWidth = 1100;
        }

        public BST_Tree(List<Student> list)
        {

        }

        public BST_Tree(BST_Tree a, int newType)
        {

        }
        #endregion

        #region Các thao tác với dữ liệu thêm, xóa, sửa

        #region Insert
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
            if (isFound(Root, a.Info))
            {
                ans.Add(display());
            }
            return getInsert(Root, a);
        }

        private List<Graph> getInsert(Node node, Node addNode)
        {


            Graph curGraph = new Graph();
            List<Graph> ans = new List<Graph>();

            if (node == null)
            {
                Root = addNode;
                Graph afterAdd = display();
                foreach (var item in afterAdd.listCircle)
                    if (item.Text == getText(addNode))
                        item.Color = System.Drawing.Color.Blue;
                ans.Add(afterAdd);
                return ans;
            }

            // Lấy ra đồ thị cho điểm hiện tại
            curGraph = display();
            foreach (var item in curGraph.listCircle) if (item.Code == node.Info.StudentCode) item.Color = System.Drawing.Color.Red;

            ans.Add(curGraph);

            if (addNode.Info.Compare(node.Info, Type))
            {
                /// Node nằm bên phải
                if (node.RightChild == null)
                {
                    // thêm nút con
                    addNode.Parent = node;
                    node.RightChild = addNode;
                    Graph afterAdd = display();
                    foreach (var item in afterAdd.listCircle)
                        if (item.Code == addNode.Info.StudentCode)
                            item.Color = System.Drawing.Color.Blue;
                    ans.Add(afterAdd);
                }
                else
                {
                    // Duyệt sang cây bên phải
                    Line line = getLine(curGraph, node.Info.StudentCode, node.RightChild.Info.StudentCode);
                    line.Color = System.Drawing.Color.Orange;
                    ans.AddRange(getInsert(node.RightChild, addNode));
                }
            }
            else
            {
                /// Node nằm bên trái
                if (node.LeftChild == null)
                {
                    // thêm nút con
                    addNode.Parent = node;
                    node.LeftChild = addNode;
                    Graph afterAdd = display();
                    foreach (var item in afterAdd.listCircle)
                        if (item.Code == addNode.Info.StudentCode)
                            item.Color = System.Drawing.Color.Blue;
                    ans.Add(afterAdd);
                }
                else
                {
                    // Duyệt sang cây bên phải
                    Line line = getLine(curGraph, node.Info.StudentCode, node.LeftChild.Info.StudentCode);
                    line.Color = System.Drawing.Color.Orange;
                    ans.AddRange(getInsert(node.LeftChild, addNode));
                }
            }

            return ans;
        }
        #endregion

        #region Delete
        public List<Graph> Clear()
        {
            List<Graph> ans = new List<Graph>();

            Root = null;

            return ans;
        }
        public List<Graph> Delete(Student a)
        {
            return getDelete(Root, a);
        }

        private List<Graph> getDelete(Node root, Student a)
        {
            List<Graph> ans = new List<Graph>();
            Graph curGraph = display();

            if (root == null) return ans;
            foreach (var item in curGraph.listCircle) if (item.Code == root.Info.StudentCode) item.Color = System.Drawing.Color.Red;
            ans.Add(curGraph);

            if (root.Info.isSame(a, Type) && a.StudentCode == root.Info.StudentCode)
            {
                if (root.LeftChild == null && root.RightChild == null)
                {
                    // Nếu nút này là lá
                    Node Parent = root.Parent;

                    if (Parent != null && Parent.LeftChild == root)
                        Parent.LeftChild = null;
                    else
                        Parent.RightChild = null;

                    if (root == Root) Root = null;

                    Graph zz = display();
                    ans.Add(zz);

                    return ans;
                }

                if (root.LeftChild == null || root.RightChild == null)
                {
                    // là Node có 1 con

                    Node child, Parent;
                    if (root.LeftChild == null)
                        child = root.RightChild;
                    else
                        child = root.LeftChild;
                    Parent = root.Parent;
                    child.Parent = Parent;

                    if (Parent != null && Parent.LeftChild == root)
                        Parent.LeftChild = child;
                    if (Parent != null && Parent.RightChild == root)
                        Parent.RightChild = child;

                    if (root == Root)
                        Root = child;


                    Graph zz = display();
                    ans.Add(zz);

                    return ans;
                }

                /// Trường hợp code có 2 con

                Node maxLeft = MaxInLeftChild(root);

                Node _Parent = root.Parent;
                Node _ParentMaxLeft = maxLeft.Parent;

                if (_ParentMaxLeft != null && maxLeft == _ParentMaxLeft.RightChild)
                {
                    _ParentMaxLeft.RightChild = maxLeft.LeftChild;
                    if (maxLeft.LeftChild != null)
                        maxLeft.LeftChild.Parent = _ParentMaxLeft;
                }

                if (_Parent != null && root == _Parent.LeftChild)
                    _Parent.LeftChild = maxLeft;
                if (_Parent != null && root == _Parent.RightChild)
                    _Parent.RightChild = maxLeft;

                maxLeft.Parent = _Parent;
                maxLeft.RightChild = root.RightChild;
                if (maxLeft != root.LeftChild) maxLeft.LeftChild = root.LeftChild;
                if (maxLeft.RightChild != null) maxLeft.RightChild.Parent = maxLeft;
                 
                if (root == Root) Root = maxLeft;

                Graph zz1 = display();
                ans.Add(zz1);
                return ans;


            }

            if (root.LeftChild != null && root.Info.Compare(a, Type))
            {
                ans.AddRange(getDelete(root.LeftChild, a));
                return ans;
            }
            else
            {
                ans.AddRange(getDelete(root.RightChild, a));
                return ans;
            }

            return ans;

        }
        #endregion

        #region Search
        public List<Graph> Search(Student a)
        {
            return getSearch(Root, a);
        }

        private List<Graph> getSearch(Node a, Student searchStudent)
        {
            List<Graph> ans = new List<Graph>();
            Graph curGraph = display();

            if (a == null) return ans;

            foreach (var item in curGraph.listCircle) if (item.Code == a.Info.StudentCode) item.Color = System.Drawing.Color.Red;
            ans.Add(curGraph);

            if (a.Info.isSame(searchStudent, Type))
            {
                Graph foundGraph = display();
                foreach (var item in foundGraph.listCircle)
                    if (item.Code == a.Info.StudentCode)
                        item.Color = System.Drawing.Color.Blue;
                ans.Add(foundGraph);
                return ans;
            }

            if (a.LeftChild != null && !searchStudent.Compare(a.Info, Type))
            {
                List<Graph> z = getSearch(a.LeftChild, searchStudent);
                ans.AddRange(z);
                return ans;
            }

            if (a.RightChild != null && searchStudent.Compare(a.Info, Type))
            {
                List<Graph> z = getSearch(a.RightChild, searchStudent);
                ans.AddRange(z);
                return ans;
            }

            return ans;
        }

        private bool isFound(Node a, Student searchStudent)
        {
            if (a == null) return false;

            if (a.Info.isSame(searchStudent, Type)) return true;
            if (a.Info.Compare(searchStudent, Type)) return isFound(a.LeftChild, searchStudent);

            return isFound(a.RightChild, searchStudent);
        }
        #endregion

        #region Update
        public List<Graph> Update(Student a)
        {
            return getUpdate(Root, a);
        }

        private List<Graph> getUpdate(Node a, Student searchStudent)
        {
            List<Graph> ans = new List<Graph>();
            Graph curGraph = display();

            if (a == null) return ans;

            foreach (var item in curGraph.listCircle) if (item.Code == a.Info.StudentCode) item.Color = System.Drawing.Color.Red;
            ans.Add(curGraph);

            if (a.Info.isSame(searchStudent, Type) && a.Info.StudentCode == searchStudent.StudentCode)
            {
                Graph foundGraph = display();
                foreach (var item in foundGraph.listCircle)
                    if (item.Code == a.Info.StudentCode)
                        item.Color = System.Drawing.Color.Pink;
                ans.Add(foundGraph);

                a.Info.FullName = searchStudent.FullName;
                a.Info.DateOfBirth = searchStudent.DateOfBirth;
                a.Info.Score = searchStudent.Score;
                a.Info.Count = searchStudent.Count;

                return ans;
            }

            if (a.RightChild != null && searchStudent.Compare(a.Info, Type))
            {
                List<Graph> z = getUpdate(a.RightChild, searchStudent);
                ans.AddRange(z);
                return ans;
            }

            if (a.LeftChild != null && !searchStudent.Compare(a.Info, Type))
            {
                List<Graph> z = getUpdate(a.LeftChild, searchStudent);
                ans.AddRange(z);
                return ans;
            }

            return ans;
        }
        #endregion

        #endregion

        #region Các thao tác duyệt cây
        public List<Graph> LNR()
        {
            return getLNR(Root);
        }

        private List<Graph> getLNR(Node node)
        {
            List<Graph> ans = new List<Graph>();

            if (node == null) return ans;

            if (node.LeftChild != null)
            {
                List<Graph> leftGr = getLNR(node.LeftChild);
                ans.AddRange(leftGr);
            }

            Graph curGraph = display();
            foreach (var item in curGraph.listCircle)
                if (item.Code == node.Info.StudentCode)
                    item.Color = System.Drawing.Color.Red;
            ans.Add(curGraph);

            if (node.RightChild != null)
            {
                List<Graph> rightGr = getLNR(node.RightChild);
                ans.AddRange(rightGr);
            }

            return ans;
        }

        public List<Graph> LRN()
        {
            return getLNR(Root);
        }

        private List<Graph> LRN(Node node)
        {
            List<Graph> ans = new List<Graph>();

            if (node == null) return ans;

            if (node.LeftChild != null)
            {
                List<Graph> leftGr = getLNR(node.LeftChild);
                ans.AddRange(leftGr);
            }

            if (node.RightChild != null)
            {
                List<Graph> rightGr = getLNR(node.RightChild);
                ans.AddRange(rightGr);
            }

            Graph curGraph = display();
            foreach (var item in curGraph.listCircle)
                if (item.Code == node.Info.StudentCode)
                    item.Color = System.Drawing.Color.Red;
            ans.Add(curGraph);

            return ans;
        }

        public List<Graph> NLR()
        {
            return getNLR(Root);
        }

        private List<Graph> getNLR(Node node)
        {
            List<Graph> ans = new List<Graph>();

            if (node == null) return ans;

            Graph curGraph = display();
            foreach (var item in curGraph.listCircle)
                if (item.Code == node.Info.StudentCode)
                    item.Color = System.Drawing.Color.Red;
            ans.Add(curGraph);

            if (node.LeftChild != null)
            {
                List<Graph> leftGr = getLNR(node.LeftChild);
                ans.AddRange(leftGr);
            }

            if (node.RightChild != null)
            {
                List<Graph> rightGr = getLNR(node.RightChild);
                ans.AddRange(rightGr);
            }

            return ans;
        }
        #endregion

        #region Hàm để biểu diễn trực quan
        public Graph display()
        {
            if (this.MaxWidth == 0) this.MaxWidth = 1100;

            return getGraph(Root, 50, 50, MaxWidth);
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
                    r = 30,
                    y = Y,
                    x = (miX + maX) / 2,
                    fontSize = 11,
                    Width = 2,
                    Color = System.Drawing.Color.Green,
                    Code = a.Info.StudentCode
                };


            Graph ans = new Graph();
            int mid = (miX + maX) / 2;

            if (a.LeftChild != null)
            {
                Graph z = getGraph(a.LeftChild, Y + 100, miX, mid);
                ans.listCircle.AddRange(z.listCircle);
                ans.listLine.AddRange(z.listLine);

                Circle temp = new Circle() { y = Y + 100, x = (miX + mid) / 2, r = 30 };
                Line line = Helper.Connect(currentNode, temp);

                ans.listLine.Add(line);
            }


            ans.listCircle.Add(currentNode);


            if (a.RightChild != null)
            {
                Graph z = getGraph(a.RightChild, Y + 100, mid, maX);
                ans.listCircle.AddRange(z.listCircle);
                ans.listLine.AddRange(z.listLine);

                Circle temp = new Circle() { y = Y + 100, x = (maX + mid) / 2, r = 30 };
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

            if (node == null) return ans;

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

        private Line getLine(Graph a, int ParentCode, int ChildCode)
        {
            Circle parent = new Circle();
            Circle child = new Circle();

            foreach (var item in a.listCircle)
            {
                if (item.Code == ParentCode) parent = item;
                if (item.Code == ChildCode) child = item;
            }

            Line ans = Helper.Connect(parent, child);

            foreach (var item in a.listLine)
                if (item.x1 == ans.x1 && item.x2 == ans.x2 && item.y1 == ans.y1 && item.y2 == ans.y2)
                    return item;

            return new Line();
        }

        private Node FindMax(Node root)
        {
            if (root == null) return new Node();
            if (root.RightChild != null) return FindMax(root.RightChild);

            return root;
        }

        private Node FindMin(Node root)
        {
            if (root == null) return new Node();
            if (root.LeftChild != null) return FindMin(root.LeftChild);

            return root;
        }

        private Node MinInRightChild(Node a)
        {
            if (a == null) return new Pointer.Node();
            return FindMin(a.RightChild);
        }

        private Node MaxInLeftChild(Node a)
        {
            if (a == null) return new Pointer.Node();

            return FindMax(a.LeftChild);
        }
        #endregion

    }
}
