using LAB6.Factory;
using LAB6.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6.Storage
{
    internal class MyCShapeList : MyList<CShape>
    {
        public void loadShapes(string filename, CMyShapeFactory factory)
        {
            StreamReader SR = new StreamReader(filename);
            int count = int.Parse(SR.ReadLine());
            for (int i = 0; i < count; i++)
            {
                CShape cShape = factory.createShape(SR.ReadLine());
                if (cShape != null)
                {
                    cShape.load(SR, factory);
                    push_back(cShape);
                }
            }
            SR.Close();
        }

    }
}
