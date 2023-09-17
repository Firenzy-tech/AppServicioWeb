namespace EmployeeOOP.Classes
{
    public abstract class Employee
    {
        public Employee()
        {
                
        }
        #region Properties
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public Date? BirthDate { get; set; }

        public Date? HiringDate { get; set; }

        public bool IsActive { get; set; }
        #endregion

        #region Methods
        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"INFORMACION EMPLEADO \n\t " +
                $"ID: {Id}\n\t" +
                $"Primer : {FirstName}\n\t" +
                $"Apellidos : {LastName}\n\t" +
                $"Fecha de Cumpleaños : {BirthDate}\n\t" +
                $"¿Empleado esta Activo {IsActive}\n\t";
        }
        #endregion
    }
}
