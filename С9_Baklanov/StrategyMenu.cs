using C9_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Baklanov
{
    internal class StrategyMenu
    {
        private IMenu menu;

        public StrategyMenu(IMenu menu)
        {
            this.menu = menu;
        }
        public void Run()
        {
            menu.Init();
            while (menu.Flag)
            {
                menu.Idle();
            }
            menu.CleanUp();
        }
    }
}