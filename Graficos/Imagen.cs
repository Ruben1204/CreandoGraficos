using IImage = Microsoft.Maui.Graphics.IImage;
using System.IO;
using System.Reflection;
#if IOS || ANDROID || MACCATALYST
using Microsoft.Maui.Graphics.Platform;
#elif WINDOWS
using Microsoft.Maui.Graphics.Win2D;
#endif

namespace TutorialGraficos.Graficos
{

    public class Imagen : IDrawable
    {

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            IImage image;
            Assembly assembly = this.GetType().GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("TutorialGraficos.Resources.Images.dotnet_bot.png");
            {
#if IOS || ANDROID || MACCATALYST
                // PlatformImage isn't currently supported on Windows.
                image = PlatformImage.FromStream(stream);
#elif WINDOWS
                image = new W2DImageLoadingService().FromStream(stream);
#endif
            }

            if (image != null)
            {
                canvas.DrawImage(image, 10, 10, 50, 50);
            }
        }
    }
}