public class Resume
{
    public string _candidateName;
    public List<Job> _jobs = new List<Job>();

    public void DisplayJobs()
    {
        Console.WriteLine($"Name: {_candidateName}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            j.DisplayJobLineDetails();
        }
    }
}