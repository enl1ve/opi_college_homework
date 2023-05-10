using S7_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_Baklanov
{
    internal class MenuStrategy
    {
        IMenu menu;

        public MenuStrategy(IMenu menu)
        {
            this.menu = menu;
        }
        public void Run()
        {
            menu.Init();
            while (menu.Flag == true)
            {
                menu.Idle();
            }
            menu.CleanUp();
        }
    }
}
