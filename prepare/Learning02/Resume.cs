public class Resume
{
    public string _applicantName;
    public List<Job> _jobs;

    public Resume()
    {
        this._jobs = new List<Job>();
    }

    public void DisplayDetails()
    {
        Console.WriteLine(this._applicantName);
        Console.WriteLine("Jobs:");
        for (int i = 0; i < this._jobs.Count; i++)
        {
            Console.Write("\t");
            this._jobs[i].DisplayJobDetails();
        }
    }
}