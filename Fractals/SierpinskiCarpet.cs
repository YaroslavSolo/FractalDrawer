using System.Drawing;

namespace Fractals
{
    public class SierpinskiCarpet : Fractal
    {
        public SierpinskiCarpet(Color startcolor, Color endColor, int maxDepth)
            : base(startcolor, endColor, maxDepth) { }

        /// <summary>
        /// Fits the size of the screen
        /// </summary>
        const int sideLength = 400;

        public override Image Draw(int scale)
        {
            _length = scale * sideLength;

            fractalImage = new Bitmap(_length, _length);
            g = Graphics.FromImage(fractalImage);

            // Creating largest square
            RectangleF rectangle = new RectangleF(0, 0, _length, _length);

            // Filling largest square
            g.FillRectangle(new SolidBrush(Gradient(_maxDepth)), rectangle);

            // Starting recursion
            DrawCarpet(rectangle, _maxDepth);

            return fractalImage;
        }

        private void DrawCarpet(RectangleF rectangle, int depth)
        {
            if (depth != 0)
            {
                float length = rectangle.Width / 3f;

                // Filling central square
                g.FillRectangle(new SolidBrush(Gradient(_maxDepth - depth)),
                    new RectangleF(rectangle.Left + length, rectangle.Top + length, length, length));

                // All possible x coordinates of smaller squares
                float x1 = rectangle.Left;
                float x2 = x1 + length;
                float x3 = x1 + length * 2;

                // All possible y coordinates of smaller squares
                float y1 = rectangle.Top;
                float y2 = y1 + length;
                float y3 = y1 + length * 2;

                // Calling for 8 smaller squares
                DrawCarpet(new RectangleF(x1, y1, length, length), depth - 1);
                DrawCarpet(new RectangleF(x2, y1, length, length), depth - 1);
                DrawCarpet(new RectangleF(x3, y1, length, length), depth - 1);
                DrawCarpet(new RectangleF(x1, y2, length, length), depth - 1);
                DrawCarpet(new RectangleF(x3, y2, length, length), depth - 1);
                DrawCarpet(new RectangleF(x1, y3, length, length), depth - 1);
                DrawCarpet(new RectangleF(x2, y3, length, length), depth - 1);
                DrawCarpet(new RectangleF(x3, y3, length, length), depth - 1);
            }
        }
    }
}
