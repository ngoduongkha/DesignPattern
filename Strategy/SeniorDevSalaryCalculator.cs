namespace Strategy {
    internal class SeniorDevSalaryCalculator : ISalaryCalculator {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) => reports
            .Where(r => r.Level == DeveloperLevel.Senior)
            .Select(r => r.CalculateSalary() * 1.2)
            .Sum();
    }
}
