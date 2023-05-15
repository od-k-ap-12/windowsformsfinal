using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformsfinal
{
    internal class MainLocation
    {
        public Character Player { get; set; }
        public PictureBox School { get; set; }
        public PictureBox NPC { get; set; }
        public PictureBox ShowChest { get; set; }
        public MainLocation(Character player,PictureBox school, PictureBox npc, PictureBox showchest)
        {
            Player = player;
            School = school;
            NPC = npc;
            Player.LocationX = Player.SpriteContainer.Location.X;
            Player.LocationY = Player.SpriteContainer.Location.Y;
            Player.Sprites = Directory.GetFiles("player", "*.png").ToList();
            Player.SpriteContainer.Image = Image.FromFile(Player.Sprites[Player.Steps]);
            Player.Speed = 15;
            Player.AnimationSpeed = 2;
            ShowChest = showchest;
        }
        public void LoadMainLocation(Form1 form)
        {
            Player.SpriteContainer.Visible = true;
            form.BackgroundImage = Image.FromFile("hydrangea.png");
            //School.Visible = true;
            NPC.Visible = true;
            ShowChest.Visible = true;

        }
        public void HideMainLocation()
        {
            NPC.Visible=false;
        }
    }
}
