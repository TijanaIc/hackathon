using OpenAI.API;
using OpenAI.API.Completions;

namespace Hackathon;

public class OpenAI
{
    public static string Prompt(string question)
    {
        return question;
    }

    public static async Task<string> PromptAI(string question)
    {
        var client = new OpenAIAPI("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");
        var parameters = new CompletionRequest
        {
            Model = "babbage-002",
            Prompt = question,
            Temperature = 0.7,
            MaxTokens = 100
        };
        var response = await client.Completions.CreateCompletionAsync(parameters);
        var answer = response.Completions[0].Text;
        return answer;
    }
}
