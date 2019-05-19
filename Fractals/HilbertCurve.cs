using System;
using System.Drawing;

namespace Fractals
{
    public class HilbertCurve : Fractal
    {
        public HilbertCurve(Color startcolor, Color endColor, int maxDepth)
            : base(startcolor, endColor, maxDepth) { }      

        /// <summary>
        /// Fits the size of the screen
        /// </summary>
        const int lineLength = 200;

        /// <summary>
        /// Starting point
        /// </summary>
        PointF currentPos;

        /// <summary>
        /// Draws a line from current point to a new offset point
        /// Updates current point coordinates
        /// </summary>
        /// <param name="xOffset">x coordinate offset</param>
        /// <param name="yOffset">y coordinate offset</param>
        /// <param name="cl">color of the line</param>
        private void DrawLine(int xOffset, int yOffset, Color cl)
        {
            g.DrawLine(new Pen(cl, 2), currentPos.X, currentPos.Y, currentPos.X += xOffset, currentPos.Y += yOffset);
        }

        public override Image Draw(int scale)
        {
            _length = scale * lineLength;

            fractalImage = new Bitmap(_length * 2 + lineLength / 5, _length * 2 + lineLength / 5);
            g = Graphics.FromImage(fractalImage);
            g.Clear(Color.Silver);

            // Resizing line
            _length = _length / (int)Math.Pow(2, _maxDepth - 1) + 1;
            currentPos = new PointF(_length / (_maxDepth * 2), _length / (_maxDepth * 2));

            // Starting recursion
            RightCurve(_maxDepth);

            return fractalImage;
        }

        private void RightCurve(int depth)
        {
            if (depth != 0)
            {
                DownCurve(depth - 1);
                // Going right
                DrawLine(_length, 0, Gradient(depth));
                RightCurve(depth - 1);
                // Going down
                DrawLine(0, _length, Gradient(depth));
                RightCurve(depth - 1);
                // Going left
                DrawLine(-_length, 0, Gradient(depth));
                UpCurve(depth - 1);
            }
        }

        private void LeftCurve(int depth)
        {
            if (depth != 0)
            {
                UpCurve(depth - 1);
                // Going left
                DrawLine(-_length, 0, Gradient(depth));
                LeftCurve(depth - 1);
                // Going up
                DrawLine(0, -_length, Gradient(depth));
                LeftCurve(depth - 1);
                // Going right  
                DrawLine(_length, 0, Gradient(depth));
                DownCurve(depth - 1);
            }
        }

        private void UpCurve(int depth)
        {
            if (depth != 0)
            {
                LeftCurve(depth - 1);
                // Going up 
                DrawLine(0, -_length, Gradient(depth));
                UpCurve(depth - 1);
                // Going left 
                DrawLine(-_length, 0, Gradient(depth));
                UpCurve(depth - 1);
                // Going down 
                DrawLine(0, _length, Gradient(depth));
                RightCurve(depth - 1);
            }
        }

        private void DownCurve(int depth)
        {
            if (depth != 0)
            {
                RightCurve(depth - 1);
                // Going down  
                DrawLine(0, _length, Gradient(depth));
                DownCurve(depth - 1);
                // Going right  
                DrawLine(_length, 0, Gradient(depth));
                DownCurve(depth - 1);
                // Going up 
                DrawLine(0, -_length, Gradient(depth));
                LeftCurve(depth - 1);
            }
        }
    } 
}
