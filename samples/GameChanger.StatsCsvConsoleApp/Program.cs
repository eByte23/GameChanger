using GameChanger.Parser;
using GameChanger.StatsCsvConsoleApp;

if (args.Length == 0)
{
    Console.WriteLine("Please provide a file path to a GameChanger XML file as the first argument.");
    return;
}

if (args.Length == 1 && !args[0].EndsWith(".xml"))
{
    Console.WriteLine("Hmm looks like the file you provided may not be an XML file. Please provide a file path to a GameChanger XML file as the first argument.");
    return;
}

var filePath = args[0];

if (!File.Exists(filePath))
{
    Console.WriteLine($"{filePath} does not exist. Please provide a file path to a GameChanger XML file as the first argument.");
    return;
}

try
{

    var game = ParserUtil.Deserialize<GameChangerXmlFile.Game>(File.ReadAllText(filePath));
    CsvFileBuilder.BuildCsvFile(game, filePath);
}
catch (Exception ex) { 
    Console.WriteLine($"Error parsing file: {ex.Message}");
    return;
}
