using System;
using System.Collections.Generic;
using System.Text;

namespace WinodwSize
{
    class CheckStateWater
    {
        public static void Check()
        {
            Animation.CheckAnimation();
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
                FillModel.Filling(DataLines.wnd.line0, DataLines.Y2, DataLines.anLine0, DataLines.DoneAnim0);
                FillModel.FillingAsync(300, DataLines.wnd.line1, DataLines.X2, DataLines.anLine1, DataLines.DoneAnim1);
                FillModel.FillingAsync(300, DataLines.wnd.line2, DataLines.X2, DataLines.anLine2, DataLines.DoneAnim2);
                FillModel.FillingAsync(600, DataLines.wnd.line3, DataLines.Y2, DataLines.anLine3, DataLines.DoneAnim3);
            }

            if (StateButton.ButtonV[12].IsState == true && DataLines.wnd.line3.Opacity == 1 && DataLines.wnd.line5.Opacity == 0 && DataLines.ChckLine3 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine3 = false;
                FillModel.Filling(DataLines.wnd.line5, DataLines.Y2, DataLines.anLine5, DataLines.DoneAnim5);
                FillModel.FillingAsync(300, DataLines.wnd.line7, DataLines.X2, DataLines.anLine7, DataLines.DoneAnim7);
                FillModel.FillingAsync(300, DataLines.wnd.line9, DataLines.X2, DataLines.anLine9, DataLines.DoneAnim9);
                FillModel.FillingAsync(600, DataLines.wnd.line10, DataLines.Y2, DataLines.anLine10, DataLines.DoneAnim10);
            }



