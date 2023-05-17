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
    public class MainLocation:Location
    {

        public MainLocation(Form1 form):base(form,0,2,1,3,-1)
        {
        }

        public override void LoadLocation(Character Character)
        {
            
            form.BackgroundImage = Image.FromFile("hydrangea2.png");
            form.SchoolTeacher.Visible = true;
            form.KeySprite.Visible = true;
            form.BackToMenu.Visible = true;
            form.label2.Visible = true;
            form.label3.Visible = true;
            if (PreviousLocation == 1)
            {
                Character.LocationX = form.LeftLocChange.Right + Character.SpriteContainer.Width + 50;
            }
            else if (PreviousLocation == 2)
            {
                Character.LocationX = form.RightLocChange.Left - Character.SpriteContainer.Width - 50;
            }
            else if (PreviousLocation == 3)
            {
                Character.LocationY = form.DownLocChange.Top - Character.SpriteContainer.Height - 50;
            }

        }
        public override void HideLocation()
        {
            form.SchoolTeacher.Visible=false;
            form.label2.Visible=false;
            form.label3.Visible=false;
        }
    }
}
