using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy Machine.xaml
    /// </summary>
    public partial class Machine : UserControl
    {
        ObservableCollection<Print> printsList = new ObservableCollection<Print>();
        public Machine()
        {
            InitializeComponent();
            this.DataContext = printsList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
            DateTimeOffset date = addWindow.NewDate.SelectedDate.Value.Date;
            string name = addWindow.NewName.Text.ToString();
            string description = addWindow.Description.Text.ToString();
            bool? calibration = addWindow.NewCallibration.IsChecked;
            printsList.Add(new Print(14, date, name, description, calibration));
        }
    }
}
