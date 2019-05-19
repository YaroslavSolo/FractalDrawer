namespace FractalApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PickStartColor = new System.Windows.Forms.Button();
            this.PickEndColor = new System.Windows.Forms.Button();
            this.PickFractal = new System.Windows.Forms.ComboBox();
            this.EnterDepth = new System.Windows.Forms.NumericUpDown();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SavePic = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.DisplayStartColor = new System.Windows.Forms.PictureBox();
            this.DisplayEndColor = new System.Windows.Forms.PictureBox();
            this.ScaleChange = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.EnterDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayStartColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayEndColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleChange)).BeginInit();
            this.SuspendLayout();
            // 
            // PickStartColor
            // 
            this.PickStartColor.Location = new System.Drawing.Point(27, 68);
            this.PickStartColor.Name = "PickStartColor";
            this.PickStartColor.Size = new System.Drawing.Size(92, 34);
            this.PickStartColor.TabIndex = 0;
            this.PickStartColor.Text = "Start color";
            this.PickStartColor.UseVisualStyleBackColor = true;
            this.PickStartColor.Click += new System.EventHandler(this.PickStartColor_Click);
            // 
            // PickEndColor
            // 
            this.PickEndColor.Location = new System.Drawing.Point(27, 108);
            this.PickEndColor.Name = "PickEndColor";
            this.PickEndColor.Size = new System.Drawing.Size(92, 34);
            this.PickEndColor.TabIndex = 1;
            this.PickEndColor.Text = "End color";
            this.PickEndColor.UseVisualStyleBackColor = true;
            this.PickEndColor.Click += new System.EventHandler(this.PickEndColor_Click);
            // 
            // PickFractal
            // 
            this.PickFractal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PickFractal.FormattingEnabled = true;
            this.PickFractal.Location = new System.Drawing.Point(27, 168);
            this.PickFractal.Name = "PickFractal";
            this.PickFractal.Size = new System.Drawing.Size(134, 24);
            this.PickFractal.TabIndex = 2;
            this.PickFractal.SelectedIndexChanged += new System.EventHandler(this.EnterDepth_ValueChanged);
            // 
            // EnterDepth
            // 
            this.EnterDepth.Location = new System.Drawing.Point(27, 219);
            this.EnterDepth.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.EnterDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EnterDepth.Name = "EnterDepth";
            this.EnterDepth.Size = new System.Drawing.Size(134, 22);
            this.EnterDepth.TabIndex = 3;
            this.EnterDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EnterDepth.ValueChanged += new System.EventHandler(this.EnterDepth_ValueChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Silver;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Location = new System.Drawing.Point(179, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(753, 483);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // SavePic
            // 
            this.SavePic.Location = new System.Drawing.Point(47, 269);
            this.SavePic.Name = "SavePic";
            this.SavePic.Size = new System.Drawing.Size(92, 34);
            this.SavePic.TabIndex = 5;
            this.SavePic.Text = "Save image";
            this.SavePic.UseVisualStyleBackColor = true;
            this.SavePic.Click += new System.EventHandler(this.SavePic_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "png Image|*.png";
            // 
            // DisplayStartColor
            // 
            this.DisplayStartColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayStartColor.Location = new System.Drawing.Point(127, 68);
            this.DisplayStartColor.Name = "DisplayStartColor";
            this.DisplayStartColor.Size = new System.Drawing.Size(34, 34);
            this.DisplayStartColor.TabIndex = 6;
            this.DisplayStartColor.TabStop = false;
            // 
            // DisplayEndColor
            // 
            this.DisplayEndColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayEndColor.Location = new System.Drawing.Point(127, 108);
            this.DisplayEndColor.Name = "DisplayEndColor";
            this.DisplayEndColor.Size = new System.Drawing.Size(34, 34);
            this.DisplayEndColor.TabIndex = 7;
            this.DisplayEndColor.TabStop = false;
            // 
            // ScaleChange
            // 
            this.ScaleChange.LargeChange = 2;
            this.ScaleChange.Location = new System.Drawing.Point(27, 328);
            this.ScaleChange.Maximum = 7;
            this.ScaleChange.Minimum = 1;
            this.ScaleChange.Name = "ScaleChange";
            this.ScaleChange.Size = new System.Drawing.Size(134, 56);
            this.ScaleChange.TabIndex = 8;
            this.ScaleChange.Value = 1;
            this.ScaleChange.ValueChanged += new System.EventHandler(this.EnterDepth_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 483);
            this.Controls.Add(this.ScaleChange);
            this.Controls.Add(this.DisplayEndColor);
            this.Controls.Add(this.DisplayStartColor);
            this.Controls.Add(this.SavePic);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.EnterDepth);
            this.Controls.Add(this.PickFractal);
            this.Controls.Add(this.PickEndColor);
            this.Controls.Add(this.PickStartColor);
            this.MinimumSize = new System.Drawing.Size(950, 530);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractal Drawer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.EnterDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayStartColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayEndColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PickStartColor;
        private System.Windows.Forms.Button PickEndColor;
        private System.Windows.Forms.ComboBox PickFractal;
        private System.Windows.Forms.NumericUpDown EnterDepth;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button SavePic;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox DisplayStartColor;
        private System.Windows.Forms.PictureBox DisplayEndColor;
        private System.Windows.Forms.TrackBar ScaleChange;
    }
}

