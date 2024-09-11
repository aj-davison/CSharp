using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Shapes
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle { length = 4.0, width = 5.0 };
            Console.WriteLine($"Area of the Rectangle: {rectangle.getArea()}");
        }
    }
}
