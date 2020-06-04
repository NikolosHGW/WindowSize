using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Shapes;

namespace WinodwSize
{
    public class Animation
    {
        public static bool StateCirc { get; private set; } = true;
        public static bool StateCirc2 { get; private set; } = true;
        public static void CheckAnimation()
        {
            if (StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true
                && StateButton.ButtonV[12].IsState == true && StateButton.Button[7].IsState == true
                && StateButton.Button[6].IsState == true && StateButton.Button[5].IsState == true
                && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true
                && StateButton.Button[4].IsState == true && StateButton.Button[3].IsState == true
                && StateButton.ButtonV[0].IsState == true && StateButton.ButtonSml[2].IsState == true
                && DataLines.wnd.line52.Opacity == 1 && StateCirc == true)
            {
                DataLines.wnd.line0a13.Opacity = 1;
                DataLines.wnd.line0a13.BeginAnimation(Line.X2Property, DataLines.anLine0a13);
                DataLines.wnd.line1a17.Opacity = 1;
                DataLines.wnd.line1a17.BeginAnimation(Line.X2Property, DataLines.anLine1a17);
                DataLines.wnd.line2a25.Opacity = 1;
                DataLines.wnd.line2a25.BeginAnimation(Line.X2Property, DataLines.anLine2a25);
                DataLines.wnd.line3a28.Opacity = 1;
                DataLines.wnd.line3a28.BeginAnimation(Line.Y2Property, DataLines.anLine3a28);
                DataLines.wnd.line4a30.Opacity = 1;
                DataLines.wnd.line4a30.BeginAnimation(Line.Y2Property, DataLines.anLine4a30);
                DataLines.wnd.line5a32.Opacity = 1;
                DataLines.wnd.line5a32.BeginAnimation(Line.Y2Property, DataLines.anLine5a32);
                DataLines.wnd.line6a34.Opacity = 1;
                DataLines.wnd.line6a34.BeginAnimation(Line.X2Property, DataLines.anLine6a34);
                DataLines.wnd.line7a38.Opacity = 1;
                DataLines.wnd.line7a38.BeginAnimation(Line.X2Property, DataLines.anLine7a38);
                DataLines.wnd.line8a45.Opacity = 1;
                DataLines.wnd.line8a45.BeginAnimation(Line.Y2Property, DataLines.anLine8a45);
                DataLines.wnd.line9a47.Opacity = 1;
                DataLines.wnd.line9a47.BeginAnimation(Line.Y2Property, DataLines.anLine9a47);
                DataLines.wnd.line10a52.Opacity = 1;
                DataLines.wnd.line10a52.BeginAnimation(Line.X2Property, DataLines.anLine10a52);
                StateCirc = false;

            }
            if (StateButton.ButtonPmpR[0].IsState == false || StateButton.Button[0].IsState == false
                || StateButton.ButtonV[12].IsState == false || StateButton.Button[7].IsState == false
                || StateButton.Button[6].IsState == false || StateButton.Button[5].IsState == false
                || StateButton.ButtonV[9].IsState == false || StateButton.ButtonV[8].IsState == false
                || StateButton.Button[4].IsState == false || StateButton.Button[3].IsState == false
                || StateButton.ButtonV[0].IsState == false || StateButton.ButtonSml[2].IsState == false)
            {
                DataLines.wnd.line0a13.Opacity = 0;
                DataLines.wnd.line0a13.BeginAnimation(Line.X2Property, null);
                DataLines.wnd.line1a17.Opacity = 0;
                DataLines.wnd.line1a17.BeginAnimation(Line.X2Property, null);
                DataLines.wnd.line2a25.Opacity = 0;
                DataLines.wnd.line2a25.BeginAnimation(Line.X2Property, null);
                DataLines.wnd.line3a28.Opacity = 0;
                DataLines.wnd.line3a28.BeginAnimation(Line.Y2Property, null);
                DataLines.wnd.line4a30.Opacity = 0;
                DataLines.wnd.line4a30.BeginAnimation(Line.Y2Property, null);
                DataLines.wnd.line5a32.Opacity = 0;
                DataLines.wnd.line5a32.BeginAnimation(Line.Y2Property, null);
                DataLines.wnd.line6a34.Opacity = 0;
                DataLines.wnd.line6a34.BeginAnimation(Line.X2Property, null);
                DataLines.wnd.line7a38.Opacity = 0;
                DataLines.wnd.line7a38.BeginAnimation(Line.X2Property, null);
                DataLines.wnd.line8a45.Opacity = 0;
                DataLines.wnd.line8a45.BeginAnimation(Line.Y2Property, null);
                DataLines.wnd.line9a47.Opacity = 0;
                DataLines.wnd.line9a47.BeginAnimation(Line.Y2Property, null);
                DataLines.wnd.line10a52.Opacity = 0;
                DataLines.wnd.line10a52.BeginAnimation(Line.X2Property, null);
                StateCirc = true;
            }

            if (StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true && StateButton.Button[1].IsState == true
                && StateButton.ButtonPmpL[0].IsState == true && StateButton.Button[10].IsState == true && StateButton.ButtonV[12].IsState == true
                && StateButton.ButtonV[10].IsState == true && StateButton.Button[7].IsState == true && StateButton.Button[6].IsState == true
                && StateButton.Button[5].IsState == true && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true
                && StateButton.Button[4].IsState == true && StateButton.Button[3].IsState == true && StateButton.Button[2].IsState == true
                && StateCirc2 == true)
            {
                DataLines.wnd.line11a.Opacity = 1;
                DataLines.wnd.line11a.BeginAnimation(Line.X2Property, DataLines.anLine11a);
                DataLines.wnd.line12a.Opacity = 1;
                DataLines.wnd.line12a.BeginAnimation(Line.Y2Property, DataLines.anLine12a);
                DataLines.wnd.line13a.Opacity = 1;
                DataLines.wnd.line13a.BeginAnimation(Line.X2Property, DataLines.anLine13a);
                DataLines.wnd.line14a.Opacity = 1;
                DataLines.wnd.line14a.BeginAnimation(Line.Y2Property, DataLines.anLine14a);
                StateCirc2 = false;
            }
            if (StateButton.ButtonPmpR[0].IsState == false || StateButton.Button[0].IsState == false || StateButton.Button[1].IsState == false
                && StateButton.ButtonPmpL[0].IsState == false || StateButton.Button[10].IsState == false || StateButton.ButtonV[12].IsState == false
                && StateButton.ButtonV[10].IsState == false || StateButton.Button[7].IsState == false || StateButton.Button[6].IsState == false
                && StateButton.Button[5].IsState == false || StateButton.ButtonV[9].IsState == false || StateButton.ButtonV[8].IsState == false
                && StateButton.Button[4].IsState == false || StateButton.Button[3].IsState == false || StateButton.Button[2].IsState == false)
            {
                DataLines.wnd.line11a.Opacity = 0;
                DataLines.wnd.line11a.BeginAnimation(Line.X2Property, null);
                DataLines.wnd.line12a.Opacity = 0;
                DataLines.wnd.line12a.BeginAnimation(Line.Y2Property, null);
                DataLines.wnd.line13a.Opacity = 0;
                DataLines.wnd.line13a.BeginAnimation(Line.X2Property, null);
                DataLines.wnd.line14a.Opacity = 0;
                DataLines.wnd.line14a.BeginAnimation(Line.Y2Property, null);
                StateCirc2 = true;
            }
        }
    }
}
