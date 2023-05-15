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
            controller.SetUp(this);

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
            controller.TimerEvent(sender,e, this.Controls.OfType<PictureBox>().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
