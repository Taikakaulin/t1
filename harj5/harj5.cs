using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj5
{
    class harj5
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[5];
            for(int l = 0; l < student.Length; l++)
            {
                student[l] = new Student();
            }
            student[0].Name = "Mikko Mallikas";
            student[0].Age = 19;
            student[1].Name = "Pena Penanen";
            student[1].Age = 30;
            student[2].Name = "Harri Hirmuinen";
            student[2].Age = 24;

            for(int l = 0; l < student.Length; l++)
            {
                student[l].PrintData();
            }
            Console.Read();
        }
    }
}
