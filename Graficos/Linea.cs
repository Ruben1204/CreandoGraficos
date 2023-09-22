using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class Linea : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            Superficie.StrokeColor = Colors.Red;
            Superficie.StrokeSize = 6;
            Superficie.DrawLine(10, 10, 90, 100);
        }
    }
}
