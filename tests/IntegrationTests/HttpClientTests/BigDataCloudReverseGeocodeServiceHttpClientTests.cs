namespace PhotoCli.Tests.IntegrationTests.HttpClientTests;

public class BigDataCloudReverseGeocodeServiceHttpClientTests : IClassFixture<SetEnvironmentVariablesFromLaunchSettingsFixture>
{
	[Fact]
	public async Task Response_Serialization_Verify()
	{
		const string apiKeyEnvironmentVariableName = "PHOTO_CLI_BIG_DATA_CLOUD_API_KEY";
		var apiKey = Environment.GetEnvironmentVariable(apiKeyEnvironmentVariableName);
		apiKey.Should().NotBeNull("{0} environment variable not set", apiKeyEnvironmentVariableName);
		var apiKeyStore = new ApiKeyStore { BigDataCloud = apiKey };
		var sut = new BigDataCloudReverseGeocodeService(BigDataCloudRealHttpClient(), NullLogger<BigDataCloudReverseGeocodeService>.Instance, apiKeyStore);
		var bigDataCloudResponse = await sut.SerializeFullResponse(CoordinateFakes.Ankara(), "tr");
		bigDataCloudResponse.Verify();
	}

	private static HttpClient BigDataCloudRealHttpClient()
	{
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
		return new HttpClient
		{
			BaseAddress = new Uri("https://api.bigdatacloud.net/data/reverse-geocode/"),
			DefaultRequestHeaders = { UserAgent = { UserAgent.Instance() } }
		};
	}
}