            if (StateButton.Button[7].IsState == true && DataLines.wnd.line7.Opacity == 1 && DataLines.wnd.line13.Opacity == 0 && DataLines.ChckLine7 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine7 = false;
                FillModel.Filling(DataLines.wnd.line13, DataLines.X2, DataLines.anLine13, DataLines.DoneAnim13);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line14);
                DataLines.ChckLine14 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line16, DataLines.Y2, DataLines.anLine16, DataLines.DoneAnim16);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line15);
                DataLines.ChckLine15 = true;
            }
            if (StateButton.Button[7].IsState == true && DataLines.wnd.line14.Opacity == 1 && DataLines.wnd.line8.Opacity == 0 && DataLines.ChckLine14 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine14 = false;
                FillModel.Filling(DataLines.wnd.line8, DataLines.X2, DataLines.anLine8, DataLines.DoneAnim8);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line7);
                DataLines.ChckLine7 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line6, DataLines.Y2, DataLines.anLine6, DataLines.DoneAnim6);
                FillModel.FillingAsync(300, DataLines.wnd.line9, DataLines.X2, DataLines.anLine9, DataLines.DoneAnim9);
                FillModel.FillingAsync(600, DataLines.wnd.line10, DataLines.Y2, DataLines.anLine10, DataLines.DoneAnim10);
            }



            if (StateButton.Button[6].IsState == true && DataLines.wnd.line13.Opacity == 1 && DataLines.wnd.line17.Opacity == 0 && DataLines.ChckLine13 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine13 = false;
                FillModel.Filling(DataLines.wnd.line17, DataLines.X2, DataLines.anLine17, DataLines.DoneAnim17);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line18);
                DataLines.ChckLine18 = true;
                FillModel.FillingAsync(100, DataLines.wnd.line20, DataLines.Y2, DataLines.anLine20, DataLines.DoneAnim20);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line19);
                DataLines.ChckLine19 = true;
                FillModel.FillingAsync(280, DataLines.wnd.line22, DataLines.Y2, DataLines.anLine22, DataLines.DoneAnim22);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line21);
                DataLines.ChckLine21 = true;
            }
            if (StateButton.Button[6].IsState == true && DataLines.wnd.line18.Opacity == 1 && DataLines.wnd.line14.Opacity == 0 && DataLines.ChckLine18 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine18 = false;
                FillModel.Filling(DataLines.wnd.line14, DataLines.X2, DataLines.anLine14, DataLines.DoneAnim14);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line13);
                DataLines.ChckLine13 = true;
                FillModel.FillingAsync(100, DataLines.wnd.line16, DataLines.Y2, DataLines.anLine16, DataLines.DoneAnim16);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line15);
                DataLines.ChckLine15 = true;
            }



            if (StateButton.Button[5].IsState == true && DataLines.wnd.line17.Opacity == 1 && DataLines.wnd.line25.Opacity == 0 && DataLines.ChckLine17 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine17 = false;
                FillModel.Filling(DataLines.wnd.line25, DataLines.X2, DataLines.anLine25, DataLines.DoneAnim25);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line26);
                DataLines.ChckLine26 = true;
                FillModel.Filling(DataLines.wnd.line24, DataLines.Y2, DataLines.anLine24, DataLines.DoneAnim24);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line23);
                DataLines.ChckLine23 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line28, DataLines.Y2, DataLines.anLine28, DataLines.DoneAnim28);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line28);
                DataLines.ChckLine28 = true;
            }
            if (StateButton.Button[5].IsState == true && DataLines.wnd.line26.Opacity == 1 && DataLines.wnd.line18.Opacity == 0 && DataLines.ChckLine26 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine26 = false;
                FillModel.Filling(DataLines.wnd.line18, DataLines.X2, DataLines.anLine18, DataLines.DoneAnim18);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line17);
                DataLines.ChckLine17 = true;
                FillModel.Filling(DataLines.wnd.line22, DataLines.Y2, DataLines.anLine22, DataLines.DoneAnim22);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line21);
                DataLines.ChckLine21 = true;
                FillModel.FillingAsync(280, DataLines.wnd.line20, DataLines.Y2, DataLines.anLine20, DataLines.DoneAnim20);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line19);
                DataLines.ChckLine19 = true;
            }



            if (StateButton.ButtonV[9].IsState == true && DataLines.wnd.line28.Opacity == 1 && DataLines.wnd.line30.Opacity == 0 && DataLines.ChckLine28 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine28 = false;
                FillModel.Filling(DataLines.wnd.line30, DataLines.Y2, DataLines.anLine30, DataLines.DoneAnim30);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line29);
                DataLines.ChckLine29 = true;
                FillModel.FillingAsync(150, DataLines.wnd.line72, DataLines.X2, DataLines.anLine72, DataLines.DoneAnim72);
            }
            if (StateButton.ButtonV[9].IsState == true && DataLines.wnd.line29.Opacity == 1 && DataLines.wnd.line27.Opacity == 0 && DataLines.ChckLine29 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine29 = false;
                FillModel.Filling(DataLines.wnd.line27, DataLines.Y2, DataLines.anLine27, DataLines.DoneAnim27);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line28);
                DataLines.ChckLine28 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line26, DataLines.X2, DataLines.anLine26, DataLines.DoneAnim26);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line25);
                DataLines.ChckLine25 = true;
                FillModel.FillingAsync(600, DataLines.wnd.line24, DataLines.Y2, DataLines.anLine24, DataLines.DoneAnim24);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line23);
                DataLines.ChckLine23 = true;
            }



            if (StateButton.ButtonV[8].IsState == true && DataLines.wnd.line30.Opacity == 1 && DataLines.wnd.line32.Opacity == 0 && DataLines.ChckLine30 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine30 = false;
                FillModel.Filling(DataLines.wnd.line32, DataLines.Y2, DataLines.anLine32, DataLines.DoneAnim32);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line31);
                DataLines.ChckLine31 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line34, DataLines.X2, DataLines.anLine34, DataLines.DoneAnim34);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line33);
                DataLines.ChckLine33 = true;
                FillModel.FillingAsync(600, DataLines.wnd.line35, DataLines.Y2, DataLines.anLine35, DataLines.DoneAnim35);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line36);
                DataLines.ChckLine36 = true;
            }
            if (StateButton.ButtonV[8].IsState == true && DataLines.wnd.line31.Opacity == 1 && DataLines.wnd.line29.Opacity == 0 && DataLines.ChckLine31 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine31 = false;
                FillModel.Filling(DataLines.wnd.line29, DataLines.Y2, DataLines.anLine29, DataLines.DoneAnim29);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line30);
                DataLines.ChckLine30 = true;
                FillModel.FillingAsync(150, DataLines.wnd.line72, DataLines.X2, DataLines.anLine72, DataLines.DoneAnim72);
            }



            if (StateButton.Button[4].IsState == true && DataLines.wnd.line34.Opacity == 1 && DataLines.wnd.line38.Opacity == 0 && DataLines.ChckLine34 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine34 = false;
                FillModel.Filling(DataLines.wnd.line38, DataLines.X2, DataLines.anLine38, DataLines.DoneAnim38);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line37);
                DataLines.ChckLine37 = true;
                FillModel.FillingAsync(20, DataLines.wnd.line39, DataLines.Y2, DataLines.anLine39, DataLines.DoneAnim39);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line40);
                DataLines.ChckLine40 = true;
                FillModel.FillingAsync(270, DataLines.wnd.line41, DataLines.Y2, DataLines.anLine41, DataLines.DoneAnim41);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line42);
                DataLines.ChckLine42 = true;
            }
            if (StateButton.Button[4].IsState == true && DataLines.wnd.line37.Opacity == 1 && DataLines.wnd.line33.Opacity == 0 && DataLines.ChckLine37 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine37 = false;
                FillModel.Filling(DataLines.wnd.line33, DataLines.X2, DataLines.anLine33, DataLines.DoneAnim33);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line34);
                DataLines.ChckLine34 = true;
                FillModel.FillingAsync(20, DataLines.wnd.line35, DataLines.Y2, DataLines.anLine35, DataLines.DoneAnim35);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line36);
                DataLines.ChckLine36 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line31, DataLines.Y2, DataLines.anLine31, DataLines.DoneAnim31);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line32);
                DataLines.ChckLine32 = true;
            }



            if (StateButton.Button[3].IsState == true && DataLines.wnd.line38.Opacity == 1 && DataLines.wnd.line44.Opacity == 0 && DataLines.ChckLine38 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine38 = false;
                FillModel.Filling(DataLines.wnd.line44, DataLines.X2, DataLines.anLine44, DataLines.DoneAnim44);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line43);
                DataLines.ChckLine43 = true;
                FillModel.FillingAsync(75, DataLines.wnd.line45, DataLines.Y2, DataLines.anLine45, DataLines.DoneAnim45);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line46);
                DataLines.ChckLine46 = true;
            }
            if (StateButton.Button[3].IsState == true && DataLines.wnd.line43.Opacity == 1 && DataLines.wnd.line37.Opacity == 0 && DataLines.ChckLine43 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine43 = false;
                FillModel.Filling(DataLines.wnd.line37, DataLines.X2, DataLines.anLine37, DataLines.DoneAnim37);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line38);
                DataLines.ChckLine38 = true;
                FillModel.FillingAsync(20, DataLines.wnd.line41, DataLines.Y2, DataLines.anLine41, DataLines.DoneAnim41);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line42);
                DataLines.ChckLine42 = true;
                FillModel.FillingAsync(280, DataLines.wnd.line39, DataLines.Y2, DataLines.anLine39, DataLines.DoneAnim39);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line40);
                DataLines.ChckLine40 = true;
            }



            if (StateButton.Button[2].IsState == true && DataLines.wnd.line2.Opacity == 1 && DataLines.wnd.line43.Opacity == 0 && DataLines.ChckLine2 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine2 = false;
                FillModel.Filling(DataLines.wnd.line43, DataLines.X2, DataLines.anLine43, DataLines.DoneAnim43);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line44);
                DataLines.ChckLine44 = true;
                FillModel.FillingAsync(230, DataLines.wnd.line45, DataLines.Y2, DataLines.anLine45, DataLines.DoneAnim45);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line46);
                DataLines.ChckLine46 = true;
            }



            if (StateButton.ButtonV[0].IsState == true && DataLines.wnd.line45.Opacity == 1 && DataLines.wnd.line47.Opacity == 0 && DataLines.ChckLine45 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine45 = false;
                FillModel.Filling(DataLines.wnd.line47, DataLines.Y2, DataLines.anLine47, DataLines.DoneAnim47);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line48);
                DataLines.ChckLine48 = true;
                FillModel.FillingAsync(150, DataLines.wnd.line49, DataLines.X2, DataLines.anLine49, DataLines.DoneAnim49);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line50);
                DataLines.ChckLine50 = true;
                FillModel.FillingAsync(220, DataLines.wnd.line52, DataLines.X2, DataLines.anLine52, DataLines.DoneAnim52);
            }
            if (StateButton.ButtonV[0].IsState == true && DataLines.wnd.line48.Opacity == 1 && DataLines.wnd.line46.Opacity == 0 && DataLines.ChckLine48 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine48 = false;
                FillModel.Filling(DataLines.wnd.line46, DataLines.Y2, DataLines.anLine46, DataLines.DoneAnim46);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line45);
                DataLines.ChckLine45 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line44);
                DataLines.ChckLine44 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line43);
                DataLines.ChckLine43 = true;
            }



            if (StateButton.ButtonV[1].IsState == true && DataLines.wnd.line41.Opacity == 1 && DataLines.wnd.line53.Opacity == 0 && DataLines.ChckLine41 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine41 = false;
                FillModel.Filling(DataLines.wnd.line53, DataLines.Y2, DataLines.anLine53, DataLines.DoneAnim53);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line54);
                DataLines.ChckLine54 = true;
                FillModel.FillingAsync(150, DataLines.wnd.line56, DataLines.X2, DataLines.anLine56, DataLines.DoneAnim56);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line55);
                DataLines.ChckLine55 = true;
                FillModel.FillingAsync(220, DataLines.wnd.line57, DataLines.X2, DataLines.anLine57, DataLines.DoneAnim57);
            }
            if (StateButton.ButtonV[1].IsState == true && DataLines.wnd.line54.Opacity == 1 && DataLines.wnd.line42.Opacity == 0 && DataLines.ChckLine54 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine54 = false;
                FillModel.Filling(DataLines.wnd.line42, DataLines.Y2, DataLines.anLine42, DataLines.DoneAnim42);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line41);
                DataLines.ChckLine41 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line37);
                DataLines.ChckLine37 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line38);
                DataLines.ChckLine38 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line39, DataLines.Y2, DataLines.anLine39, DataLines.DoneAnim39);
                FillModel.OnlyOpacity(DataLines.wnd.line40);
                DataLines.ChckLine40 = true;
            }



            if (StateButton.ButtonV[2].IsState == true && DataLines.wnd.line16.Opacity == 1 && DataLines.wnd.line48.Opacity == 0 && DataLines.ChckLine16 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine16 = false;
                FillModel.Filling(DataLines.wnd.line48, DataLines.Y2, DataLines.anLine48, DataLines.DoneAnim48);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line47);
                DataLines.ChckLine47 = true;
                FillModel.FillingAsync(80, DataLines.wnd.line52, DataLines.X2, DataLines.anLine52, DataLines.DoneAnim52);
                FillModel.FillingAsync(150, DataLines.wnd.line49, DataLines.X2, DataLines.anLine49, DataLines.DoneAnim49);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line50);
                DataLines.ChckLine50 = true;
            }
            if (StateButton.ButtonV[2].IsState == true && DataLines.wnd.line47.Opacity == 1 && DataLines.wnd.line15.Opacity == 0 && DataLines.ChckLine47 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine47 = false;
                FillModel.Filling(DataLines.wnd.line15, DataLines.Y2, DataLines.anLine15, DataLines.DoneAnim15);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line16);
                DataLines.ChckLine16 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line13);
                DataLines.ChckLine13 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line14);
                DataLines.ChckLine14 = true;
            }



            if (StateButton.ButtonV[3].IsState == true && DataLines.wnd.line20.Opacity == 1 && DataLines.wnd.line54.Opacity == 0 && DataLines.ChckLine20 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine20 = false;
                FillModel.Filling(DataLines.wnd.line54, DataLines.Y2, DataLines.anLine54, DataLines.DoneAnim54);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line53);
                DataLines.ChckLine53 = true;
                FillModel.FillingAsync(80, DataLines.wnd.line57, DataLines.X2, DataLines.anLine57, DataLines.DoneAnim57);
                FillModel.FillingAsync(150, DataLines.wnd.line56, DataLines.X2, DataLines.anLine56, DataLines.DoneAnim56);
                FillModel.OnlyOpacity(DataLines.wnd.line55);
                DataLines.ChckLine55 = true;
            }
            if (StateButton.ButtonV[3].IsState == true && DataLines.wnd.line53.Opacity == 1 && DataLines.wnd.line19.Opacity == 0 && DataLines.ChckLine53 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine53 = false;
                FillModel.Filling(DataLines.wnd.line19, DataLines.Y2, DataLines.anLine19, DataLines.DoneAnim19);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line20);
                DataLines.ChckLine20 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line17);
                DataLines.ChckLine17 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line18);
                DataLines.ChckLine18 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line22, DataLines.Y2, DataLines.anLine22, DataLines.DoneAnim22);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line21);
                DataLines.ChckLine21 = true;
            }



            if (StateButton.ButtonV[4].IsState == true && DataLines.wnd.line39.Opacity == 1 && DataLines.wnd.line59.Opacity == 0 && DataLines.ChckLine39 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine39 = false;
                FillModel.Filling(DataLines.wnd.line59, DataLines.Y2, DataLines.anLine59, DataLines.DoneAnim59);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line60);
                DataLines.ChckLine60 = true;
                FillModel.FillingAsync(80, DataLines.wnd.line64, DataLines.X2, DataLines.anLine64, DataLines.DoneAnim64);
                FillModel.FillingAsync(150, DataLines.wnd.line61, DataLines.X2, DataLines.anLine61, DataLines.DoneAnim61);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line62);
                DataLines.ChckLine62 = true;
            }
            if (StateButton.ButtonV[4].IsState == true && DataLines.wnd.line60.Opacity == 1 && DataLines.wnd.line40.Opacity == 0 && DataLines.ChckLine60 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine60 = false;
                FillModel.Filling(DataLines.wnd.line40, DataLines.Y2, DataLines.anLine40, DataLines.DoneAnim40);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line39);
                DataLines.ChckLine39 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line38);
                DataLines.ChckLine38 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line37);
                DataLines.ChckLine37 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line41, DataLines.Y2, DataLines.anLine41, DataLines.DoneAnim41);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line42);
                DataLines.ChckLine42 = true;
            }



            if (StateButton.ButtonV[5].IsState == true && DataLines.wnd.line35.Opacity == 1 && DataLines.wnd.line65.Opacity == 0 && DataLines.ChckLine35 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine35 = false;
                FillModel.Filling(DataLines.wnd.line65, DataLines.Y2, DataLines.anLine65, DataLines.DoneAnim65);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line66);
                DataLines.ChckLine66 = true;
                FillModel.FillingAsync(20, DataLines.wnd.line69, DataLines.X2, DataLines.anLine69, DataLines.DoneAnim69);
                FillModel.FillingAsync(140, DataLines.wnd.line68, DataLines.X2, DataLines.anLine68, DataLines.DoneAnim68);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line67);
                DataLines.ChckLine67 = true;
            }
            if (StateButton.ButtonV[5].IsState == true && DataLines.wnd.line66.Opacity == 1 && DataLines.wnd.line36.Opacity == 0 && DataLines.ChckLine66 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine66 = false;
                FillModel.Filling(DataLines.wnd.line36, DataLines.Y2, DataLines.anLine36, DataLines.DoneAnim36);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line35);
                DataLines.ChckLine35 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line33, DataLines.X2, DataLines.anLine33, DataLines.DoneAnim33);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line34);
                DataLines.ChckLine34 = true;
                FillModel.FillingAsync(140, DataLines.wnd.line31, DataLines.Y2, DataLines.anLine31, DataLines.DoneAnim31);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line32);
                DataLines.ChckLine32 = true;
            }



            if (StateButton.ButtonV[6].IsState == true && DataLines.wnd.line22.Opacity == 1 && DataLines.wnd.line60.Opacity == 0 && DataLines.ChckLine22 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine22 = false;
                FillModel.Filling(DataLines.wnd.line60, DataLines.Y2, DataLines.anLine60, DataLines.DoneAnim60);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line59);
                DataLines.ChckLine59 = true;
                FillModel.FillingAsync(20, DataLines.wnd.line61, DataLines.X2, DataLines.anLine61, DataLines.DoneAnim61);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line62);
                DataLines.ChckLine62 = true;
                FillModel.FillingAsync(280, DataLines.wnd.line64, DataLines.X2, DataLines.anLine64, DataLines.DoneAnim64);
            }
            if (StateButton.ButtonV[6].IsState == true && DataLines.wnd.line59.Opacity == 1 && DataLines.wnd.line21.Opacity == 0 && DataLines.ChckLine59 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine59 = false;
                FillModel.Filling(DataLines.wnd.line21, DataLines.Y2, DataLines.anLine21, DataLines.DoneAnim21);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line22);
                DataLines.ChckLine22 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line18);
                DataLines.ChckLine18 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line17);
                DataLines.ChckLine17 = true;
                FillModel.FillingAsync(280, DataLines.wnd.line20, DataLines.Y2, DataLines.anLine20, DataLines.DoneAnim20);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line19);
                DataLines.ChckLine19 = true;
            }



            if (StateButton.ButtonV[7].IsState == true && DataLines.wnd.line24.Opacity == 1 && DataLines.wnd.line66.Opacity == 0 && DataLines.ChckLine24 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine24 = false;
                FillModel.Filling(DataLines.wnd.line66, DataLines.Y2, DataLines.anLine66, DataLines.DoneAnim66);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line65);
                DataLines.ChckLine65 = true;
                FillModel.FillingAsync(150, DataLines.wnd.line68, DataLines.X2, DataLines.anLine68, DataLines.DoneAnim68);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line67);
                DataLines.ChckLine67 = true;
                FillModel.FillingAsync(280, DataLines.wnd.line69, DataLines.X2, DataLines.anLine69, DataLines.DoneAnim69);
            }
            if (StateButton.ButtonV[7].IsState == true && DataLines.wnd.line65.Opacity == 1 && DataLines.wnd.line23.Opacity == 0 && DataLines.ChckLine65 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine65 = false;
                FillModel.Filling(DataLines.wnd.line23, DataLines.Y2, DataLines.anLine23, DataLines.DoneAnim23);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line24);
                DataLines.ChckLine24 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line25, DataLines.X2, DataLines.anLine25, DataLines.DoneAnim25);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line26);
                DataLines.ChckLine26 = true;
                FillModel.FillingAsync(600, DataLines.wnd.line28, DataLines.Y2, DataLines.anLine28, DataLines.DoneAnim18);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line27);
                DataLines.ChckLine27 = true;
            }



            if (StateButton.ButtonSml[0].IsState == true && DataLines.wnd.line49.Opacity == 1 && DataLines.wnd.line55.Opacity == 0 && DataLines.ChckLine49 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine49 = false;
                FillModel.Filling(DataLines.wnd.line55, DataLines.X2, DataLines.anLine55, DataLines.DoneAnim55);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line56);
                DataLines.ChckLine56 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line53);
                DataLines.ChckLine53 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line54);
                DataLines.ChckLine54 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line57, DataLines.X2, DataLines.anLine57, DataLines.DoneAnim57);
            }
            if (StateButton.ButtonSml[0].IsState == true && DataLines.wnd.line56.Opacity == 1 && DataLines.wnd.line50.Opacity == 0 && DataLines.ChckLine56 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine56 = false;
                FillModel.Filling(DataLines.wnd.line50, DataLines.X2, DataLines.anLine50, DataLines.DoneAnim50);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line49);
                DataLines.ChckLine49 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line47);
                DataLines.ChckLine47 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line48);
                DataLines.ChckLine48 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line52, DataLines.X2, DataLines.anLine52, DataLines.DoneAnim52);
            }



            if (StateButton.ButtonSml[1].IsState == true && DataLines.wnd.line61.Opacity == 1 && DataLines.wnd.line67.Opacity == 0 && DataLines.ChckLine61 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine61 = false;
                FillModel.Filling(DataLines.wnd.line67, DataLines.X2, DataLines.anLine67, DataLines.DoneAnim67);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line68);
                DataLines.ChckLine68 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line65);
                DataLines.ChckLine65 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line66);
                DataLines.ChckLine66 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line69, DataLines.X2, DataLines.anLine69, DataLines.DoneAnim69);
            }
            if (StateButton.ButtonSml[1].IsState == true && DataLines.wnd.line68.Opacity == 1 && DataLines.wnd.line62.Opacity == 0 && DataLines.ChckLine68 == true && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine68 = false;
                FillModel.Filling(DataLines.wnd.line62, DataLines.X2, DataLines.anLine62, DataLines.DoneAnim62);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line61);
                DataLines.ChckLine61 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line59);
                DataLines.ChckLine59 = true;
                FillModel.OnlyOpacityAsync(DataLines.wnd.line60);
                DataLines.ChckLine60 = true;
                FillModel.FillingAsync(300, DataLines.wnd.line64, DataLines.X2, DataLines.anLine64, DataLines.DoneAnim64);
            }

            if (StateButton.ButtonV[10].IsState == true && StateButton.ButtonV[11].IsState == true
                && DataLines.wnd.line10.Opacity == 1 && DataLines.wnd.line11.Opacity == 0 && DataLines.ChckLine10 == true
                && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true)
            {
                DataLines.ChckLine10 = false;
                FillModel.Filling(DataLines.wnd.line11, DataLines.Y2, DataLines.anLine11, DataLines.DoneAnim11);
                FillModel.FillingAsync(300, DataLines.wnd.line12, DataLines.X2, DataLines.anLine12, DataLines.DoneAnim12);
            }
        }
    }
}
