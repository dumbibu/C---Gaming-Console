using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingConsole
{
    interface TicTacToeInterface
    {
        void ButtonsPlaceHolder(int butno);
        bool Chkwin();
        bool Chktie();
        void Dbox(bool Popupchk);
        void TieBox(bool Popupchk);

    }
}
