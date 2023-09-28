using System;

Console.WriteLine("Fecha de cumpleaños");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine();

Console.Write("Ingrese su fecha de cumpleaños (MM/DD/YYYY): ");
if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaCumpleaños))
{
    DateTime FechaAct = DateTime.Now;
    DateTime proxCumpleaños = new DateTime(FechaAct.Year, fechaCumpleaños.Month, fechaCumpleaños.Day);

    if (proxCumpleaños < FechaAct)
    {
        proxCumpleaños = proxCumpleaños.AddYears(1);
    }

    TimeSpan Diasres = proxCumpleaños - FechaAct;
    int diasRes = Diasres.Days;

    Console.WriteLine();
    Console.WriteLine($"Su fecha de cumpleaños es: " + fechaCumpleaños);
    Console.WriteLine();

    Console.WriteLine($"Días restantes para su próximo cumpleaños: " + diasRes);
}
else
{
    Console.WriteLine();

    Console.WriteLine("Formato de fecha incorrecto.");

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("---------------------------------------------------");

//Jose Roberto Orellana Rodriguez