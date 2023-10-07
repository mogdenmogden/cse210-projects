public class MenuServe
{
    public List<MenuItem> _rows = new List<MenuItem>();

    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        foreach (MenuItem Item in _rows)
        {
            Item.WriteMenuLine();
        }
    }
}