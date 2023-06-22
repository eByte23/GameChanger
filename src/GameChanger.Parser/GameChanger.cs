using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace GameChanger.Parser
{
    public class GameChangerXmlFile
    {



        [XmlRoot(ElementName = "venue")]
        public class Venue
        {
            [XmlAttribute(AttributeName = "date")]
            public string Date { get; set; }
            [XmlAttribute(AttributeName = "gameid")]
            public string Gameid { get; set; }

            [XmlAttribute(AttributeName = "homeid")]
            public string Homeid { get; set; }

            [XmlAttribute(AttributeName = "homename")]
            public string Homename { get; set; }
            [XmlAttribute(AttributeName = "leaguegame")]
            public string Leaguegame { get; set; }
            [XmlAttribute(AttributeName = "location")]
            public string Location { get; set; }
            [XmlAttribute(AttributeName = "schedinn")]
            public string Schedinn { get; set; }
            [XmlAttribute(AttributeName = "start")]
            public string Start { get; set; }
            [XmlAttribute(AttributeName = "visid")]
            public string Visid { get; set; }
            [XmlAttribute(AttributeName = "visname")]
            public string Visname { get; set; }
        }

        [XmlRoot(ElementName = "lineinn")]
        public class Lineinn
        {
            [XmlAttribute(AttributeName = "inn")]
            public string Inn { get; set; }
            [XmlAttribute(AttributeName = "score")]
            public string Score { get; set; }
        }

        [XmlRoot(ElementName = "linescore")]
        public class Linescore
        {
            [XmlElement(ElementName = "lineinn")]
            public List<Lineinn> Lineinn { get; set; }
            [XmlAttribute(AttributeName = "errs")]
            public string Errs { get; set; }
            [XmlAttribute(AttributeName = "hits")]
            public string Hits { get; set; }
            [XmlAttribute(AttributeName = "line")]
            public string Line { get; set; }
            [XmlAttribute(AttributeName = "lob")]
            public string Lob { get; set; }
            [XmlAttribute(AttributeName = "runs")]
            public string Runs { get; set; }
        }

        [XmlRoot(ElementName = "starter")]
        public class Starter
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }

            [XmlAttribute(AttributeName = "pos")]
            public string Pos { get; set; }

            [XmlAttribute(AttributeName = "slot")]
            public string Slot { get; set; }

            [XmlAttribute(AttributeName = "uni")]
            public string Uniform { get; set; }
        }


        public class BatterOrderBatter
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }

            [XmlAttribute(AttributeName = "pos")]
            public string Pos { get; set; }

            [XmlAttribute(AttributeName = "spot")]
            public string Slot { get; set; }

            [XmlAttribute(AttributeName = "uni")]
            public string Uniform { get; set; }
        }

        // [XmlRoot(ElementName = "starters")]
        // public class Starters
        // {
        //     [XmlElement(ElementName = "starter")]
        //     public List<Starter> Starter { get; set; }
        // }

        [XmlRoot(ElementName = "batords")]
        public class BattingOrder
        {
            [XmlElement(ElementName = "batord")]
            public List<BatterOrderBatter> Batters { get; set; }
        }

        [XmlRoot(ElementName = "hitting")]
        public class Hitting
        {
            [XmlIgnore]
            public string Name { get; set; }

            [XmlAttribute(AttributeName = "ab")]
            public int Ab { get; set; }
            [XmlAttribute(AttributeName = "bb")]
            public int Bb { get; set; }
            [XmlAttribute(AttributeName = "cs")]
            public int Cs { get; set; }
            [XmlAttribute(AttributeName = "double")]
            public int Double { get; set; }
            [XmlAttribute(AttributeName = "gdp")]
            public int Gdp { get; set; }
            [XmlAttribute(AttributeName = "ground")]
            public int Ground { get; set; }
            [XmlAttribute(AttributeName = "h")]
            public int H { get; set; }
            [XmlAttribute(AttributeName = "hbp")]
            public int Hbp { get; set; }
            [XmlAttribute(AttributeName = "hr")]
            public int Hr { get; set; }
            [XmlAttribute(AttributeName = "kl")]
            public int Kl { get; set; }
            [XmlAttribute(AttributeName = "pickoff")]
            public int Pickoff { get; set; }
            [XmlAttribute(AttributeName = "r")]
            public int R { get; set; }
            [XmlAttribute(AttributeName = "rbi")]
            public int Rbi { get; set; }
            [XmlAttribute(AttributeName = "rchci")]
            public int Rchci { get; set; }
            [XmlAttribute(AttributeName = "rcherr")]
            public int Rcherr { get; set; }
            [XmlAttribute(AttributeName = "sb")]
            public int Sb { get; set; }
            [XmlAttribute(AttributeName = "sf")]
            public int Sf { get; set; }
            [XmlAttribute(AttributeName = "sh")]
            public int Sh { get; set; }
            [XmlAttribute(AttributeName = "so")]
            public int So { get; set; }
            [XmlAttribute(AttributeName = "triple")]
            public int Triple { get; set; }
        }

        [XmlRoot(ElementName = "fielding")]
        public class Fielding
        {
            [XmlAttribute(AttributeName = "a")]
            public int A { get; set; }
            [XmlAttribute(AttributeName = "ci")]
            public int Ci { get; set; }
            [XmlAttribute(AttributeName = "csb")]
            public int Csb { get; set; }
            [XmlAttribute(AttributeName = "e")]
            public int E { get; set; }
            [XmlAttribute(AttributeName = "indp")]
            public int Indp { get; set; }
            [XmlAttribute(AttributeName = "intp")]
            public int Intp { get; set; }
            [XmlAttribute(AttributeName = "pb")]
            public int Pb { get; set; }
            [XmlAttribute(AttributeName = "po")]
            public int Po { get; set; }
            [XmlAttribute(AttributeName = "sba")]
            public int Sba { get; set; }
        }

        [XmlRoot(ElementName = "pitching")]
        public class Pitching
        {
            [XmlAttribute(AttributeName = "ab")]
            public int Ab { get; set; }
            [XmlAttribute(AttributeName = "bb")]
            public int Bb { get; set; }
            [XmlAttribute(AttributeName = "bf")]
            public int Bf { get; set; }
            [XmlAttribute(AttributeName = "bk")]
            public int Bk { get; set; }
            [XmlAttribute(AttributeName = "er")]
            public int Er { get; set; }
            [XmlAttribute(AttributeName = "fly")]
            public int Fly { get; set; }
            [XmlAttribute(AttributeName = "ground")]
            public int Ground { get; set; }
            [XmlAttribute(AttributeName = "h")]
            public int H { get; set; }
            [XmlAttribute(AttributeName = "hbp")]
            public int Hbp { get; set; }
            [XmlAttribute(AttributeName = "hr")]
            public int Hr { get; set; }
            [XmlAttribute(AttributeName = "ip")]
            public float Ip { get; set; }
            [XmlAttribute(AttributeName = "picked")]
            public int Picked { get; set; }
            [XmlAttribute(AttributeName = "pitches")]
            public int Pitches { get; set; }
            [XmlAttribute(AttributeName = "r")]
            public int R { get; set; }
            [XmlAttribute(AttributeName = "so")]
            public int So { get; set; }
            [XmlAttribute(AttributeName = "wp")]
            public int Wp { get; set; }
            [XmlAttribute(AttributeName = "appear")]
            public int Appear { get; set; }
            [XmlAttribute(AttributeName = "gs")]
            public int Gs { get; set; }
            [XmlAttribute(AttributeName = "win")]
            public string Win { get; set; }
            [XmlAttribute(AttributeName = "loss")]
            public string Loss { get; set; }
        }

        [XmlRoot(ElementName = "hsitsummary")]
        public class Hsitsummary
        {
            [XmlAttribute(AttributeName = "lob")]
            public int Lob { get; set; }
            [XmlAttribute(AttributeName = "rbi-2out")]
            public int Rbi2out { get; set; }
            [XmlAttribute(AttributeName = "rchci")]
            public int Rchci { get; set; }
            [XmlAttribute(AttributeName = "rcherr")]
            public int Rcherr { get; set; }
            [XmlAttribute(AttributeName = "wrbiops")]
            public int Wrbiops { get; set; }
        }

        [XmlRoot(ElementName = "psitsummary")]
        public class Psitsummary
        {
            [XmlAttribute(AttributeName = "fly")]
            public int Fly { get; set; }
            [XmlAttribute(AttributeName = "ground")]
            public int Ground { get; set; }
        }

        [XmlRoot(ElementName = "totals")]
        public class Totals
        {
            [XmlElement(ElementName = "hitting")]
            public Hitting Hitting { get; set; }
            [XmlElement(ElementName = "fielding")]
            public Fielding Fielding { get; set; }
            [XmlElement(ElementName = "pitching")]
            public Pitching Pitching { get; set; }
            [XmlElement(ElementName = "hsitsummary")]
            public Hsitsummary Hsitsummary { get; set; }
            [XmlElement(ElementName = "psitsummary")]
            public Psitsummary Psitsummary { get; set; }
        }

        [XmlRoot(ElementName = "player")]
        public class Player
        {
            [XmlElement(ElementName = "hitting")]
            public Hitting Hitting { get; set; }
            [XmlElement(ElementName = "fielding")]
            public Fielding Fielding { get; set; }
            [XmlElement(ElementName = "hsitsummary")]
            public Hsitsummary Hsitsummary { get; set; }
            [XmlAttribute(AttributeName = "atpos")]
            public string Atpos { get; set; }
            [XmlAttribute(AttributeName = "gp")]
            public string Gp { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "pos")]
            public string Pos { get; set; }
            [XmlAttribute(AttributeName = "shortname")]
            public string Shortname { get; set; }
            [XmlAttribute(AttributeName = "spot")]
            public string Spot { get; set; }
            [XmlElement(ElementName = "pitching")]
            public Pitching Pitching { get; set; }
            [XmlElement(ElementName = "psitsummary")]
            public Psitsummary Psitsummary { get; set; }
            [XmlAttribute(AttributeName = "gs")]
            public string Gs { get; set; }
        }

        [XmlRoot(ElementName = "team")]
        public class Team
        {
            [XmlElement(ElementName = "linescore")]
            public Linescore Linescore { get; set; }

            [XmlArray("starters")]
            [XmlArrayItem("starter")]
            public List<Starter> Starters { get; set; } = new List<Starter>();

            [XmlArray("batords")]
            [XmlArrayItem("batord")]
            public List<BatterOrderBatter> BattingOrder { get; set; } = new List<BatterOrderBatter>();

            [XmlElement(ElementName = "totals")]
            public Totals Totals { get; set; }

            [XmlElement(ElementName = "player")]
            public List<Player> Players { get; set; }

            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "record")]
            public string Record { get; set; }
            [XmlAttribute(AttributeName = "vh")]
            public string Vh { get; set; }
        }

        [XmlRoot(ElementName = "batter")]
        public class Batter
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "out")]
            public string Out { get; set; }
            [XmlAttribute(AttributeName = "scored")]
            public string Scored { get; set; }
            [XmlAttribute(AttributeName = "tobase")]
            public string Tobase { get; set; }
        }

        [XmlRoot(ElementName = "narrative")]
        public class Narrative
        {
            [XmlAttribute(AttributeName = "text")]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "play")]
        public class Play
        {
            [XmlElement(ElementName = "batter")]
            public Batter Batter { get; set; }
            [XmlElement(ElementName = "narrative")]
            public Narrative Narrative { get; set; }
            [XmlElement(ElementName = "runner")]
            public List<Runner> Runner { get; set; }
        }

        [XmlRoot(ElementName = "innsummary")]
        public class Innsummary
        {
            [XmlAttribute(AttributeName = "e")]
            public string E { get; set; }
            [XmlAttribute(AttributeName = "h")]
            public string H { get; set; }
            [XmlAttribute(AttributeName = "lob")]
            public string Lob { get; set; }
            [XmlAttribute(AttributeName = "r")]
            public string R { get; set; }
        }

        [XmlRoot(ElementName = "batting")]
        public class Batting
        {
            [XmlElement(ElementName = "play")]
            public List<Play> Play { get; set; }
            [XmlElement(ElementName = "innsummary")]
            public Innsummary Innsummary { get; set; }
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "vh")]
            public string Vh { get; set; }
        }

        [XmlRoot(ElementName = "inning")]
        public class Inning
        {
            [XmlElement(ElementName = "batting")]
            public List<Batting> Batting { get; set; }
            [XmlAttribute(AttributeName = "number")]
            public string Number { get; set; }
        }

        [XmlRoot(ElementName = "runner")]
        public class Runner
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "out")]
            public string Out { get; set; }
            [XmlAttribute(AttributeName = "scored")]
            public string Scored { get; set; }
            [XmlAttribute(AttributeName = "tobase")]
            public string Tobase { get; set; }
        }

        [XmlRoot(ElementName = "plays")]
        public class Plays
        {
            [XmlElement(ElementName = "inning")]
            public List<Inning> Inning { get; set; }

            [XmlAttribute(AttributeName = "format")]
            public string Format { get; set; }
        }

        [XmlRoot(ElementName = "status")]
        public class Status
        {
            [XmlAttribute(AttributeName = "complete")]
            public string Complete { get; set; }
        }

        [XmlRoot(ElementName = "bsgame")]
        public class Game
        {
            [XmlElement(ElementName = "venue")]
            public Venue Venue { get; set; }

            [XmlElement(ElementName = "team")]
            public List<Team> Teams { get; set; }

            [XmlElement(ElementName = "plays")]
            public Plays Plays { get; set; }

            [XmlElement(ElementName = "status")]
            public Status Status { get; set; }

            [XmlAttribute(AttributeName = "generated")]
            public string Generated { get; set; }

            [XmlAttribute(AttributeName = "source")]
            public string Source { get; set; }

            [XmlAttribute(AttributeName = "source_format")]
            public string Source_format { get; set; }

            [XmlAttribute(AttributeName = "version")]
            public string Version { get; set; }
        }

    }
}