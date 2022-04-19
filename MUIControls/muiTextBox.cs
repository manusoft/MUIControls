using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUIControls
{
    [DefaultEvent("Text_Changed")]
    public partial class muiTextBox : UserControl
    {
        public enum Style
        {
            Normal,
            Round,
            Circle
        }

        //Fields
        private Style boxStyle = Style.Normal;
        private Color borderColor = Color.Black;
        private Color borderFocusColor = Color.CornflowerBlue;
        private string placeholderText = String.Empty;
        private int borderRadius = 0;
        private int borderSize = 1;
        private bool underlinedStyle = false;
        private bool isFocused = false;
        private bool numberMode = false;
        private char passwordChar = char.MinValue;
        private bool useSystemPasswordChar = false;
        private bool hideSelection = true;
        private int maxLegth = 32767;
        private bool readOnly = false;
        private CharacterCasing characterCasing = CharacterCasing.Normal;
        private ScrollBars scrollBars = ScrollBars.None;
        private HorizontalAlignment textAlign = HorizontalAlignment.Left;
        private bool wordWrap = true;

        //Event
        public event EventHandler Text_Changed;

        public muiTextBox()
        {
            InitializeComponent();
        }

        [RefreshProperties(RefreshProperties.Repaint)]
        public Color BorderColor { get => borderColor; set => borderColor = value; }
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }
        public string PlaceholderText { get => placeholderText; set => placeholderText = value; }

       // [RefreshProperties(RefreshProperties.Repaint)]
        //public int BorderRadius { get => borderRadius; set { borderRadius = value; } }

        [RefreshProperties(RefreshProperties.Repaint)]
        public int BorderSize { get => borderSize; set { if (value >= 1) { borderSize = value; } } }

        [RefreshProperties(RefreshProperties.Repaint)]
        [DefaultValue(false)]
        public bool UnderlinedStyle { get => underlinedStyle; set => underlinedStyle = value; }
        public char PasswordChar { get => passwordChar; set { passwordChar = value; txtBox.PasswordChar = value; } }

        [DefaultValue(false)]
        public bool Multiline { get => txtBox.Multiline; set { txtBox.Multiline = value; } }
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; txtBox.BackColor = value; } }
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; txtBox.ForeColor = value; } }
        public override Font Font { get => base.Font; set { base.Font = value; txtBox.Font = value; if (this.DesignMode) { UpdateControlHeight(); } } }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text { get => txtBox.Text; set => txtBox.Text = value; }
        public bool UseSystemPasswordChar { get => useSystemPasswordChar; set { useSystemPasswordChar = value; txtBox.UseSystemPasswordChar = value; } }

        [DefaultValue(AutoCompleteSource.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource { get => txtBox.AutoCompleteSource; set => txtBox.AutoCompleteSource = value; }

        [DefaultValue(AutoCompleteMode.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode { get => txtBox.AutoCompleteMode; set => txtBox.AutoCompleteMode = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get => txtBox.AutoCompleteCustomSource;
            set => txtBox.AutoCompleteCustomSource = value;
        }

        [DefaultValue(CharacterCasing.Normal)]
        public CharacterCasing CharacterCasing { get => characterCasing; set { characterCasing = value; txtBox.CharacterCasing = value; } }

        [DefaultValue(false)]
        public bool NumberMode { get => numberMode; set => numberMode = value; }

        [DefaultValue(true)]
        public bool HideSelection { get => hideSelection; set { hideSelection = value; txtBox.HideSelection = value; } }

        [DefaultValue(32767)]
        public int MaxLegth { get => maxLegth; set { maxLegth = value; txtBox.MaxLength = value; } }

        [DefaultValue(false)]
        public bool ReadOnly { get => readOnly; set { readOnly = value; txtBox.ReadOnly = value; } }

        [DefaultValue(ScrollBars.None)]
        public ScrollBars ScrollBars { get => scrollBars; set { scrollBars = value; if (Multiline) txtBox.ScrollBars = value; } }

        [DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment TextAlign { get => textAlign; set { textAlign = value; txtBox.TextAlign = value; } }

        [DefaultValue(true)]
        public bool WordWrap { get => wordWrap; set { wordWrap = value; txtBox.WordWrap = value; } }

        [DefaultValue(Style.Normal)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public Style BoxStyle 
        { 
            get => boxStyle;
            set
            {
                boxStyle = value;
                switch (value)
                {
                    case Style.Normal:
                        borderRadius = 1;
                        break;
                    case Style.Round:
                        borderRadius = this.Height / 5;
                        break;
                    case Style.Circle:
                        borderRadius = this.Height / 2;
                        break;
                    default:
                        break;
                }
            }
        }

        [Browsable(false)]
        public new BorderStyle BorderStyle { get => BorderStyle.None; set => BorderStyle = value; }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (txtBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                txtBox.Multiline = true;
                txtBox.MinimumSize = new Size(0, txtHeight);
                txtBox.Multiline = false;

                this.Height = txtBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Simple Working Code
            //base.OnPaint(e);
            //Graphics g = e.Graphics;

            ////Draw border
            //using (Pen penBorder = new Pen(borderColor, borderSize))
            //{
            //    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            //    if (UnderlinedStyle)
            //    {
            //        g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
            //    }
            //    else
            //    {
            //        g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            //    }

            //}

            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

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

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(txtBox.ClientRectangle, borderRadius - borderSize);
                txtBox.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(txtBox.ClientRectangle, borderSize * 2);
                txtBox.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            isFocused &= false;
            this.Invalidate();
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (numberMode)
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete) { }
                else
                {
                    e.Handled = true;
                }
            }
        }        

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            if (Text_Changed != null) Text_Changed.Invoke(sender, e);
        }
    }
}
