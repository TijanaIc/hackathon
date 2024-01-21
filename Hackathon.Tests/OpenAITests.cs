namespace Hackathon.Tests;

public class OpenAITests
{
    [Fact]
    public void Test_Prompt()
    {        
        string answer = OpenAI.Prompt("");
        Assert.Equal("", answer);
    }

    [Fact]
    public async Task Test_PromptAI()
    {
        string answer = await OpenAI.PromptAI("What is the largest continent?");
        Assert.NotEmpty(answer);
    }
}