﻿namespace EmployeeOOP.Classes
{
    public class SalaryEmployee : Employee
    {
        public SalaryEmployee()
        {
                
        }

        #region MyRegion
        public decimal Salary { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {

           return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario devengado {Salary:C2}\n\t";
        }
        #endregion
    }
}
