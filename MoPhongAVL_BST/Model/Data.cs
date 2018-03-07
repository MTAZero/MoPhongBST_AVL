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
        public static AVL_Tree BST = new AVL_Tree() { MaxWidth = 1000, Type = 2 };
        
        public static bool CodeIsOk(Student z)
        {
            List<Student> zz = BST.getListStudent();
            foreach (var item in zz) if (item.StudentCode == z.StudentCode) return false;

            return true;
        }

        public static bool CodeIsOk(int z)
        {
            List<Student> zz = BST.getListStudent();
            foreach (var item in zz) if (item.StudentCode == z) return false;

            return true;
        }
    }
}
