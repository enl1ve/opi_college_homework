using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Baklanov
{
    internal abstract class AbstractMenu
    {
        protected bool flag = true;
        public void Run()
        {
            Init();
            while (flag)
            {
                Idle();
            }
            CleanUp();
        }
        protected abstract void Init();
        protected abstract void Idle();
        protected abstract void CleanUp();
    }
}
