using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConcreteAggregate a= new ConcreteAggregate();
            //a[0] = "a";
            //a[1] = "b";
            //a[2] = "c";
            //a[3] = "d";
            //a[4] = "e";
            //a[5] = "f";

            IList<string> a = new List<string>();
            a.Add("a");
            a.Add("b");
            a.Add("c");
            
            IEnumerator<string> e = a.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine($"{e.Current}请买车票！");
                Console.WriteLine($"{e.Current}请买车票！");
            }
            //foreach (var item in a)
            //{
            //    Console.WriteLine("{0}请买车票！", item);
            //}
            ////Itertor i = new ConcreteIterator(a);
            //Itertor i = new ConcreIteratorDesc(a);
            //object item = i.First();
            //while (!i.IsDone())
            //{
            //    Console.WriteLine("{0}请买车票！",i.CurrentItem());
            //    i.Next();
            //}
            Console.Read();
        }
    }
}
