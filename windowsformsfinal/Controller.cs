using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformsfinal
{
    internal class Controller
    {
        public Object SchoolTeacher { get; set; }
        public Chest Chest { get; set; }
        public MainLocation MainLocation { get; set; }
        public Menu Menu { get; set; }
        public Character Player { get; set; }
        public double ClientSizeWidth { get; set; }
        public double ClientSizeHeight { get; set; }
        public Controller(double ClientSizeWidth, double ClientSizeHeight, PictureBox MC)
        {
            Player = new Character();
            Player.SpriteContainer = MC;
            this.ClientSizeHeight = ClientSizeHeight;
            this.ClientSizeWidth = ClientSizeWidth;
        }
        public void TimerEvent(object sender, EventArgs e, PictureBox[] pbs, Form1 form)
        {
            foreach(PictureBox pictureBox in pbs)
            {
                if (pictureBox.Bounds.IntersectsWith(Player.SpriteContainer.Bounds)&&pictureBox==SchoolTeacher.Sprite)
                {
                    DialogueCall(form, SchoolTeacher);
                  Player.LocationX = pictureBox.Left - Player.SpriteContainer.Width-100;

                }
            }
                if (Player.MoveLeft && Player.LocationX > 0)
                {
                    Player.LocationX -= Player.Speed;
                    Player.SpriteContainer.Location = new Point(Player.LocationX, Player.LocationY);
                    PlayAnimation(4, 7);
                }
                else if (Player.MoveRight && Player.LocationX + Player.Width < ClientSizeWidth)
                {
                    Player.LocationX += Player.Speed;
                    Player.SpriteContainer.Location = new Point(Player.LocationX, Player.LocationY);
                    PlayAnimation(8, 11);
                }
                else if (Player.MoveUp && Player.LocationY > 0)
                {
                    Player.LocationY -= Player.Speed;
                    Player.SpriteContainer.Location = new Point(Player.LocationX, Player.LocationY);
                    PlayAnimation(12, 15);
                }
                else if (Player.MoveDown && Player.LocationY + Player.Height < ClientSizeHeight)
                {
                    Player.LocationY += Player.Speed;
                    Player.SpriteContainer.Location = new Point(Player.LocationX, Player.LocationY);
                    PlayAnimation(0, 3);
                }
                else
                {
                    PlayAnimation(0, 0);
                }
                
            
        }
        public void PlayAnimation(int start, int end)
        {
            Player.AnimationSpeed += 1;
            if (Player.AnimationSpeed == 4)
            {
                Player.Steps++;
                Player.AnimationSpeed = 0;
            }
            if (Player.Steps > end || Player.Steps < start)
            {
                Player.Steps = start;
            }
            Player.SpriteContainer.Image = Image.FromFile(Player.Sprites[Player.Steps]);

        }
        public void TitleScreen(Form1 form)
        {
            Menu = new Menu(new Button[] {form.button1,form.button2 });
            form.BackgroundImage = Image.FromFile("titlescreen.png");
            Menu.LoadMenu();
            MainLocation = new MainLocation(Player,null, form.pictureBox2, form.pictureBox4);
            SchoolTeacher = new Object(form.pictureBox2, new List<string> { "Where's your key?"});

        }
        public void DialogueCall(Form1 form,Object obj)
        {
            form.DialogueBox.Visible = true;
            form.label1.Text = obj.NextLineCall();
            form.label1.Visible = true;
        }
        public void LoadMainLocation(Form1 form)
        {
            Menu.HideMenu();
            MainLocation.LoadMainLocation(form);
            Chest = new Chest(form.pictureBox3);
            Image chest = Image.FromFile("chest.png");
            Chest.ChestMods.Add(chest);
        }
        public void ShowChest()
        {
            Chest.ShowChest();
        }
        public void HideChest()
        {
            Chest.HideChest();
        }
    }
}
