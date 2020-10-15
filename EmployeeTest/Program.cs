using System;
namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("temidayo", "samuel", 3000M);
            Employee employee2 = new Employee("samuel", "temidayo", 50000M);
            
            employee1.GetYearlySalary();
            employee2.GetYearlySalary();

            employee1.TenPercentRaise();
            employee2.TenPercentRaise();
            
            employee1.GetYearlySalary();
            employee2.GetYearlySalary();
        }
    }
}





