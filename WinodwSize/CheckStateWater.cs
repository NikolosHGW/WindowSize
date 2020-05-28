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

            if (StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && DataLines.Chck == true && DataLines.wnd.line0.Opacity == 0)
            {
                FillModel.Filling(DataLines.wnd.line0, DataLines.Y2, DataLines.anLine0);
                FillModel.FillingAsync(300, DataLines.wnd.line1, DataLines.X2, DataLines.anLine1);
                FillModel.FillingAsync(300, DataLines.wnd.line2, DataLines.X2, DataLines.anLine2);
                FillModel.FillingAsync(600, DataLines.wnd.line3, DataLines.Y2, DataLines.anLine3);
            }

            if (StateButton.ButtonV[12].IsState == true && DataLines.wnd.line3.Opacity == 1 && DataLines.wnd.line5.Opacity == 0 && DataLines.ChckLine3 == true)
            {
                DataLines.ChckLine3 = false;
                FillModel.Filling(DataLines.wnd.line5, DataLines.Y2, DataLines.anLine5);
                FillModel.FillingAsync(300, DataLines.wnd.line7, DataLines.X2, DataLines.anLine7);
                FillModel.FillingAsync(300, DataLines.wnd.line9, DataLines.X2, DataLines.anLine9);
                FillModel.FillingAsync(600, DataLines.wnd.line10, DataLines.Y2, DataLines.anLine10);
            }



            if (StateButton.Button[7].IsState == true && DataLines.wnd.line7.Opacity == 1 && DataLines.wnd.line13.Opacity == 0 && DataLines.ChckLine7 == true)
            {
                DataLines.ChckLine7 = false;
                FillModel.Filling(DataLines.wnd.line13, DataLines.X2, DataLines.anLine13);
                FillModel.FillingAsync(300, DataLines.wnd.line16, DataLines.Y2, DataLines.anLine16);
            }
            if (StateButton.Button[7].IsState == true && DataLines.wnd.line14.Opacity == 1 && DataLines.wnd.line8.Opacity == 0 && DataLines.ChckLine14 == true)
            {
                DataLines.ChckLine14 = false;
                FillModel.Filling(DataLines.wnd.line8, DataLines.X2, DataLines.anLine8);
                FillModel.FillingAsync(300, DataLines.wnd.line6, DataLines.Y2, DataLines.anLine6);
                FillModel.FillingAsync(300, DataLines.wnd.line9, DataLines.X2, DataLines.anLine9);
                FillModel.FillingAsync(600, DataLines.wnd.line10, DataLines.Y2, DataLines.anLine10);
                FillModel.FillingAsync(900, DataLines.wnd.line11, DataLines.Y2, DataLines.anLine11);
                FillModel.FillingAsync(1200, DataLines.wnd.line12, DataLines.X2, DataLines.anLine12);
            }



            if (StateButton.Button[6].IsState == true && DataLines.wnd.line13.Opacity == 1 && DataLines.wnd.line17.Opacity == 0 && DataLines.ChckLine13 == true)
            {
                DataLines.ChckLine13 = false;
                FillModel.Filling(DataLines.wnd.line17, DataLines.X2, DataLines.anLine17);
                FillModel.FillingAsync(100, DataLines.wnd.line20, DataLines.Y2, DataLines.anLine20);
                FillModel.FillingAsync(280, DataLines.wnd.line22, DataLines.Y2, DataLines.anLine22);
            }
            if (StateButton.Button[6].IsState == true && DataLines.wnd.line18.Opacity == 1 && DataLines.wnd.line14.Opacity == 0 && DataLines.ChckLine18 == true)
            {
                DataLines.ChckLine18 = false;
                FillModel.Filling(DataLines.wnd.line14, DataLines.X2, DataLines.anLine14);
                FillModel.FillingAsync(100, DataLines.wnd.line16, DataLines.Y2, DataLines.anLine16);
            }



            if (StateButton.Button[5].IsState == true && DataLines.wnd.line17.Opacity == 1 && DataLines.wnd.line25.Opacity == 0 && DataLines.ChckLine17 == true)
            {
                DataLines.ChckLine17 = false;
                FillModel.Filling(DataLines.wnd.line25, DataLines.X2, DataLines.anLine25);
                FillModel.Filling(DataLines.wnd.line24, DataLines.Y2, DataLines.anLine24);
                FillModel.FillingAsync(300, DataLines.wnd.line28, DataLines.Y2, DataLines.anLine28);
            }
            if (StateButton.Button[5].IsState == true && DataLines.wnd.line26.Opacity == 1 && DataLines.wnd.line18.Opacity == 0 && DataLines.ChckLine26 == true)
            {
                DataLines.ChckLine26 = false;
                FillModel.Filling(DataLines.wnd.line18, DataLines.X2, DataLines.anLine18);
                FillModel.Filling(DataLines.wnd.line22, DataLines.Y2, DataLines.anLine22);
                FillModel.FillingAsync(280, DataLines.wnd.line20, DataLines.Y2, DataLines.anLine20);
            }



            if (StateButton.ButtonV[9].IsState == true && DataLines.wnd.line28.Opacity == 1 && DataLines.wnd.line30.Opacity == 0 && DataLines.ChckLine28 == true)
            {
                DataLines.ChckLine28 = false;
                FillModel.Filling(DataLines.wnd.line30, DataLines.Y2, DataLines.anLine30);
                FillModel.FillingAsync(150, DataLines.wnd.line72, DataLines.X2, DataLines.anLine72);
            }
            if (StateButton.ButtonV[9].IsState == true && DataLines.wnd.line29.Opacity == 1 && DataLines.wnd.line27.Opacity == 0 && DataLines.ChckLine29 == true)
            {
                DataLines.ChckLine29 = false;
                FillModel.Filling(DataLines.wnd.line27, DataLines.Y2, DataLines.anLine27);
                FillModel.FillingAsync(300, DataLines.wnd.line26, DataLines.X2, DataLines.anLine26);
                FillModel.FillingAsync(600, DataLines.wnd.line24, DataLines.Y2, DataLines.anLine24);
            }



            if (StateButton.ButtonV[8].IsState == true && DataLines.wnd.line30.Opacity == 1 && DataLines.wnd.line32.Opacity == 0 && DataLines.ChckLine30 == true)
            {
                DataLines.ChckLine30 = false;
                FillModel.Filling(DataLines.wnd.line32, DataLines.Y2, DataLines.anLine32);
                FillModel.FillingAsync(300, DataLines.wnd.line34, DataLines.X2, DataLines.anLine34);
                FillModel.FillingAsync(600, DataLines.wnd.line35, DataLines.Y2, DataLines.anLine35);
            }
            if (StateButton.ButtonV[8].IsState == true && DataLines.wnd.line31.Opacity == 1 && DataLines.wnd.line29.Opacity == 0 && DataLines.ChckLine31 == true)
            {
                DataLines.ChckLine31 = false;
                FillModel.Filling(DataLines.wnd.line29, DataLines.Y2, DataLines.anLine29);
                FillModel.FillingAsync(150, DataLines.wnd.line72, DataLines.X2, DataLines.anLine72);
            }



            if (StateButton.Button[4].IsState == true && DataLines.wnd.line34.Opacity == 1 && DataLines.wnd.line38.Opacity == 0 && DataLines.ChckLine34 == true)
            {
                DataLines.ChckLine34 = false;
                FillModel.Filling(DataLines.wnd.line38, DataLines.X2, DataLines.anLine38);
                FillModel.FillingAsync(20, DataLines.wnd.line39, DataLines.Y2, DataLines.anLine39);
                FillModel.FillingAsync(270, DataLines.wnd.line41, DataLines.Y2, DataLines.anLine41);
            }
            if (StateButton.Button[4].IsState == true && DataLines.wnd.line37.Opacity == 1 && DataLines.wnd.line33.Opacity == 0 && DataLines.ChckLine37 == true)
            {
                DataLines.ChckLine37 = false;
                FillModel.Filling(DataLines.wnd.line33, DataLines.X2, DataLines.anLine33);
                FillModel.FillingAsync(20, DataLines.wnd.line35, DataLines.Y2, DataLines.anLine35);
                FillModel.FillingAsync(300, DataLines.wnd.line31, DataLines.Y2, DataLines.anLine31);
            }



            if (StateButton.Button[3].IsState == true && DataLines.wnd.line38.Opacity == 1 && DataLines.wnd.line44.Opacity == 0 && DataLines.ChckLine38 == true)
            {
                DataLines.ChckLine38 = false;
                FillModel.Filling(DataLines.wnd.line44, DataLines.X2, DataLines.anLine44);
                FillModel.FillingAsync(75, DataLines.wnd.line45, DataLines.Y2, DataLines.anLine45);
            }
            if (StateButton.Button[3].IsState == true && DataLines.wnd.line43.Opacity == 1 && DataLines.wnd.line37.Opacity == 0 && DataLines.ChckLine43 == true)
            {
                DataLines.ChckLine43 = false;
                FillModel.Filling(DataLines.wnd.line37, DataLines.X2, DataLines.anLine37);
                FillModel.FillingAsync(20, DataLines.wnd.line41, DataLines.Y2, DataLines.anLine41);
                FillModel.FillingAsync(280, DataLines.wnd.line39, DataLines.Y2, DataLines.anLine39);
            }



            if (StateButton.Button[2].IsState == true && DataLines.wnd.line2.Opacity == 1 && DataLines.wnd.line43.Opacity == 0 && DataLines.ChckLine2 == true)
            {
                DataLines.ChckLine2 = false;
                FillModel.Filling(DataLines.wnd.line43, DataLines.X2, DataLines.anLine43);
                FillModel.FillingAsync(230, DataLines.wnd.line45, DataLines.Y2, DataLines.anLine45);
            }
        }
    }
}
