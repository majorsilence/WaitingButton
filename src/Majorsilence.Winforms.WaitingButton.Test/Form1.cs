using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Majorsilence.Winforms.WaitingButton.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonThreeDots1_Click(object sender, EventArgs e)
        {
            buttonThreeDots1.DarkColor = Color.DarkBlue;
            buttonThreeDots1.LightColor = Color.Cyan;


            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
                this.Invoke((MethodInvoker)delegate
                {
                    buttonThreeDots1.Reset();
                });
            });
        }

        private async void buttonThreeDots2_Click(object sender, EventArgs e)
        {
            buttonThreeDots2.DisplayCharacter = "😜";


            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
                this.Invoke((MethodInvoker)delegate
                {
                    buttonThreeDots2.Reset();
                });
            });
        }

        private async void buttonThreeDots3_Click(object sender, EventArgs e)
        {
            buttonThreeDots3.DisplayCharacter = "👀";
            buttonThreeDots3.LightColor = Color.Cyan;


            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
                this.Invoke((MethodInvoker)delegate
                {
                    buttonThreeDots3.Reset();
                });
            });
        }
    }
}
