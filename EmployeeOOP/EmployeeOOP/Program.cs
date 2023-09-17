using EmployeeOOP.Classes;

try
{
    int hours;
    decimal commisionPercentaje = 0;
    decimal hourValue = 0;
    //Declaración de variables
    int day, month, year;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.WriteLine("Ingrese nombre completo: ");
    string? firtName = Console.ReadLine();

    Console.WriteLine("Ingrese apellidos: ");
    string? lastName = Console.ReadLine();

    Console.WriteLine("Ingrese Salario Devengado: ");
    decimal salary = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Ingrese valor en ventas: ");
    decimal sales = Convert.ToDecimal(Console.ReadLine());

    if (sales > 0)
    {
        Console.WriteLine("Ingrese Porcentaje a pagar en ventas: ");
        commisionPercentaje = Convert.ToDecimal(Console.ReadLine());
    }

    Console.WriteLine("Ingrese Cantidad de horas adicionales: ");
    hours = Convert.ToInt16(Console.ReadLine());

    if (hours > 0)
    {
        Console.WriteLine("Ingrese el valor de la hora: ");
        hourValue = Convert.ToDecimal(Console.ReadLine());
    }

    SalaryEmployee salaryEmployee = new()
    {
        Id = 123456,
        FirstName = firtName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary

    };

    CommissionEmployee commissionEmployee = new()
    {
        Sales = sales,
        CommisionPercentaje = commisionPercentaje,
    };

    HourlyEmployee hourlyEmployee = new()
    {
        Hours = hours,
        HourValue = hourValue
    };

    Console.WriteLine(salaryEmployee);
    if (hours > 0)
    {
        Console.WriteLine(hourlyEmployee);
        Console.WriteLine($"---VARLOR A PAGAR EN HORAS--- {hourlyEmployee.GetValueToPay()}");
    }
    if (sales > 0)
    {
        Console.WriteLine(commissionEmployee);
        Console.WriteLine($"---VARLO A PAGAR EN COMISIÓN--- {hourlyEmployee.GetValueToPay()}");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}