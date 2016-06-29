using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDao studentDao = new StudentDaoImpl();

            //输出所有的学生
            foreach (var student1 in studentDao.getAllStudents())
            {
                Console.WriteLine($"Student: [RollNo :{student1.getRollNo()}, Name :{student1.getName()}]");
            }

            //更新学生
            Student student = studentDao.getAllStudents().ElementAt(0);
            student.setName("Michael");
            studentDao.updateStudent(student);

            //获取学生
            studentDao.getStudent(0);
            Console.WriteLine($"Student: [RollNo :{student.getRollNo()}, Name :{student.getName()}]");
            Console.ReadKey();
        }
    }
}
