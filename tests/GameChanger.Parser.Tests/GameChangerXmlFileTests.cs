namespace GameChanger.Parser.Tests;

public class GameChangerXmlFileTests
{
    [Theory]
    [InlineData("test_files/test_file1_sabertooth.xml", "5cccbb850cd201f5ec000008", "05/04/19")]
    [InlineData("test_files/test_file2_chelsea.xml", "62f5944135d90073e5000002", "08/13/22")]
    public void ShouldParseGameChangerFileWithNoError(string filePath, string expectGameId, string expectedVenuDate)
    {
        var output = ParserUtil.Deserialize<GameChangerXmlFile.Game>(File.ReadAllText(filePath));

        Assert.Equal(expectGameId, output.Venue.Gameid);
        Assert.Equal(expectedVenuDate, output.Venue.Date);
    }

    [Theory]
    [InlineData("test_files/test_file1_sabertooth.xml", "DNCS", "Doncaster", "SNTS", "St.Kilda 2019 MWBL C Resv Grade")]
    [InlineData("test_files/test_file2_chelsea.xml", "CRYD", "Croydon B Reserves", "STKL", "St Kilda  B Reserves")]
    public void ShouldParseGameChangerFileToTeamsCorrectly(string filePath, string expectedFirstTeamCode, string expectedFirstTeamName, string expectedSecondTeamCode, string expectedSecondTeamName)
    {
        var output = ParserUtil.Deserialize<GameChangerXmlFile.Game>(File.ReadAllText(filePath));

        Assert.Equal(expectedFirstTeamCode, output.Teams[0].Code);
        Assert.Equal(expectedFirstTeamName, output.Teams[0].Name);
        Assert.Equal(expectedSecondTeamCode, output.Teams[1].Code);
        Assert.Equal(expectedSecondTeamName, output.Teams[1].Name);
    }

    [Theory]
    [InlineData("test_files/test_file1_sabertooth.xml")]
    public void ShouldParseVenueAttributes(string filePath)
    {
        var output = ParserUtil.Deserialize<GameChangerXmlFile.Game>(File.ReadAllText(filePath));

        Assert.Equal("05/04/19", output.Venue.Date);
        Assert.Equal("5cccbb850cd201f5ec000008", output.Venue.Gameid);
        Assert.Equal("SNTS", output.Venue.Homeid);
        Assert.Equal("St.Kilda 2019 MWBL C Resv Grade", output.Venue.Homename);
        Assert.Equal("Y", output.Venue.Leaguegame);
        Assert.Equal("", output.Venue.Location);
        Assert.Equal("7", output.Venue.Schedinn);
        Assert.Equal("12:30 PM", output.Venue.Start);
        Assert.Equal("DNCS", output.Venue.Visid);
        Assert.Equal("Doncaster", output.Venue.Visname);
    }

    [Fact]
    public void ShouldParseSabertoothFileFormatCorrectly()
    {

        var output = ParserUtil.Deserialize<GameChangerXmlFile.Game>(File.ReadAllText("test_files/test_file1_sabertooth.xml"));

        // Venue Game Attributes
        Assert.Equal("Sabertooth", output.Source_format);

        var teamToTest = output.Teams[1];

        Assert.Equal(0, teamToTest.BattingOrder.Count);
        Assert.NotNull(teamToTest.Starters);
        Assert.Equal(10, teamToTest.Starters.Count);

        // Start 1
        Assert.Equal("Omar Gomez", teamToTest.Starters[0].Name);
        Assert.Equal("1", teamToTest.Starters[0].Slot);
        Assert.Null(teamToTest.Starters[0].Pos);
        Assert.Null(teamToTest.Starters[0].Uniform);

        // Start 2
        Assert.Equal("Kevin Wang", teamToTest.Starters[1].Name);
        Assert.Equal("SS", teamToTest.Starters[1].Pos);
        Assert.Equal("2", teamToTest.Starters[1].Slot);

        // Starter 9
        Assert.Equal("Josh Leicht", teamToTest.Starters[8].Name);
        Assert.Equal("2B", teamToTest.Starters[8].Pos);
        Assert.Equal("9", teamToTest.Starters[8].Slot);
        Assert.Equal("29", teamToTest.Starters[8].Uniform);
    }


    [Fact]
    public void ShouldParseChelseaFileFormatCorrectly()
    {

        var output = ParserUtil.Deserialize<GameChangerXmlFile.Game>(File.ReadAllText("test_files/test_file2_chelsea.xml"));

        // Venue Game Attributes
        Assert.Equal("Chelsea", output.Source_format);

        var teamToTest = output.Teams[1];

        Assert.Equal(0, teamToTest.Starters.Count);
        Assert.NotNull(teamToTest.BattingOrder);
        Assert.Equal(9, teamToTest.BattingOrder.Count);

        // Starter 1
        Assert.Equal("David Velazquez", teamToTest.BattingOrder[0].Name);
        Assert.Equal("1", teamToTest.BattingOrder[0].Slot);
        Assert.Equal("SS", teamToTest.BattingOrder[0].Pos);
        Assert.Null(teamToTest.BattingOrder[0].Uniform);

        // Starter 2
        Assert.Equal("Steve Bowden", teamToTest.BattingOrder[1].Name);
        Assert.Equal("C", teamToTest.BattingOrder[1].Pos);
        Assert.Equal("2", teamToTest.BattingOrder[1].Slot);

        // Starter 9
        Assert.Equal("Josh Smart", teamToTest.BattingOrder[8].Name);
        Assert.Equal("1B", teamToTest.BattingOrder[8].Pos);
        Assert.Equal("9", teamToTest.BattingOrder[8].Slot);
    }
}