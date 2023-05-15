using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformsfinal
{
    internal class Character
    {
        public PictureBox SpriteContainer { get; set; }
        public List<string> Sprites = new List<string>();
        public int Steps { get; set; }
        public int AnimationSpeed { get; set; }
        public bool MoveLeft{get;set;}
        public bool MoveRight { get;set;}
        public bool MoveUp { get;set;}
        public bool MoveDown { get;set;}
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        //public int Height { get; set; }
        //public int Width { get; set; }
        public int Speed { get; set; }
        public void MoveKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = true;
            }
        }
        public void MoveKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = false;
            }
        }
    }
}
