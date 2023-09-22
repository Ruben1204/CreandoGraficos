
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class CuadradoDiscontinuo : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            Superficie.StrokeColor = Colors.Salmon;
            Superficie.StrokeSize = 4;
            Superficie.StrokeDashPattern = new float[] { 4, 4, 1, 4 };
            Superficie.DrawRectangle(10, 10, 90, 100);
        }
    }
}
