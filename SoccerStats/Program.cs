using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
            var fileContents = ReadSoccerResults(fileName);
            fileName = Path.Combine(directory.FullName, "Players.json");
            var players = DeserializePlayers(fileName);
            var topTenPlayers = GetTopTenPlayers(players);
            foreach (var player in topTenPlayers)
            {
                List<NewsResult> newsResult = GetNewsForPlayer(string.Format("{0} {1}", player.FirstName, player.SecondName));
                foreach(var result in newsResult)
                {
                    Console.WriteLine(string.Format("Date: {0:f}, Headline: {1}, Summary: {2} \r\n", result.DatePublished, result.Headline, result.Summary));
                    Console.ReadKey();
                }
            }
            fileName = Path.Combine(directory.FullName, "TopTen.json");
            SerializePlayersToFile(topTenPlayers, fileName);
            
        }

        //Reads the whole file and returns it 
        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        //Reads the file and breaks it up based on the line and splits at ','
        public static List<GameResult> ReadSoccerResults(string fileName)
        {
            var soccerResults = new List<GameResult>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                //Loads the whole file into one line
                while ((line = reader.ReadLine()) != null)
                {
                    var gameResult = new GameResult();
                    //Breaks up the line into values based on the ,
                    string[] values = line.Split(',');
                    DateTime gameDate;

                    //GameDate
                    if (DateTime.TryParse(values[0], out gameDate))
                    {
                        gameResult.GameDate = gameDate;
                    }
                    //TeamName
                    gameResult.TeamName = values[1];
                    //HomeOrAway
                    HomeOrAway homeOrAway;
                    if (Enum.TryParse(values[2], out homeOrAway))
                    {
                        gameResult.HomeOrAway = homeOrAway;
                    }
                    //Goals
                    int parseInt;
                    if (int.TryParse(values[3], out parseInt))
                    {
                        gameResult.Goals = parseInt;
                    }
                    //GoalAttempts
                    if (int.TryParse(values[4], out parseInt))
                    {
                        gameResult.GoalAttempts = parseInt;
                    }
                    //ShotsOnGoal
                    if (int.TryParse(values[5], out parseInt))
                    {
                        gameResult.ShotsOnGoal = parseInt;
                    }
                    //ShotsOffGoal
                    if (int.TryParse(values[6], out parseInt))
                    {
                        gameResult.ShotsOffGoal = parseInt;
                    }
                    //PossesionPercent
                    double parseDouble;
                    if (double.TryParse(values[7], out parseDouble))
                    {
                        gameResult.PossesionPercent = parseDouble;
                    }

                    soccerResults.Add(gameResult);
                }
            }
            return soccerResults;
        }

        public static List<Player> DeserializePlayers(string fileName)
        {
            var players = new List<Player>();
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(fileName))
            using (var jsonReader = new JsonTextReader(reader))
            {
                players = serializer.Deserialize<List<Player>>(jsonReader);
            }

            return players;
        }

        public static List<Player> GetTopTenPlayers(List<Player> players)
        {
            var topTenPlayers = new List<Player>();
            players.Sort(new PlayerComparer());

            int counter = 0;
            foreach (var player in players)
            {
                topTenPlayers.Add(player);
                counter++;
                if (counter == 10)
                {
                    break;
                }
            }

            return topTenPlayers;
        }

        public static void SerializePlayersToFile(List<Player> players, string fileName)
        {
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, players);
            }
        }

        public static string GetGoogleHomePage()
        {
            string google = "";
            using (var webClient = new WebClient())
            {
                byte[] googleHome = webClient.DownloadData("https://www.google.com");

                using (var stream = new MemoryStream(googleHome))
                using (var reader = new StreamReader(stream))
                {
                    google = reader.ReadToEnd();
                }
            }
            return google;
        }

        public static List<NewsResult> GetNewsForPlayer(string playerName)
        {
            var results = new List<NewsResult>();
            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("Ocp-Apim-Subscription-Key", "e78845a0b3d842a29805ac448bf4c01c");
                //{0} is telling the string to insert the playernam variable
                byte[] searchResults = webClient.DownloadData(string.Format("https://api.cognitive.microsoft.com/bing/v7.0/news/search?q={0}&mkt=en-us", playerName));
                var serializer = new JsonSerializer();
                using (var stream = new MemoryStream(searchResults))
                using (var reader = new StreamReader(stream))
                using (var jsonReader = new JsonTextReader(reader))
                {
                    results = serializer.Deserialize<NewsSearch>(jsonReader).NewsResult;
                }
            }
            return results;
        }
    }
}
