using System;
using System.Drawing;

namespace FlaUI.Bridge
{
    public class ImageUtils
    {
        private ImageConverter converter = new ImageConverter();

        public ImageUtils() { }

        public byte[] convert(Image image)
        {
            try {
                return (byte[])converter.ConvertTo(image, typeof(byte[]));

            } catch(Exception e) {
                return null;
            }
        }
    }
}
