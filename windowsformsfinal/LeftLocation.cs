using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformsfinal
{
    internal class LeftLocation:Location
    {
        public int CrystallBallPiecesFound { get;set; }
        public bool CrystallBall1Found { get;set; }
        public bool CrystallBall2Found { get; set; }
        public bool BerriesFound { get; set; }

        public LeftLocation(Form1 form):base(form,1,0,-1,-1,-1)
        {
            CrystallBallPiecesFound = 0;
            CrystallBall1Found=false;
            CrystallBall2Found=false;
        }

        public override void LoadLocation(Character Character)
        {

                if (CrystallBallPiecesFound == 3)
                {
                    form.BackgroundImage = Image.FromFile("magnoliacrystallball.png");
                }
                else
                {
                    form.BackgroundImage = Image.FromFile("magnolia.png");
                }
                if (CrystallBall1Found == false) { form.CrystallBall1.Visible = true; }
                if (CrystallBall2Found == false) { form.CrystallBall2.Visible = true; }
                if (BerriesFound == false) { form.Berries.Visible = true; }
                Character.LocationX = form.RightLocChange.Left - Character.SpriteContainer.Width - 50;

        }
        public override void HideLocation()
        {
            form.CrystallBall1.Visible = false;
            form.CrystallBall2.Visible = false;
            form.Berries.Visible=false;
        }
    }
}
