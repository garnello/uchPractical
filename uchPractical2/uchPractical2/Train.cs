using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uPrac2
{
    public class Train
    {
        public string destination { get; set; }
        public int trainNumber { get; set; }
        public string timeStart { get; set; }

        public Train(int trainNumber, string destination, string timeStart)
        {
            this.trainNumber = trainNumber;
            this.destination = destination;
            this.timeStart = timeStart;
        }

        public void TrianInfo()
        {
            Console.Write($"Пункт отправления: {destination}\n"
                + $"Номер поезда: {trainNumber}\n"
                + $"Время отправления: {timeStart}");
        }
    }
}
