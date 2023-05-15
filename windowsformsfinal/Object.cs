using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace windowsformsfinal
{
    internal class Object
    {
        public PictureBox Sprite { get; set; }
        public List<string> Description { get; set; }
        public int CurrentLine { get; set; }
        public Object(PictureBox Sprite, List<string> Description)
        {
            this.Sprite = Sprite;
            this.Description = Description;
            CurrentLine = 0;
        }
        public string NextLineCall()
        {
            if (CurrentLine != Description.Count)
            {
                return Description[CurrentLine];
                
            }
            else
            {
                return "";
            }
        }


    }
}
