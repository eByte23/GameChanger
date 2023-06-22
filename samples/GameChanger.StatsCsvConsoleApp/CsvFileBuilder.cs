using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

using CsvHelper;
using GameChanger.Parser;

namespace GameChanger.StatsCsvConsoleApp
{
    public class CsvFileBuilder
    {
        public static void BuildCsvFile(GameChangerXmlFile.Game gameChangerGame, string filePath)
        {
            var gameDate = DateTime.ParseExact(gameChangerGame.Venue.Date, "MM/dd/yy", null);

            foreach (var team in gameChangerGame.Teams)
            {
                var fileName = $"{gameChangerGame.Venue.Homename} vs. {gameChangerGame.Venue.Visname}_{team.Id}_{gameDate.ToString("yyyy_MM_dd")}";

                using (var writer = new StreamWriter($"{fileName}.csv"))
                using (var csv = new CsvWriter(writer))
                {
                    var players = team.Players.Select(x =>
                    {
                        var hitting = new Hitting
                        {
                            Name = x.Name,
                            Ab = x.Hitting.Ab,
                            Bb = x.Hitting.Bb,
                            Double = x.Hitting.Double,
                            H = x.Hitting.H,
                            Hbp = x.Hitting.Hbp,
                            Hr = x.Hitting.Hr,
                            R = x.Hitting.R,
                            Rbi = x.Hitting.Rbi,
                            Rcherr = x.Hitting.Rcherr,
                            Sb = x.Hitting.Sb,
                            So = x.Hitting.So,
                            Triple = x.Hitting.Triple,
                            PA = x.Hitting.H + x.Hitting.Bb + x.Hitting.So + x.Hitting.Hbp + x.Hitting.Sh + x.Hitting.Sf,
                            Sin = x.Hitting.H - (x.Hitting.Triple + x.Hitting.Double)
                        };


                        return hitting;
                    }).OrderBy(x => x.Name);

                    csv.WriteRecords(players);
                }
            }
        }
    }

    public class Hitting
    {
        [XmlIgnore]
        public string Name { get; set; }
        public int PA { get; set; }
        public int Ab { get; set; }
        public int H { get; set; }
        public int Sin { get; set; }
        public int Double { get; set; }
        public int Triple { get; set; }
        public int Hr { get; set; }
        public int Bb { get; set; }
        public int Hbp { get; set; }
        public int So { get; set; }
        public int Rbi { get; set; }
        public int R { get; set; }
        public int Rcherr { get; set; }
        public int Sb { get; set; }




    }
}