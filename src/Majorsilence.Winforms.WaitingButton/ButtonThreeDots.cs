using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Majorsilence.Winforms.WaitingButton
{
    [Description("Button that shows an animation after having been clicked.")]
    public class ButtonThreeDots : Button
    {

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel layout;
        System.Windows.Forms.Timer timer;


        public ButtonThreeDots()
        {
            label1 = new Label()
            {
                Text = _displayChar,
                Size = new Size(20, 20),
                ForeColor = Color.Gray
            };

            label2 = new Label()
            {
                Text = _displayChar,
                Size = new Size(20, 20),
                ForeColor = Color.Gray
            };
            label3 = new Label()
            {
                Text = _displayChar,
                Size = new Size(20, 20),
                ForeColor = Color.Gray
            };
            layout = new Panel()
            {
                BackColor = Color.Transparent
            };
            layout.Controls.Add(label1);
            layout.Controls.Add(label2);
            layout.Controls.Add(label3);
            timer = new System.Windows.Forms.Timer();
            timer.Tick += timer_Tick;
        }

        public Color LightColor { get; set; } = Color.Gray;
        public Color DarkColor { get; set; } = Color.Black;

        private string _displayChar = "⬤";
        public string DisplayCharacter
        {
            get
            {
                return _displayChar;
            }
            set
            {
                _displayChar = value;
                label1.Text = _displayChar;
                label2.Text = _displayChar;
                label3.Text = _displayChar;
            }
        }

        private string origText = "";
        private uint count = 0;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            origText = this.Text;
            this.Text = "";
            timer.Enabled = true;

            layout.Width = this.label1.Width + this.label2.Width + this.label3.Width;
            layout.Height = this.label1.Height * 2;

            this.label1.Location = new Point(0, layout.Height / 3);
            this.label2.Location = new Point(label1.Width, layout.Height / 3);
            this.label3.Location = new Point(label1.Width * 2, layout.Height / 3);

            layout.Top = (this.Height - layout.Height) / 2;
            layout.Left = (this.Width - layout.Width) / 2;

            this.Controls.Add(layout);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            count += 1;

            if (count % 12 == 0)
            {
                label3.ForeColor = LightColor;
                label2.ForeColor = LightColor;
                label1.ForeColor = LightColor;
                count = 0;
            }
            else if (count % 9 == 0)
            {
                label3.ForeColor = DarkColor;
            }
            else if (count % 6 == 0)
            {
                label2.ForeColor = DarkColor;
            }
            else if (count % 3 == 0)
            {
                label1.ForeColor = DarkColor;
            }
        }


        public void Reset()
        {
            timer.Enabled = false;
            this.Controls.Remove(layout);
            this.Text = origText;
            origText = "";
        }

        public new void Dispose()
        {
            base.Dispose();
            this?.timer.Dispose();
        }
    }
}
