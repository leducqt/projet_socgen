using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Controls;
using System.Windows.Input;
using socgen_taux.Model;
using System.Windows;

namespace socgen_taux.ViewModel
{
    class ResultsViewModel : BindableBase
    {
        private double time;
        private double rate;
        public Interpolation interpolation;
        SeriesCollection seriesCollection = new SeriesCollection();

        public ICommand computeCommand
        {
            get; private set;
        }

        public ResultsViewModel(SeriesCollection series, Interpolation interpolation)
        {
            computeCommand = new DelegateCommand(ComputeCommand);
            this.interpolation = interpolation;
            SeriesCollection = series;
        }

        public double Time
        {
            get => time;
            set => SetProperty(ref time, value);
        }

        public double Rate
        {
            get => rate;
            set => SetProperty(ref rate, value);
        }

        void ComputeCommand()
        {
            /*
             I decided to contrains the max input time at 2 year because after
             that the interpolation is not efficient at all. 
             Notice : between 1 and 2 year the curve is not precise due to the 
             fact that the last value inputed is a rate for before first year.
             */
            if (Time >= 0 && Time <= 2)
            {
                Rate = Math.Round(interpolation.computeRate(Time), 2);
            }
            else
            {
                MessageBox.Show("La date d'entrée doit être comprise entre 0 et 2.");
            }
        }

        public SeriesCollection SeriesCollection
        {
            get => seriesCollection;
            set => SetProperty(ref seriesCollection, value);
        }
    }
}
