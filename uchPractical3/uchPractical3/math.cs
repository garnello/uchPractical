using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPrac3
{
    public class Math
    {
        public int x { get; set; }
        public int y { get; set; }

        public Math()
        {
            x = 5;
            y = -2;
        }

        public void Print()
        {
            Console.WriteLine($"Первое число: {x}\n"
                            + $"Второе число: {y}\n");
        }
    }
}
