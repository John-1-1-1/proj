namespace BlazorApp6.Components.Test.SubClassesForTests;

public class Question {
    public string Id { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string PathToImage { get; set; } = string.Empty;
    public ICollection<string> Answers { get; set; } = new List<string>();
    public string TrueAnswer { get; set; } = string.Empty;

    public bool ValidateQuestion() {
        return Answers.Select(a => a == TrueAnswer).Any(b => b == true);
    }
}