using composite;
using System;

namespace CompositeDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating Leaf Objects
            IComponent hardDisk = new Leaf("Hard Disk", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 2000);
            IComponent mouse = new Leaf("Mouse", 2000);
            IComponent keyboard = new Leaf("Keyboard", 2000);

            //Creating composite objects
            Composite package_1 = new Composite("Package 1");
            Composite package_2 = new Composite("Package 2");
            Composite package_3 = new Composite("Package 3");
            Composite package_4 = new Composite("Package 4");


            //Creating tree structure
            //Ading CPU and RAM in package 4
            package_4.addComponent(cpu);
            package_4.addComponent(ram);

            //Ading mother board and hard disk in package 2
            package_2.addComponent(package_4);
            package_2.addComponent(hardDisk);

            //Ading mouse and keyborad in package 3
            package_3.addComponent(mouse);
            package_3.addComponent(keyboard);

            //Ading package_2 and package_3 in package_1
            package_1.addComponent(package_2);
            package_1.addComponent(package_3);

            //To display the Price of Computer
            package_1.displayPrice();
            Console.WriteLine();

            //To display the Price of Keyboard
            //keyboard.displayPrice();
            //Console.WriteLine();

            //To display the Price of Cabinet
            //cabinet.displayPrice();
            Console.WriteLine(package_2.totalPrice());
            //To display the total Price of computer
            Console.WriteLine(package_1.totalPrice());
            Console.Read();
        }
    }
}