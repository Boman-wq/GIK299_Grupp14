using System;
// Sfärvolym == (4pir^3)/3
// Sfärarea == 4pir^2
// Pyramidvolym/kon == (b*l*h)/3
// rektangel == b*h
// trangel == b*h/2
// Cirkel == r*r*pi
// kub == b^3
namespace Projekt_GIK299
{
    public class Area
    {
        public double r;    // radie
        public double b;    // bas
        public double h;    // höjd
        public double l;    // längd
        public double pi = Math.PI;
        public double sfVol;
        public double sfArea;
        public double cArea;
        public double cubeVol;
        public double cubeArea;
        public double rektArea;
        public double rektVol;
        public double blockArea;
        public double triArea;
        public double pyrVol;
        public string result = "";
        public string rAsString
        {
            get
            {
                return r > 0 ? r.ToString() : "";
            }
        }
        public string bAsString
        {
            get
            {
                return b > 0 ? b.ToString() : "";
            }
        }
        public string hAsString
        {
            get
            {
                return h > 0 ? h.ToString() : "";
            }
        }
        public string lAsString
        {
            get
            {
                return l > 0 ? l.ToString() : "";
            }
        }
        public void CalcAreaVol(double r, double b, double h, double l)
        {
            if (r > 0)
            {
                sfVol = (4 * pi * r * r * r) / 3;
                sfArea = (4 * pi * r * r);
                cArea = r * r * pi;
                Console.WriteLine($"\nSfärens volym är: {sfVol:F2}ve\n ");
                Console.WriteLine($"Sfärens area är: {sfArea:F2}ae\n ");
                Console.WriteLine($"Cirkelns area är: {cArea:F2}ae\n ");
            }
            if (b > 0)
            {
                cubeVol = b * b * b;
                cubeArea = 6 * b * b;
                Console.WriteLine($"\nKubens volym är: {cubeVol:F2}ve och dess area är: {cubeArea:F2}ae\n ");

            }
            if (b > 0 && h > 0)
            {
                triArea = b * h / 2;
                rektArea = b * h;
                Console.WriteLine($"Triangelns area är: {triArea:F2}ae\n ");
                Console.WriteLine($"Rektangelns area är: {rektArea:F2}ae\n ");
            }
            if (b > 0 && h > 0 && l > 0)
            {
                pyrVol = b * h * l / 3;
                rektVol = b * h * l;
                blockArea = 2 * b * h + 2 * h * l + 2 * b * l;
                Console.WriteLine($"Pyramidens volym är: {pyrVol:F2}ve\n ");
                Console.WriteLine($"Rätblockets volym är: {rektVol:F2}ve\n ");
                Console.WriteLine($"Rätblockets area är: {blockArea:F2}ae\n ");
            }
            if (b > 0 && l > 0 || l > 0 && h > 0)
            {
                rektArea = b * l;
                Console.WriteLine($"En möjlig rektangeln area är: {rektArea:F2}ae\n ");
                rektArea = h * l;
                Console.WriteLine($"Rektangelns area är: {rektArea:F2}ae\n ");
            }
        }
    }

}