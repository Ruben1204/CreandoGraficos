using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Graphics;

namespace TutorialGraficos.Graficos
{
    public class DibRellenoYTrazos : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            PathF path = new PathF();
            path.MoveTo(40, 10);
            path.LineTo(70, 80);
            path.LineTo(10, 50);
            Superficie.FillColor = Colors.SlateBlue;
            Superficie.FillPath(path);
            Superficie.DrawPath(path);
        }
    }
}
