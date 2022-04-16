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
    public class muiComboBox : ComboBox
    {
        private Color arrowColor;
        private Color borderColor = Color.Black;
        private Color selectionColor = Color.LightSeaGreen;
        private bool underlinedStyle = false;

        public muiComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            SetStyle(ControlStyles.UserPaint, true);
        }

        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle=value; this.Invalidate(); } }

        public Color BorderColor { get => borderColor; set { borderColor=value; this.Invalidate(); } }

        public Color SelectionColor { get => selectionColor; set => selectionColor=value; }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DrawMode== DrawMode.Normal)
            {
                this.DrawMode = DrawMode.OwnerDrawFixed;
            }
        }


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (e.Index >= 0)
            {
                e.DrawBackground();

                Graphics g = e.Graphics;
                Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ?
                              new SolidBrush(SelectionColor) : new SolidBrush(e.BackColor);

                g.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawString(base.Items[e.Index].ToString(), e.Font,
                         new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);

                //e.DrawFocusRectangle();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                g.Clear(BackColor);

                Rectangle clientArea = new Rectangle(0, 0, ClientRectangle.Width -1, ClientRectangle.Height-1 );
                Rectangle rectIcon = new Rectangle(this.Width - 16, (this.Height - 5) / 2, 10, 5);

                if (BackColor.GetBrightness() >= 0.6F)
                    arrowColor = Color.Black;
                else arrowColor = Color.White;

                // Draw Arrorw
                g.SmoothingMode = SmoothingMode.HighQuality ;
                GraphicsPath path = new GraphicsPath();
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (10.0F / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (10.0F / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                g.DrawPath(new Pen(arrowColor, 1.5F), path);

                if (UnderlinedStyle)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawLine(new Pen(BorderColor, 2), 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else
                {
                    g.SmoothingMode = SmoothingMode.None;
                    g.DrawRectangle(new Pen(BorderColor, 2), this.ClientRectangle);
                }

                //g.DrawString(base.Text, base.Font, new SolidBrush (ForeColor),base.ClientRectangle , format);
                TextRenderer.DrawText(g, this.Text, this.Font, new Point (2,3) , this.ForeColor, this.BackColor  );
                g.Dispose();
               
            }
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            pevent.Graphics.Clear(Color.Transparent);
        }
    }
}
