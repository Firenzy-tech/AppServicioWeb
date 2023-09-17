namespace EmployeeOOP.Classes
{
    internal class HourlyEmployee : Employee
    {

        public HourlyEmployee()
        {
                
        }
        #region Properties
        public int Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion
        public override decimal GetValueToPay()
        {
            return  Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Horas trabajadas  {Hours}\n\t" +
                $"Varlo Hora trabajada {HourValue}\n\t";

        }
    }
}

