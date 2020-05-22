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
            new Button(437,153,1017,521), // valve 1 // Button[0]
            new Button(399,252,1071,432), // valve 2 // Button[1]
            new Button(559,253,911,431), // valve 3 // Button[2]
            new Button(702,253,833,432), // valve 4 // Button[3]
            new Button(914,255,621,432), // valve 5 // Button[4]
            new Button(914,516,621,173), // valve 6 // Button[5]
            new Button(702,515,833,175), // valve 7 // Button[6]
            new Button(596,515,939,176), // valve 8 // Button[7]
            new Button(432,334,1103,359), // Button[8]
            new Button(432,409,1103,286), // Button[9]
            new Button(305,258,1230,437), // Button[10]
            new Button(306,335,1235,362), // Button[11]
            new Button(310,412,1237,286), // Button[12]
        };

        public ObservableCollection<Button> ButtonsV { get; } = new ObservableCollection<Button>
        {
            new Button(685,337,889,373), // valve 9 // ButtonV[0]
            new Button(763,339,818,373), // valve 10 // ButtonV[1]
            new Button(691,457,897,257), // valve 14 // ButtonV[2]
            new Button(770,457,825,257), // valve 15 // ButtonV[3]
            new Button(920,342,682,374), // valve 16 // ButtonV[4]
            new Button(980,342,629,376), // valve 17 // ButtonV[5]
            new Button(927,459,689,259), // valve 19 // ButtonV[6]
            new Button(987,459,636,259), // valve 20 // ButtonV[7]
            new Button(1214,344,416,376), // valve 21 // ButtonV[8]
            new Button(1218,459,419,261), // valve 22 // ButtonV[9]
            new Button(251,378,1393,342), // valve 26 // ButtonV[10]
            new Button(258,309,1399,413), // valve 27 // ButtonV[11]
            new Button(612,403,1058,321), // valve 28 // ButtonV[12]
            new Button(1325,246,358,480), // valve 29 // ButtonV[13]
            new Button(1331,551,365,177), // valve 20 // ButtonV[14]
        };

        public ObservableCollection<Button> ButtonsSml { get; } = new ObservableCollection<Button>
        {
            new Button(790,402,919,328), // valve 18 // ButtonSml[0]
            new Button(1011,401,717,329), // valve 13 // ButtonSml[1]
            new Button(715,424,1013,308), // valve 11 // ButtonSml[2]
            new Button(892,424,855,310), // valve 12 // ButtonSml[3]
            new Button(960,376,806,360), // valve 23 // ButtonSml[4]
            new Button(1110,374,675,362), // valve 24 // ButtonSml[5]
            new Button(1258,407,546,331), // valve 25 // ButtonSml[6]
            new Button(459,306,1383,435), // ButtonSml[7]
            new Button(466,386,1395,356), // ButtonSml[8]
            new Button(477,467,1403,277), // valve 11 // ButtonSml[9]
            new Button(331,359,1568,385), // valve 11 // ButtonSml[10]
            new Button(787,249,1137,497), // valve 11 // ButtonSml[11]
            new Button(804,580,1145,167), // valve 11 // ButtonSml[12]
            new Button(1417,292,557,456), // valve 11 // ButtonSml[13]
            new Button(1430,542,569,208), // valve 11 // ButtonSml[14]
            new Button(1511,293,513,458), // valve 11 // ButtonSml[15]
        };

        public ObservableCollection<Button> ButtonsPmpR { get; } = new ObservableCollection<Button>
        {
            new Button(383, 146, 1078, 516) // pump 1 // ButtonPmpR[0]
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
