//creativity: my code will only hide new words for each cycle; also, it will randomly present 1 of 3 scriptures on each run

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Reference myRef = new Reference("John", 3 ,16, "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture scripture = new Scripture(myRef);
        scriptures.Add(scripture);

        List<Reference> myRefs = new List<Reference>();
        myRefs.Add(new Reference("Proverbs", 3, 5, "Trust in the LORD with all thine heart; and lean not unto thine own understanding."));
        myRefs.Add(new Reference("Proverbs", 3, 6, "In all thy ways acknowledge him, and he shall direct thy paths."));
        scripture = new Scripture(myRefs);
        scriptures.Add(scripture);

        myRefs = new List<Reference>();
        myRefs.Add(new Reference("Abraham", 3, 22, "Now the lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many noble and great ones;"));
        myRefs.Add(new Reference("Abraham", 3, 23, "And G od saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and hesaid unto me: Abraham, thou art one of them; thou wast chosen before thou wast born."));
        scripture = new Scripture(myRefs);
        scriptures.Add(scripture);

        Random rand = new Random();
        int ndx = rand.Next(scriptures.Count);
        scripture = scriptures[ndx];

        int hideIncrementer = 0;
        string response = "";
        while (response.ToUpper() != "QUIT")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetVerseWithReferenceWithHiddenWords(hideIncrementer));
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            if (scripture.IsFullyHidden())
            {
                break;
            }
            hideIncrementer = 3; //want the first time to not hide any words, then hide them after the first enter
        }
    }
}