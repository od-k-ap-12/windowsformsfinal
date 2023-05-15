using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformsfinal
{
    internal class Chest
    {
        public int CollectedGems { get; set; }
        List<Image> ChestMods;
        public Chest(List<Image> ChestMods)
        {
            CollectedGems = 0;
            this.ChestMods = ChestMods;
        }
    }
}
