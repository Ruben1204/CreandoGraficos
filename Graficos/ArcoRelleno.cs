using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class ArcoRelleno : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            //Superficie.StrokeColor = Colors.Teal;
            //Superficie.StrokeSize = 4;
            Superficie.FillColor = Colors.Teal;
            Superficie.FillArc(10, 10, 100, 100, 0, 180, true);
        }
    }
}
