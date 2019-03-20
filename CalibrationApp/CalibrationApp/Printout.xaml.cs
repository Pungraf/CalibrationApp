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
    /// Logika interakcji dla klasy Printout.xaml
    /// </summary>
    public partial class Printout : UserControl
    {
        private DateTimeOffset date;
        private string descritpion;
        private bool calibration;

        public static readonly DependencyProperty PrintoutTextProperty =
            DependencyProperty.Register("Name", typeof(String),
            typeof(Printout), new FrameworkPropertyMetadata(string.Empty));

        public new String Name
        {
            get { return GetValue(PrintoutTextProperty).ToString(); }
            set { SetValue(PrintoutTextProperty, value); }
        }

        public DateTimeOffset Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        
        public string Description
        {
            get { return this.descritpion; }
            set { this.descritpion = value; }
        }
        public bool Calibration
        {
            get { return this.calibration; }
            set { this.calibration = value; }
        }




        public Printout()
        {
            InitializeComponent();
        }
    }
}
