using System.Reflection;

public class Reflect : Activity
{
    private List<string> _reflections;
    private List<string> _questions;
    private List<int> _pickThisOne;
    // private string _thisReflection;
    // private string _thisQuestion;
    private int _countDownSeconds;
    
    public Reflect(string choiceA) : base(choiceA)
    {
        _countDownSeconds = 3;
        
        List<string> reflections = new List<string>();
        reflections.Add("Think of a time when you stood up for someone else.");
        reflections.Add("Think of a time when you did something really difficult.");
        reflections.Add("Think of a time when you helped someone in need.");
        reflections.Add("Think of a time when you did something truly selfless.");
        _reflections = reflections;

        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        _questions = questions;
    }

    // public List<int> RandomPicker(int questionsPlusOne, int reflectionsPlusOne)
    // {
    //     Random random = new();
    //     List<int> _pickThisOne = new List<int>();
    //     _pickThisOne.Add(random.Next(1,1+_questions.Count));
    //     _pickThisOne.Add(random.Next(1,1+_reflections.Count));
    //     return _pickThisOne;
    // }

    // private void SetReflection(int pick)
    // {
    //     _thisReflection = _reflections[pick];
    // }

    // private string GetReflection()
    // {
    //     return _thisReflection;
    // }

    // private void SetQuestion(int pick)
    // {
    //     _thisQuestion = _questions[pick];
    // }

    // private string GetQuestion()
    // {
    //     return _thisQuestion;
    // }

    public void RunReflect()
    {
        _pickThisOne = SetPicks(_reflections,_questions);
        // SetReflection(_pickThisOne[0]);
        SetPrompt(_reflections,_pickThisOne[0]);
        // SetQuestion(_pickThisOne[1]);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {_thisPrompt} --- \n");  //_thisReflection
        Console.WriteLine("When you have something in mind, press Enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now consider each of the following questions and how they relate to the above experience. ");
        Console.Write($"You may begin in...  "); 
        CountDown(_countDownSeconds);
        Console.Clear();
        SetTime();
        GetEndTime();

        do
        {
            // _pickThisOne.RemoveAt(1);
            // _pickThisOne.Add(random.Next(1,1+_questions.Count));
            _pickThisOne = SetPicks(_reflections,_questions);
            // SetQuestion(_pickThisOne[1]);
            SetPrompt(_questions,_pickThisOne[1]);
            Console.Write($"> {_thisPrompt} "); //GetQuestion()
            Spin(6);
            Console.WriteLine();
            GetTimeNow();
        } while (_now < _endTime);
    }
}