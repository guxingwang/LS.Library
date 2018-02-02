using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using LS.Library.Extensions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = "床前明月光";
            List<long> list = new List<long>();
            Stopwatch sw = new Stopwatch();

            for (int j = 0; j < 10; j++)
            {
                //运行的次数
                sw.Restart();
                for (int i = 0; i < 10000; i++)
                {
                    //每次时间间隔的运行次数
                    ss.GetChineseCode();
                }
                list.Add(sw.ElapsedMilliseconds);
            }

            sw.Stop();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"第{i}次运行时间{list[i]}");
            }
            
            Console.WriteLine("平均时间"+list.Average().ToString());
        }
    }
}
