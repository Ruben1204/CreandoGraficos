using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class Circulo : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            Superficie.StrokeColor = Colors.Purple;
            Superficie.StrokeSize = 4;
            Superficie.DrawEllipse(10, 10, 100, 100);
        }
    }
}
