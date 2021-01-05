using System;

namespace Projekt_GIK299
{
    public class OhmLaw
    {
        public double R;
        public double I;
        public double U;
        public string result = "";
        public string RAsString
        {
            get
            {
                return R > 0 ? R.ToString() : "";
            }
        }
        public string IAsString
        {
            get
            {
                return I > 0 ? I.ToString() : "";
            }
        }
        public string UAsString
        { 
            get
            {
                return U > 0 ? U.ToString() : "";
            }
        }
        public void CalcOhm(double Rcalc, double Ucalc, double Icalc)
        {
            if (Ucalc > 0 && Icalc > 0)
            {
                double RTot = Ucalc / Icalc;
                Console.WriteLine($"\nDen beräknade resistansen är: {RTot:F2} Ω \n ");
            }
            else
            {
                Console.WriteLine($"\nInmatade värdet för resistansen är: {Rcalc}. Ω\n ");
            }
            if (Rcalc > 0 && Icalc > 0)
            {
                double UTot = Rcalc * Icalc;
                Console.WriteLine($"Den beräknade spänningen är: {UTot:F2} V \n ");
            }
            else
            {
                Console.WriteLine($"Inmatade värdet för spänningen är: {Ucalc} V.\n ");
            }
            if (Ucalc > 0 && Rcalc > 0)
            {
                double ITot = Ucalc/Rcalc;
                Console.WriteLine($"Den beräknade strömstyrkan är: {ITot:F2} A \n ");
            }
            else
            {
                Console.WriteLine($"Inmatade värdet för strömstyrkan är: {Icalc} A.\n ");
            }
        }
    }
}