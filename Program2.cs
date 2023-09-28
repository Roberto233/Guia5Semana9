Console.WriteLine("Prestamo, Gastos de colegiatura ciclo 2-2023 UNAB Chalatenango");
Console.WriteLine("------------------------------------------------------------------");

int prestamo = 3000;
int MontoMes = 0;
int ciclo = 2;
int año = 2023;
int plazo = 6;
string estudiante = "Juan Perez";

Console.WriteLine();
Console.WriteLine("Datos del prestamo");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("Cantidad del prestamo: $" + prestamo);
Console.WriteLine("Ciclo: " + ciclo + " año: " + año);
Console.WriteLine("Plazo del prestamo: " + plazo + " meses.");
Console.WriteLine("Nombre del estudiante: " + estudiante);
Console.WriteLine("---------------------------------------------");

Console.WriteLine();
Console.WriteLine("Calculando el monto por mes");

MontoMes = prestamo / plazo;

Console.WriteLine("Su monto de pago por cada mes es: $" + MontoMes);
Console.WriteLine();
Console.WriteLine("------------------------------------------------");

Console.WriteLine();
DateTime fechaInicio = DateTime.Now;

Console.WriteLine("------------------------------------------------");
for (int i = 0; i < plazo; i++)
{
    Console.WriteLine();
    DateTime fechapago = fechaInicio.AddMonths(i);
    Console.WriteLine("Fecha de pago: "+ fechapago + " Mes: " + i + " Monto: $" + MontoMes);

}
Console.WriteLine();
Console.WriteLine("------------------------------------------------");

//Jose Roberto Orellana Rodriguez