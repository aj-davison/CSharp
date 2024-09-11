using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Rectangle : IShape
    {
        public double length {  get; set; }
        public double width { get; set; }

        public virtual double getArea()
        {
            return length * width;
        }

        public virtual double getPerimeter()
        {
            return (2 * width) + (2 * length);
        }
    }
}
