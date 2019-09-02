using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeClient.CustomControls
{
    public partial class FeedMeTextBox : TextBox
    {
        private Font Fnt;
        private Color Col;
        private float FntSize;

        #region Initialize Class
        public FeedMeTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;

            Controls.Add(new Label
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = _borderColor
            });

            //Planning On Adding a PictureBox To The RightSide of the TextBox
            //Controls.Add(new PictureBox
            //{
            //    Height = 10,
            //    Width = 5,
            //    Dock = DockStyle.Left,
            //});

            Fnt = Font;
            FntSize = Font.Size;

            InitializeComponent();
        }
        #endregion

        #region Protected Override Events

        #region WaterMark Events
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ReSizeTextBox();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (Text == watermark)
            {
                Font = new Font(Font.FontFamily, Font.Size, this.Font.Style | FontStyle.Italic);
                ResetText();
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            CheckWatermark();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (Text.EndsWith(watermark) && Text.Length != watermark.Length)
            {
                Text = Text.Substring(0, Text.Length - Watermark.Length);
            }

            CheckWatermark();
            if (Text == watermark || Text == String.Empty)
            {
                return;
            }

            Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            Size size = TextRenderer.MeasureText(Text, Font);
            Height = size.Height + 5;
        }
        #endregion

        #region Border Events
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            Controls[0].BackColor = _FocusColor;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            Controls[0].BackColor = _borderColor;
        }
        #endregion

        #region Other Events
        //Empty But Events Might Be Added Later
        #endregion

        #endregion

        #region Custom Properties
        private Color _baseColor = Color.Black;
        private Color _borderColor = Color.Black;
        private Color _FocusColor = Color.White;
        private string watermark = string.Empty;

        public Color BaseColor
        {
            get { return _baseColor; }
            set { _baseColor = value; }
        }

        public string Watermark
        {
            get { return watermark; }
            set { watermark = value; Text = watermark; CheckWatermark(); }
        }

        //This Disables/Hides the Property from the property list because this is a custom TextBox which doesnt includes a custom Style
        [Browsable(false)] 
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Controls[0].BackColor = _borderColor;
            }
        }

        public Color FocusColor
        {
            get { return _FocusColor; }
            set
            {
                _FocusColor = value;
            }
        }
        #endregion

        #region Helper Methods
        private void ReSizeTextBox()
        {
            Size size = TextRenderer.MeasureText(Text, Font); // Gets The Size
            ClientSize = new Size(Width, size.Height + 3); //3 = The Margin Between The Text & height
        }

        private void CheckWatermark()
        {
            if (Text == string.Empty || Text == watermark)
            {
                ForeColor = Color.Gray;
                Text = watermark;
                Font = new Font(Font.FontFamily, FntSize - 1.0F, FontStyle.Italic);
                //Invalidate();
            }
            else
            {
                Font = new Font(Font.FontFamily, FntSize + 3.0F, FontStyle.Regular);
                ForeColor = _baseColor;
                ReSizeTextBox();
            }
        }

        #endregion


    }
}
