namespace EmployeeTest
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public decimal MonthlySalary { get; set; }

         public Employee(string firstname,  string lastname, decimal monthlysalary)
        {
            FirstName = firstname;
            LastName = lastname;
            if 
            ( MonthlySalary < 0.0M) {
                monthlysalary = 0;
            } else {
                MonthlySalary = monthlysalary;
            }
            
        }
         public decimal GetEmployeeSalary()
    {
      return MonthlySalary;
    }
    public decimal TenPercentRaise()
    {
      MonthlySalary = (0.10M * MonthlySalary) + MonthlySalary;
      return MonthlySalary;
       }
   }

}

