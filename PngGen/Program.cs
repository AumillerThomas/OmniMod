using System;
using System.Drawing;

public class ImageProcessor
{
    public static void ReplaceColor(string inputPath, string outputPath, Color targetColor, Color replacementColor)
    {
        using (Bitmap image = new Bitmap(inputPath))
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    if (pixelColor == targetColor)
                    {
                        image.SetPixel(x, y, replacementColor);
                    }
                }
            }

            image.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);
        }
    }

    public static void Main(string[] args)
    {
        string inputPath = @"C:\Users\Aumil\Documents\My Games\Terraria\tModLoader\ModSources\OmniMod\Tiles\OmniOre.png" ;
        string outputFileName = "neu_ore_Green.png"; // Hier den Namen der Ausgabedatei angeben
        string outputPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(inputPath), outputFileName);
        
        Color target = Color.FromArgb(0, 255, 0); // Rot 89, 106, 114
        Color replacement = Color.FromArgb(89, 106, 114); // Grün 0, 255, 0

        ReplaceColor(inputPath, outputPath, target, replacement);
    }
}