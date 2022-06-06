using template_method;
public class program
{
    public static void Main(string[] args)
    {
        Person manager = new Manager();
        manager.all();
        Console.WriteLine();
        Person employee = new Employee();
        employee.all();
    }
}
