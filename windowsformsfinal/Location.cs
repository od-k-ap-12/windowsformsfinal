using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsformsfinal
{
    public abstract class Location
    {
        public int PreviousLocation { get;set; }
        public int LocationCode { get; set; }
        public Form1 form { get; set; }
        public int RightLocation { get; set; }
        public int LeftLocation { get; set; }
        public int DownLocation { get; set; }
        public int UpLocation { get; set; }
        public Location(Form1 form, int LocationCode,int RightLocation, int LeftLocation, int DownLocation, int UpLocation)
        {
            this.form = form;
            this.LocationCode = LocationCode;
            this.RightLocation = RightLocation;
            this.LeftLocation = LeftLocation;
            this.DownLocation = DownLocation;
            this.UpLocation = UpLocation;
            PreviousLocation = 0;
        }

        public abstract void HideLocation();
        public abstract void LoadLocation(Character Character);

    }
}
