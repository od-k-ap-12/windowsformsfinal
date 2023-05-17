using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformsfinal
{
    public class Chest
    {
        public int CollectedGems { get; set; }
        public List<Image> ChestMods { get; set; }
        public PictureBox ChestSprite { get;set; }
        public Chest(PictureBox ChestSprite)
        {
            this.ChestSprite = ChestSprite;
            CollectedGems = 0;
            ChestMods = new List<Image>();

        }
        public void ShowChest()
        {
            ChestSprite.Image = ChestMods[CollectedGems];
            ChestSprite.Visible = true;
            ChestSprite.BringToFront();
        }
        public void HideChest()
        {
            ChestSprite.Visible = false;
        }
    }
}
