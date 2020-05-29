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
                FillModel.Filling(DataLines.wnd.line0, DataLines.Y2, DataLines.anLine0, DataLines.DoneAnim0);
                FillModel.FillingAsync(300, DataLines.wnd.line1, DataLines.X2, DataLines.anLine1, DataLines.DoneAnim1);
                FillModel.FillingAsync(300, DataLines.wnd.line2, DataLines.X2, DataLines.anLine2, DataLines.DoneAnim2);
                FillModel.FillingAsync(600, DataLines.wnd.line3, DataLines.Y2, DataLines.anLine3, DataLines.DoneAnim3);
            }

            if (StateButton.ButtonV[12].IsState == true && DataLines.wnd.line3.Opacity == 1 && DataLines.wnd.line5.Opacity == 0 && DataLines.ChckLine3 == true)
            {
                DataLines.ChckLine3 = false;
                FillModel.Filling(DataLines.wnd.line5, DataLines.Y2, DataLines.anLine5, DataLines.DoneAnim5);
                FillModel.FillingAsync(300, DataLines.wnd.line7, DataLines.X2, DataLines.anLine7, DataLines.DoneAnim7);
                FillModel.FillingAsync(300, DataLines.wnd.line9, DataLines.X2, DataLines.anLine9, DataLines.DoneAnim9);
                FillModel.FillingAsync(600, DataLines.wnd.line10, DataLines.Y2, DataLines.anLine10, DataLines.DoneAnim10);
            }



            if (StateButton.Button[7].IsState == true && DataLines.wnd.line7.Opacity == 1 && DataLines.wnd.line13.Opacity == 0 && DataLines.ChckLine7 == true)
            {
                DataLines.ChckLine7 = false;
                FillModel.Filling(DataLines.wnd.line13, DataLines.X2, DataLines.anLine13, DataLines.DoneAnim13);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line14);
                FillModel.FillingAsync(300, DataLines.wnd.line16, DataLines.Y2, DataLines.anLine16, DataLines.DoneAnim16);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line15);
            }
            if (StateButton.Button[7].IsState == true && DataLines.wnd.line14.Opacity == 1 && DataLines.wnd.line8.Opacity == 0 && DataLines.ChckLine14 == true)
            {
                DataLines.ChckLine14 = false;
                FillModel.Filling(DataLines.wnd.line8, DataLines.X2, DataLines.anLine8, DataLines.DoneAnim8);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line7);
                FillModel.FillingAsync(300, DataLines.wnd.line6, DataLines.Y2, DataLines.anLine6, DataLines.DoneAnim6);
                FillModel.FillingAsync(300, DataLines.wnd.line9, DataLines.X2, DataLines.anLine9, DataLines.DoneAnim9);
                FillModel.FillingAsync(600, DataLines.wnd.line10, DataLines.Y2, DataLines.anLine10, DataLines.DoneAnim10);
            }



            if (StateButton.Button[6].IsState == true && DataLines.wnd.line13.Opacity == 1 && DataLines.wnd.line17.Opacity == 0 && DataLines.ChckLine13 == true)
            {
                DataLines.ChckLine13 = false;
                FillModel.Filling(DataLines.wnd.line17, DataLines.X2, DataLines.anLine17, DataLines.DoneAnim17);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line18);
                FillModel.FillingAsync(100, DataLines.wnd.line20, DataLines.Y2, DataLines.anLine20, DataLines.DoneAnim20);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line19);
                FillModel.FillingAsync(280, DataLines.wnd.line22, DataLines.Y2, DataLines.anLine22, DataLines.DoneAnim22);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line21);
            }
            if (StateButton.Button[6].IsState == true && DataLines.wnd.line18.Opacity == 1 && DataLines.wnd.line14.Opacity == 0 && DataLines.ChckLine18 == true)
            {
                DataLines.ChckLine18 = false;
                FillModel.Filling(DataLines.wnd.line14, DataLines.X2, DataLines.anLine14, DataLines.DoneAnim14);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line13);
                FillModel.FillingAsync(100, DataLines.wnd.line16, DataLines.Y2, DataLines.anLine16, DataLines.DoneAnim16);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line15);
            }



            if (StateButton.Button[5].IsState == true && DataLines.wnd.line17.Opacity == 1 && DataLines.wnd.line25.Opacity == 0 && DataLines.ChckLine17 == true)
            {
                DataLines.ChckLine17 = false;
                FillModel.Filling(DataLines.wnd.line25, DataLines.X2, DataLines.anLine25, DataLines.DoneAnim25);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line26);
                FillModel.Filling(DataLines.wnd.line24, DataLines.Y2, DataLines.anLine24, DataLines.DoneAnim24);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line23);
                FillModel.FillingAsync(300, DataLines.wnd.line28, DataLines.Y2, DataLines.anLine28, DataLines.DoneAnim28);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line28);
            }
            if (StateButton.Button[5].IsState == true && DataLines.wnd.line26.Opacity == 1 && DataLines.wnd.line18.Opacity == 0 && DataLines.ChckLine26 == true)
            {
                DataLines.ChckLine26 = false;
                FillModel.Filling(DataLines.wnd.line18, DataLines.X2, DataLines.anLine18, DataLines.DoneAnim18);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line17);
                FillModel.Filling(DataLines.wnd.line22, DataLines.Y2, DataLines.anLine22, DataLines.DoneAnim22);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line21);
                FillModel.FillingAsync(280, DataLines.wnd.line20, DataLines.Y2, DataLines.anLine20, DataLines.DoneAnim20);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line19);
            }



            if (StateButton.ButtonV[9].IsState == true && DataLines.wnd.line28.Opacity == 1 && DataLines.wnd.line30.Opacity == 0 && DataLines.ChckLine28 == true)
            {
                DataLines.ChckLine28 = false;
                FillModel.Filling(DataLines.wnd.line30, DataLines.Y2, DataLines.anLine30, DataLines.DoneAnim30);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line29);
                FillModel.FillingAsync(150, DataLines.wnd.line72, DataLines.X2, DataLines.anLine72, DataLines.DoneAnim72);
            }
            if (StateButton.ButtonV[9].IsState == true && DataLines.wnd.line29.Opacity == 1 && DataLines.wnd.line27.Opacity == 0 && DataLines.ChckLine29 == true)
            {
                DataLines.ChckLine29 = false;
                FillModel.Filling(DataLines.wnd.line27, DataLines.Y2, DataLines.anLine27, DataLines.DoneAnim27);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line28);
                FillModel.FillingAsync(300, DataLines.wnd.line26, DataLines.X2, DataLines.anLine26, DataLines.DoneAnim26);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line25);
                FillModel.FillingAsync(600, DataLines.wnd.line24, DataLines.Y2, DataLines.anLine24, DataLines.DoneAnim24);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line23);
            }



            if (StateButton.ButtonV[8].IsState == true && DataLines.wnd.line30.Opacity == 1 && DataLines.wnd.line32.Opacity == 0 && DataLines.ChckLine30 == true)
            {
                DataLines.ChckLine30 = false;
                FillModel.Filling(DataLines.wnd.line32, DataLines.Y2, DataLines.anLine32, DataLines.DoneAnim32);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line31);
                FillModel.FillingAsync(300, DataLines.wnd.line34, DataLines.X2, DataLines.anLine34, DataLines.DoneAnim34);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line33);
                FillModel.FillingAsync(600, DataLines.wnd.line35, DataLines.Y2, DataLines.anLine35, DataLines.DoneAnim35);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line36);
            }
            if (StateButton.ButtonV[8].IsState == true && DataLines.wnd.line31.Opacity == 1 && DataLines.wnd.line29.Opacity == 0 && DataLines.ChckLine31 == true)
            {
                DataLines.ChckLine31 = false;
                FillModel.Filling(DataLines.wnd.line29, DataLines.Y2, DataLines.anLine29, DataLines.DoneAnim29);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line30);
                FillModel.FillingAsync(150, DataLines.wnd.line72, DataLines.X2, DataLines.anLine72, DataLines.DoneAnim72);
            }



            if (StateButton.Button[4].IsState == true && DataLines.wnd.line34.Opacity == 1 && DataLines.wnd.line38.Opacity == 0 && DataLines.ChckLine34 == true)
            {
                DataLines.ChckLine34 = false;
                FillModel.Filling(DataLines.wnd.line38, DataLines.X2, DataLines.anLine38, DataLines.DoneAnim38);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line37);
                FillModel.FillingAsync(20, DataLines.wnd.line39, DataLines.Y2, DataLines.anLine39, DataLines.DoneAnim39);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line40);
                FillModel.FillingAsync(270, DataLines.wnd.line41, DataLines.Y2, DataLines.anLine41, DataLines.DoneAnim41);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line42);
            }
            if (StateButton.Button[4].IsState == true && DataLines.wnd.line37.Opacity == 1 && DataLines.wnd.line33.Opacity == 0 && DataLines.ChckLine37 == true)
            {
                DataLines.ChckLine37 = false;
                FillModel.Filling(DataLines.wnd.line33, DataLines.X2, DataLines.anLine33, DataLines.DoneAnim33);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line34);
                FillModel.FillingAsync(20, DataLines.wnd.line35, DataLines.Y2, DataLines.anLine35, DataLines.DoneAnim35);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line36);
                FillModel.FillingAsync(300, DataLines.wnd.line31, DataLines.Y2, DataLines.anLine31, DataLines.DoneAnim31);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line32);
            }



            if (StateButton.Button[3].IsState == true && DataLines.wnd.line38.Opacity == 1 && DataLines.wnd.line44.Opacity == 0 && DataLines.ChckLine38 == true)
            {
                DataLines.ChckLine38 = false;
                FillModel.Filling(DataLines.wnd.line44, DataLines.X2, DataLines.anLine44, DataLines.DoneAnim44);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line43);
                FillModel.FillingAsync(75, DataLines.wnd.line45, DataLines.Y2, DataLines.anLine45, DataLines.DoneAnim45);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line46);
            }
            if (StateButton.Button[3].IsState == true && DataLines.wnd.line43.Opacity == 1 && DataLines.wnd.line37.Opacity == 0 && DataLines.ChckLine43 == true)
            {
                DataLines.ChckLine43 = false;
                FillModel.Filling(DataLines.wnd.line37, DataLines.X2, DataLines.anLine37, DataLines.DoneAnim37);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line38);
                FillModel.FillingAsync(20, DataLines.wnd.line41, DataLines.Y2, DataLines.anLine41, DataLines.DoneAnim41);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line42);
                FillModel.FillingAsync(280, DataLines.wnd.line39, DataLines.Y2, DataLines.anLine39, DataLines.DoneAnim39);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line40);
            }



            if (StateButton.Button[2].IsState == true && DataLines.wnd.line2.Opacity == 1 && DataLines.wnd.line43.Opacity == 0 && DataLines.ChckLine2 == true)
            {
                DataLines.ChckLine2 = false;
                FillModel.Filling(DataLines.wnd.line43, DataLines.X2, DataLines.anLine43, DataLines.DoneAnim43);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line44);
                FillModel.FillingAsync(230, DataLines.wnd.line45, DataLines.Y2, DataLines.anLine45, DataLines.DoneAnim45);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line46);
            }



            if (StateButton.ButtonV[0].IsState == true && DataLines.wnd.line45.Opacity == 1 && DataLines.wnd.line47.Opacity == 0 && DataLines.ChckLine45 == true)
            {
                DataLines.ChckLine45 = false;
                FillModel.Filling(DataLines.wnd.line47, DataLines.Y2, DataLines.anLine47, DataLines.DoneAnim47);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line48);
                FillModel.FillingAsync(150, DataLines.wnd.line49, DataLines.X2, DataLines.anLine49, DataLines.DoneAnim49);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line50);
                FillModel.FillingAsync(220, DataLines.wnd.line52, DataLines.X2, DataLines.anLine52, DataLines.DoneAnim52);
            }
            if (StateButton.ButtonV[0].IsState == true && DataLines.wnd.line48.Opacity == 1 && DataLines.wnd.line46.Opacity == 0 && DataLines.ChckLine48 == true)
            {
                DataLines.ChckLine48 = false;
                FillModel.Filling(DataLines.wnd.line46, DataLines.Y2, DataLines.anLine46, DataLines.DoneAnim46);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line45);
                FillModel.OnlyOpacity(DataLines.wnd.line44);
                FillModel.OnlyOpacity(DataLines.wnd.line43);
            }



            if (StateButton.ButtonV[1].IsState == true && DataLines.wnd.line41.Opacity == 1 && DataLines.wnd.line53.Opacity == 0 && DataLines.ChckLine41 == true)
            {
                DataLines.ChckLine41 = false;
                FillModel.Filling(DataLines.wnd.line53, DataLines.Y2, DataLines.anLine53, DataLines.DoneAnim53);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line54);
                FillModel.FillingAsync(150, DataLines.wnd.line56, DataLines.X2, DataLines.anLine56, DataLines.DoneAnim56);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line55);
                FillModel.FillingAsync(220, DataLines.wnd.line57, DataLines.X2, DataLines.anLine57, DataLines.DoneAnim57);
            }
            if (StateButton.ButtonV[1].IsState == true && DataLines.wnd.line54.Opacity == 1 && DataLines.wnd.line42.Opacity == 0 && DataLines.ChckLine54 == true)
            {
                DataLines.ChckLine54 = false;
                FillModel.Filling(DataLines.wnd.line42, DataLines.Y2, DataLines.anLine42, DataLines.DoneAnim42);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line41);
                FillModel.OnlyOpacity(DataLines.wnd.line37);
                FillModel.OnlyOpacity(DataLines.wnd.line38);
                FillModel.FillingAsync(300, DataLines.wnd.line39, DataLines.Y2, DataLines.anLine39, DataLines.DoneAnim39);
                FillModel.OnlyOpacity(DataLines.wnd.line40);
            }



            if (StateButton.ButtonV[2].IsState == true && DataLines.wnd.line16.Opacity == 1 && DataLines.wnd.line48.Opacity == 0 && DataLines.ChckLine16 == true)
            {
                DataLines.ChckLine16 = false;
                FillModel.Filling(DataLines.wnd.line48, DataLines.Y2, DataLines.anLine48, DataLines.DoneAnim48);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line47);
                FillModel.FillingAsync(80, DataLines.wnd.line52, DataLines.X2, DataLines.anLine52, DataLines.DoneAnim52);
                FillModel.FillingAsync(150, DataLines.wnd.line49, DataLines.X2, DataLines.anLine49, DataLines.DoneAnim49);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line50);
            }
            if (StateButton.ButtonV[2].IsState == true && DataLines.wnd.line47.Opacity == 1 && DataLines.wnd.line15.Opacity == 0 && DataLines.ChckLine47 == true)
            {
                DataLines.ChckLine47 = false;
                FillModel.Filling(DataLines.wnd.line15, DataLines.Y2, DataLines.anLine15, DataLines.DoneAnim15);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line16);
                FillModel.OnlyOpacity(DataLines.wnd.line13);
                FillModel.OnlyOpacity(DataLines.wnd.line14);
            }



            if (StateButton.ButtonV[3].IsState == true && DataLines.wnd.line20.Opacity == 1 && DataLines.wnd.line54.Opacity == 0 && DataLines.ChckLine20 == true)
            {
                DataLines.ChckLine20 = false;
                FillModel.Filling(DataLines.wnd.line54, DataLines.Y2, DataLines.anLine54, DataLines.DoneAnim54);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line53);
                FillModel.FillingAsync(80, DataLines.wnd.line57, DataLines.X2, DataLines.anLine57, DataLines.DoneAnim57);
                FillModel.FillingAsync(150, DataLines.wnd.line56, DataLines.X2, DataLines.anLine56, DataLines.DoneAnim56);
                FillModel.OnlyOpacity(DataLines.wnd.line55);
            }
            if (StateButton.ButtonV[3].IsState == true && DataLines.wnd.line53.Opacity == 1 && DataLines.wnd.line19.Opacity == 0 && DataLines.ChckLine53 == true)
            {
                DataLines.ChckLine53 = false;
                FillModel.Filling(DataLines.wnd.line19, DataLines.Y2, DataLines.anLine19, DataLines.DoneAnim19);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line20);
                FillModel.OnlyOpacity(DataLines.wnd.line17);
                FillModel.OnlyOpacity(DataLines.wnd.line19);
            }



            if (StateButton.ButtonV[4].IsState == true && DataLines.wnd.line39.Opacity == 1 && DataLines.wnd.line59.Opacity == 0 && DataLines.ChckLine39 == true)
            {
                DataLines.ChckLine39 = false;
                FillModel.Filling(DataLines.wnd.line59, DataLines.Y2, DataLines.anLine59, DataLines.DoneAnim59);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line60);
                FillModel.FillingAsync(80, DataLines.wnd.line64, DataLines.X2, DataLines.anLine64, DataLines.DoneAnim64);
                FillModel.FillingAsync(150, DataLines.wnd.line61, DataLines.X2, DataLines.anLine61, DataLines.DoneAnim61);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line62);
            }
            if (StateButton.ButtonV[4].IsState == true && DataLines.wnd.line60.Opacity == 1 && DataLines.wnd.line40.Opacity == 0 && DataLines.ChckLine60 == true)
            {
                DataLines.ChckLine60 = false;
                FillModel.Filling(DataLines.wnd.line40, DataLines.Y2, DataLines.anLine40, DataLines.DoneAnim40);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line39);
                FillModel.OnlyOpacity(DataLines.wnd.line38);
                FillModel.OnlyOpacity(DataLines.wnd.line37);
                FillModel.FillingAsync(300, DataLines.wnd.line41, DataLines.Y2, DataLines.anLine41, DataLines.DoneAnim41);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line42);
            }



            if (StateButton.ButtonV[5].IsState == true && DataLines.wnd.line35.Opacity == 1 && DataLines.wnd.line65.Opacity == 0 && DataLines.ChckLine35 == true)
            {
                DataLines.ChckLine35 = false;
                FillModel.Filling(DataLines.wnd.line65, DataLines.Y2, DataLines.anLine65, DataLines.DoneAnim65);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line66);
                FillModel.FillingAsync(20, DataLines.wnd.line69, DataLines.X2, DataLines.anLine69, DataLines.DoneAnim69);
                FillModel.FillingAsync(140, DataLines.wnd.line68, DataLines.X2, DataLines.anLine68, DataLines.DoneAnim68);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line67);
            }
            if (StateButton.ButtonV[5].IsState == true && DataLines.wnd.line66.Opacity == 1 && DataLines.wnd.line36.Opacity == 0 && DataLines.ChckLine66 == true)
            {
                DataLines.ChckLine66 = false;
                FillModel.Filling(DataLines.wnd.line36, DataLines.Y2, DataLines.anLine36, DataLines.DoneAnim36);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line35);
                FillModel.FillingAsync(300, DataLines.wnd.line33, DataLines.X2, DataLines.anLine33, DataLines.DoneAnim33);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line34);
                FillModel.FillingAsync(140, DataLines.wnd.line31, DataLines.Y2, DataLines.anLine31, DataLines.DoneAnim31);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line32);
            }



            if (StateButton.ButtonV[6].IsState == true && DataLines.wnd.line22.Opacity == 1 && DataLines.wnd.line60.Opacity == 0 && DataLines.ChckLine22 == true)
            {
                DataLines.ChckLine22 = false;
                FillModel.Filling(DataLines.wnd.line60, DataLines.Y2, DataLines.anLine60, DataLines.DoneAnim60);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line59);
                FillModel.FillingAsync(20, DataLines.wnd.line61, DataLines.X2, DataLines.anLine61, DataLines.DoneAnim61);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line62);
                FillModel.FillingAsync(280, DataLines.wnd.line64, DataLines.X2, DataLines.anLine64, DataLines.DoneAnim64);
            }
            if (StateButton.ButtonV[6].IsState == true && DataLines.wnd.line59.Opacity == 1 && DataLines.wnd.line21.Opacity == 0 && DataLines.ChckLine59 == true)
            {
                DataLines.ChckLine59 = false;
                FillModel.Filling(DataLines.wnd.line21, DataLines.Y2, DataLines.anLine21, DataLines.DoneAnim21);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line22);
                FillModel.OnlyOpacity(DataLines.wnd.line18);
                FillModel.OnlyOpacity(DataLines.wnd.line17);
                FillModel.FillingAsync(280, DataLines.wnd.line20, DataLines.Y2, DataLines.anLine20, DataLines.DoneAnim20);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line19);
            }



            if (StateButton.ButtonV[7].IsState == true && DataLines.wnd.line24.Opacity == 1 && DataLines.wnd.line66.Opacity == 0 && DataLines.ChckLine24 == true)
            {
                DataLines.ChckLine24 = false;
                FillModel.Filling(DataLines.wnd.line66, DataLines.Y2, DataLines.anLine66, DataLines.DoneAnim66);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line65);
                FillModel.FillingAsync(150, DataLines.wnd.line68, DataLines.X2, DataLines.anLine68, DataLines.DoneAnim68);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line67);
                FillModel.FillingAsync(280, DataLines.wnd.line69, DataLines.X2, DataLines.anLine69, DataLines.DoneAnim69);
            }
            if (StateButton.ButtonV[7].IsState == true && DataLines.wnd.line65.Opacity == 1 && DataLines.wnd.line23.Opacity == 0 && DataLines.ChckLine65 == true)
            {
                DataLines.ChckLine65 = false;
                FillModel.Filling(DataLines.wnd.line23, DataLines.Y2, DataLines.anLine23, DataLines.DoneAnim23);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line24);
                FillModel.FillingAsync(300, DataLines.wnd.line25, DataLines.X2, DataLines.anLine25, DataLines.DoneAnim25);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line26);
                FillModel.FillingAsync(600, DataLines.wnd.line28, DataLines.Y2, DataLines.anLine28, DataLines.DoneAnim18);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line27);
            }



            if (StateButton.ButtonSml[0].IsState == true && DataLines.wnd.line49.Opacity == 1 && DataLines.wnd.line55.Opacity == 0 && DataLines.ChckLine49 == true)
            {
                DataLines.ChckLine49 = false;
                FillModel.Filling(DataLines.wnd.line55, DataLines.X2, DataLines.anLine55, DataLines.DoneAnim55);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line56);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line53);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line54);
                FillModel.FillingAsync(300, DataLines.wnd.line57, DataLines.X2, DataLines.anLine57, DataLines.DoneAnim57);
            }
            if (StateButton.ButtonSml[0].IsState == true && DataLines.wnd.line56.Opacity == 1 && DataLines.wnd.line50.Opacity == 0 && DataLines.ChckLine56 == true)
            {
                DataLines.ChckLine56 = false;
                FillModel.Filling(DataLines.wnd.line50, DataLines.X2, DataLines.anLine50, DataLines.DoneAnim50);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line49);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line47);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line48);
                FillModel.FillingAsync(300, DataLines.wnd.line52, DataLines.X2, DataLines.anLine52, DataLines.DoneAnim52);
            }



            if (StateButton.ButtonSml[1].IsState == true && DataLines.wnd.line61.Opacity == 1 && DataLines.wnd.line67.Opacity == 0 && DataLines.ChckLine61 == true)
            {
                DataLines.ChckLine61 = false;
                FillModel.Filling(DataLines.wnd.line67, DataLines.X2, DataLines.anLine67, DataLines.DoneAnim67);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line68);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line65);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line66);
                FillModel.FillingAsync(300, DataLines.wnd.line69, DataLines.X2, DataLines.anLine69, DataLines.DoneAnim69);
            }
            if (StateButton.ButtonSml[1].IsState == true && DataLines.wnd.line68.Opacity == 1 && DataLines.wnd.line62.Opacity == 0 && DataLines.ChckLine68 == true)
            {
                DataLines.ChckLine68 = false;
                FillModel.Filling(DataLines.wnd.line62, DataLines.X2, DataLines.anLine62, DataLines.DoneAnim62);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line61);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line59);
                FillModel.OnlyOpacityAsync(DataLines.wnd.line60);
                FillModel.FillingAsync(300, DataLines.wnd.line64, DataLines.X2, DataLines.anLine64, DataLines.DoneAnim64);
            }
        }
    }
}
