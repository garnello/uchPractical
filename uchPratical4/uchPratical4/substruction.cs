using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchPratical4
{
    public class substruction
    {
        public int counter { get; set; }

        public substruction()
        {
            counter = 5;
        }
        
        public void CounterInfo()
        {
            Console.WriteLine("Значение счетчика: " + counter + "\n");
        }
    }
}
