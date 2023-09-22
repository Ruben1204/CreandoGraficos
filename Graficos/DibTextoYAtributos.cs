
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class DibTextoYAtributos : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            Superficie.FontColor = Colors.Blue;
            Superficie.FontSize = 18;

            Superficie.Font = Microsoft.Maui.Graphics.Font.Default;
            Superficie.DrawString("Text is left aligned.", 20, 20, 380, 100, HorizontalAlignment.Left, VerticalAlignment.Top);
            Superficie.DrawString("Text is centered.", 20, 60, 380, 100, HorizontalAlignment.Center, VerticalAlignment.Top);
            Superficie.DrawString("Text is right aligned.", 20, 100, 380, 100, HorizontalAlignment.Right, VerticalAlignment.Top);

            Superficie.Font = Microsoft.Maui.Graphics.Font.DefaultBold;
            Superficie.DrawString("This text is displayed using the bold system font.", 20, 140, 350, 100, HorizontalAlignment.Left, VerticalAlignment.Top);

            Superficie.Font = new Microsoft.Maui.Graphics.Font("Arial");
            Superficie.FontColor = Colors.Black;
            Superficie.SetShadow(new SizeF(6, 6), 4, Colors.Gray);
            Superficie.DrawString("This text has a shadow.", 20, 200, 300, 100, HorizontalAlignment.Left, VerticalAlignment.Top);
        }
    }
}
