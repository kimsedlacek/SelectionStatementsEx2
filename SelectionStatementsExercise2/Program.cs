namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school? (please type in lower case)");
            string favSubj = Console.ReadLine();

            
            switch (favSubj)
            {
                case "art":
                    Console.WriteLine("Art is so much fun, I love having a creative outlet at school.");
                    break;

                case "science":
                    Console.WriteLine("Science is very important, I'm glad you like it!");
                    break;

                case "pe":
                    Console.WriteLine("I love PE too, I'm glad we get a chance to run around and move our bodies.");
                    break;

                case "history":
                    Console.WriteLine("That's great that history is your favorite subject, it's important to know where we came from.");
                    break;

                case "english":
                    Console.WriteLine("English is difficult for many people; you must be a good writer and enjoy reading.");
                    break;

                case "math":
                    Console.WriteLine("Math is fun and challenging!");
                    break;

                default:
                    Console.WriteLine($"Yes, {favSubj} is great subject to study, I'm glad it's your favorite!");
                    break;
            }




        }

        
    }
}