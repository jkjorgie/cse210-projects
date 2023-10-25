public class Job
{
    public string _jobTitle;
    public string _company;
    public float _wage;
    public string _salariedOrHourly;
    public string _department;
    public string _supervisorId;

    public Job() 
    {

    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{this._jobTitle}, {this._company}, {this._department}: {this._wage} {this._salariedOrHourly}");
    }
}