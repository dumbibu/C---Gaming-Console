using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingConsole
{
    interface MineFieldInterface
    {
        void ButtonsPlaceHolder(int butno);
        bool Chkwin();
        bool Chkloss();
        void Dbox(bool Popupchk);
    }
}
