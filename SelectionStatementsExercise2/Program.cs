namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();
            switch (subject)
            {
                case "Math": Console.WriteLine("Math is a fun subject, I like it too.");
                    break;

                case "PE": Console.WriteLine("I love PE, we all need to get out of the classroom and move around.");
                    break;

                case "English": Console.WriteLine("English is an essential subject, both Reading and Writing" +
                    "are very important, I'm glad you like it.");
                    break;

                case "Science": Console.WriteLine("Science is so much fun, I love all the experiments!");
                    break;

                case "Social Studies": Console.WriteLine("Great, Social Studies is always changing and I like that" +
                    "about it.");
                    break;
                default: Console.WriteLine($"Oh yes, {subject} is a wonderful subject, I'm glad you're enjoying it!");
                   break;

            }
            
        }
    }
}