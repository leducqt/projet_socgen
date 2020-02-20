using Prism.Commands;
using Prism.Mvvm;
using socgen_pricer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace socgen_pricer.ViewModel
{
    class MainWindowViewModel : BindableBase
    {
        //Pricing
        private Pricing pricer;

        //Bonds
        private double nominalB;
        private double tauxCouponB;
        private double nbCouponB;
        private double rB;
        private double nbPeriodB;
        private double priceB;
        
        public double NominalB
        {
            get => nominalB;
            set => SetProperty(ref nominalB, value);
        }

        public double RB
        {
            get => rB;
            set => SetProperty(ref rB, value);
        }

        public double TauxCouponB
        {
            get => tauxCouponB;
            set => SetProperty(ref tauxCouponB, value);
        }

        public double NbCouponB
        {
            get => nbCouponB;
            set => SetProperty(ref nbCouponB, value);
        }

        public double NbPeriodB
        {
            get => nbPeriodB;
            set => SetProperty(ref nbPeriodB, value);
        }

        public double PriceB
        {
            get => priceB;
            set => SetProperty(ref priceB, value);
        }

        //Future
        private double spotF;
        private double rF;
        private double maturityF;
        private double priceF;

        public double SpotF
        {
            get => spotF;
            set => SetProperty(ref spotF, value);
        }

        public double RF
        {
            get => rF;
            set => SetProperty(ref rF, value);
        }

        public double MaturityF
        {
            get => maturityF;
            set => SetProperty(ref maturityF, value);
        }

        public double PriceF
        {
            get => priceF;
            set => SetProperty(ref priceF, value);
        }

        //Option
        private double spotO;
        private double strikeO;
        private double rO;
        private double maturityO;
        private double volO;
        private double priceC;
        private double priceP;

        public double SpotO
        {
            get => spotO;
            set => SetProperty(ref spotO, value);
        }

        public double StrikeO
        {
            get => strikeO;
            set => SetProperty(ref strikeO, value);
        }

        public double RO
        {
            get => rO;
            set => SetProperty(ref rO, value);
        }

        public double MaturityO
        {
            get => maturityO;
            set => SetProperty(ref maturityO, value);
        }

        public double VolO
        {
            get => volO;
            set => SetProperty(ref volO, value);
        }

        public double PriceC
        {
            get => priceC;
            set => SetProperty(ref priceC, value);
        }

        public double PriceP
        {
            get => priceP;
            set => SetProperty(ref priceP, value);
        }

        //Commands
        public ICommand pricingB
        {
            get; private set;
        }

        public ICommand pricingF
        {
            get; private set;
        }

        public ICommand pricingO
        {
            get; private set;
        }

        public MainWindowViewModel()
        {
            PriceB = 0;
            PriceF = 0;
            PriceC = 0;
            PriceP = 0;
            pricingB = new DelegateCommand(PricingB);
            pricingF = new DelegateCommand(PricingF);
            pricingO = new DelegateCommand(PricingO);
            pricer = new Pricing();
        }

        bool verifInputsB()
        {
            if (TauxCouponB < 0 || NbPeriodB <= 0 || NbCouponB < 0 || RO != 0)
            {
                MessageBox.Show("Les entrées ne sont pas conformes.");
                return false;
            }
            return true;
        }

        bool verifInputsF()
        {
            if (SpotF <= 0 || MaturityF < 0)
            {
                MessageBox.Show("Les entrées ne sont pas conformes.");
                return false;
            }
            return true;
        }

        bool verifInputsO()
        {
            if (SpotO <= 0 || StrikeO <= 0 || MaturityO < 0 || VolO < 0)
            {
                MessageBox.Show("Les entrées ne sont pas conformes.");
                return false;
            }
            return true;
        }

        void PricingB()
        {
            if (verifInputsB())
            {
                PriceB = Math.Round(pricer.PricerB(NominalB, NbPeriodB, RB, TauxCouponB, NbCouponB),2);
            } 
        }

        void PricingF()
        {
            if (verifInputsF())
            {
                PriceF = Math.Round(pricer.PricerF(SpotF, RF, MaturityF),2);
            }
        }

        void PricingO()
        {
            if (verifInputsO())
            {
                PriceC = Math.Round(pricer.PricerC(SpotO, StrikeO, RO, MaturityO, VolO), 2);
                PriceP = Math.Round(pricer.PricerP(SpotO, StrikeO, RO, MaturityO, VolO), 2);
            }
        }
    }
}
