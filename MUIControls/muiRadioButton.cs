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
    [ToolboxBitmap(typeof(System.Windows.Forms.RadioButton))]
    [Description("Enables the user to select a single option from a group of choices when paired with other MRadioButtons.")]
    public class muiRadioButton : RadioButton
    {
        // Fields
        private Color checkedColor = Color.Teal;
        private Color unCheckedColor = Color.Gray;

        public muiRadioButton()
        {
            this.MinimumSize = new Size(0, 21);
            // Add a padding of 10 to the left to have a considerable distance between the text and the RadioButton.
            this.Padding = new Padding(10, 0, 0, 0);
        }

        public Color CheckedColor { get => checkedColor; set { checkedColor=value; this.Invalidate(); } }
        public Color UnCheckedColor { get => unCheckedColor; set { unCheckedColor=value; this.Invalidate();} }

        // Overridden methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Fields
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;

            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (this.Height - rbBorderSize) / 2, // Center
                Width = rbBorderSize,
                Height = rbBorderSize
            };

            RectangleF rectRbCheck = new RectangleF()
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), // Center
                Y = (this.Height - rbCheckSize) / 2, // Center
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            // Drawing
            using (Pen penBorder = new Pen(checkedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(checkedColor))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor))
            {
                // Draw surface
                graphics.Clear(this.BackColor);
                // Draw Radio Button
                if (this.Checked)
                {
                    graphics.DrawEllipse(penBorder, rectRbBorder); // Circle border
                    graphics.FillEllipse(brushRbCheck, rectRbCheck); // Circle Radio Check
                }
                else
                {
                    penBorder.Color = unCheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder); // Circle border
                }

                // Draw text
                graphics.DrawString(this.Text, this.Font, brushText, rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2); // Y=Center
            }
        }
    }
}
