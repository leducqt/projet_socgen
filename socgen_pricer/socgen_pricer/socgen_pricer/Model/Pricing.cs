using Meta.Numerics.Statistics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socgen_pricer.Model
{
    class Pricing
    {
        public double PricerB(double nominal, double nbPeriod, double r, double tauxCoupon, double nbCoupon)
        {
            double C = nominal * tauxCoupon / nbCoupon;
            return C * (1 - Math.Pow(1 + r, -nbPeriod)) / r + nominal * Math.Pow(1 + r, -nbPeriod);
        }

        public double PricerF(double spot, double r, double T)
        {
            return spot * Math.Exp(r * T);
        }

        public double PricerC(double spot, double K, double r, double T, double vol)
        {
            var distrib = new NormalDistribution();
            var d1 = 1 / (vol * Math.Sqrt(T)) * (Math.Log(spot / K) + (r + Math.Pow(vol, 2) / 2) * T);
            var d2 = d1 - vol * Math.Sqrt(T);
            return spot*distrib.LeftProbability(d1) - K*Math.Exp(-r*T)*distrib.LeftProbability(d2);
        }

        public double PricerP(double spot, double K, double r, double T, double vol)
        {
            var distrib = new NormalDistribution();
            var d1 = 1 / (vol * Math.Sqrt(T)) * (Math.Log(spot / K) + (r + Math.Pow(vol, 2) / 2) * T);
            var d2 = d1 - vol * Math.Sqrt(T);
            return - spot * distrib.LeftProbability(-d1) + K * Math.Exp(-r * T) * distrib.LeftProbability(-d2);
        }
    }
}
