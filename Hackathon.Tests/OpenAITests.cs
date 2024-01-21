namespace Hackathon.Tests;

public class OpenAITests
{
    [Fact]
    public void Test_Prompt()
    {        
        string anwser = OpenAI.Prompt("");
        Assert.Equal("", anwser);
    }
}