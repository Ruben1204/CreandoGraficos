using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class Elipse : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            Superficie.StrokeColor = Colors.Orange;
            Superficie.StrokeSize = 4;
            Superficie.StrokeDashPattern = new float[] { 2, 2 };
            Superficie.DrawEllipse(10, 10, 100, 50);

        }
    }
}
