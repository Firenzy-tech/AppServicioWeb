namespace EmployeeOOP.Classes
{
    internal class BaseCommissionEmployee : Employee
    {
        public decimal Base { get; set; }
        public override decimal GetValueToPay()
        {
            return Base;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        
    }
}
