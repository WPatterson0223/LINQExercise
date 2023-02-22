namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>() {"Duck Hunt", "Primal Rage", "Golden Eye", "Crash Bandicoot", "Grand Theft Auto Vice City", "Animal Crossing", "Call of Duty II", "The Last of Us", "Dysmantle"};

            games.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
