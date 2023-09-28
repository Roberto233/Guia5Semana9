Console.WriteLine("Año Bisiesto");
Console.WriteLine("-------------------------------------------------");

int[] years = new int[9] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

foreach (int year in years)
{
    bool bisiesto = DateTime.IsLeapYear(year);
    Console.WriteLine("¿El año, " + year + " es año bisiesto?: " + bisiesto);
    Console.WriteLine();
}

Console.WriteLine("-------------------------------------------------");

//Jose Roberto Orellana Rodriguez

