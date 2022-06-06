using state;

class main
{
    public static void Main()
    {
        Filee f = new Filee();
        f.Open();
        f.Open();
        f.Close();
        f.Open();
        f.Close();
        f.Delete();
        f.Delete();
    }
}