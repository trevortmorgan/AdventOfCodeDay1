using System.Drawing;
using Pastel;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "static/sonarReadings.txt";
            if(File.Exists(path)) {
                var sonarReadings = File.ReadAllText(path).Split(new string[] {Environment.NewLine}, StringSplitOptions.None);
                var increase = 0;

                foreach (var sonarReading in sonarReadings.Select((value, index) => (value, index)).Skip(1))
                {
                    var previousValue = sonarReadings[sonarReading.index - 1];
                    int previousReading;
                    Int32.TryParse(previousValue, out previousReading);

                    int currentReading;
                    int.TryParse(sonarReading.value, out currentReading);
                    
                    string change;

                    if(currentReading > previousReading) {
                        increase++;
                        change = "(Increased)".Pastel(Color.Green) + Environment.NewLine + $"AMOUNT OF INCREASES: {increase}".Pastel(Color.Yellow);
                    } else if(currentReading == previousReading) {
                        change = "(Equal)".Pastel(Color.Yellow);
                    } else {
                        change = "(Decreased)".Pastel(Color.Red);
                    }
                    Console.WriteLine($"{sonarReading.value} - {change}");
                }
            } else {
                Console.WriteLine("No file found");  
            }
        }
    }
}