using MoPhongAVL_BST.Pointer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoPhongAVL_BST.Model
{
    public static class Data
    {
        public static BST_Tree BST = new BST_Tree() { MaxWidth = 1000, Type = 2 };
        public static AVL_Tree AVL = new AVL_Tree() { MaxWidth = 1000, Type = 2 };
        public static bool isBST = true;
        
        public static bool CodeIsOk(Student z)
        {
            if (isBST)
            {
                List<Student> zz = BST.getListStudent();
                foreach (var item in zz) if (item.StudentCode == z.StudentCode) return false;
            }
            else
            {
                List<Student> zz = AVL.getListStudent();
                foreach (var item in zz) if (item.StudentCode == z.StudentCode) return false;
            }

            return true;
        }

        public static bool CodeIsOk(int z)
        {
            if (isBST)
            {
                List<Student> zz = BST.getListStudent();
                foreach (var item in zz) if (item.StudentCode == z) return false;
            }
            else
            {
                List<Student> zz = AVL.getListStudent();
                foreach (var item in zz) if (item.StudentCode == z) return false;
            }

            return true;
        }
    }
}
