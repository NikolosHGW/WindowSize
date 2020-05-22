using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WinodwSize
{
    class MainVM : INotifyPropertyChanged
    {
        public ObservableCollection<Button> Buttons { get; } = new ObservableCollection<Button>
        {
            new Button(459,178,1070,564), // valve 1 // Button[0]
            new Button(411,279,1118,463), // valve 2 // Button[1]
            new Button(582,277,947,465), // valve 3 // Button[2]
            new Button(697,279,832,463), // valve 4 // Button[3]
            new Button(919,279,610,463), // valve 5 // Button[4]
            new Button(919,549,610,193), // valve 6 // Button[5]
            new Button(697,549,832,193), // valve 7 // Button[6]
            new Button(583,550,946,192), // valve 8 // Button[7]
            new Button(411,356,1118,386), // Button[8]
            new Button(411,436,1118,306), // Button[9]
            new Button(281,278,1248,464), // Button[10]
            new Button(276,357,1253,385), // Button[11]
            new Button(278,436,1251,306), // Button[12]
        };

        public ObservableCollection<Button> ButtonsV { get; } = new ObservableCollection<Button>
        {
            new Button(667,360,883,393), // valve 9 // ButtonV[0]
            new Button(747,360,803,392), // valve 10 // ButtonV[1]
            new Button(667,477,883,276), // valve 14 // ButtonV[2]
            new Button(746,477,804,276), // valve 15 // ButtonV[3]
            new Button(899,358,651,394), // valve 16 // ButtonV[4]
            new Button(959,358,591,396), // valve 17 // ButtonV[5]
            new Button(900,476,650,276), // valve 19 // ButtonV[6]
            new Button(959,478,591,276), // valve 20 // ButtonV[7]
            new Button(1194,360,356,394), // valve 21 // ButtonV[8]
            new Button(1194,476,356,278), // valve 22 // ButtonV[9]
            new Button(177,398,1373,356), // valve 26 // ButtonV[10]
            new Button(176,324,1374,428), // valve 27 // ButtonV[11]
            new Button(540,414,1010,338), // valve 28 // ButtonV[12]
            new Button(1282,260,268,494), // valve 29 // ButtonV[13]
            new Button(1282,570,268,184), // valve 20 // ButtonV[14]
        };

        public ObservableCollection<Button> ButtonsSml { get; } = new ObservableCollection<Button>
        {
            new Button(707,414,843,338), // valve 18 // ButtonSml[0]
            new Button(930,414,620,338), // valve 13 // ButtonSml[1]
            new Button(628,438,922,316), // valve 11 // ButtonSml[2]
            new Button(794,437,756,316), // valve 12 // ButtonSml[3]
            new Button(860,384,690,368), // valve 23 // ButtonSml[4]
            new Button(997,382,553,370), // valve 24 // ButtonSml[5]
            new Button(1157,416,393,336), // valve 25 // ButtonSml[6]
            new Button(291,308,1259,445), // ButtonSml[7]
            new Button(287,392,1263,362), // ButtonSml[8]
            new Button(290,476,1260,278), // valve 11 // ButtonSml[9]
            new Button(125,363,1425,390), // valve 11 // ButtonSml[10]
            new Button(594,246,956,508), // valve 11 // ButtonSml[11]
            new Button(592,593,958,160), // valve 11 // ButtonSml[12]
            new Button(1225,290,325,464), // valve 11 // ButtonSml[13]
            new Button(1227,552,323,200), // valve 11 // ButtonSml[14]
            new Button(1299,290,251,463), // valve 11 // ButtonSml[15]
        };

        public ObservableCollection<Button> ButtonsPmpR { get; } = new ObservableCollection<Button>
        {
            new Button(406,169,1130,561) // pump 1 // ButtonPmpR[0]
        };

        public ObservableCollection<Button> ButtonsPmpL { get; } = new ObservableCollection<Button>
        {
            new Button(365,274,1177,460), // pump 2 // ButtonPmpL[0]
            new Button(364,352,1178,382), // ButtonPmpL[1]
            new Button(369,432,1173,302) // ButtonPmpL[2]
        };


        private RelayCommand stateCommand;
        public RelayCommand StateCommand
        {
            get
            {
                return stateCommand ??
                  (stateCommand = new RelayCommand(obj =>
                  {
                      ChangeState((Button)obj);
                  }));
            }
        }

        void ChangeState(Button button)
        {
            button.IsState = !button.IsState;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        //                                            ВРЕМЕННЫЙ КОД ДЛЯ ИНФО
        private int opa;
        public int Opa
        {
            get
            {
                return opa;
            }
            set
            {
                opa = value;
                OnPropertyChanged("Opa");
            }
        }

        private RelayCommand infoCommand;
        public RelayCommand InfoCommand
        {
            get
            {
                return infoCommand ??
                  (infoCommand = new RelayCommand(obj =>
                  {
                      if (Opa == 1)
                          Opa = 0;
                      else
                          Opa = 1;
                  }));
            }
        }
    }
}
