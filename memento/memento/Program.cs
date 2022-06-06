using memento;
class Program
{
    static void Main(string[] args)
    {
        CareTaker careTaker = new CareTaker();
        Originator originator = new Originator();
        originator.set("state 1");
        careTaker.AddMemento(originator.CreateMemento());
        originator.set("state 2");
        careTaker.AddMemento(originator.CreateMemento());
        originator.set("state 3");
        careTaker.AddMemento(originator.CreateMemento());
        originator.detail();
        originator.SetMemento(careTaker.GetMemento(0));
        originator.detail();
    }
}