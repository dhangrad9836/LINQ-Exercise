namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create a list
            List<string> videoGames = new List<string>();

            //populate the list with video games
            videoGames.Add("Super Mario Bros");
            videoGames.Add("Pac Man");
            videoGames.Add("Resident Evil");
            videoGames.Add("Eleven Table Tennis");
            videoGames.Add("Street Fighter");

            //order the list of games by the length of the game name
            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));

            //foreach (var game in videoGames)
            //{
            //    Console.WriteLine(game);
            //}

            Console.ReadLine();
        }
    }
}
