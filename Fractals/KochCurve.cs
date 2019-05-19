using System.Drawing;

namespace Fractals
{
   public class KochCurve : Fractal
    {
        public KochCurve(Color startcolor, Color endColor, int maxDepth)
            : base(startcolor, endColor, maxDepth) { }

        /// <summary>
        /// Fits the size of the screen
        /// </summary>
        const int lineLength = 150;

        public override Image Draw(int scale)
        {         
            _length = scale * lineLength;

            fractalImage = new Bitmap(_length * 3, _length * 3);
            g = Graphics.FromImage(fractalImage);
            g.Clear(Color.Silver);

            // Bottom line
            PointF startPoint = new PointF(0, _length * 2);
            PointF endPoint = new PointF(_length * 3, _length * 2);
            g.DrawLine(new Pen(Gradient(0), 2), startPoint, endPoint);

            // Starting recursion
            Curve(startPoint, endPoint, _maxDepth);

            return fractalImage;
        }

        private void Curve(PointF startPoint, PointF endPoint, int depth)
        {
            if (depth != 0)
            {             
                // Offset of the new 3 points
                PointF v1 = new PointF((endPoint.X - startPoint.X) / 3, (endPoint.Y - startPoint.Y) / 3);
                PointF v2 = new PointF((endPoint.X - startPoint.X) / 2, (endPoint.Y - startPoint.Y) / 2);
                PointF v3 = new PointF(v1.X * 2, v1.Y * 2);

                // New point coordinates
                PointF p1 = new PointF(startPoint.X + v1.X, startPoint.Y + v1.Y);
                PointF p2 = new PointF(startPoint.X + v2.X, startPoint.Y + v2.Y);
                PointF p3 = new PointF(startPoint.X + v3.X, startPoint.Y + v3.Y);

                // Height of the triangle
                PointF vecHeight = new PointF(v1.Y, -v1.X);             
                PointF pointHeight = new PointF(p2.X + vecHeight.X, p2.Y + vecHeight.Y);
                
                // Drawing triangle
                g.DrawLine(new Pen(Gradient(_maxDepth - depth), 2), p1, pointHeight);
                g.DrawLine(new Pen(Gradient(_maxDepth - depth), 2), p3, pointHeight);

                // Erasing bottom line
                g.DrawLine(new Pen(Color.Silver, 2), p1, p3);

                // Calling for 4 lines
                Curve(p1, pointHeight, depth - 1);
                Curve(pointHeight, p3, depth - 1);
                Curve(startPoint, p1, depth - 1);
                Curve(p3, endPoint, depth - 1);
            }
        }
    } 
}
