using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Shapes;

namespace WinodwSize
{
    public class Animation
    {
        public static void CheckAnimation()
        {
            if (StateButton.ButtonPmpR[0].IsState == true && StateButton.Button[0].IsState == true
                && StateButton.ButtonV[12].IsState == true && StateButton.Button[7].IsState == true
                && StateButton.Button[6].IsState == true && StateButton.Button[5].IsState == true
                && StateButton.ButtonV[9].IsState == true && StateButton.ButtonV[8].IsState == true
                && StateButton.Button[4].IsState == true && StateButton.Button[3].IsState == true
                && StateButton.ButtonV[0].IsState == true && StateButton.ButtonSml[2].IsState == true
                && DataLines.wnd.line52.Opacity == 1)
            {
                if (DataLines.anLine0a13.Name == null)
                {
                    DataLines.wnd.line0a13.Opacity = 1;
                    DataLines.wnd.line0a13.BeginAnimation(Line.X2Property, DataLines.anLine0a13);
                }
                DataLines.anLine0a13.Name = "off";
                if (DataLines.anLine1a17.Name == null)
                {
                    DataLines.wnd.line1a17.Opacity = 1;
                    DataLines.wnd.line1a17.BeginAnimation(Line.X2Property, DataLines.anLine1a17);
                }
                DataLines.anLine1a17.Name = "off";
                if (DataLines.anLine2a25.Name == null)
                {
                    DataLines.wnd.line2a25.Opacity = 1;
                    DataLines.wnd.line2a25.BeginAnimation(Line.X2Property, DataLines.anLine2a25);
                }
                DataLines.anLine2a25.Name = "off";
                if (DataLines.anLine3a28.Name == null)
                {
                    DataLines.wnd.line3a28.Opacity = 1;
                    DataLines.wnd.line3a28.BeginAnimation(Line.Y2Property, DataLines.anLine3a28);
                }
                DataLines.anLine3a28.Name = "off";
                if (DataLines.anLine4a30.Name == null)
                {
                    DataLines.wnd.line4a30.Opacity = 1;
                    DataLines.wnd.line4a30.BeginAnimation(Line.Y2Property, DataLines.anLine4a30);
                }
                DataLines.anLine4a30.Name = "off";
                if (DataLines.anLine5a32.Name == null)
                {
                    DataLines.wnd.line5a32.Opacity = 1;
                    DataLines.wnd.line5a32.BeginAnimation(Line.Y2Property, DataLines.anLine5a32);
                }
                DataLines.anLine5a32.Name = "off";
                if (DataLines.anLine6a34.Name == null)
                {
                    DataLines.wnd.line6a34.Opacity = 1;
                    DataLines.wnd.line6a34.BeginAnimation(Line.X2Property, DataLines.anLine6a34);
                }
                DataLines.anLine6a34.Name = "off";
                if (DataLines.anLine7a38.Name == null)
                {
                    DataLines.wnd.line7a38.Opacity = 1;
                    DataLines.wnd.line7a38.BeginAnimation(Line.X2Property, DataLines.anLine7a38);
                }
                DataLines.anLine7a38.Name = "off";
                if (DataLines.anLine8a45.Name == null)
                {
                    DataLines.wnd.line8a45.Opacity = 1;
                    DataLines.wnd.line8a45.BeginAnimation(Line.Y2Property, DataLines.anLine8a45);
                }
                DataLines.anLine8a45.Name = "off";
                if (DataLines.anLine9a47.Name == null)
                {
                    DataLines.wnd.line9a47.Opacity = 1;
                    DataLines.wnd.line9a47.BeginAnimation(Line.Y2Property, DataLines.anLine9a47);
                }
                DataLines.anLine9a47.Name = "off";
                if (DataLines.anLine10a52.Name == null)
                {
                    DataLines.wnd.line10a52.Opacity = 1;
                    DataLines.wnd.line10a52.BeginAnimation(Line.X2Property, DataLines.anLine10a52);
                }
                DataLines.anLine10a52.Name = "off";
            }
            else
            {
                DataLines.wnd.line0a13.Opacity = 0;
                DataLines.wnd.line0a13.BeginAnimation(Line.X2Property, null);
                DataLines.anLine0a13.Name = null;
                DataLines.wnd.line1a17.Opacity = 0;
                DataLines.wnd.line1a17.BeginAnimation(Line.X2Property, null);
                DataLines.anLine1a17.Name = null;
                DataLines.wnd.line2a25.Opacity = 0;
                DataLines.wnd.line2a25.BeginAnimation(Line.X2Property, null);
                DataLines.anLine2a25.Name = null;
                DataLines.wnd.line3a28.Opacity = 0;
                DataLines.wnd.line3a28.BeginAnimation(Line.Y2Property, null);
                DataLines.anLine3a28.Name = null;
                DataLines.wnd.line4a30.Opacity = 0;
                DataLines.wnd.line4a30.BeginAnimation(Line.Y2Property, null);
                DataLines.anLine4a30.Name = null;
                DataLines.wnd.line5a32.Opacity = 0;
                DataLines.wnd.line5a32.BeginAnimation(Line.Y2Property, null);
                DataLines.anLine5a32.Name = null;
                DataLines.wnd.line6a34.Opacity = 0;
                DataLines.wnd.line6a34.BeginAnimation(Line.X2Property, null);
                DataLines.anLine6a34.Name = null;
                DataLines.wnd.line7a38.Opacity = 0;
                DataLines.wnd.line7a38.BeginAnimation(Line.X2Property, null);
                DataLines.anLine7a38.Name = null;
                DataLines.wnd.line8a45.Opacity = 0;
                DataLines.wnd.line8a45.BeginAnimation(Line.Y2Property, null);
                DataLines.anLine8a45.Name = null;
                DataLines.wnd.line9a47.Opacity = 0;
                DataLines.wnd.line9a47.BeginAnimation(Line.Y2Property, null);
                DataLines.anLine9a47.Name = null;
                DataLines.wnd.line10a52.Opacity = 0;
                DataLines.wnd.line10a52.BeginAnimation(Line.X2Property, null);
                DataLines.anLine10a52.Name = null;
            }
        }
    }
}
