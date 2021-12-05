using System.Drawing;
using Pastel;

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
                var sonarReadings = File.ReadAllText(path).Split(new string[] {Environment.NewLine}, StringSplitOptions.None);
                var increase = 0;

                foreach (var sonarReading in sonarReadings.Select((value, index) => (value, index)))
                {
                    var previousValue = sonarReading.index != 0 ? sonarReadings[sonarReading.index - 1] : null;
                    int previousReading;
                    Int32.TryParse(previousValue, out previousReading);

                    int currentReading;
                    int.TryParse(sonarReading.value, out currentReading);

                    var change = currentReading > previousReading ? "(Increased)".Pastel(Color.Green) : "(Decreased)".Pastel(Color.Red);

                    Console.WriteLine($"{sonarReading.value} - {change}");


                }
            } else {
                Console.WriteLine("No file found");  
            }
        }
    }
}