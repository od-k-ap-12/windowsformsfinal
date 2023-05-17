using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace windowsformsfinal
{
    internal class RightLocation : Location
    {
        public bool CrystallBall3Found { get; set; }
        public bool BeastFed { get; set; }
        public RightLocation(Form1 form) : base(form, 2, -1, 0, -1, -1)
        {
            CrystallBall3Found = false;
            BeastFed = false;
        }

        public override void HideLocation()
        {
            form.BackgroundImage = Image.FromFile("sunflower.jpg");

            form.CrystallBall3.Visible = false;
            form.BeastObstacle.Visible = false;
        }

        public override void LoadLocation(Character Character)
        {
            form.BackgroundImage = Image.FromFile("sunflower.jpg");
            Character.LocationX = form.LeftLocChange.Right + Character.SpriteContainer.Width + 50;
            if(CrystallBall3Found==false)
            {
                form.CrystallBall3.Visible = true;
                if (BeastFed == false) { form.BeastObstacle.Visible= true; }
            }
            
            
        }
    }
}
