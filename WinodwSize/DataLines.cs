using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

        //ЦИРКУЛЯЦИЯ
        public static DoubleAnimationUsingKeyFrames anLine0a13 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine1a17 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine2a25 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine3a28 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine4a30 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine5a32 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine6a34 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine7a38 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine8a45 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine9a47 = new DoubleAnimationUsingKeyFrames();
        public static DoubleAnimationUsingKeyFrames anLine10a52 = new DoubleAnimationUsingKeyFrames();

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
                    65, // Target value (KeyValue)
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
                    -65, // Target value (KeyValue)
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




            //АНИМАЦИЯ ЦИРКУЛЯЦИИ
            //                                              Анимация Line0a13
            anLine0a13.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine0a13.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    68, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine0a13.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line1a17
            anLine1a17.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine1a17.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    174, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine1a17.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line2a25
            anLine2a25.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine2a25.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    241, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine2a25.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line3a28
            anLine3a28.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine3a28.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine3a28.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line4a30
            anLine4a30.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine4a30.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -92, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine4a30.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line5a32
            anLine5a32.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine5a32.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine5a32.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line6a34
            anLine6a34.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine6a34.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -241, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine6a34.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line7a38
            anLine7a38.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine7a38.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -174, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine7a38.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line8a45
            anLine8a45.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine8a45.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    67, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine8a45.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line9a47
            anLine9a47.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine9a47.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    90, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine9a47.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line10a52
            anLine10a52.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine10a52.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5/*была 1*/))) // KeyTime
                );
            anLine10a52.RepeatBehavior = RepeatBehavior.Forever;


            anLine0.Completed += new EventHandler(AnLine0_Completed);
            anLine1.Completed += new EventHandler(AnLine1_Completed);
            anLine2.Completed += new EventHandler(AnLine2_Completed);
            anLine3.Completed += new EventHandler(AnLine3_Completed);
            anLine4.Completed += new EventHandler(AnLine4_Completed);
            anLine5.Completed += new EventHandler(AnLine5_Completed);
            anLine6.Completed += new EventHandler(AnLine6_Completed);
            anLine7.Completed += new EventHandler(AnLine7_Completed);
            anLine8.Completed += new EventHandler(AnLine8_Completed);
            anLine9.Completed += new EventHandler(AnLine9_Completed);
            anLine10.Completed += new EventHandler(AnLine10_Completed);
            anLine11.Completed += new EventHandler(AnLine11_Completed);
            anLine12.Completed += new EventHandler(AnLine12_Completed);
            anLine13.Completed += new EventHandler(AnLine13_Completed);
            anLine14.Completed += new EventHandler(AnLine14_Completed);
            anLine15.Completed += new EventHandler(AnLine15_Completed);
            anLine16.Completed += new EventHandler(AnLine16_Completed);
            anLine17.Completed += new EventHandler(AnLine17_Completed);
            anLine18.Completed += new EventHandler(AnLine18_Completed);
            anLine19.Completed += new EventHandler(AnLine19_Completed);
            anLine20.Completed += new EventHandler(AnLine20_Completed);
            anLine21.Completed += new EventHandler(AnLine21_Completed);
            anLine22.Completed += new EventHandler(AnLine22_Completed);
            anLine23.Completed += new EventHandler(AnLine23_Completed);
            anLine24.Completed += new EventHandler(AnLine24_Completed);
            anLine25.Completed += new EventHandler(AnLine25_Completed);
            anLine26.Completed += new EventHandler(AnLine26_Completed);
            anLine27.Completed += new EventHandler(AnLine27_Completed);
            anLine28.Completed += new EventHandler(AnLine28_Completed);
            anLine29.Completed += new EventHandler(AnLine29_Completed);
            anLine30.Completed += new EventHandler(AnLine30_Completed);
            anLine31.Completed += new EventHandler(AnLine31_Completed);
            anLine32.Completed += new EventHandler(AnLine32_Completed);
            anLine33.Completed += new EventHandler(AnLine33_Completed);
            anLine34.Completed += new EventHandler(AnLine34_Completed);
            anLine35.Completed += new EventHandler(AnLine35_Completed);
            anLine36.Completed += new EventHandler(AnLine36_Completed);
            anLine37.Completed += new EventHandler(AnLine37_Completed);
            anLine38.Completed += new EventHandler(AnLine38_Completed);
            anLine39.Completed += new EventHandler(AnLine39_Completed);
            anLine40.Completed += new EventHandler(AnLine40_Completed);
            anLine41.Completed += new EventHandler(AnLine41_Completed);
            anLine42.Completed += new EventHandler(AnLine42_Completed);
            anLine43.Completed += new EventHandler(AnLine43_Completed);
            anLine44.Completed += new EventHandler(AnLine44_Completed);
            anLine45.Completed += new EventHandler(AnLine45_Completed);
            anLine46.Completed += new EventHandler(AnLine46_Completed);
            anLine47.Completed += new EventHandler(AnLine47_Completed);
            anLine48.Completed += new EventHandler(AnLine48_Completed);
            anLine49.Completed += new EventHandler(AnLine49_Completed);
            anLine50.Completed += new EventHandler(AnLine50_Completed);
            anLine51.Completed += new EventHandler(AnLine51_Completed);
            anLine52.Completed += new EventHandler(AnLine52_Completed);
            anLine53.Completed += new EventHandler(AnLine53_Completed);
            anLine54.Completed += new EventHandler(AnLine54_Completed);
            anLine55.Completed += new EventHandler(AnLine55_Completed);
            anLine56.Completed += new EventHandler(AnLine56_Completed);
            anLine57.Completed += new EventHandler(AnLine57_Completed);
            anLine58.Completed += new EventHandler(AnLine58_Completed);
            anLine59.Completed += new EventHandler(AnLine59_Completed);
            anLine60.Completed += new EventHandler(AnLine60_Completed);
            anLine61.Completed += new EventHandler(AnLine61_Completed);
            anLine62.Completed += new EventHandler(AnLine62_Completed);
            anLine63.Completed += new EventHandler(AnLine63_Completed);
            anLine64.Completed += new EventHandler(AnLine64_Completed);
            anLine65.Completed += new EventHandler(AnLine65_Completed);
            anLine66.Completed += new EventHandler(AnLine66_Completed);
            anLine67.Completed += new EventHandler(AnLine67_Completed);
            anLine68.Completed += new EventHandler(AnLine68_Completed);
            anLine69.Completed += new EventHandler(AnLine69_Completed);
            anLine70.Completed += new EventHandler(AnLine70_Completed);
            anLine71.Completed += new EventHandler(AnLine71_Completed);
            anLine72.Completed += new EventHandler(AnLine72_Completed);
        }

        public static bool ChckLine2 { get; set; } = false;
        public static bool ChckLine3 { get; set; } = false;
        public static bool ChckLine4 { get; set; } = false;
        public static bool ChckLine5 { get; set; } = false;
        public static bool ChckLine6 { get; set; } = false;
        public static bool ChckLine7 { get; set; } = false;
        public static bool ChckLine8 { get; set; } = false;
        public static bool ChckLine9 { get; set; } = false;
        public static bool ChckLine10 { get; set; } = false;
        public static bool ChckLine11 { get; set; } = false;
        public static bool ChckLine12 { get; set; } = false;
        public static bool ChckLine13 { get; set; } = false;
        public static bool ChckLine14 { get; set; } = false;
        public static bool ChckLine15 { get; set; } = false;
        public static bool ChckLine16 { get; set; } = false;
        public static bool ChckLine17 { get; set; } = false;
        public static bool ChckLine18 { get; set; } = false;
        public static bool ChckLine19 { get; set; } = false;
        public static bool ChckLine20 { get; set; } = false;
        public static bool ChckLine21 { get; set; } = false;
        public static bool ChckLine22 { get; set; } = false;
        public static bool ChckLine23 { get; set; } = false;
        public static bool ChckLine24 { get; set; } = false;
        public static bool ChckLine25 { get; set; } = false;
        public static bool ChckLine26 { get; set; } = false;
        public static bool ChckLine27 { get; set; } = false;
        public static bool ChckLine28 { get; set; } = false;
        public static bool ChckLine29 { get; set; } = false;
        public static bool ChckLine30 { get; set; } = false;
        public static bool ChckLine31 { get; set; } = false;
        public static bool ChckLine32 { get; set; } = false;
        public static bool ChckLine33 { get; set; } = false;
        public static bool ChckLine34 { get; set; } = false;
        public static bool ChckLine35 { get; set; } = false;
        public static bool ChckLine36 { get; set; } = false;
        public static bool ChckLine37 { get; set; } = false;
        public static bool ChckLine38 { get; set; } = false;
        public static bool ChckLine39 { get; set; } = false;
        public static bool ChckLine40 { get; set; } = false;
        public static bool ChckLine41 { get; set; } = false;
        public static bool ChckLine42 { get; set; } = false;
        public static bool ChckLine43 { get; set; } = false;
        public static bool ChckLine44 { get; set; } = false;
        public static bool ChckLine45 { get; set; } = false;
        public static bool ChckLine46 { get; set; } = false;
        public static bool ChckLine47 { get; set; } = false;
        public static bool ChckLine48 { get; set; } = false;
        public static bool ChckLine49 { get; set; } = false;
        public static bool ChckLine50 { get; set; } = false;
        public static bool ChckLine51 { get; set; } = false;
        public static bool ChckLine52 { get; set; } = false;
        public static bool ChckLine53 { get; set; } = false;
        public static bool ChckLine54 { get; set; } = false;
        public static bool ChckLine55 { get; set; } = false;
        public static bool ChckLine56 { get; set; } = false;
        public static bool ChckLine57 { get; set; } = false;
        public static bool ChckLine58 { get; set; } = false;
        public static bool ChckLine59 { get; set; } = false;
        public static bool ChckLine60 { get; set; } = false;
        public static bool ChckLine61 { get; set; } = false;
        public static bool ChckLine62 { get; set; } = false;
        public static bool ChckLine63 { get; set; } = false;
        public static bool ChckLine64 { get; set; } = false;
        public static bool ChckLine65 { get; set; } = false;
        public static bool ChckLine66 { get; set; } = false;
        public static bool ChckLine67 { get; set; } = false;
        public static bool ChckLine68 { get; set; } = false;
        public static bool ChckLine69 { get; set; } = false;
        public static bool ChckLine70 { get; set; } = false;
        public static bool ChckLine71 { get; set; } = false;
        public static bool ChckLine72 { get; set; } = false;


        private static void AnLine0_Completed(object sender, EventArgs e)
        {
            DoneAnim0 = false;
        }
        private static void AnLine1_Completed(object sender, EventArgs e)
        {
            DoneAnim1 = false;
        }
        private static void AnLine2_Completed(object sender, EventArgs e)
        {
            ChckLine2 = true;
            DoneAnim2 = false;
        }
        private static void AnLine3_Completed(object sender, EventArgs e)
        {
            ChckLine3 = true;
            DoneAnim3 = false;
        }
        private static void AnLine4_Completed(object sender, EventArgs e)
        {
            ChckLine4 = true;
            DoneAnim4 = false;
        }
        private static void AnLine5_Completed(object sender, EventArgs e)
        {
            ChckLine5 = true;
            DoneAnim5 = false;
        }
        private static void AnLine6_Completed(object sender, EventArgs e)
        {
            ChckLine6 = true;
            DoneAnim6 = false;
        }
        private static void AnLine7_Completed(object sender, EventArgs e)
        {
            ChckLine7 = true;
            DoneAnim7 = false;
        }
        private static void AnLine8_Completed(object sender, EventArgs e)
        {
            ChckLine8 = true;
            DoneAnim8 = false;
        }
        private static void AnLine9_Completed(object sender, EventArgs e)
        {
            ChckLine9 = true;
            DoneAnim9 = false;
        }
        private static void AnLine10_Completed(object sender, EventArgs e)
        {
            ChckLine10 = true;
            DoneAnim10 = false;
        }
        private static void AnLine11_Completed(object sender, EventArgs e)
        {
            ChckLine11 = true;
            DoneAnim11 = false;
        }
        private static void AnLine12_Completed(object sender, EventArgs e)
        {
            ChckLine12 = true;
            DoneAnim12 = false;
        }
        private static void AnLine13_Completed(object sender, EventArgs e)
        {
            ChckLine13 = true;
            DoneAnim13 = false;
        }
        private static void AnLine14_Completed(object sender, EventArgs e)
        {
            ChckLine14 = true;
            DoneAnim14 = false;
        }
        private static void AnLine15_Completed(object sender, EventArgs e)
        {
            ChckLine15 = true;
            DoneAnim15 = false;
        }
        private static void AnLine16_Completed(object sender, EventArgs e)
        {
            ChckLine16 = true;
            DoneAnim16 = false;
        }
        private static void AnLine17_Completed(object sender, EventArgs e)
        {
            ChckLine17 = true;
            DoneAnim17 = false;
        }
        private static void AnLine18_Completed(object sender, EventArgs e)
        {
            ChckLine18 = true;
            DoneAnim18 = false;
        }
        private static void AnLine19_Completed(object sender, EventArgs e)
        {
            ChckLine19 = true;
            DoneAnim19 = false;
        }
        private static void AnLine20_Completed(object sender, EventArgs e)
        {
            ChckLine20 = true;
            DoneAnim20 = false;
        }
        private static void AnLine21_Completed(object sender, EventArgs e)
        {
            ChckLine21 = true;
            DoneAnim21 = false;
        }
        private static void AnLine22_Completed(object sender, EventArgs e)
        {
            ChckLine22 = true;
            DoneAnim22 = false;
        }
        private static void AnLine23_Completed(object sender, EventArgs e)
        {
            ChckLine23 = true;
            DoneAnim23 = false;
        }
        private static void AnLine24_Completed(object sender, EventArgs e)
        {
            ChckLine24 = true;
            DoneAnim24 = false;
        }
        private static void AnLine25_Completed(object sender, EventArgs e)
        {
            ChckLine25 = true;
            DoneAnim25 = false;
        }
        private static void AnLine26_Completed(object sender, EventArgs e)
        {
            ChckLine26 = true;
            DoneAnim26 = false;
        }
        private static void AnLine27_Completed(object sender, EventArgs e)
        {
            ChckLine27 = true;
            DoneAnim27 = false;
        }
        private static void AnLine28_Completed(object sender, EventArgs e)
        {
            ChckLine28 = true;
            DoneAnim28 = false;
        }
        private static void AnLine29_Completed(object sender, EventArgs e)
        {
            ChckLine29 = true;
            DoneAnim29 = false;
        }
        private static void AnLine30_Completed(object sender, EventArgs e)
        {
            ChckLine30 = true;
            DoneAnim30 = false;
        }
        private static void AnLine31_Completed(object sender, EventArgs e)
        {
            ChckLine31 = true;
            DoneAnim31 = false;
        }
        private static void AnLine32_Completed(object sender, EventArgs e)
        {
            ChckLine32 = true;
            DoneAnim32 = false;
        }
        private static void AnLine33_Completed(object sender, EventArgs e)
        {
            ChckLine33 = true;
            DoneAnim33 = false;
        }
        private static void AnLine34_Completed(object sender, EventArgs e)
        {
            ChckLine34 = true;
            DoneAnim34 = false;
        }
        private static void AnLine35_Completed(object sender, EventArgs e)
        {
            ChckLine35 = true;
            DoneAnim35 = false;
        }
        private static void AnLine36_Completed(object sender, EventArgs e)
        {
            ChckLine36 = true;
            DoneAnim36 = false;
        }
        private static void AnLine37_Completed(object sender, EventArgs e)
        {
            ChckLine37 = true;
            DoneAnim37 = false;
        }
        private static void AnLine38_Completed(object sender, EventArgs e)
        {
            ChckLine38 = true;
            DoneAnim38 = false;
        }
        private static void AnLine39_Completed(object sender, EventArgs e)
        {
            ChckLine39 = true;
            DoneAnim39 = false;
        }
        private static void AnLine40_Completed(object sender, EventArgs e)
        {
            ChckLine40 = true;
            DoneAnim40 = false;
        }
        private static void AnLine41_Completed(object sender, EventArgs e)
        {
            ChckLine41 = true;
            DoneAnim41 = false;
        }
        private static void AnLine42_Completed(object sender, EventArgs e)
        {
            ChckLine42 = true;
            DoneAnim42 = false;
        }
        private static void AnLine43_Completed(object sender, EventArgs e)
        {
            ChckLine43 = true;
            DoneAnim43 = false;
        }
        private static void AnLine44_Completed(object sender, EventArgs e)
        {
            ChckLine44 = true;
            DoneAnim44 = false;
        }
        private static void AnLine45_Completed(object sender, EventArgs e)
        {
            ChckLine45 = true;
            DoneAnim45 = false;
        }
        private static void AnLine46_Completed(object sender, EventArgs e)
        {
            ChckLine46 = true;
            DoneAnim46 = false;
        }
        private static void AnLine47_Completed(object sender, EventArgs e)
        {
            ChckLine47 = true;
            DoneAnim47 = false;
        }
        private static void AnLine48_Completed(object sender, EventArgs e)
        {
            ChckLine48 = true;
            DoneAnim48 = false;
        }
        private static void AnLine49_Completed(object sender, EventArgs e)
        {
            ChckLine49 = true;
            DoneAnim49 = false;
        }
        private static void AnLine50_Completed(object sender, EventArgs e)
        {
            ChckLine50 = true;
            DoneAnim50 = false;
        }
        private static void AnLine51_Completed(object sender, EventArgs e)
        {
            ChckLine51 = true;
            DoneAnim51 = false;
        }
        private static void AnLine52_Completed(object sender, EventArgs e)
        {
            ChckLine52 = true;
            DoneAnim52 = false;
        }
        private static void AnLine53_Completed(object sender, EventArgs e)
        {
            ChckLine53 = true;
            DoneAnim53 = false;
        }
        private static void AnLine54_Completed(object sender, EventArgs e)
        {
            ChckLine54 = true;
            DoneAnim54 = false;
        }
        private static void AnLine55_Completed(object sender, EventArgs e)
        {
            ChckLine55 = true;
            DoneAnim55 = false;
        }
        private static void AnLine56_Completed(object sender, EventArgs e)
        {
            ChckLine56 = true;
            DoneAnim56 = false;
        }
        private static void AnLine57_Completed(object sender, EventArgs e)
        {
            ChckLine57 = true;
            DoneAnim57 = false;
        }
        private static void AnLine58_Completed(object sender, EventArgs e)
        {
            ChckLine58 = true;
            DoneAnim58 = false;
        }
        private static void AnLine59_Completed(object sender, EventArgs e)
        {
            ChckLine59 = true;
            DoneAnim59 = false;
        }
        private static void AnLine60_Completed(object sender, EventArgs e)
        {
            ChckLine60 = true;
            DoneAnim60 = false;
        }
        private static void AnLine61_Completed(object sender, EventArgs e)
        {
            ChckLine61 = true;
            DoneAnim61 = false;
        }
        private static void AnLine62_Completed(object sender, EventArgs e)
        {
            ChckLine62 = true;
            DoneAnim62 = false;
        }
        private static void AnLine63_Completed(object sender, EventArgs e)
        {
            ChckLine63 = true;
            DoneAnim63 = false;
        }
        private static void AnLine64_Completed(object sender, EventArgs e)
        {
            ChckLine64 = true;
            DoneAnim64 = false;
        }
        private static void AnLine65_Completed(object sender, EventArgs e)
        {
            ChckLine65 = true;
            DoneAnim65 = false;
        }
        private static void AnLine66_Completed(object sender, EventArgs e)
        {
            ChckLine66 = true;
            DoneAnim66 = false;
        }
        private static void AnLine67_Completed(object sender, EventArgs e)
        {
            ChckLine67 = true;
            DoneAnim67 = false;
        }
        private static void AnLine68_Completed(object sender, EventArgs e)
        {
            ChckLine68 = true;
            DoneAnim68 = false;
        }
        private static void AnLine69_Completed(object sender, EventArgs e)
        {
            ChckLine69 = true;
            DoneAnim69 = false;
        }
        private static void AnLine70_Completed(object sender, EventArgs e)
        {
            ChckLine70 = true;
            DoneAnim70 = false;
        }
        private static void AnLine71_Completed(object sender, EventArgs e)
        {
            ChckLine71 = true;
            DoneAnim71 = false;
        }
        private static void AnLine72_Completed(object sender, EventArgs e)
        {
            ChckLine72 = true;
            DoneAnim72 = false;
        }


        public static bool DoneAnim0 { get; set; } = true;
        public static bool DoneAnim1 { get; set; } = true;
        public static bool DoneAnim2 { get; set; } = true;
        public static bool DoneAnim3 { get; set; } = true;
        public static bool DoneAnim4 { get; set; } = true;
        public static bool DoneAnim5 { get; set; } = true;
        public static bool DoneAnim6 { get; set; } = true;
        public static bool DoneAnim7 { get; set; } = true;
        public static bool DoneAnim8 { get; set; } = true;
        public static bool DoneAnim9 { get; set; } = true;
        public static bool DoneAnim10 { get; set; } = true;
        public static bool DoneAnim11 { get; set; } = true;
        public static bool DoneAnim12 { get; set; } = true;
        public static bool DoneAnim13 { get; set; } = true;
        public static bool DoneAnim14 { get; set; } = true;
        public static bool DoneAnim15 { get; set; } = true;
        public static bool DoneAnim16 { get; set; } = true;
        public static bool DoneAnim17 { get; set; } = true;
        public static bool DoneAnim18 { get; set; } = true;
        public static bool DoneAnim19 { get; set; } = true;
        public static bool DoneAnim20 { get; set; } = true;
        public static bool DoneAnim21 { get; set; } = true;
        public static bool DoneAnim22 { get; set; } = true;
        public static bool DoneAnim23 { get; set; } = true;
        public static bool DoneAnim24 { get; set; } = true;
        public static bool DoneAnim25 { get; set; } = true;
        public static bool DoneAnim26 { get; set; } = true;
        public static bool DoneAnim27 { get; set; } = true;
        public static bool DoneAnim28 { get; set; } = true;
        public static bool DoneAnim29 { get; set; } = true;
        public static bool DoneAnim30 { get; set; } = true;
        public static bool DoneAnim31 { get; set; } = true;
        public static bool DoneAnim32 { get; set; } = true;
        public static bool DoneAnim33 { get; set; } = true;
        public static bool DoneAnim34 { get; set; } = true;
        public static bool DoneAnim35 { get; set; } = true;
        public static bool DoneAnim36 { get; set; } = true;
        public static bool DoneAnim37 { get; set; } = true;
        public static bool DoneAnim38 { get; set; } = true;
        public static bool DoneAnim39 { get; set; } = true;
        public static bool DoneAnim40 { get; set; } = true;
        public static bool DoneAnim41 { get; set; } = true;
        public static bool DoneAnim42 { get; set; } = true;
        public static bool DoneAnim43 { get; set; } = true;
        public static bool DoneAnim44 { get; set; } = true;
        public static bool DoneAnim45 { get; set; } = true;
        public static bool DoneAnim46 { get; set; } = true;
        public static bool DoneAnim47 { get; set; } = true;
        public static bool DoneAnim48 { get; set; } = true;
        public static bool DoneAnim49 { get; set; } = true;
        public static bool DoneAnim50 { get; set; } = true;
        public static bool DoneAnim51 { get; set; } = true;
        public static bool DoneAnim52 { get; set; } = true;
        public static bool DoneAnim53 { get; set; } = true;
        public static bool DoneAnim54 { get; set; } = true;
        public static bool DoneAnim55 { get; set; } = true;
        public static bool DoneAnim56 { get; set; } = true;
        public static bool DoneAnim57 { get; set; } = true;
        public static bool DoneAnim58 { get; set; } = true;
        public static bool DoneAnim59 { get; set; } = true;
        public static bool DoneAnim60 { get; set; } = true;
        public static bool DoneAnim61 { get; set; } = true;
        public static bool DoneAnim62 { get; set; } = true;
        public static bool DoneAnim63 { get; set; } = true;
        public static bool DoneAnim64 { get; set; } = true;
        public static bool DoneAnim65 { get; set; } = true;
        public static bool DoneAnim66 { get; set; } = true;
        public static bool DoneAnim67 { get; set; } = true;
        public static bool DoneAnim68 { get; set; } = true;
        public static bool DoneAnim69 { get; set; } = true;
        public static bool DoneAnim70 { get; set; } = true;
        public static bool DoneAnim71 { get; set; } = true;
        public static bool DoneAnim72 { get; set; } = true;
    }
}
