using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Activity.GetSummary();
    }
}

class Activity
{

public static void GetSummary() {
        Activity.Swimming swimmingObject = new Activity.Swimming();
        Activity.Running runningObject = new Activity.Running();
        Activity.Cycling cyclingObject = new Activity.Cycling();


        string today = Activity.Today();
        string length = Activity.Length();
        string RunningDistance = Activity.RunningDistance();
        string CyclingSpeed = Activity.CyclingSpeed();
        Console.WriteLine("How far did you cycle?");
        string CyclingDistance = Console.ReadLine();
        string laps = Activity.Swimming.Laps();
        decimal lapsDec = Convert.ToDecimal(laps);



        string swimmingOutput = swimmingObject.DisplaySwimming(lapsDec, today, length);
        string runningOutput = runningObject.DisplayRunning(Convert.ToDecimal(RunningDistance), today, length);
        string cyclingOutput = cyclingObject.DisplayCycling(Convert.ToDecimal(CyclingSpeed), Convert.ToDecimal(CyclingDistance), today, length);

        List<string> output = new() {
            swimmingOutput,
            cyclingOutput,
            runningOutput
        };

        Console.Clear();

        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
}

    public static string Today()
    {
        Console.WriteLine("What is the date today?");
        string today = Console.ReadLine();
        return today;
    }

    public static string Length()
    {
        Console.WriteLine("How much time did you spend on each activity? (In minutes)");
        string length = Console.ReadLine();
        return length;
    }

    public static string RunningDistance()
    {
        Console.WriteLine("How far did you run?");
        string running = Console.ReadLine();
        return running;
    }

    public static string CyclingSpeed()
    {
        Console.WriteLine("What was your cycling speed?");
        string running = Console.ReadLine();
        return running;
    }

    public abstract class SwimmingContainer
    {
        public abstract string SwimmingDistance(decimal laps);
        public abstract string SwimmingSpeed(decimal laps, decimal time);

        public abstract string SwimmingPace(decimal laps, decimal time);

    }



    public class Swimming : SwimmingContainer 
    {
        public override string SwimmingDistance(decimal laps)
        {
            
            decimal totalLaps = laps * 50 / 1000;
            return $"Distance: {totalLaps}km";
        }

        public override string SwimmingSpeed(decimal laps, decimal time)
        {
            decimal speed = ((laps * 50 / 1000 ) /time ) * 60;
            return speed.ToString();
        }

        public override string SwimmingPace(decimal laps, decimal time)
        {
            decimal pace = time / (laps * 50 / 1000);
            return pace.ToString();
        }




        public static string Laps()
        {
            Console.WriteLine("How many laps did you swim?");
            string laps = Console.ReadLine();
            return laps;
        }

        public string DisplaySwimming(decimal laps, string today, string length)
        {
            return $"Swimming:\n{length} Minutes\nDate: {today}\n{SwimmingDistance(laps)}\n" +
            $"Speed: {SwimmingSpeed(laps, Math.Round(Convert.ToDecimal(length)))}\nPace: {SwimmingPace(laps, Math.Round(Convert.ToDecimal(length)))} \n";
        }
    }





    public abstract class RunningContainer
    {
        public abstract string RunningSpeed(decimal runningDistance, decimal time);

        public abstract string RunningPace(decimal runningDistance, decimal time);

    }
    public class Running : RunningContainer 

    {

        public override string RunningSpeed(decimal laps, decimal time)
        {
            decimal speed = ((laps * 50 / 1000 ) /time ) * 60;
            return speed.ToString();
        }

        public override string RunningPace(decimal laps, decimal time)
        {
            decimal pace = time / (laps * 50 / 1000);
            return pace.ToString();
        }


        public string DisplayRunning(decimal RunningDistance, string today, string length)
        {
            return $"Running:\n{length} Minutes\nDate: {today}\n{RunningDistance}\n" +
            $"Speed: {RunningSpeed(RunningDistance, Math.Round(Convert.ToDecimal(length)))}\nPace: {RunningPace(RunningDistance, Math.Round(Convert.ToDecimal(length)))}";
        }


    }


public abstract class CyclingContainer
    {

        public abstract string CyclingPace(decimal runningDistance, decimal time);

    }
    public class Cycling : CyclingContainer 
    {

        public override string CyclingPace(decimal laps, decimal time)
        {
            decimal pace = time / (laps * 50 / 1000);
            return pace.ToString();
        }


        public string DisplayCycling(decimal CyclingSpeed, decimal CyclingDistance, string today, string length)
        {
            return $"Cycling:\n{length} Minutes\nDate: {today}\n{CyclingDistance}\n" +
            $"Speed: {CyclingSpeed}\nPace: {CyclingPace(CyclingDistance, Math.Round(Convert.ToDecimal(length)))}\n";
        }
    }
}
