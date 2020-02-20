using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections;
using System.Data;
using System.Collections.ObjectModel;
using LiveCharts;
using LiveCharts.Wpf;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows;
using socgen_taux.Model;

namespace socgen_taux.ViewModel
{
    class MainWindowViewModel : BindableBase
    {
        //Taux spot
        private double r3;
        private double r6;
        private double r9;

        //Taux forward
        private double r3F;
        private double r6F;
        private double r9F;
        private double r12F;

        public double R3
        {
            get => r3;
            set => SetProperty(ref r3, value);
        }

        public double R6
        {
            get => r6;
            set => SetProperty(ref r6, value);
        }

        public double R9
        {
            get => r9;
            set => SetProperty(ref r9, value);
        }

        public double R3F
        {
            get => r3F;
            set => SetProperty(ref r3F, value);
        }

        public double R6F
        {
            get => r6F;
            set => SetProperty(ref r6F, value);
        }

        public double R9F
        {
            get => r9F;
            set => SetProperty(ref r9F, value);
        }

        public double R12F
        {
            get => r12F;
            set => SetProperty(ref r12F, value);
        }

        public ICommand simulationCommand
        {
            get; private set;
        }

        public ICommand simulationForwardCommand
        {
            get; private set;
        }

        public MainWindowViewModel()
        {
            simulationCommand = new DelegateCommand(SimulationCommande);
            simulationForwardCommand = new DelegateCommand(SimulationForwardCommande);
        }

        private SeriesCollection createSeries(Interpolation interpolation)
        {
            ChartValues<double> rateValues = new ChartValues<double>();
            for (int i = 0; i < 365; i++)
            {
                rateValues.Add(interpolation.computeRate(i*0.00274));
            }
            SeriesCollection series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Rate Curve",
                        Values = rateValues,
                        PointGeometry = null
                    }
                };
            return series;
        }

        bool verifInput()
        {
            //Lower than zero rate are authorized.
            if (R3 <= 0 || R3 >= 100)
            {
                MessageBox.Show("L'entrée du taux 3 mois n'est pas conforme.");
                return false;
            }
            if (R6 <= 0 || R6 >= 100)
            {
                MessageBox.Show("L'entrée du taux 6 mois n'est pas conforme.");
                return false;
            }
            if (R9 <= 0 || R9 >= 100)
            {
                MessageBox.Show("L'entrée du taux 9 mois n'est pas conforme.");
                return false;
            }
            return true;
        }

        bool verifInputForward()
        {
            //Lower than zero rate are authorized.
            if (R3F <= 0 || R3F >= 100)
            {
                MessageBox.Show("L'entrée du taux 3 n'est pas conforme.");
                return false;
            }
            if (R6F <= 0 || R6F >= 100) {
                MessageBox.Show("L'entrée du taux 3x6 n'est pas conforme.");
                return false;
            }
            if (R9F <= 0 || R9F >= 100)
            {
                MessageBox.Show("L'entrée du taux 3x9 n'est pas conforme.");
                return false;
            }
            if (R12F <= 0 || R12F >= 100)
            {
                MessageBox.Show("L'entrée du taux 3x12 n'est pas conforme.");
                return false;
            }
            return true;
        }

        void SimulationForwardCommande()
        {
            if (verifInputForward())
            {
                Interpolation interpolation = new Interpolation();
                var newRates = interpolation.TransfromRate(r3F, r6F, r9F, r12F);
                interpolation.setParam(r3F, newRates.Item1 - r3F, newRates.Item2 - r3F, newRates.Item3 - r3F);
                ResultsView resultView = new ResultsView(createSeries(interpolation), interpolation);
                resultView.Show();
            }
        }

        void SimulationCommande()
        {
            if (verifInput())
            {
                Interpolation interpolation = new Interpolation();
                interpolation.setParam(0, r3, r6, r9);
                ResultsView resultView = new ResultsView(createSeries(interpolation), interpolation);
                resultView.Show();
            }
        }
    }
}

