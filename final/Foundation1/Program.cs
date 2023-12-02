using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Video v1 = new Video("How to Install Baseboards", "Your Neighborhood Carpenter", 631);
        v1.AddComment("Harry Potter", "Great video! Thanks for the help.");
        v1.AddComment("Hermione Granger", "This whole video was wrong. Don't listen to this guy!!");
        v1.AddComment("Ron Weasley", "What's a hammer?");
        v1.AddComment("Dumbledore", "This video would have been great if I weren't dead and I didn't know how to use magic.");

        Video v2 = new Video("Ants Build a Colony", "Outdoorsy Guy", 222);
        v2.AddComment("Michael Scott", "Watching these ants reminds me of the time I felt like there was a man on the moon that was looking down at me and I was tiny.");
        v2.AddComment("Jim Halpert", "I wonder which of these ants is the Dwight Schrute of the colony.");
        v2.AddComment("Dwight Schrute", "Ants can carry 10x their body weight. I am the ant of the human race.");

        Video v3 = new Video("For Loops in C#", "Coding 101", 45);
        v3.AddComment("Aragorn", "Wow, this really helped me pass my coding class!");
        v3.AddComment("Gimli", "Useless video. Dwarves belong in the mines, not on computers.");
        v3.AddComment("Legolas", "They're taking the hobbits to Isengard.");

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        for (int i = 0; i < videos.Count; i++)
        {
            videos[i].DisplayInfo();
            Console.WriteLine();
        }
    }
}