using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        Object CalledObj;
        public List<Location> Locations { get;set; }
        public Form1 form { get; set; }
        public int CurrentLocation { get; set; }
        public Object SchoolTeacherWithKey { get; set; }
        public Object BeastObstacleWithBerries { get; set; }
        public Object BeastObstacle { get; set; }
        public Object Berries { get; set; }
        public Object SchoolTeacher { get; set; }
        public Object CrystallBall1 { get; set; }
        public Object CrystallBall2 { get; set; }
        public Object CrystallBall3 { get; set; }
        public Chest Chest { get; set; }
        public MainLocation MainLocation { get; set; }
        public LeftLocation LeftLocation { get; set; }
        public RightLocation RightLocation { get; set; }
        public DownLocation DownLocation { get; set; }
        public Menu Menu { get; set; }
        public Character Player { get; set; }
        public Controller(Form1 form)
        {
            this.form = form;
            Player = new Character(form.Player,2,15);
            Locations= new List<Location>();
        }
        public void TimerEvent(object sender, EventArgs e, PictureBox[] pbs)
        {
            foreach(PictureBox pictureBox in pbs)
            {
                if (pictureBox.Bounds.IntersectsWith(Player.SpriteContainer.Bounds) && pictureBox == SchoolTeacher.Sprite && SchoolTeacher.Sprite.Visible == true)
                {
                    if (Chest.CollectedGems == 1) 
                    {
                    CalledObj = SchoolTeacherWithKey; 
                    }
                    else
                    {
                        CalledObj = SchoolTeacher;
                    }
                    DialogueCall();
                    Player.LocationX = pictureBox.Left - Player.SpriteContainer.Width - 100;

                }
                if (pictureBox.Bounds.IntersectsWith(Player.SpriteContainer.Bounds) && pictureBox==Berries.Sprite && Berries.Sprite.Visible == true)
                {
                    CalledObj = Berries;
                    DialogueCall();
                    LeftLocation.BerriesFound= true;
                    form.Berries.Visible = false;

                }
                if (pictureBox.Bounds.IntersectsWith(Player.SpriteContainer.Bounds) && pictureBox == BeastObstacle.Sprite && BeastObstacle.Sprite.Visible == true)
                {
                    if (LeftLocation.BerriesFound == false)
                    {
                        CalledObj = BeastObstacle;
                        DialogueCall();
                        Player.LocationX = pictureBox.Left - Player.SpriteContainer.Width - 100;
                    }
                    else
                    {
                        CalledObj = BeastObstacleWithBerries;
                        DialogueCall();
                        RightLocation.BeastFed = true;
                        form.BeastObstacle.Visible = false;
                        Player.LocationX = pictureBox.Left - Player.SpriteContainer.Width - 100;
                    }
                  

                }
                if (pictureBox.Bounds.IntersectsWith(Player.SpriteContainer.Bounds) && pictureBox.Tag == "crystallball" && pictureBox.Visible == true)
                {
                    CalledObj = CrystallBall1;
                    DialogueCall();
                    LeftLocation.CrystallBallPiecesFound++;
                    if (LeftLocation.CrystallBallPiecesFound == 3) { Chest.CollectedGems++; };
                    pictureBox.Visible = false;
                    if (pictureBox.Name == "CrystallBall1") { LeftLocation.CrystallBall1Found=true; };
                    if (pictureBox.Name == "CrystallBall2") { LeftLocation.CrystallBall2Found = true; };
                    if (pictureBox.Name == "CrystallBall3") { RightLocation.CrystallBall3Found = true; };

                }
                if (pictureBox.Bounds.IntersectsWith(Player.SpriteContainer.Bounds) && pictureBox.Tag == "left")
                {
                    if (Locations[CurrentLocation].LeftLocation != -1)
                    {
                        Locations[CurrentLocation].HideLocation();
                        int NextLocation = Locations[CurrentLocation].LeftLocation;
                        Locations[NextLocation].PreviousLocation = CurrentLocation;
                        Locations[NextLocation].LoadLocation(Player);
                        CurrentLocation = NextLocation;
                    }

                }
                else if (pictureBox.Bounds.IntersectsWith(Player.SpriteContainer.Bounds) && pictureBox.Tag == "right")
                {
                    if (Locations[CurrentLocation].RightLocation != -1)
                    {
                        Locations[CurrentLocation].HideLocation();
                        int NextLocation = Locations[CurrentLocation].RightLocation;
                        Locations[NextLocation].PreviousLocation = CurrentLocation;
                        Locations[NextLocation].LoadLocation(Player);
                        CurrentLocation = NextLocation;
                    }

                }
                else if (pictureBox.Bounds.IntersectsWith(Player.SpriteContainer.Bounds) && pictureBox.Tag == "down")
                {
                    if (Locations[CurrentLocation].DownLocation != -1)
                    {
                        Locations[CurrentLocation].HideLocation();
                        int NextLocation = Locations[CurrentLocation].DownLocation;
                        Locations[NextLocation].PreviousLocation = CurrentLocation;
                        Locations[NextLocation].LoadLocation(Player);
                        CurrentLocation = NextLocation;
                    }

                }
                else if (pictureBox.Bounds.IntersectsWith(Player.SpriteContainer.Bounds) && pictureBox.Tag == "up")
                {
                    if (Locations[CurrentLocation].UpLocation != -1)
                    {
                        Locations[CurrentLocation].HideLocation();
                        int NextLocation = Locations[CurrentLocation].UpLocation;
                        Locations[NextLocation].PreviousLocation = CurrentLocation;
                        Locations[NextLocation].LoadLocation(Player);
                        CurrentLocation = NextLocation;
                    }

                }
            }
                if (Player.MoveLeft && Player.LocationX > 0)
                {
                    Player.LocationX -= Player.Speed;
                    Player.SpriteContainer.Location = new Point(Player.LocationX, Player.LocationY);
                    PlayAnimation(4, 7);
                }
                else if (Player.MoveRight && Player.LocationX  < form.ClientSize.Width)
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
                else if (Player.MoveDown && Player.LocationY < form.ClientSize.Height)
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
        public async void PlayAnimation(int start, int end)
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
            await Task.Run(() =>
            {
                Player.SpriteContainer.Image = Image.FromFile(Player.Sprites[Player.Steps]);
            });

        }
        public void TitleScreen()
        {

                Menu = new Menu(new Button[] { form.StartButton, form.QuitButton });
                form.BackgroundImage = Image.FromFile("titlescreenthelostkey.png");
                Menu.LoadMenu();
                MainLocation = new MainLocation(form);
                LeftLocation = new LeftLocation(form);
                RightLocation = new RightLocation(form);
                DownLocation = new DownLocation(form);
                Locations.Add(MainLocation);
                Locations.Add(LeftLocation);
                Locations.Add(RightLocation);
                Locations.Add(DownLocation);
                SchoolTeacher = new Object(form.SchoolTeacher, new List<string> { "Where's your key?", "Bring me the key" });
                SchoolTeacherWithKey = new Object(form.SchoolTeacher, new List<string> { "Thank you. You may be free" });
                CrystallBall1 = new Object(form.CrystallBall1, new List<string> { "Crystall Ball piece obtained" });
                BeastObstacle = new Object(form.BeastObstacle, new List<string> { "If you want that shiny thing, do me a favor - feed me" });
                BeastObstacleWithBerries = new Object(form.BeastObstacle, new List<string> { "You have berries...Alright, you can have the piece" });
                Berries = new Object(form.Berries, new List<string> { "You now have berries, but you're not hungry..." });

        }
        public void DialogueCall()
        {
            form.DialogueBox.Visible = true;
            form.label1.Text = CalledObj.NextLineCall();
            form.label1.Visible = true;
            form.label1.BringToFront();

        }
        public void LoadSpawnPoint()
        {
            Menu.HideMenu();
            MainLocation.LoadLocation(Player);
            Player.SpawnCharacter();
            Chest = new Chest(form.ChestSprite);
            Image chest = Image.FromFile("chest.png");
            Chest.ChestMods.Add(chest);
            chest = Image.FromFile("chestcompleted.png");
            Chest.ChestMods.Add(chest);
            CurrentLocation = MainLocation.LocationCode;
        }
        public void DialogueBoxClick(object sender, EventArgs e)
        {
            if (CalledObj.NextLineCall() == "")
            {
                form.DialogueBox.Visible = false;
                form.label1.Visible = false;
                CalledObj.CurrentLine = 0;
            }
            else
            {
                form.label1.Text = CalledObj.NextLineCall();
                CalledObj.CurrentLine++;
            }
        }

        public void ShowChest()
        {
            Chest.ShowChest();
        }
        public void HideChest()
        {
            Chest.HideChest();
        }
        public void BackToMenu()
        {
            form.BackgroundImage = Image.FromFile("titlescreenthelostkey.png");
            Locations[CurrentLocation].HideLocation();
            Menu.LoadMenu();
            form.BackToMenu.Visible = false;
            form.KeySprite.Visible = false;
            form.SchoolTeacher.Visible = false;
            form.Player.Visible = false;
        }
    }
}
