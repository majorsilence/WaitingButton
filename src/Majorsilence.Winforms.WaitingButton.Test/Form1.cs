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

            buttonThreeDots5.ResizeLabels(23, 20);
            buttonThreeDots5.ResizeCharacters(2.3f);
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

            listBox1.Items.Add("buttonThreeDots1_Click finished");
        }

        private async void buttonThreeDots2_Click(object sender, EventArgs e)
        {
            buttonThreeDots2.DisplayCharacter = "😜";


            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(10000);
                this.Invoke((MethodInvoker)delegate
                {
                    buttonThreeDots2.Reset();
                });
            });

            listBox1.Items.Add("buttonThreeDots2_Click finished");
        }

        private async void buttonThreeDots3_Click(object sender, EventArgs e)
        {
            buttonThreeDots3.DisplayCharacter = "ಠ_ಠ";
            buttonThreeDots3.LightColor = Color.Cyan;
            listBox1.Items.Add("buttonThreeDots3_Click is clicked");

            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(15000);
                this.Invoke((MethodInvoker)delegate
                {
                    buttonThreeDots3.Reset();
                });
            });
            listBox1.Items.Add("buttonThreeDots3_Click finished");
        }

        private async void buttonThreeDots5_Click(object sender, EventArgs e)
        {
            buttonThreeDots5.DisplayCharacter = "ಠ_ಠ";
            listBox1.Items.Add("buttonThreeDots5_Click is clicked");

            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
                this.Invoke((MethodInvoker)delegate
                {
                    buttonThreeDots5.Reset();
                });
            });
            listBox1.Items.Add("buttonThreeDots5_Click finished");
        }
    }
}
