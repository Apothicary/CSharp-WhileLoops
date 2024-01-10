namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A while loop will repeat code indefintely while a condition remains true 

            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            /* Another shorter way to do the above would be :
             *
             *  String name = "";
             *  
            */
            while (name == "")      // Start of While Loop if name String is left blank
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
