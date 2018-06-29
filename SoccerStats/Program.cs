using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                    if(Enum.TryParse(values[2], out homeOrAway))
                    {
                        gameResult.HomeOrAway = homeOrAway;
                    }
                    //Goals
                    int parseInt;
                    if(int.TryParse(values[3], out parseInt))
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
                    if(double.TryParse(values[7], out parseDouble))
                    {
                        gameResult.PossesionPercent = parseDouble;
                    }
                    soccerResults.Add(gameResult);
                }
            }
            return soccerResults;
        }
    }
}
