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

       

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("button1_Click is clicked");

            button1.StartWaiting();
            await Task.Run(async () =>
            {
                await Task.Delay(15000);
            });
            button1.EndWaiting();


            listBox1.Items.Add("button1_Click finished");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("button2_Click is clicked");

            button2.StartWaiting(displayChar: "ಠ_ಠ",
                resizeLabel: (40, 40), 
                resizeCharactersPercent: 2.3f);
            await Task.Run(async () =>
            {
                await Task.Delay(5000);
            });
            button2.EndWaiting();

            listBox1.Items.Add("button2_Click finished");
        }
    }
}
