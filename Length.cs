using System;

namespace Projekt_GIK299
{
    public class Lenght
    {
        public double cm;
        public double tum;
        public double yards;
        public double foot;
        public double meter;

        public void CalcLenght(double input, string lengthType){
            if(lengthType == "cm" && input >= 0){
                cm = input;
                tum = CentimeterToTum(input);
                yards = CentimeterToYards(input);
                foot = CentimeterToFoot(input);
                meter = CentimeterToMeter(input);
                
            }
            else if(lengthType == "tum" && input >= 0){
                tum = input;
                cm = TumToCentimeter(input);
                yards = TumToYards(input);
                foot = TumToFoot(input);
                meter = TumToMeter(input);
            }
            else if(lengthType == "yards" && input >= 0){
                yards = input;
                cm = YardsToCentimeter(input);
                tum = YardsToTum(input);
                foot = YardsToFoot(input);
                meter = YardsToMeter(input);
            }
            else if (lengthType == "foot" && input >= 0){
                foot = input;
                cm = FotToCentimeter(input);
                tum = FotToTum(input);
                yards = FotToYard(input);
                meter = FotToMeter(input);
            }
            else if(lengthType == "meter" && input >= 0){
                meter = input;
                cm = MeterToCentimeter(input);
                tum = MeterToTum(input);
                yards = MeterToYards(input);
                foot = MeterToFoot(input);
            }
            else{
                Console.Clear();
                Console.WriteLine("En längdenhet kan inte vara negativ, skriv in ett värde som är större än 0 :)");
                Console.ReadLine();
                cm = 0;
                tum = 0;
                yards = 0;
                foot = 0;
                meter = 0;
            }
        }
        private double CentimeterToTum(double cm){
            return cm * 0.3937;
        }
        private double CentimeterToFoot(double cm){
            return cm * 0.0328;
        }
        private double CentimeterToYards(double cm){
            return cm * 0.0109;
        }   
        private double CentimeterToMeter(double cm){
            return cm * 0.01;
        }

        private double TumToCentimeter(double inch){
            return inch * 2.54;
        }
        private double TumToFoot(double inch){
            return inch * 0.0833;
        }
        private double TumToYards(double inch){
            return inch * 0.0278;
        }
        private double TumToMeter(double inch){
            return inch * 0.0254;
        }

        private double YardsToTum(double yd){
            return yd * 36;
        }
        private double YardsToCentimeter(double yd){
            return yd * 91.44;
        }
        private double YardsToFoot(double yd){
            return yd * 3;
        }
        private double YardsToMeter(double yd){
            return yd * 0.9144;
        }

        private double FotToTum(double f)
        {
            return f * 12;
        }
        private double FotToCentimeter(double f)
        {
            return f * 30.48;
        }
        private double FotToYard(double f)
        {
            return f * 0.3333;
        }
        private double FotToMeter(double f)
        {
            return f * 0.3048;
        }

        private double MeterToTum(double m){
            return m * 39.3701;
        }
        private double MeterToCentimeter(double m){
            return m * 100;
        }
        private double MeterToFoot(double m){
            return m * 3.2808;
        }
        private double MeterToYards(double m){
            return m * 1.0936;
        }
    }
}