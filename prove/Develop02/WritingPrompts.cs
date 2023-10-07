public class WritingPrompts {
    public Random _randomNbr;
    public string _prompt;
    

    public string PickAPrompt()
    {
        Random _randombNbr = new Random();

        List<string> _promptList = new List<string>();
        _promptList.Add("What do you admire most about your mother and/or grandmother?");
        _promptList.Add("What do you admire most about your father and/or grandfather?");
        _promptList.Add("What is the farthest you have traveled?");
        _promptList.Add("Where did you go today?");
        _promptList.Add("Tell about a family tradition.");
        _promptList.Add("What do you know about when you were a baby?");
        _promptList.Add("What things do you think you cannot live without");
        _promptList.Add("Write about what your name means to you or your family.");
        _promptList.Add("Write about how you named your children, or what you might name them if you have children.");
        _promptList.Add("Has anyone ever rescued you, figuratively or literally?");
        _promptList.Add("What was one of the most romantic moments in your life?");
        _promptList.Add("What story do you like to tell over and over?");
        _promptList.Add("Do you have any particularly vivid memories of your grandparents?");
        _promptList.Add("Do you have any particularly vivid memories of your parents?");
        _promptList.Add("Do you have any particularly vivid memories of your siblings and/or friends?");

        string _prompt = _promptList[_randombNbr.Next(1,16)-1];
        Console.WriteLine(_prompt);
        return _prompt;
    }
}