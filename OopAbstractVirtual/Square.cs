using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAbstractVirtual
{
    internal class Square : Shape
    {
        public Square(int width) 
        {
            Width = width;
        }
        public int Width { get; }
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
