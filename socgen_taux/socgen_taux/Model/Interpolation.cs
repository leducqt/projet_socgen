using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socgen_taux.Model
{
    public class Interpolation
    {
        /*
         * This class is used for creating the rate curve from the rate values inputed by the user.
         * We use interpolation for the curve profile. 
         * R(t) =  a*t^3 + b*t^2 + c*t + d
         * With contrains :
         * R(0) = 0
         * R(0.25) = r3
         * R(0.5) = r6
         * R(0.75) = r9
         */
        private double a;
        private double b;
        private double c;
        private double d;
        private Matrix<double> timeCoeff;

        public Interpolation()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.d = 0;
            this.timeCoeff = Matrix<double>.Build.DenseOfArray(new double[,] {{ 0.0156, 0.0625, 0.25}, { 0.125, 0.25, 0.5}, { 0.4219, 0.5625, 0.75}});
        }

        public void setParam(double r0, double r3, double r6, double r9)
        {
            var r = Vector<double>.Build.Dense(new double[] { r3, r6, r9});
            var x = timeCoeff.Solve(r);
            this.a = x[0];
            this.b = x[1];
            this.c = x[2];
            this.d = r0;
        }

        public double computeRate(double time)
        {
            return a * Math.Pow(time, 3) + b * Math.Pow(time, 2) + c * time + d;
        }

        /*
         This method aims to transform forward rate into spot rate.
         */
        public (double, double, double) TransfromRate(double r3F, double r6F, double r9F, double r12F)
        {
            var toReturn = (100 * (Math.Pow((1 + r6F / 100), 0.5) * Math.Pow((1 + r3F / 100), 0.5) - 1), 
                100 * (Math.Pow((1 + r9F / 100), 0.6666) * Math.Pow((1 + r3F / 100), 0.3333) - 1),
                100 * (Math.Pow((1 + r12F / 100), 0.75) * Math.Pow((1 + r3F / 100), 0.25) - 1));
            return toReturn;
        }
    }
}
