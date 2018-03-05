using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoPhongAVL_BST.Model
{
    public class Student
    {
        public int StudentCode { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        // Diem TBC
        public double Score { get; set; }
        // So tin chi tich Luy
        public int Count { get; set; }


        public bool Compare(Student b, int type)
        {
            /// 1 - Tìm kiếm dựa và student Code
            if (type == 1)
            {
                if (b.StudentCode > this.StudentCode) return false;
                return true;
            }

            // 2 - Tìm kiếm dựa vào họ tên
            if (type == 2)
            {
                if (b.FullName.CompareTo(this.FullName) == 1) return false;
                return true;
            }

            // 3 - Tìm kiếm dựa vào ngày sinh
            if (type == 3)
            {
                if (b.DateOfBirth.CompareTo(this.DateOfBirth) == 1) return false;
                return true;
            }

            // 4 - Tìm kiếm dựa vào điểm tích lũy 
            if (type == 4)
            {
                if (b.Score > Score) return false;
                return true;
            }

            // 5 - Tìm kiếm dựa vào số tín chỉ tích lũy
            if (type == 5)
            {
                if (b.Count > Count) return false;
                return true;
            }

            return false;
        }
    }
}
