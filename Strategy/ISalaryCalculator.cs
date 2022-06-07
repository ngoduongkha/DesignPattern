namespace Strategy {
    internal interface ISalaryCalculator {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}
