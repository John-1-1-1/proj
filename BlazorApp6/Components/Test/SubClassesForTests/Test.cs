namespace BlazorApp6.Components.Test.SubClassesForTests;

public class Test {
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public ICollection<Question> Questions { get; set; } = new List<Question>();

    public bool ValidateQuestion() {
        return Questions.Select(q => q.ValidateQuestion()).All(b => b);
    }
}