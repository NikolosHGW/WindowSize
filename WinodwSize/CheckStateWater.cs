using System;
using System.Collections.Generic;
using System.Text;

namespace WinodwSize
{
    class CheckStateWater
    {
        public static void Check()
        {
            if (StateButton.Button[6].IsState == true && DataLines.wnd.line13.Opacity == 1 && DataLines.wnd.line17.Opacity == 0)
            {
                FillModel.Filling(DataLines.wnd.line17, DataLines.X2, DataLines.anLine17);
            }
        }
    }
}
