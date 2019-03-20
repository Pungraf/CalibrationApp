using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalibrationApp
{
    /// <summary>
    /// Logika interakcji dla klasy MachineDisplay.xaml
    /// </summary>
    public partial class MachineDisplay : UserControl
    {
        public string Machine { get; set; }
        public string Station { get; set; }

        public MachineDisplay()
        {
            Machine = "Lisa Pro";
            Station = "A0";
            NewMachineWindow newMachineWindow = new NewMachineWindow();
            newMachineWindow.ShowDialog();
            Machine = newMachineWindow.MachineName.Text.ToString();
            Station = newMachineWindow.Place.Text.ToString();
            InitializeComponent();
            
        }
    }
}
