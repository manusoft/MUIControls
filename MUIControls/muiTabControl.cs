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
    [ToolboxBitmap(typeof(System.Windows.Forms.TabControl))]
    [Description("Manages and displays to the user a related collection of tabs that can contain controls and components.")]
    public class muiTabControl : TabControl
    {
        public enum TabStyle
        {
            Flat,
            Line
        }

        // Fields        
        private Color backgroundColor = SystemColors.Control;
        private Color buttonBackColor = Color.WhiteSmoke;
        private Color buttonForeColor = Color.Black;
        private Color buttonSelectedForeColor = Color.CornflowerBlue;
        private Color lineBackColor = Color.Gainsboro;
        private Color lineForeColor = Color.LightSeaGreen;
        private bool hideButton = false;
        private TabStyle style;

        public muiTabControl()
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);

            base.SizeMode= TabSizeMode.Fixed;
            base.ItemSize = new System.Drawing.Size(130, 30);
            Style = TabStyle.Line;
        }

        public Color BackgroundColor { get => backgroundColor; set { backgroundColor=value; base.Invalidate(); } }
        public Color ButtonBackColor { get => buttonBackColor; set { buttonBackColor=value; base.Invalidate(); } }
        public Color ButtonForeColor { get => buttonForeColor; set { buttonForeColor=value; base.Invalidate(); } }
        public Color ButtonSelectedForeColor { get => buttonSelectedForeColor; set { buttonSelectedForeColor=value; base.Invalidate(); } }
        public Color LineBackColor { get => lineBackColor; set { lineBackColor=value; base.Invalidate(); } }
        public Color LineForeColor { get => lineForeColor; set => lineForeColor=value; }
        public bool HideButton
        {
            get => hideButton;
            set
            {
                if (value)
                {
                    base.ItemSize= new Size(0, 1);
                }
                else
                {
                    base.ItemSize= new Size(130, 30);
                }

                hideButton=value;
                base.Invalidate();
            }
        }
        public TabStyle Style { get => style; set { style=value; this.Invalidate(); } }

        protected override void CreateHandle()
        {
            base.CreateHandle();
            //if (Alignment==System.Windows.Forms.TabAlignment.Left || Alignment==System.Windows.Forms.TabAlignment.Right)
            //{
            //    Alignment=System.Windows.Forms.TabAlignment.Top;
            //}

            if (base.Appearance!= TabAppearance.Normal)
            {
                base.Appearance = TabAppearance.Normal;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (HideButton)
            {
                e.Graphics.Clear(BackgroundColor);
                return;
            }

            using (Bitmap bmp = new Bitmap(Width, Height))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(BackgroundColor);
                g.SmoothingMode=SmoothingMode.AntiAlias;

                for (int i = 0; i < TabCount-1; i++)
                {
                    Rectangle tabRect = GetTabRect(i);

                    if (i==SelectedIndex)
                    {
                        switch (Style)
                        {
                            case TabStyle.Flat:
                                g.FillRectangle(new SolidBrush(buttonBackColor), tabRect); // Header button back color
                                break;
                            case TabStyle.Line:
                                g.DrawLine(new Pen(LineBackColor, 3), 0, tabRect.Bottom, this.Width, tabRect.Bottom);
                                g.FillRectangle(new SolidBrush(LineForeColor), new Rectangle(tabRect.Left, tabRect.Bottom-1, ItemSize.Width, 3));
                                break;
                            default:
                                break;
                        }

                        if (ImageList!=null)
                        {
                            try
                            {
                                if (ImageList.Images[TabPages[i].ImageIndex]!=null)
                                {
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(tabRect.Location.X+8, tabRect.Location.Y+6));
                                    g.DrawString("     " + TabPages[i].Text, Font, new SolidBrush(ButtonSelectedForeColor), tabRect,
                                            new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                                }
                                else
                                {
                                    g.DrawString(TabPages[i].Text, Font, new SolidBrush(ButtonSelectedForeColor), tabRect,
                                            new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                                }
                            }
                            catch (Exception)
                            {
                                g.DrawString(TabPages[i].Text, Font, new SolidBrush(ButtonSelectedForeColor), tabRect,
                                        new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                            }
                        }
                        else
                        {
                            g.DrawString(TabPages[i].Text, Font, new SolidBrush(ButtonSelectedForeColor), tabRect,
                                        new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                        }
                    }
                    else
                    {
                        if (ImageList!=null)
                        {
                            try
                            {
                                if (ImageList.Images[TabPages[i].ImageIndex]!=null)
                                {
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(tabRect.Location.X+8, tabRect.Location.Y+6));
                                    g.DrawString("     " + TabPages[i].Text, Font, new SolidBrush(ButtonForeColor), tabRect,
                                            new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                                }
                                else
                                {
                                    g.DrawString(TabPages[i].Text, Font, new SolidBrush(ButtonForeColor), tabRect,
                                            new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                                }
                            }
                            catch (Exception)
                            {
                                g.DrawString(TabPages[i].Text, Font, new SolidBrush(ButtonForeColor), tabRect,
                                        new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                            }
                        }
                        else
                        {
                            g.DrawString(TabPages[i].Text, Font, new SolidBrush(ButtonForeColor), tabRect,
                                        new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                        }
                    }
                }

                base.OnPaint(e);
                e.Graphics.DrawImage((Bitmap)bmp.Clone(), 0, 0);
                g.Dispose();
            }
        }
    }
}
