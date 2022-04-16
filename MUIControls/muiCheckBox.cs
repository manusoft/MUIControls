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
    [ToolboxBitmap(typeof(System.Windows.Forms.CheckBox))]
    [Description("Enables the user to select or clear the associated option.")]
    public class muiCheckBox:CheckBox
    {
        // Fields
        private Color checkedColor = Color.Teal;
        private Color unCheckedColor = Color.Gray;

        public muiCheckBox()
        {
            this.MinimumSize = new Size(0, 21);
            // Add a padding of 10 to the left to have a considerable distance between the text and the RadioButton.
            this.Padding = new Padding(10, 0, 0, 0);
        }

        // Properties
        [Category("Laksya Framework")]
        public Color CheckedColor
        {
            get { return checkedColor; }
            set { checkedColor=value; base.Invalidate(); }
        }

        [Category("Laksya Framework")]
        public Color UnCheckedColor
        {
            get { return unCheckedColor; }
            set { unCheckedColor=value; base.Invalidate(); }
        }

        // Overridden methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Fields
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int rbBorderSize = 18;

            Rectangle rectBorder = new Rectangle()
            {
                X = 0,
                Y = (this.Height - rbBorderSize) / 2, // Center
                Width = rbBorderSize,
                Height = rbBorderSize
            };

            // Drawing
            using (Pen penBorder = new Pen(checkedColor, 1.6F))
            using (Pen penCheck = new Pen(checkedColor, 2))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor))
            {
                // Draw surface
                g.Clear(this.BackColor);
                // Draw Radio Button
                if (this.Checked)
                {
                    g.DrawRectangle(penBorder, rectBorder); // Box border

                    // Draw the tick
                    g.DrawLine(penCheck, 2, 10, 8, 16);
                    g.DrawLine(penCheck, 6, 16, 16, 5);

                }
                else
                {
                    penBorder.Color = unCheckedColor;
                    g.DrawRectangle(penBorder, rectBorder); // Box border
                }

                // Draw text
                g.DrawString(this.Text, this.Font, brushText, rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2); // Y=Center
            }

        }
    }
}
