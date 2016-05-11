using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{

    /// <summary>
    /// TODOResume
    /// by gouyf
    /// 2016/5/4 17:32:40
    /// 简历
    /// </summary>
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private  WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work=new WorkExperience();
        }
        public Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }
        //设置个人信息
        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }
        //设置工作经历
        public void SetWorkExperience(string workDate, string company)
        {
            work.workDate = workDate;
            work.company = company;
        }
        //显示
        public void Display()
        {
            Console.WriteLine("{0}{1}{2}",name,sex,age);
            Console.WriteLine("工作经历：{0}{1}", work.workDate, work.company);
        }
        public object Clone()
        {
            //Resume obj = new Resume(this.work);
            //obj.name = this.name;
            //obj.sex = this.sex;
            //obj.age = this.age;
            //return obj;
            return (Resume) (new Resume(this.work).MemberwiseClone());
        }
    }
}
