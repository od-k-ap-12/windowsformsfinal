using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformsfinal
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller(ClientSize.Width, ClientSize.Height,pictureBox1);
            controller.TitleScreen(this);

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            controller.Player.MoveKeyDown(sender, e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            controller.Player.MoveKeyUp(sender,e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controller.TimerEvent(sender,e, this.Controls.OfType<PictureBox>().ToArray(),this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.LoadMainLocation(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.ShowChest();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            controller.HideChest();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            controller.ShowChest();
        }

        private void DialogueBox_Click(object sender, EventArgs e)
        {
            if (controller.SchoolTeacher.NextLineCall() == "")
            {
                DialogueBox.Visible = false;
                label1.Visible = false;
                controller.SchoolTeacher.CurrentLine=0;
            }
            else
            {
                label1.Text = controller.SchoolTeacher.NextLineCall();
                controller.SchoolTeacher.CurrentLine++;
            }
        }
    }
}
