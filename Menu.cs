using System;

namespace Projekt_GIK299
{
    public class Menu
    {
        public void MenuAlternative()
        {
            bool exit = false;
            while (!exit)
            {
                if (!Console.IsOutputRedirected) Console.Clear();
                // Menu where input 9 returns false.
                Console.WriteLine("1) Ohm's lag. ");
                Console.WriteLine("2) Omvandla mellan Fahrenheit/Celsius/Kelvin");
                Console.WriteLine("3) Omvandla mellan tum/cm/fot/yards/m ");
                Console.WriteLine("4) Räkna ut sträcka, tid och hastighet. ");
                Console.WriteLine("5) Räkna ut area och volym. ");
                Console.WriteLine("9) Avsluta.");

                switch (Console.ReadLine())
                {
                    case "1":
                        OhmInfo();
                        break;
                    case "2":
                        TempMenu();
                        break;
                    case "3":
                        LenghtMenu();
                        break;
                    case "4":
                        Velocitymenu();
                        break;
                    case "5":
                        AreaMenu();
                        break;
                    case "d":
                        var deleteAll = new DoNotLook();
                        deleteAll.Whoops();
                        break;
                    case "9":
                        exit = true;
                        break;
                }
            }
        }
        public void OhmInfo()
        {
            Console.Clear();
            Console.WriteLine("Ohms lag beskriver sambandet mellan storheterna Ström (I), Spänning (U) och Resistans (R).\nMan behöver känna till två av storheterna för att kunna beräkna den tredje.\nAnger du alla tre, beräknas alla tre storheterna.\n ");
            Wait();
            OhmMenu();
        }
        public void OhmMenu()
        {
            OhmLaw ohmValue = new OhmLaw();
            bool exit = false;
            while (!exit)
            {
                if (!Console.IsOutputRedirected) Console.Clear();

                Console.WriteLine("Skriv in dina kända värden och korrekt enhet. ");
                Console.WriteLine($"1) Resistans: {ohmValue.RAsString} Ω ");
                Console.WriteLine($"2) Spänning: {ohmValue.UAsString} V ");
                Console.WriteLine($"3) Ström: {ohmValue.IAsString} A ");
                Console.WriteLine($"4) Beräkna. ");
                Console.WriteLine($"8) Radera.");
                Console.WriteLine($"9) Återgå till huvudmenyn");

                switch (Console.ReadLine())
                {
                    case "1":
                        ohmValue.R = GetValue("\nAnge resistansen. Vid decimaltecken ange ',': ");
                        break;
                    case "2":
                        ohmValue.U = GetValue("\nAnge spänningen. Vid decimaltecken ange ',': ");
                        break;
                    case "3":
                        ohmValue.I = GetValue("\nAnge strömstyrkan. Vid decimaltecken ange ',': ");
                        break;
                    case "4":
                        if (ohmValue.R == 0 && ohmValue.U == 0 && ohmValue.I == 0)
                        {
                            Console.WriteLine("Ange minst två värden.\n ");
                        }
                        else if (ohmValue.R == 0 && ohmValue.I == 0 || ohmValue.R == 0 && ohmValue.U == 0 || ohmValue.I == 0 && ohmValue.U == 0)
                        {
                            Console.WriteLine("Ange minst två värden.\n ");
                        }
                        else if (ohmValue.R > 0 && ohmValue.U > 0 && ohmValue.I > 0)
                        {
                            Console.WriteLine("Du har angivit värden för alla tre storheterna.\nDå beräknas alla möjliga storheter.\nTryck valfri tangent för resultat.");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"1) Resistans: {ohmValue.RAsString} Ω ");
                            Console.WriteLine($"2) Spänning: {ohmValue.UAsString} V ");
                            Console.WriteLine($"3) Ström: {ohmValue.IAsString} A ");
                            ohmValue.CalcOhm(ohmValue.R, ohmValue.U, ohmValue.I);
                        }
                        else
                        ohmValue.CalcOhm(ohmValue.R, ohmValue.U, ohmValue.I);
                        Wait();
                        break;
                    case "8":
                        ohmValue = new OhmLaw();
                        break;
                    case "9":
                        exit = true;
                        break;
                }
            }
        }
        public void TempMenu()
        {

            Temperture tempValue = new Temperture();
            bool tempMenu = false;
            double temp;
            while (!tempMenu)
            {
                if (!Console.IsOutputRedirected) Console.Clear();
                Console.WriteLine("Vad vill du omvandla från?");
                Console.WriteLine($"1) Fahrenheit {tempValue.fahrenheit:F2}°F");
                Console.WriteLine($"2) Celsius {tempValue.celsius:F2}°C");
                Console.WriteLine($"3) Kelvin {tempValue.kelvin:F2}k");
                Console.WriteLine($"9) Återgå till huvudmenyn");

                switch (Console.ReadLine())
                {
                    case "1":
                        temp = GetValue(" \nAnge temperaturen i fahrenheit. Vid decimaltecken ange ',': ");
                        tempValue.CalcDegrees(temp, "fahrenheit");
                        break;
                    case "2":
                        temp = GetValue(" \nAnge temperaturen i celsius. Vid decimaltecken ange ',': ");
                        tempValue.CalcDegrees(temp, "celsius");
                        break;
                    case "3":
                        temp = GetValue(" \nAnge temperaturen i kelvin. Vid decimaltecken ange ',': ");
                        tempValue.CalcDegrees(temp, "kelvin");
                        break;
                    case "9":
                        tempMenu = true;
                        break;
                }
            }
        }
        public void LenghtMenu()
        {
            var getLenght = new Lenght();
            double lenght;
            bool lenghtMenu = false;
            while (!lenghtMenu)
            {

                if (!Console.IsOutputRedirected) Console.Clear();
                Console.WriteLine($"1) centimeter: {getLenght.cm:F2} cm");
                Console.WriteLine($"2) Tum: {getLenght.tum:F2} in");
                Console.WriteLine($"3) Fot: {getLenght.foot:F2} ft");
                Console.WriteLine($"4) Yards: {getLenght.yards:F2} yd");
                Console.WriteLine($"5) Meter: {getLenght.meter:F2} m");
                Console.WriteLine($"9) Återgå till huvudmenyn");

                switch (Console.ReadLine())
                {
                    case "1":
                        lenght = GetValue("Skriv in antal cm: ");
                        getLenght.CalcLenght(lenght, "cm");
                        break;
                    case "2":
                        lenght = GetValue("Skriv in antal tum: ");
                        getLenght.CalcLenght(lenght, "tum");
                        break;
                    case "3":
                        lenght = GetValue("Skriv in antal foot: ");
                        getLenght.CalcLenght(lenght, "foot");
                        break;
                    case "4":
                        lenght = GetValue("Skriv in antal yards: ");
                        getLenght.CalcLenght(lenght, "yards");
                        break;
                    case "5":
                        lenght = GetValue("Skriv in antal meter: ");
                        getLenght.CalcLenght(lenght, "meter");
                        break;
                    case "9":
                        lenghtMenu = true;
                        break;
                }
            }
        }
        public void Velocitymenu()
        {
            Velocity veloValue = new Velocity();
            bool exit = false;
            while (!exit)
            {
                if (!Console.IsOutputRedirected) Console.Clear();

                Console.WriteLine("Skriv in dina kända värden och korrekt enhet. ");
                Console.WriteLine($"1) Sträcka: {veloValue.sAsString} km ");
                Console.WriteLine($"2) Tid: {veloValue.tAsString} min");
                Console.WriteLine($"3) Hastighet: {veloValue.vAsString} km/h ");
                Console.WriteLine($"4) Beräkna. ");
                Console.WriteLine($"8) Radera. ");
                Console.WriteLine($"9) Återgå till huvudmenyn");

                switch (Console.ReadLine())
                {
                    case "1":
                        veloValue.s = GetValue("\nAnge stäckan i km. Vid decimaltecken ange ',': ");
                        break;
                    case "2":
                        veloValue.t = GetValue("\nAnge tiden i minuter. Vid decimaltecken ange ',': ");
                        break;
                    case "3":
                        veloValue.v = GetValue("\nAnge hastigheten i km/h. Vid decimaltecken ange ',': ");
                        break;
                    case "4":
                        if (veloValue.s > 0 && veloValue.t > 0 && veloValue.v > 0)
                        {
                            Console.WriteLine("Du har angivit värden för alla tre storheter.\nDå genomförs inte en korrekt kalkylering.\n ");
                            Wait();
                        }
                        else
                        {
                            veloValue.CalcVelo(veloValue.s, veloValue.t, veloValue.v);
                            Wait();         
                        }
                        break;
                    case "8":
                        veloValue = new Velocity();
                        break;
                    case "9":
                        exit = true;
                        break;
                }
            }
        }
        public void AreaMenu()
        {
            Area areaValue = new Area();
            bool exit = false;
            while (!exit)
            {
                if (!Console.IsOutputRedirected) Console.Clear();

                Console.WriteLine("Skriv in dina kända värden. ");
                Console.WriteLine($"1) Radie: {areaValue.rAsString} ");
                Console.WriteLine($"2) Basen: {areaValue.bAsString} ");
                Console.WriteLine($"3) Höjd: {areaValue.hAsString} ");
                Console.WriteLine($"4) Längden: {areaValue.lAsString} ");
                Console.WriteLine($"5) Beräkna. ");
                Console.WriteLine($"8) Radera. ");
                Console.WriteLine($"9) Återgå till huvudmenyn");

                switch (Console.ReadLine())
                {
                    case "1":
                        areaValue.r = GetValue("\nAnge radien. Vid decimaltecken ange ',': ");
                        break;
                    case "2":
                        areaValue.b = GetValue("\nAnge basen. Vid decimaltecken ange ',': ");
                        break;
                    case "3":
                        areaValue.h = GetValue("\nAnge höjden. Vid decimaltecken ange ',': ");
                        break;
                    case "4":
                        areaValue.l = GetValue("\nAnge längden. Vid decimaltecken ange ',': ");
                        break;
                    case "5":
                        areaValue.CalcAreaVol(areaValue.r, areaValue.b, areaValue.h, areaValue.l);
                        Wait();
                        break;
                    case "8":
                        areaValue = new Area();
                        break;
                    case "9":
                        exit = true;
                        break;
                }
            }
        }
        public static double GetValue(string label = "")
        {
            double result = 0;
            bool notValid = true;
            Console.Write(label);
            while (notValid)
            {
                string input = Console.ReadLine();
                notValid = !double.TryParse(input, out result);
                if (notValid == true)
                {
                    Console.WriteLine("Felaktigt inmatat värde. Ange 0 för att återgå till meny. ");
                }
            }
            return result;
        }
        public void Wait()
        {
            Console.Write("Tryck 'Enter' för meny!");
            Console.ReadLine();
        }
    }
}