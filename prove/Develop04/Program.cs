//creativity: I added a subclass called PromptActivity that extends Activity. Reflection and Listing extend PromptActivity.
//            Additionally, my prompts and questions won't repeat until the full list has been exhausted per program run.

using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity ba = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity ra = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity la = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        string response = "";
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            response = Console.ReadLine();
            
            switch (response)
            {
                case "1":
                {
                    ba.RunActivity();
                    break;
                }
                case "2":
                {   
                    ra.RunActivity();
                    break;
                }
                case "3":
                {
                    la.RunActivity();
                    break;
                }
                default:
                {
                    continue;
                }
            }

        } while (response != "4");
    }
}