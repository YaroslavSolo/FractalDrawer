using System.Drawing;

namespace Fractals
{
    public abstract class Fractal
    {
        /// <summary>
        /// Start and end colors of fractal
        /// </summary>
        protected Color _startColor, _endColor;

        protected int _maxDepth, _depth, _length;

        /// <summary>
        /// Image of fractal
        /// </summary>
        protected Image fractalImage;

        /// <summary>
        /// Graphics for drawing
        /// </summary>
        protected Graphics g;

        /// <summary>
        /// Draws fractal on bitmap
        /// </summary>
        /// <param name="scale"></param>
        /// <returns>fractal image</returns>
        public abstract Image Draw(int scale);

        public Fractal(Color startcolor, Color endColor, int maxDepth)
        {
            _startColor = startcolor;
            _endColor = endColor;
            _maxDepth = maxDepth;
        }
        
        /// <summary>
        /// Linear gradient between startColor and endColor
        /// </summary>
        /// <param name="num">number of current color</param>
        /// <returns>linear gradient color of current color</returns>
        public Color Gradient(int num)
        {
            // Color gradient step
            int stepR = (_endColor.R - _startColor.R) / _maxDepth;
            int stepG = (_endColor.G - _startColor.G) / _maxDepth;
            int stepB = (_endColor.B - _startColor.B) / _maxDepth;

            return Color.FromArgb(255, _startColor.R + stepR * num,
                                       _startColor.G + stepG * num,
                                       _startColor.B + stepB * num);
        }
    }
}
