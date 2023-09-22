using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class ExtremosDeLinea : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            Superficie.StrokeSize = 10;
            Superficie.StrokeColor = Colors.Red;
            Superficie.StrokeLineCap = LineCap.Round;
            Superficie.DrawLine(10, 10, 110, 110);
        }
    }
}
