using LAB6.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6.Factory
{
    internal abstract class CShapeFactory
    {
        public abstract CShape createShape(string code, int _x = 0, int _y = 0, int _size = 150, Color _color = default(Color));

    }
}
