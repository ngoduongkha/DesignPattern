using visitor;
class program
{
    public static void Main(string[] args)
    {
        Human warrior = new Warrior();
        Human wizard = new Wizard();
        Monster NormalMonster = new NormalMonster();
        Monster DracularMonster = new DracularMonster();
        warrior.hit(NormalMonster);
        wizard.hit(NormalMonster);
        warrior.hit(DracularMonster);
        wizard.hit(DracularMonster);
    }
}