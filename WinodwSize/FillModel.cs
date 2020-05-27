using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WinodwSize
{
    public class FillModel
    {
        public static void Filling(Line ln, DependencyProperty X2, DoubleAnimationUsingKeyFrames AnLines)
        {
            ln.Opacity = 1;
            ln.BeginAnimation(X2, AnLines);
        }
    }
}
