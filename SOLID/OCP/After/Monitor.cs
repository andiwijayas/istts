namespace SOLID.OCP.After
{
    public interface ISalaryCalculator
    {
        double CalculateSalary(double workingHours);
    }
    
    public abstract class BaseSalaryCalculator : ISalaryCalculator 
    {
        protected abstract double HourlyRate { get; }
        
        public double CalculateSalary(double workingHours) 
        {
            return workingHours * HourlyRate;
        }
    }

    public class JuniorDeveloperSalaryCalculator : BaseSalaryCalculator 
    {
        protected override double HourlyRate => 30.5;
    } 

    public class MidDeveloperSalaryCalculator : BaseSalaryCalculator
    {
        protected override double HourlyRate => 40.5;
    }

    public class SeniorDeveloperSalaryCalculator: BaseSalaryCalculator
    {
        protected override double HourlyRate => 50.5;
    }

    public class CalculatorStrategy
    {
        public ISalaryCalculator GetCalculator(string level)
        {
            switch (level)
            {
                case "Junior Developer": return new JuniorDeveloperSalaryCalculator();
                case "Mid Developer" : return new MidDeveloperSalaryCalculator();
                case "Senior Developer": return new SeniorDeveloperSalaryCalculator();
                default: return null;
            }        
        }   
    }
    
    public class SalaryCalculator
    {
        public double CalculateSalary(string level, double workingHours)
        {
            var calculatorStrategy = new CalculatorStrategy();
            var calculator = calculatorStrategy.GetCalculator(level);
            return calculator.CalculateSalary(workingHours);
        }
    }
}