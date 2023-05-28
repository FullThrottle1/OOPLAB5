using LAB6.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6.Factory
{
    internal class CMyShapeFactory : CShapeFactory
    {
        public override CShape createShape(string code, int _x = 0, int _y = 0, int _size = 150, Color _color = default(Color))
        {
            CShape shape = null;
            switch (code)
            {
                case "Circle":
                    shape = new CCircle(_x, _y, _size, _color);
                    break;
                case "Triangle":
                    shape = new CTriangle(_x, _y, _size, _color);
                    break;
                case "Square":
                    shape = new CSquare(_x, _y, _size, _color);
                    break;
                case "Group":
                    shape = new CGroup(_x, _y, _size, _color);
                    break;
                default:
                    break;
            }
            return shape;
        }
    }
}
