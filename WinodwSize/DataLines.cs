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
        public static bool Chck { get; set; }

        public static DoubleAnimationUsingKeyFrames anLine0 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine1 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine2 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine3 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine4 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine5 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine6 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine7 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine8 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine9 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine10 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine11 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine12 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine13 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine14 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine15 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine16 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine17 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine18 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine19 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine20 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine21 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine22 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine23 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine24 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine25 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine26 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine27 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine28 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine29 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine30 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine31 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine32 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine33 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine34 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine35 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine36 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine37 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine38 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine39 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine40 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine41 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine42 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine43 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine44 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine45 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine46 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine47 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine48 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine49 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine50 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine51 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine52 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine53 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine54 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine55 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine56 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine57 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine58 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine59 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine60 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine61 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine62 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine63 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine64 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine65 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine66 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine67 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine68 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine69 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine70 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine71 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine72 = new DoubleAnimationUsingKeyFrames();

        public static void InitializeLines()
        {
            //                                              Анимация Line0
            anLine0.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine0.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    104, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line1
            anLine1.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine1.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -60, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line2
            anLine2.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine2.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    64, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line3
            anLine3.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine3.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    124, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line4
            anLine4.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine4.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -123, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line5
            anLine5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    129, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line6
            anLine6.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine6.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -129, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line7
            anLine7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    32, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line8
            anLine8.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine8.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -34, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line9
            anLine9.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine9.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -365, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line10
            anLine10.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine10.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -144, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line11
            anLine11.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine11.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -35, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line12
            anLine12.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine12.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    94, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line13
            anLine13.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine13.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    68, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line14
            anLine14.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine14.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -66, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line15
            anLine15.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine15.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line16
            anLine16.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine16.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line17
            anLine17.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine17.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    174, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line18
            anLine18.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine18.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -176, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line19
            anLine19.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine19.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line20
            anLine20.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine20.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line21
            anLine21.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine21.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    66, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line22
            anLine22.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine22.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line23
            anLine23.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine23.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    66, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line24
            anLine24.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine24.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line25
            anLine25.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine25.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    241, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line26
            anLine26.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine26.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -241, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line27
            anLine27.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine27.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    104, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line28
            anLine28.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine28.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line29
            anLine29.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine29.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    90, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line30
            anLine30.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine30.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -92, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line31
            anLine31.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine31.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line32
            anLine32.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine32.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line33
            anLine33.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine33.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    241, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line34
            anLine34.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine34.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -241, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line35
            anLine35.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine35.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line36
            anLine36.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine36.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line37
            anLine37.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine37.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    174, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line38
            anLine38.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine38.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -174, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line39
            anLine39.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine39.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    66, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line40
            anLine40.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine40.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -66, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line41
            anLine41.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine41.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    66, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line42
            anLine42.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine42.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -66, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line43
            anLine43.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine43.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    67, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line44
            anLine44.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine44.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -67, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line45
            anLine45.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine45.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    67, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line46
            anLine46.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine46.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -67, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line47
            anLine47.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine47.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    90, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line48
            anLine48.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine48.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -90, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line49
            anLine49.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine49.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line50
            anLine50.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine50.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line51
            anLine51.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine51.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line52
            anLine52.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine52.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line53
            anLine53.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine53.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    90, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line54
            anLine54.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine54.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -90, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line55
            anLine55.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine55.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line56
            anLine56.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine56.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line57
            anLine57.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine57.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    38, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line58
            anLine58.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine58.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -38, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line59
            anLine59.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine59.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    92, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line60
            anLine60.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine60.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -92, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line61
            anLine61.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine61.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    19, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line62
            anLine62.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine62.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -19, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line63
            anLine63.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine63.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line64
            anLine64.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine64.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line65
            anLine65.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine65.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    93, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line66
            anLine66.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine66.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -93, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line67
            anLine67.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine67.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    18, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line68
            anLine68.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine68.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -18, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line69
            anLine69.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine69.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    27, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line70
            anLine70.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine70.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -27, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line71
            anLine71.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine71.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    24, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );

            //                                              Анимация Line72
            anLine72.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine72.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -24, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );
        }
    }
}
