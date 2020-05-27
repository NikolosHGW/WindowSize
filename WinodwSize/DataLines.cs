using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WinodwSize
{
    public class DataLines
    {
        public static MainWindow wnd = (MainWindow)Application.Current.MainWindow;
        public static readonly DependencyProperty X2 = Line.X2Property;
        public static readonly DependencyProperty Y2 = Line.Y2Property;

        public static DoubleAnimationUsingKeyFrames anLine17 = new DoubleAnimationUsingKeyFrames();

        public static void InitializeLines()
        {
            //                                              Анимация Line0
            
            anLine17.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine17.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    174, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(10/*была 1*/))) // KeyTime
                );
        }
    }
}
