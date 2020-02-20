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
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.VisualBasic;
using socgen_taux.Model;
using socgen_taux.ViewModel;

namespace socgen_taux
{
    /// <summary>
    /// Logique d'interaction pour Portfolio.xaml
    /// </summary>
    public partial class ResultsView : Window
    {
        public ResultsView(SeriesCollection series, Interpolation interpolation)
        {
            InitializeComponent();
            this.DataContext = new ResultsViewModel(series, interpolation);
        }
    }
}
