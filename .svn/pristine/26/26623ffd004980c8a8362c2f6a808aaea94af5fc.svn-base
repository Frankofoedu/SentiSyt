using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentAnalysis
{
    public partial class TransparentPanel : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x20;
        public TransparentPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
        }

        private int _opacity = 50;
        [DefaultValue(50)]
        public int Opacity
        {
            get
            {
                return this._opacity;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("value must be between 0 and 100");
                _opacity = value;
            }


        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush
                (Color.FromArgb(_opacity * 255 / 100, BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);

            }
            base.OnPaint(e);
        }
    }
}
