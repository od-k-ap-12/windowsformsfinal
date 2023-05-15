using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformsfinal
{
    internal class Menu
    {
        Button[] MenuOptions;
        PictureBox Background;
        public Menu(Button[] menuOptions, PictureBox background)
        {
            MenuOptions = menuOptions;
            Background = background;
        }
        public void LoadMenu()
        {
            foreach (var option in MenuOptions)
            {
                option.Visible = true;
            }
        }
    }
}
