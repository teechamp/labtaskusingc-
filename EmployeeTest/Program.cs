using System;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee employee1 = new Employee("James", "Stuart", 5000M);
            Employee employee2 = new Employee("Daniel", "Campbell", 30000M);

            employee1.GetEmployeeSalary();
            employee2.GetEmployeeSalary();

            employee1.TenPercentRaise();
            employee2.TenPercentRaise();

            employee1.GetEmployeeSalary();
            employee2.GetEmployeeSalary();

             Console.WriteLine($"The salary of employee1 is :{employee1.GetEmployeeSalary()} and the percent raise is {employee1.TenPercentRaise()}");
             Console.WriteLine($"The salary of employee2 is :{employee2.GetEmployeeSalary()} and the percent raise is {employee2.TenPercentRaise()}");
           
        }
    }
}
