using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class DibujandoTrazado :IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            float radius = Math.Min(dirtyRect.Width, dirtyRect.Height) / 4;

        PathF path = new PathF();
        path.AppendCircle(dirtyRect.Center.X, dirtyRect.Center.Y, radius);

            Superficie.StrokeColor = Colors.Blue;
            Superficie.StrokeSize = 10;
            Superficie.FillColor = Colors.Red;

            Superficie.FillPath(path);
            Superficie.DrawPath(path);
        }
    }
}
