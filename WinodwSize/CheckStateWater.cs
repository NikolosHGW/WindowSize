using System;
using System.Collections.Generic;
using System.Text;

namespace WinodwSize
{
    class CheckStateWater
    {
        public static void Check()
        {
            if (StateButton.Button[0].IsState == true && StateButton.ButtonPmpR[0].IsState == false)
            {
                DataLines.Chck = false;
            }
            if (StateButton.ButtonPmpR[0].IsState == false && StateButton.Button[0].IsState == false)
            {
                DataLines.Chck = true;
            }

            if (StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && DataLines.Chck == true)
            {

            }


            if (StateButton.Button[6].IsState == true && DataLines.wnd.line13.Opacity == 1 && DataLines.wnd.line17.Opacity == 0)
            {
                FillModel.Filling(DataLines.wnd.line17, DataLines.X2, DataLines.anLine17);
            }
        }
    }
}
