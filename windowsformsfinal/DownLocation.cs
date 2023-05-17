using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsformsfinal
{
    internal class DownLocation : Location
    {
        public DownLocation(Form1 form) : base(form, 3, -1, -1, -1, 0)
        {
        }

        public override void HideLocation()
        {
            form.BackgroundImage = Image.FromFile("waterlily.jpg");
        }

        public override void LoadLocation(Character Character)
        {
            form.BackgroundImage = Image.FromFile("waterlily.jpg");
            Character.LocationY = form.UpLocChange.Bottom + 20;
        }
    }
}
