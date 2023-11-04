using System.Reflection;

public class Reflect : Activity
{
    private List<string> _reflections;
    private List<string> _questions;
    private List<int> _pickThisOne;
    // private List<string> _usedQuestions;
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

    public void RunReflect()
    {
        List<string> usedQuestions = new List<string>();
        _pickThisOne = SetPicks(_reflections,_questions);  //choose two things from two lists using a list of two ints
        SetPrompt(_reflections,_pickThisOne[0]);  //I only use the first list choice this time.
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {_thisPrompt} --- \n");  //display the choice
        Console.WriteLine("When you have something in mind, press Enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now consider each of the following questions and how they relate to the above experience. ");
        Console.Write($"You may begin in...  "); 
        CountDown(_countDownSeconds);
        Console.Clear();
        SetTime();  //beginning time
        GetEndTime();  //end time calculation and to establish the ending time attribute
        int repeatNumber = _questions.Count;
        do
        {

            if (repeatNumber == 0)
            {
                // _questions = usedQuestions;
                foreach (string question in usedQuestions)
                {
                    _questions.Add(question);
                }
                usedQuestions.Clear(); 
                repeatNumber = _questions.Count;
            }
            
            _pickThisOne = SetPicks(_reflections,_questions);  //must be reestablished so that a new one is chosen each cycle
          
            SetPrompt(_questions,_pickThisOne[1]);  //I only use the second list choice this time.
            int indexPlace = _pickThisOne[1];
            Console.Write($"> {_thisPrompt} "); 
            _questions.RemoveAt(indexPlace);
            usedQuestions.Add(_thisPrompt);
            repeatNumber--;
            Spin(_spinSeconds);
            Console.WriteLine();
            GetTimeNow();


        } while (_now < _endTime);
    }
}