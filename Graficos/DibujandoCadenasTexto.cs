using Microsoft.Maui.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGraficos.Graficos
{
    public class DibujandoCadenasTexto : IDrawable
    {
        public void Draw(ICanvas Superficie, RectF dirtyRect)
        {
            //no funciona por el momento
            //Superficie.Font = new Microsoft.Maui.Graphics.Font("Arial");
            //Superficie.FontSize = 18;
            //Superficie.FontColor = Colors.Blue;

            //string markdownText = @"This is *italic text*, **bold text**, __underline text__, and ***bold italic text***.";
            //IAttributedText attributedText = MarkdownAttributedTextReader.Read(markdownText); // Requires the Microsoft.Maui.Graphics.Text.Markdig package
            //Superficie.DrawText(attributedText, 10, 10, 100, 100);
        }

        
    }
}
