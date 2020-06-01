using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WinodwSize
{
    public class FillModel
    {
        public static void Filling(Line ln, DependencyProperty X2, DoubleAnimationUsingKeyFrames AnLines, bool chck)
        {
            ln.Opacity = 1;
            if (chck == true)
            {
                ln.BeginAnimation(X2, AnLines);
            }
        }

        public static async Task FillingAsync(int ms, Line ln, DependencyProperty X2, DoubleAnimationUsingKeyFrames AnLines, bool chck)
        {
            await Task.Delay(ms);
            ln.Opacity = 1;
            if (chck == true)
            {
                ln.BeginAnimation(X2, AnLines);
            }
        }

        public static async Task OnlyOpacityAsync(Line ln)
        {
            await Task.Delay(300);
            ln.Opacity = 1;
        }

        public static void OnlyOpacity(Line ln)
        {
            ln.Opacity = 1;
        }
    }
}
