using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBO studentBusinessObject = new StudentBO();

            //输出所有的学生
            foreach (var student1 in studentBusinessObject.getAllStudents())
            {
                Console.WriteLine("Student: [RollNo : "
                + student1.getRollNo() + ", Name : " + student1.getName() + " ]");
            }

            //更新学生
            StudentVO student = studentBusinessObject.getAllStudents().ElementAt(0);
            student.setName("Michael");
            studentBusinessObject.updateStudent(student);

            //获取学生
            studentBusinessObject.getStudent(0);
            Console.WriteLine("Student: [RollNo : "
            + student.getRollNo() + ", Name : " + student.getName() + " ]");

            Console.ReadKey();
        }
    }
}
