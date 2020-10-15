namespace EmployeeTest
{
    public class Employee
    {
        string firstName;
        string lastName;
        decimal monthlySalary;
        public Employee(string firstName, string lastName, decimal monthlySalary){
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }
            public string LastName{
                get{
                    return lastName;
                }
                set{
                    lastName = value;
                }
            }
            public string FirstName{
                get{
                    return firstName;
                }
                set{
                    firstName = value;
                }
            }
            public decimal MonthlySalary{
                get{
                    return monthlySalary;
                }
                set{
                    if(monthlySalary > 0.0M){
                    monthlySalary = value;
                    }
                }
            }
            public decimal GetYearlySalary(){
               return MonthlySalary *12;
            }
            public decimal TenPercentRaise(){
                decimal raise = 0.1M * monthlySalary;
                monthlySalary = monthlySalary + raise;
                return monthlySalary;
            }
    }
}