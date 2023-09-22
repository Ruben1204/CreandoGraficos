using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class LineaDiscontinua : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            Superficie.StrokeColor = Colors.Blue;
            Superficie.StrokeSize = 4;
            Superficie.StrokeDashPattern = new float[] { 2, 2 };
            Superficie.DrawLine(10, 10, 90, 100);
            
        }
    }
}
