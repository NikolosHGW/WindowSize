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
            //new Button(396, 376), // Button[9]
            //new Button(267, 310), // Button[10]
            //new Button(267, 374), // Button[11]
            //new Button(553, 508), // Button[12]
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
