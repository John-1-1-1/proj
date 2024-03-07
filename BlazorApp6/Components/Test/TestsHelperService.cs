namespace BlazorApp6.Components.Test;

public class TestsHelperService {

    public List<SubClassesForTests.Test>? ListTests ;
    
    public TestsHelperService(IConfiguration configuration) {
        ListTests = configuration.GetSection("ListTests").Get<List<SubClassesForTests.Test>>();

        if (ListTests == null || ListTests.Select(t => t.ValidateQuestion()).Any(b => b == false)) {
            throw new Exception("listTest.json invalid");
        }
        
    }
}