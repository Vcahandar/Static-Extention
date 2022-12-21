using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_Practice.Models
{
    public  class Car
    {
        public static int Speed { get; set; } = 500;

        static Car()
        {
            Console.WriteLine("Constoructor ");
        }

        public Car()
        {
            Console.WriteLine("Salam Baki");
        }
      
    }
}
