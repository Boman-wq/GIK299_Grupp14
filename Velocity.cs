using System;

namespace Projekt_GIK299
{
    public class Velocity
    {
        public double s;
        public double t;
        public double v;
        public string result = "";
        public string sAsString
        {
            get
            {
                return s > 0 ? s.ToString() : "";
            }
        }
        public string tAsString
        {
            get
            {
                return t > 0 ? t.ToString() : "";
            }
        }
        public string vAsString
        {
            get
            {
                return v > 0 ? v.ToString() : "";
            }
        }
        public void CalcVelo(double sCalc, double tCalc, double vCalc)
        {
            if (tCalc > 0 && vCalc > 0)
            {
                tCalc = tCalc/60;
                double sTot = tCalc * vCalc;
                Console.WriteLine($"Den beräknade sträckan är: {sTot:F2} km ");
            }
            else
            {
                Console.WriteLine("Sträckan gick ej att beräkna med dina angivna värden.\n ");
            }
            if (sCalc > 0 && vCalc > 0)
            {

                double tTot = (sCalc / vCalc)*60;
                Console.WriteLine($"Den beräknade tiden är: {tTot:F2} min ");
            }
            else
            {
                Console.WriteLine("Tiden gick ej att beräkna med dina angivna värden.\n ");
            }
            if (tCalc > 0 && sCalc > 0)
            {
                tCalc = tCalc/60;
                double vTot = sCalc/tCalc;
                Console.WriteLine($"Den beräknade hastigheten är: {vTot:F2} km/h ");
            }
            else
            {
                Console.WriteLine("Hastigheten gick ej att beräkna med dina angivna värden.\n ");
            }
        }
    }
}