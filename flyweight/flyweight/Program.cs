// See https://aka.ms/new-console-template for more information
namespace flyweight;
class main
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 3; i++)
        {
            Circle circle = (Circle)CircleFactory.getCircle("red");
            UnshareConcrete unshare = new UnshareConcrete(10, 10*i);
            circle.Draw(unshare);
        }
        for (int i = 1; i < 3; i++)
        {
            Circle circle = (Circle)CircleFactory.getCircle("blue");
            UnshareConcrete unshare = new UnshareConcrete(10, 10 * i);
            circle.Draw(unshare);
        }
        for (int i = 1; i < 3; i++)
        {
            Circle circle = (Circle)CircleFactory.getCircle("green");
            UnshareConcrete unshare = new UnshareConcrete(10, 10 * i);
            circle.Draw(unshare);
            circle = (Circle)CircleFactory.getCircle("red");
            circle.Draw(unshare);
        }

    }
}