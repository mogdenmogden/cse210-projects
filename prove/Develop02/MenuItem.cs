public class MenuItem
{
    public int _menuNumb;
    public string _menuText;

    public void WriteMenuLine()
    {
        Console.WriteLine($"[{_menuNumb}] {_menuText}");
    }
}