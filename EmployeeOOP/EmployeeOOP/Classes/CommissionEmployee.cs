namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
        public CommissionEmployee()
        {
                
        }
        #region Properties
        public decimal CommisionPercentaje { get; set; }
        public decimal Sales { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            if (Sales > 0)
            {
                return (Sales * CommisionPercentaje);
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Porcentaje de Comisión {CommisionPercentaje}\n\t" +
                $"Total ventas {Sales}\n\t";
        } 
        #endregion
    }
}
