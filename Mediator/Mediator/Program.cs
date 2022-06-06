using Mediator;
class Program
{
    static void Main(string[] args)
    {
        IChatMediator ChatMediator = new ChatMediator();
        User Ram = new ConcreteUser(ChatMediator, "Ram");
        User Dave = new ConcreteUser(ChatMediator, "Dave");
        User Smith = new ConcreteUser(ChatMediator, "Smith");

        ChatMediator.RegisterUser(Ram);
        ChatMediator.RegisterUser(Smith);
        ChatMediator.RegisterUser(Dave);
        Dave.Send("Hello");
        Console.WriteLine();
        Smith.Send("Hi");

        IChatMediator newChat = new ChatMediator();
        User a = new ConcreteUser(newChat, "a");
        User b = new ConcreteUser(newChat, "b");
        User c = new ConcreteUser(newChat, "c");
        newChat.RegisterUser(a);
        newChat.RegisterUser(b);
        newChat.RegisterUser(c);

        b.Send("test");

    }
}
