namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("What is your name?");
            // var name = Console.ReadLine();
            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            // Console.Write($"{Environment.NewLine}Press any key to exit...");
            // Console.ReadKey(true);
            string path = "static/sonarReadings.txt";
            if(File.Exists(path)) {
                Console.WriteLine("exists!");
            } else {
                Console.WriteLine("Doesn't Exist");  
            }

            Console.WriteLine("test");

        }
    }
}