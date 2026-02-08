public class InternSalaryCalculator : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.BaseSalary * 0.8;
    }
}
