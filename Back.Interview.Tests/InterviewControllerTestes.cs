namespace Back.Interview.Tests;

public class InterviewControllerTests : IClassFixture<CustomWebApplicationFactory>
{
    private readonly HttpClient _client;

    public InterviewControllerTests(CustomWebApplicationFactory factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetInterviewAsync_ReturnsExpectedMessage()
    {
        var expectedResponse = "1 - Teste - Ativo";
        
        var response = await _client.GetAsync("/Interview");
        
        response.EnsureSuccessStatusCode();
        var actualResponse = await response.Content.ReadAsStringAsync();
        Assert.Equal(expectedResponse, actualResponse);
    }
}