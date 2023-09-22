using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class LineasCombinadas :IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            PathF path = new PathF();
            path.MoveTo(10, 10);
            path.LineTo(110, 50);
            path.LineTo(10, 110);

            Superficie.StrokeSize = 20;
            Superficie.StrokeColor = Colors.Blue;
            Superficie.StrokeLineJoin = LineJoin.Round;
            Superficie.DrawPath(path);
        }
    }
}
