//creativity -- I created a class called GoalTracker that handles all goal actions
//              Also, when recording event, I prevent completed simple goals from being recompleted
//              Also, I created a process for cloning goals

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        GoalTracker gt = new GoalTracker();
        string resp = "";
        do
        {
            Console.WriteLine();
            Console.WriteLine($"You have {gt.GetTotalPoints()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Clone Goal");
            Console.WriteLine("  7. Quit");
            Console.WriteLine();
            Console.Write("Select an option from the menu: ");
            resp = Console.ReadLine();

            switch (resp)
            {
                case "1":
                {
                    gt.CreateGoal();
                    break;
                }
                case "2":
                {
                    gt.DisplayGoalsAsChecklist();
                    break;
                }
                case "3":
                {
                    gt.SaveGoals();
                    break;
                }
                case "4":
                {
                    gt.LoadGoals();
                    break;
                }
                case "5":
                {
                    gt.RecordEvent();
                    break;
                }
                case "6":
                {
                    gt.CloneGoal();
                    break;
                }
                default:
                {
                    continue;
                }
            }
        } while (resp != "7");
    }
}