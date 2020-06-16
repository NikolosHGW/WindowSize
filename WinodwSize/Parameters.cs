using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media;

namespace WinodwSize
{
    public class Parameters
    {
        public static double P1 { get; private set; }
        public static int Number1 { get; set; } = 0;
        public static double P2 { get; private set; }
        public static int Number2 { get; set; } = 0;
        public static int T1 { get; private set; }
        public static int Number3 { get; set; } = 0;
        public static int T2 { get; private set; }
        public static int Number4 { get; set; } = 0;
        public static int G1 { get; private set; }
        public static int NumberG1 { get; set; } = 0;
        public static int G2 { get; private set; }
        public static int NumberG2 { get; set; } = 0;
        public static int Gp { get; private set; }
        public static int NumberGp { get; set; } = 0;


        public static void Calc()
        {
            if (Number1 == 0 &&
                StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.ButtonV[12].IsState == true
                && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true && StateButton.Button[5].IsState == true
                && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true && StateButton.Button[4].IsState == true
                && StateButton.Button[3].IsState == true && StateButton.ButtonV[0].IsState == true)
            {
                P1 = 1.5;
                P2 = 1.5;
                Gp = 350;
                Number1 = 1;
            }
            if (DataLines.wnd.line52.Opacity == 1 && Number1 == 1 &&
                StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.ButtonV[12].IsState == true
                && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true && StateButton.Button[5].IsState == true
                && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true && StateButton.Button[4].IsState == true
                && StateButton.Button[3].IsState == true && StateButton.ButtonV[0].IsState == true)
            {
                P1 = 3.0;
                P2 = 3.0;
                G1 = 0;
                Gp = 0;
                Number1 = 2;
            }
            if (DataLines.wnd.line52.Opacity == 1 && StateButton.ButtonSml[2].IsState == true && Number1 == 2 
                && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.ButtonV[12].IsState == true
                && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true && StateButton.Button[5].IsState == true
                && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true && StateButton.Button[4].IsState == true
                && StateButton.Button[3].IsState == true && StateButton.ButtonV[0].IsState == true)
            {
                P1 = 1.5;
                P2 = 1.5;
                G1 = 100;
                Gp = 100;
                Number1 = 3;
            }
            if (DataLines.wnd.line52.Opacity == 1 && StateButton.ButtonSml[2].IsState == false && Number1 == 3
                && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.ButtonV[12].IsState == true
                && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true && StateButton.Button[5].IsState == true
                && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true && StateButton.Button[4].IsState == true
                && StateButton.Button[3].IsState == true && StateButton.ButtonV[0].IsState == true)
            {
                P1 = 3.0;
                P2 = 3.0;
                G1 = 0;
                Gp = 0;
                Number1 = 2;
            }

            if (StateButton.ButtonSml[2].IsState == true && Number2 == 0
                && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.Button[1].IsState == true
                && StateButton.ButtonPmpL[0].IsState == true && StateButton.Button[10].IsState == true && StateButton.ButtonV[11].IsState == true
                && StateButton.ButtonV[10].IsState == true && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true
                && StateButton.Button[5].IsState == true && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true
                && StateButton.Button[4].IsState == true && StateButton.Button[3].IsState == true && StateButton.Button[2].IsState == true)
            {
                P1 = 10;
                P2 = 6;
                G1 = 1000;
                G2 = 800;
                Gp = 200;
                Number1 = -1;
                Number2 = 1;
                Number3 = 1;
            }
            if (StateButton.ButtonSml[2].IsState == false && Number2 == 1
                && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.Button[1].IsState == true
                && StateButton.ButtonPmpL[0].IsState == true && StateButton.Button[10].IsState == true && StateButton.ButtonV[11].IsState == true
                && StateButton.ButtonV[10].IsState == true && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true
                && StateButton.Button[5].IsState == true && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true
                && StateButton.Button[4].IsState == true && StateButton.Button[3].IsState == true && StateButton.Button[2].IsState == true)
            {
                P1 = 12;
                P2 = 8;
                G1 = 1000;
                G2 = 1000;
                Gp = 0;
                Number1 = -1;
                Number2 = 2;
            }
            if (StateButton.ButtonSml[2].IsState == true && Number2 == 2
                && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.Button[1].IsState == true
                && StateButton.ButtonPmpL[0].IsState == true && StateButton.Button[10].IsState == true && StateButton.ButtonV[11].IsState == true
                && StateButton.ButtonV[10].IsState == true && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true
                && StateButton.Button[5].IsState == true && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true
                && StateButton.Button[4].IsState == true && StateButton.Button[3].IsState == true && StateButton.Button[2].IsState == true)
            {
                P1 = 10;
                P2 = 6;
                G1 = 1000;
                G2 = 800;
                Gp = 200;
                Number1 = -1;
                Number2 = 1;
                Number3 = 1;
            }
            if (StateButton.ButtonV[12].IsState == false
                && StateButton.ButtonSml[2].IsState == true && Number3 == 1
                && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.Button[1].IsState == true
                && StateButton.ButtonPmpL[0].IsState == true && StateButton.Button[10].IsState == true && StateButton.ButtonV[11].IsState == true
                && StateButton.ButtonV[10].IsState == true && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true
                && StateButton.Button[5].IsState == true && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true
                && StateButton.Button[4].IsState == true && StateButton.Button[3].IsState == true && StateButton.Button[2].IsState == true)
            {
                P1 = 15;
                P2 = 11;
                G1 = 500;
                G2 = 300;
                Gp = 200;
                Number2 = -1;
                Number3 = 2;
                Number4 = 1;
            }
            if (Number4 == 1 && StateButton.ButtonSml[2].IsState == false)
            {
                P1 = 17;
                P2 = 13;
                G1 = 500;
                G2 = 500;
                Gp = 00;
                Number4 = 2;
            }
            if (StateButton.ButtonV[12].IsState == true
                && StateButton.ButtonSml[2].IsState == true && Number3 == 2
                && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.Button[1].IsState == true
                && StateButton.ButtonPmpL[0].IsState == true && StateButton.Button[10].IsState == true && StateButton.ButtonV[11].IsState == true
                && StateButton.ButtonV[10].IsState == true && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true
                && StateButton.Button[5].IsState == true && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true
                && StateButton.Button[4].IsState == true && StateButton.Button[3].IsState == true && StateButton.Button[2].IsState == true)
            {
                P1 = 10;
                P2 = 6;
                G1 = 1000;
                G2 = 800;
                Gp = 200;
                Number2 = -1;
                Number3 = 1;
            }
            if (StateButton.ButtonSml[2].IsState == false && Number2 == 0
                && StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.Button[1].IsState == true
                && StateButton.ButtonPmpL[0].IsState == true && StateButton.Button[10].IsState == true && StateButton.ButtonV[11].IsState == true
                && StateButton.ButtonV[10].IsState == true && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true
                && StateButton.Button[5].IsState == true && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true
                && StateButton.Button[4].IsState == true && StateButton.Button[3].IsState == true && StateButton.Button[2].IsState == true)
            {
                P1 = 12;
                P2 = 8;
                G1 = 1000;
                G2 = 1000;
                Gp = 0;
                Number1 = -1;
                Number2 = 1;
            }
            if (Number4 == 2
                && StateButton.ButtonV[14].IsState == true && StateButton.ButtonV[13].IsState == true && StateButton.ButtonSml[15].IsState == true
                && StateButton.ButtonSml[13].IsState == true && StateButton.ButtonSml[14].IsState == true)
            {
                P1 = 9;
                P2 = 5;
                T1 = 75;
                T2 = 60;
                G1 = 1300;
                G2 = 1300;
                Gp = 0;
                Number4 = 3;
            }
            if (Number4 == 3 && (StateButton.ButtonV[8].IsState == false || StateButton.ButtonV[9].IsState == false)
                && StateButton.ButtonV[14].IsState == true && StateButton.ButtonV[13].IsState == true && StateButton.ButtonSml[15].IsState == true
                && StateButton.ButtonSml[13].IsState == true && StateButton.ButtonSml[14].IsState == true)
            {
                P1 = 14;
                P2 = 10;
                T1 = 75;
                T2 = 60;
                G1 = 800;
                G2 = 800;
                Gp = 0;
                Number4 = 4;
            }

            if (DataLines.wnd.line9.Stroke == Brushes.Red && StateButton.ButtonSml[15].IsState == false)
            {
                T1 = 75;
                T2 = 74;
            }
        }
    }
}
