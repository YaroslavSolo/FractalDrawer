using System;
using System.Drawing;
using System.Windows.Forms;
using Fractals;

namespace FractalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       

            // Adding items to comboBox
            PickFractal.Items.AddRange(new string[] { "Sierpinski carpet", "Koch curve", "Hilbert curve" });

            // Selecting default fractal
            PickFractal.SelectedIndex = 0;

            // Default image
            fractalImage = Bitmap.FromFile("InitialImage.jpg");
            this.OnSizeChanged(EventArgs.Empty);

            // Displaying default colors
            DisplayStartColor.BackColor = startColor;
            DisplayEndColor.BackColor = endColor;

            // Tip for the control, changing depth
            ToolTip EnterDepthTip = new ToolTip();
            EnterDepthTip.SetToolTip(EnterDepth, "Recursion depth");

            // Tip for the control, changing scale
            ToolTip ScaleChangeTip = new ToolTip();
            ScaleChangeTip.SetToolTip(ScaleChange, "Zoom"); 
        }

        /// <summary>
        /// Bitmap image of fractal
        /// </summary>
        Image fractalImage;

        /// <summary>
        /// Fractal itself
        /// </summary>
        Fractal fractal;

        /// <summary>
        /// Start and end colors of fractal
        /// </summary>
        Color startColor = Color.Magenta, endColor = Color.Black;

        /// <summary>
        /// Mouse coordinates
        /// </summary>
        int mouseX = 0, mouseY = 0;

        /// <summary>
        /// Picture coordinates
        /// </summary>
        int pictureX = 0, pictureY = 0;

        private void PickStartColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Saving start color and displaying it
                startColor = colorDialog.Color;
                DisplayStartColor.BackColor = startColor;
            }
        }

        private void PickEndColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Saving end color and displaying it
                endColor = colorDialog.Color;
                DisplayEndColor.BackColor = endColor;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox.Capture)
            {
                // Calculating mouse offset after it was pressed
                int mouseOffsetX = mouseX - e.X;
                int mouseOffsetY = mouseY - e.Y;

                // New picture coordinates
                pictureX -= mouseOffsetX;
                pictureY -= mouseOffsetY;

                // Keeping image within pictureBox
                if (pictureX < -fractalImage.Width)
                    pictureX = -fractalImage.Width;

                if (pictureY < -fractalImage.Height)
                    pictureY = -fractalImage.Height;

                if (pictureX > fractalImage.Width + pictureBox.Width)
                    pictureX = fractalImage.Width + pictureBox.Width;

                if (pictureY > fractalImage.Height + pictureBox.Height)
                    pictureY = fractalImage.Height + pictureBox.Height;

                // Relocating image
                pictureBox.Invalidate();

                // Setting new mouse position
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void EnterDepth_ValueChanged(object sender, EventArgs e)
        {
            // Fractal selected in combobox
            int index = PickFractal.SelectedIndex;

            switch (index)
            {
                case 0:
                    fractal = new SierpinskiCarpet(startColor, endColor, (int)EnterDepth.Value);
                    break;
                case 1:
                    fractal = new KochCurve(startColor, endColor, (int)EnterDepth.Value);
                    break;
                case 2:
                    fractal = new HilbertCurve(startColor, endColor, (int)EnterDepth.Value);
                    break;
            }

            // Drawing selected fractal
            fractalImage = fractal.Draw(ScaleChange.Value);

            // Form center position
            pictureX = (pictureBox.Width - fractalImage.Width) / 2;
            pictureY = (pictureBox.Height - fractalImage.Height) / 2;
            pictureBox.Invalidate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                // Moving picture to form center
                pictureX = (pictureBox.Width - fractalImage.Width) / 2;
                pictureY = (pictureBox.Height - fractalImage.Height) / 2;
                pictureBox.Invalidate();
            }
            catch (NullReferenceException)
            {
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(fractalImage, pictureX, pictureY);
        }

        private void SavePic_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();

                // Saving as png image
                fractalImage.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                fs.Dispose();
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Initial mouse position
            mouseX = e.X;
            mouseY = e.Y;
        }
    }
}
