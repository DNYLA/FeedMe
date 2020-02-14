using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FeedMeLogic.Controls
{
    public partial class FeedMeTextBox : TextBox //Inherits Everything From TextBox Class
    {
        private readonly Font Fnt;
        private readonly float FntSize;

        #region Initialize Class

        /// <summary>
        /// Constructor which adds the Single Border onto the control
        /// </summary>
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

        #endregion Initialize Class

        #region Protected Override Events

        #region WaterMark Events

        //Overrides Default TextBox Methods

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
                Font = new Font(Font.FontFamily, Font.Size, Font.Style | FontStyle.Italic);
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
            base.OnTextChanged(e); //The Base Function is used to access variables and members in the original object method

            if (Text.EndsWith(watermark) && Text.Length != watermark.Length) //Checks if Watermark should be added onto textbox
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

        #endregion WaterMark Events

        #region Border Events

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (Text == watermark)
            {
                Text = string.Empty;
            }
            //Single Border
            Controls[0].BackColor = _FocusColor;

            //Creates 4 Borders Around the Control
            if (!SingleLine)
            {
                Controls[0].BackColor = _FocusColor;
                Controls[1].BackColor = _FocusColor;
                Controls[2].BackColor = _FocusColor;
                Controls[3].BackColor = _FocusColor;
            }
        }

        /// <summary>
        /// Updates Colour On Leave
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (Text == string.Empty)
            {
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

        #endregion Border Events

        #region Other Events

        //Empty But Events Might Be Added Later

        #endregion Other Events

        #endregion Protected Override Events

        #region Custom Properties
        //Custom Atributes added to the object
        private Color _baseColor = Color.Black;
        private Color _borderColor = Color.Black;
        private Color _FocusColor = Color.White;
        private string watermark = string.Empty;
        private bool _autoResize = false;
        private bool _singleLine = true;

        //Each Function here Gets & Sets each of the private atributes above

        public bool SingleLine
        {
            get => _singleLine;
            set { _singleLine = value; CheckBorder(); }
        }

        public bool AutoResize
        {
            get => _autoResize;
            set => _autoResize = value;
        }

        public Color BaseColor
        {
            get => _baseColor;
            set => _baseColor = value;
        }

        public string Watermark
        {
            get => watermark;
            set { watermark = value; Text = watermark; CheckWatermark(); }
        }

        //This Disables/Hides the Property from the property list because this is a custom TextBox which doesnt includes a custom Style
        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get => base.BorderStyle;
            set => base.BorderStyle = value;
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Controls[0].BackColor = _borderColor;
            }
        }

        public Color FocusColor
        {
            get => _FocusColor;
            set => _FocusColor = value;
        }

        #endregion Custom Properties

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

        /// <summary>
        /// Adds A Single or Multiple Border Around the TextBox.
        /// </summary>
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
                    Height = Height,
                    Width = 1,
                    Dock = DockStyle.Left,
                    BackColor = _borderColor
                });

                Controls.Add(new Label
                {
                    Name = "RightBorder",
                    Height = Height,
                    Width = 1,
                    Dock = DockStyle.Right,
                    BackColor = _borderColor
                });
            }
        }

        /// <summary>
        /// Removes Border around the Control
        /// </summary>
        private void RemoveBorder()
        {
            string[] LabelList = new string[] { "TopBorder", "LeftBorder", "RightBorder" };
            foreach (string BorderSide in LabelList)
            {
                Label CurrentLabel = Controls.Find(BorderSide, true).OfType<Label>().SingleOrDefault();
                Controls.Remove(CurrentLabel);
            }
        }

        #endregion Border Methods

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
                //Updates Text To include watermark
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

        #endregion Other Helpers

        #endregion Helper Methods
    }
}