using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUIControls
{
    public class muiProgressBar: ProgressBar
    {
        // Others
        private bool paintedBack = false;
        private bool stopPainting = false;

        public muiProgressBar()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
            this.Size = new Size(100 , 25);
        }

        //-> Paint the background & channel
        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
        {
            if (stopPainting == false)
            {
                if (paintedBack == false)
                {
                    //Fields
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, this.Height);
                    using (var brushChannel = new SolidBrush(BackColor))
                    {
                        //Painting
                        graph.Clear(this.Parent.BackColor);//Surface
                        graph.FillRectangle(brushChannel, rectChannel);//Channel

                        //Stop painting the back & Channel
                        if (this.DesignMode == false)
                            paintedBack = true;
                    }
                }
                //Reset painting the back & channel
                if (this.Value == this.Maximum || this.Value == this.Minimum)
                    paintedBack = false;
            }
        }
        //-> Paint slider
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (stopPainting == false)
            {
                //Fields
                Graphics graph = e.Graphics;
                double scaleFactor = (((double)this.Value - this.Minimum) / ((double)this.Maximum - this.Minimum));
                int sliderWidth = (int)(this.Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, this.Height);
                using (var brushSlider = new SolidBrush(ForeColor))
                {
                    //Painting
                    if (sliderWidth > 1) //Slider
                        graph.FillRectangle(brushSlider, rectSlider);
                    //if (showValue != TextPosition.None) //Text
                    // graph.DrawString (Value.ToString(),Parent.Font,Brushes.Blue, new Point(base.Width/2,0)); 
                }
            }
            if (this.Value == this.Maximum) stopPainting = true;//Stop painting
            else stopPainting = false; //Keep painting
        }
    }
}
