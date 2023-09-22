using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class DibSombras : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            Superficie.FillColor = Colors.DarkSalmon;
            Superficie.SetShadow(new SizeF(-10, 10), 4, Colors.LightPink);
            Superficie.FillRoundedRectangle(210, 10, 90, 100, 25);
        }
    }
}
