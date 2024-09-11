using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Square : Rectangle
    {
        private double length {  get; set; }

        public double getArea()
        {
            return length * length;
        }

        public double getPerimeter()
        {
            return 4 * length;
        }
    }
}
