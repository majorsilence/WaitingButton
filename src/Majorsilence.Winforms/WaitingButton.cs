﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Majorsilence.Winforms
{
    internal class WaitingButton
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel layout;
        System.Windows.Forms.Timer timer;
        readonly Button button;

        public WaitingButton(Button button)
        {
            this.button = button;
            label1 = new Label()
            {
                Text = _displayChar,
                Size = new Size(20, 20),
                ForeColor = Color.Gray,
            };

            label2 = new Label()
            {
                Text = _displayChar,
                Size = new Size(20, 20),
                ForeColor = Color.Gray,
            };
            label3 = new Label()
            {
                Text = _displayChar,
                Size = new Size(20, 20),
                ForeColor = Color.Gray,
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
        public bool DisableButtonOnClick { get; set; } = true;


        public void ResizeLabels(int width = 20, int height = 20)
        {
            this.label1.Size = new Size(width, height);
            this.label2.Size = new Size(width, height);
            this.label3.Size = new Size(width, height);
        }

        public void ResizeCharacters(float percent)
        {
            this.label1.Size = new Size((int)(this.label1.Width * percent), (int)(this.label1.Height * percent));
            this.label2.Size = new Size((int)(this.label2.Width * percent), (int)(this.label2.Height * percent));
            this.label3.Size = new Size((int)(this.label3.Width * percent), (int)(this.label3.Height * percent));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", this.label1.Font.SizeInPoints * percent, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", this.label2.Font.SizeInPoints * percent, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", this.label3.Font.SizeInPoints * percent, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

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

        private bool isclicked = false;
        public void OnClick()
        {
            if (DisableButtonOnClick)
            {
                if (isclicked)
                {
                    return;
                }
            }
            isclicked = true;

            origText = this.button.Text;
            this.button.Text = "";
            timer.Enabled = true;

            layout.Width = this.label1.Width + this.label2.Width + this.label3.Width;
            layout.Height = this.label1.Height * 2;

            this.label1.Location = new Point(0, layout.Height / 3);
            this.label2.Location = new Point(label1.Width, layout.Height / 3);
            this.label3.Location = new Point(label1.Width * 2, layout.Height / 3);

            layout.Top = (this.button.Height - layout.Height) / 2;
            layout.Left = (this.button.Width - layout.Width) / 2;

            this.button.Controls.Add(layout);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            button.Invalidate();
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
            this.button.Controls.Remove(layout);
            this.button.Text = origText;
            origText = "";
            isclicked = false;
        }

        public void Dispose()
        {
            this.label1?.Dispose();
            this.label2?.Dispose();
            this.label3?.Dispose();
            this.layout?.Dispose();
            this?.timer.Dispose();
        }
    }
}
