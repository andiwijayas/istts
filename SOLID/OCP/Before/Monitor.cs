namespace SOLID.OCP.Before
{
    public class SalaryCalculator 
    {
        public double CalculateSalary(string level, double workingHours) 
        {
            if (level == "Junior Developer") 
            {
                return workingHours * 30.5;
            } 
            else if (level == "Mid Developer")
            {
                return workingHours * 40.5;
            }
            else if (level == "Senior Developer")
            {
                return workingHours * 50;
            }
        }
    }
}