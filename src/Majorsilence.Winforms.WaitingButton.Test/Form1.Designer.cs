namespace Majorsilence.Winforms.WaitingButton.Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonThreeDots1 = new Majorsilence.Winforms.WaitingButton.ButtonThreeDots();
            this.buttonThreeDots2 = new Majorsilence.Winforms.WaitingButton.ButtonThreeDots();
            this.buttonThreeDots3 = new Majorsilence.Winforms.WaitingButton.ButtonThreeDots();
            this.SuspendLayout();
            // 
            // buttonThreeDots1
            // 
            this.buttonThreeDots1.DarkColor = System.Drawing.Color.Black;
            this.buttonThreeDots1.DisplayCharacter = "⬤";
            this.buttonThreeDots1.LightColor = System.Drawing.Color.Gray;
            this.buttonThreeDots1.Location = new System.Drawing.Point(74, 53);
            this.buttonThreeDots1.Name = "buttonThreeDots1";
            this.buttonThreeDots1.Size = new System.Drawing.Size(178, 43);
            this.buttonThreeDots1.TabIndex = 0;
            this.buttonThreeDots1.Text = "buttonThreeDots1";
            this.buttonThreeDots1.UseVisualStyleBackColor = true;
            this.buttonThreeDots1.Click += new System.EventHandler(this.buttonThreeDots1_Click);
            // 
            // buttonThreeDots2
            // 
            this.buttonThreeDots2.DarkColor = System.Drawing.Color.Black;
            this.buttonThreeDots2.DisplayCharacter = "⬤";
            this.buttonThreeDots2.LightColor = System.Drawing.Color.Gray;
            this.buttonThreeDots2.Location = new System.Drawing.Point(317, 53);
            this.buttonThreeDots2.Name = "buttonThreeDots2";
            this.buttonThreeDots2.Size = new System.Drawing.Size(75, 23);
            this.buttonThreeDots2.TabIndex = 1;
            this.buttonThreeDots2.Text = "buttonThreeDots2";
            this.buttonThreeDots2.UseVisualStyleBackColor = true;
            this.buttonThreeDots2.Click += new System.EventHandler(this.buttonThreeDots2_Click);
            // 
            // buttonThreeDots3
            // 
            this.buttonThreeDots3.DarkColor = System.Drawing.Color.Black;
            this.buttonThreeDots3.DisplayCharacter = "⬤";
            this.buttonThreeDots3.LightColor = System.Drawing.Color.Gray;
            this.buttonThreeDots3.Location = new System.Drawing.Point(503, 88);
            this.buttonThreeDots3.Name = "buttonThreeDots3";
            this.buttonThreeDots3.Size = new System.Drawing.Size(161, 107);
            this.buttonThreeDots3.TabIndex = 2;
            this.buttonThreeDots3.Text = "buttonThreeDots3";
            this.buttonThreeDots3.UseVisualStyleBackColor = true;
            this.buttonThreeDots3.Click += new System.EventHandler(this.buttonThreeDots3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThreeDots3);
            this.Controls.Add(this.buttonThreeDots2);
            this.Controls.Add(this.buttonThreeDots1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonThreeDots buttonThreeDots1;
        private ButtonThreeDots buttonThreeDots2;
        private ButtonThreeDots buttonThreeDots3;
    }
}

