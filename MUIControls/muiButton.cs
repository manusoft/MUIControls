using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUIControls
{
    [ToolboxBitmap(typeof(System.Windows.Forms.Button))]
    [Description("Raises an event when user clicks it.")]
    public class muiButton : Button
    {
        // Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.Teal;

        public muiButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(100, 25);
            this.BackColor = Color.DeepSkyBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        // Properties
        [Category("MUI Controls")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize=value; this.Invalidate(); }
        }

        [Category("MUI Controls")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius=value; this.Invalidate(); }
        }

        [Category("MUI Controls")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor=value; this.Invalidate(); }
        }

        // Overridden properties
        public override Color BackColor { get => base.BackColor; set => base.BackColor=value; }
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor=value; }

        // Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Overridden methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;

            if (borderSize > 0) smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
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

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Parent_BackColorChanged);
        }

        private void Parent_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height) { borderRadius = this.Height; }
        }
    }
}
