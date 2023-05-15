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
        public Menu(Button[] menuOptions)
        {
            MenuOptions = menuOptions;
        }
        public void LoadMenu()
        {
            foreach (var option in MenuOptions)
            {
                option.Visible = true;
            }
        }
        public void HideMenu()
        {
            foreach (var option in MenuOptions)
            {
                option.Visible = false;
            }
        }
    }
}
