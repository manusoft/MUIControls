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
        // Fields
        // Appearance
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 10;
        private int sliderHeight = 10;

        // Others
        private bool paintedBack = false;
        private bool stopPainting = false;

        public Color ChannelColor { get => channelColor; set { channelColor=value; this.Invalidate(); } }
        public Color SliderColor { get => sliderColor; set { sliderColor=value; this.Invalidate(); } }
        public Color ForeBackColor { get => foreBackColor; set { foreBackColor=value; this.Invalidate(); } }
        public int ChannelHeight { get => channelHeight; set { channelHeight=value; this.Invalidate(); } }
        public int SliderHeight { get => sliderHeight; set { sliderHeight=value; this.Invalidate(); } }

        public muiProgressBar()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
            this.Size = new Size(this.Width , this.Width );
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
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, ChannelHeight);
                    using (var brushChannel = new SolidBrush(ChannelColor))
                    {
                        if (ChannelHeight >= SliderHeight)
                            rectChannel.Y = this.Height - ChannelHeight;
                        else rectChannel.Y = this.Height - ((ChannelHeight + SliderHeight) / 2);

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
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, SliderHeight);
                using (var brushSlider = new SolidBrush(SliderColor))
                {
                    if (SliderHeight >= ChannelHeight)
                        rectSlider.Y = this.Height - SliderHeight;
                    else rectSlider.Y = this.Height - ((SliderHeight + ChannelHeight) / 2);

                    //Painting
                    if (sliderWidth > 1) //Slider
                        graph.FillRectangle(brushSlider, rectSlider);
                    //if (showValue != TextPosition.None) //Text
                    //DrawValueText(graph, sliderWidth, rectSlider);
                }
            }
            if (this.Value == this.Maximum) stopPainting = true;//Stop painting
            else stopPainting = false; //Keep painting
        }
    }
}
