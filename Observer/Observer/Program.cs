using Observer;
class Program
{
    public static void Main(string[] args)
    {
        Stock TCB = new ConcreteStock("TCB", 43);
        Stock MBB = new ConcreteStock("MBB", 28);
        IInvestor hieu = new Investor("Hieu");
        IInvestor nam = new Investor("Nam");
        Investor trung = new Investor("Trung");
        TCB.Attach(hieu);
        TCB.Attach(nam);
        TCB.Price = 43.8;
        TCB.Price = 44;
        MBB.Attach(nam);
        MBB.Attach(trung);
        MBB.Price = 29;

    }
}