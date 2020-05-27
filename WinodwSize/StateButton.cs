using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WinodwSize
{
    public class StateButton
    {
        static public ObservableCollection<Button> Button { get; set; } = new ObservableCollection<Button>();
        static public ObservableCollection<Button> ButtonV { get; set; } = new ObservableCollection<Button>();
        static public ObservableCollection<Button> ButtonSml { get; set; } = new ObservableCollection<Button>();
        static public ObservableCollection<Button> ButtonPmpR { get; set; } = new ObservableCollection<Button>();
        static public ObservableCollection<Button> ButtonPmpL { get; set; } = new ObservableCollection<Button>();
    }
}
