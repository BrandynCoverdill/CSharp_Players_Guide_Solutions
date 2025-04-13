namespace TheThingNamer3000 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("What kind of thing are we talking about?");

            // 'a' stores the name of the thing.
            string? a = Console.ReadLine();

            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

            /*
             * 'b' stores the description of 'a'.
             */
            string? b = Console.ReadLine();

            // Holds the string "of Doom".
            string c = "of Doom";

            /*
             * Holds the string "3000".
             */
            string d = "3000";

            Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
        }
    }
}

/*
 * Question: Aside from the comments, what else could you do to make this code more understandable?
 * 
 * Answer: I would make the variable names more descriptive.
 * 'a' could be 'nameOfThing' instead, 'b' could be 'description', and so on.
 */