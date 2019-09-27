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
        private readonly float FntSize;

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
            if (AutoResize)
            {
                ReSizeTextBox();
            }
            
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
                Text = string.Empty;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            CheckWatermark();
            //if (Text == string.Empty)
            //{
            //    Text = watermark;
            //}
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (Text.EndsWith(watermark) && Text.Length != watermark.Length)
            {
                Text = Text.Substring(0, Text.Length - Watermark.Length);
            }

            
            if (Text == watermark || Text == string.Empty)
            {
                return;
            }
            CheckWatermark();
            Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            Size size = TextRenderer.MeasureText(Text, Font);
            Height = size.Height + 5;
        }
        #endregion

        #region Border Events
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (Text == watermark)
            {
                Console.WriteLine("Text");
                Text = string.Empty;
            }
            Controls[0].BackColor = _FocusColor;

            if (!SingleLine)
            {
                Controls[0].BackColor = _FocusColor;
                Controls[1].BackColor = _FocusColor;
                Controls[2].BackColor = _FocusColor;
                Controls[3].BackColor = _FocusColor;
            }

        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (Text == string.Empty)
            {
                Console.WriteLine("Test");
                Text = watermark;
            }
            Controls[0].BackColor = _borderColor;
            if (!SingleLine)
            {
                Controls[0].BackColor = _borderColor;
                Controls[1].BackColor = _borderColor;
                Controls[2].BackColor = _borderColor;
                Controls[3].BackColor = _borderColor;
            }
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
        private bool _autoResize = false;
        private bool _singleLine = true;

        public bool SingleLine
        {
            get { return _singleLine; }
            set { _singleLine = value; CheckBorder(); }
        }

        public bool AutoResize
        {
            get { return _autoResize; }
            set { _autoResize = value; }
        }

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

        #region Border Methods

        private void ChangeFocus(bool isFocus)
        {
            Controls[0].BackColor = _FocusColor;
            if (!_singleLine)
            {
                Controls[0].BackColor = _FocusColor;
                Controls[1].BackColor = _FocusColor;
                Controls[2].BackColor = _FocusColor;
                Controls[3].BackColor = _FocusColor;
            }
        }

        private void CheckBorder()
        {
            if (_singleLine)
            {
                RemoveBorder();
            }
            else
            {
                AddBorders();
            }
        }

        private void AddBorders()
        {
            if (!SingleLine)
            {
                Controls.Add(new Label
                {
                    Name = "TopBorder",
                    Height = 1,
                    Dock = DockStyle.Top,
                    BackColor = _borderColor
                });

                Controls.Add(new Label
                {
                    Name = "LeftBorder",
                    Height = this.Height,
                    Width = 1,
                    Dock = DockStyle.Left,
                    BackColor = _borderColor
                });

                Controls.Add(new Label
                {
                    Name = "RightBorder",
                    Height = this.Height,
                    Width = 1,
                    Dock = DockStyle.Right,
                    BackColor = _borderColor
                });
            }
        }

        private void RemoveBorder()
        {
            string[] LabelList = new string[] { "TopBorder", "LeftBorder", "RightBorder" };
            foreach(String BorderSide in LabelList)
            {
                Label CurrentLabel = Controls.Find(BorderSide, true).OfType<Label>().SingleOrDefault();
                Controls.Remove(CurrentLabel);
            }
        }
        #endregion

        #region Other Helpers
        private void ReSizeTextBox()
        {
            Size size = TextRenderer.MeasureText(Text, Font); // Gets The Size
            ClientSize = new Size(Width, size.Height + 3); //3 = The Margin Between The Text & height
        }

        private void CheckWatermark()
        {
            if (Text == watermark || Text == string.Empty)
            {
                ForeColor = Color.Gray;
                Text = watermark;
                Font = new Font(Font.FontFamily, FntSize - 1.0F, FontStyle.Italic);
                Invalidate();
            }
            else
            {
                Font = new Font(Font.FontFamily, FntSize + 3.0F, FontStyle.Regular);
                ForeColor = _baseColor;
                ReSizeTextBox();
            }
        }
        #endregion

        #endregion


    }
}
