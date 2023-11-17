﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace PROG7312_Part1
{
    public class CustomButton : Button
    {

        //------------------------------------------------------------------------------------------//
        // Global Variables
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// Button border size properties
        /// </summary>
        [Category("Custom Button")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// Button border radius properties
        /// </summary>
        [Category("Custom Button")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// Button border color properties
        /// </summary>
        [Category("Custom Button")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// Button background color properties
        /// </summary>
        [Category("Custom Button")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// Button text color properties
        /// </summary>
        [Category("Custom Button")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //------------------------------------------------------------------------------------------//
        // Constructor
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// Alters the buttons visable properties.
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// An override method for the buttons paint.
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            // Rouded Button
            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Button Surface
                    this.Region = new Region(pathSurface);
                    // Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Button Border
                    if (borderSize >= 1)
                    {
                        // Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            // Normal Button
            else
            {
                // Button Surface
                this.Region = new Region(rectSurface);
                // Button Border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {

                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// An override method to handle the changed button color.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        //------------------------------------------------------------------------------------------//
        /// <summary>
        /// An override method to handle the changed button color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }

        //------------------------------------------------------------------------------------------//

    }
}
//------------------------------------------EndOfFile-----------------------------------------------//
#region /// REFERENCES - CODE ATTRIBUTION:
/* 
 * 
Aurthor:  RJ Code Advance EN
Webisite: StackOverFlow, 2021/05/08. Custom Button - Rounded, Pill or Square Shape - WinForm C#. [Online]
Accessed on: 2023/10/25
URL:https://www.youtube.com/watch?v=u8SL5g9QGcI

 */
#endregion