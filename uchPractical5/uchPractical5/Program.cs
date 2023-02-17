using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;

namespace uchPractical5
{
    public class Program
    {
        public static void Method()
        {
            Del del = new Del();
        }
        static void Main()
        {
            Method();
            
            GC.Collect();
            Console.ReadLine();


        }
    }
}
