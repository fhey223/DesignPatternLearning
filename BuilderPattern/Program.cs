using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        private static object pictureBox1;

        static void Main(string[] args)
        {
            Pen p = new Pen(Color.Aqua);
            Graphics gThin = Graphics.FromImage(new Bitmap(50,50));
            PersonThinBuilder ptb = new PersonThinBuilder(gThin,p);
            PersonDirector xiaohei = new PersonDirector(ptb);
            xiaohei.CreatePerson();
            Console.WriteLine(xiaohei);
            Console.Read();
        }
    }
}
