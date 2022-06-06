using proxy;

class Program
{
    static void Main(string[] args)
    {
        SharedFolderProxy manager = new SharedFolderProxy("manager");
        manager.share();
        SharedFolderProxy staff = new SharedFolderProxy("staff");
        staff.share();
    }
}