namespace PhotoCli.Tests.EndToEndTests;

public abstract class BaseEndToEndTests : IClassFixture<SetEnvironmentVariablesFromLaunchSettingsFixture>
{
	private readonly ITestOutputHelper _testOutputHelper;

	protected BaseEndToEndTests(ITestOutputHelper testOutputHelper)
	{
		_testOutputHelper = testOutputHelper;
	}

	#region Single Folder - PhotoCsv

	protected static PhotoCsv SingleKenya(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Kenya.jpg"), ExifDataFakes.Kenya(), useFullPath);
	}

	protected static PhotoCsv SingleItalyFlorence(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Florence.jpg"), ExifDataFakes.ItalyFlorence(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo1(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-1.jpg"), ExifDataFakes.ItalyArezzo1(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo2(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-2.jpg"), ExifDataFakes.ItalyArezzo2(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo3(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-3.jpg"), ExifDataFakes.ItalyArezzo3(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo4(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-4.jpg"), ExifDataFakes.ItalyArezzo4(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo5(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-5.jpg"), ExifDataFakes.ItalyArezzo5(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo6(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-6.jpg"), ExifDataFakes.ItalyArezzo6(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo7(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-7.jpg"), ExifDataFakes.ItalyArezzo7(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo8(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-8.jpg"), ExifDataFakes.ItalyArezzo8(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo9(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-9.jpg"), ExifDataFakes.ItalyArezzo9(), useFullPath);
	}

	protected static PhotoCsv SingleItalyArezzo9Duplicate(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Italy-Arezzo-9-duplicate.jpg"), ExifDataFakes.ItalyArezzo9(), useFullPath);
	}

	protected static PhotoCsv SingleUnitedKingdom(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("United-Kingdom.jpg"), ExifDataFakes.UnitedKingdom(), useFullPath);
	}

	protected static PhotoCsv SingleSpain1(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Spain-1.jpg"), ExifDataFakes.Spain1(), useFullPath);
	}

	protected static PhotoCsv SingleSpain2(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("Spain-2.jpg"), ExifDataFakes.Spain2(), useFullPath);
	}

	protected static PhotoCsv SingleNoPhotoTakenDate(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("NoPhotoTakenDate.jpg"), useFullPath: useFullPath);
	}

	protected static PhotoCsv SingleNoPhotoTakenDateWithDefaultName(bool useFullPath = true)
	{
		return SingleNoPhotoTakenDate(NoPhotoTakenDateFileName, useFullPath);
	}

	protected static PhotoCsv SingleNoGpsCoordinate(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("NoGpsCoordinate.jpg"), ExifDataFakes.NoGpsCoordinate(), useFullPath: useFullPath);
	}

	protected const string NoGpsCoordinateAndNoPhotoTakenDateFileName = "NoGpsCoordinateAndNoPhotoTakenDate";

	protected static PhotoCsv SingleNoGpsCoordinateAndNoPhotoTakenDateWithDefaultName(bool useFullPath = true)
	{
		return SingleNoGpsCoordinateAndNoPhotoTakenDate(NoGpsCoordinateAndNoPhotoTakenDateFileName, useFullPath);
	}

	protected static PhotoCsv SingleNoGpsCoordinateAndNoPhotoTakenDate(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SingleFolder("NoGpsCoordinateAndNoPhotoTakenDate.jpg"), useFullPath: useFullPath);
	}

	#endregion

	#region Subfolder PhotoCsv

	protected static PhotoCsv SubFoldersKenya(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("Kenya.jpg"), ExifDataFakes.Kenya(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyFlorence(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Florence/Italy-Florence.jpg"), ExifDataFakes.ItalyFlorence(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo1(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-1.jpg"), ExifDataFakes.ItalyArezzo1(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo2(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-2.jpg"), ExifDataFakes.ItalyArezzo2(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo3(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-3.jpg"), ExifDataFakes.ItalyArezzo3(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo4(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-4.jpg"), ExifDataFakes.ItalyArezzo4(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo5(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-5.jpg"), ExifDataFakes.ItalyArezzo5(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo6(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-6.jpg"), ExifDataFakes.ItalyArezzo6(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo7(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-7.jpg"), ExifDataFakes.ItalyArezzo7(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo8(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-8.jpg"), ExifDataFakes.ItalyArezzo8(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo9(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-9.jpg"), ExifDataFakes.ItalyArezzo9(), useFullPath);
	}

	protected static PhotoCsv SubFoldersItalyArezzo9Duplicate(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Arezzo/Italy-Arezzo-9-duplicate.jpg"), ExifDataFakes.ItalyArezzo9Duplicate(), useFullPath);
	}

	protected static PhotoCsv SubFoldersUnitedKingdom(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("United-Kingdom.jpg"), ExifDataFakes.UnitedKingdom(), useFullPath);
	}

	protected static PhotoCsv SubFoldersSpain1(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("SpainFolder/Spain-1.jpg"), ExifDataFakes.Spain1(), useFullPath);
	}

	protected static PhotoCsv SubFoldersSpain2(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("SpainFolder/Spain-2.jpg"), ExifDataFakes.Spain2(), useFullPath);
	}


	private static readonly DateTime NoGpsCoordinatePhotoTakenDateTime = new(2008, 7, 16, 11, 33, 20);
	protected static readonly string NoGpsCoordinateDayFormatFileName = NoGpsCoordinatePhotoTakenDateTime.ToString("yyyy.MM.dd");
	protected static PhotoCsv SubFoldersNoGpsCoordinate(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("ItalyFolder/Florence/NoGpsCoordinate.jpg"), NoGpsCoordinatePhotoTakenDateTime, useFullPath: useFullPath);
	}

	protected const string NoPhotoTakenDateFileName = "NoPhotoTakenDate";

	protected static PhotoCsv SubFoldersNoPhotoTakenDateWithDefaultName(bool useFullPath = true)
	{
		return SubFoldersNoPhotoTakenDate(NoPhotoTakenDateFileName, useFullPath);
	}

	protected static PhotoCsv SubFoldersNoPhotoTakenDate(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("SpainFolder/NoPhotoTakenDate.jpg"), useFullPath: useFullPath);
	}

	protected static PhotoCsv SubFoldersNoGpsCoordinateAndNoPhotoTakenDateWithDefaultName(bool useFullPath = true)
	{
		return SubFoldersNoGpsCoordinateAndNoPhotoTakenDate(NoGpsCoordinateAndNoPhotoTakenDateFileName, useFullPath);
	}

	protected static PhotoCsv SubFoldersNoGpsCoordinateAndNoPhotoTakenDate(string? newFileName = null, bool useFullPath = true)
	{
		return CreatePhotoCsv(newFileName, TestImagesPathHelper.SubFolders("NoGpsCoordinateAndNoPhotoTakenDate.jpg"), useFullPath: useFullPath);
	}

	#endregion

	private static PhotoCsv CreatePhotoCsv(string? newFileName, string filePath, ExifData exifData, bool useFullPath = true, params string[] reverseGeocodes)
	{
		var outputPhotoFile = newFileName != null ? $"{newFileName}.jpg" : null;
		if (useFullPath)
			filePath = FullPath(filePath);

		return PhotoCsvFakes.Create(filePath, exifData, outputPhotoFile, reverseGeocodes.ToList(), true);
	}

	private static PhotoCsv CreatePhotoCsv(string? newFileName, string filePath, DateTime? takenDateTime = null, double? latitude = null, double? longitude = null, bool useFullPath = true,
		params string[] reverseGeocodes)
	{
		var outputPhotoPath = newFileName != null ? $"{newFileName}.jpg" : null;
		if (useFullPath)
			filePath = FullPath(filePath);

		return PhotoCsvFakes.Create(filePath, outputPhotoPath, takenDateTime, reverseGeocodes.ToList(), latitude, longitude, true);
	}

	protected ConsoleOutputValues ParseConsoleOutput(string actualOutput)
	{
		var photosFound = GetRegexValue(@"(.\d+) photo\(s\) found.", actualOutput);
		var photosCopied = GetRegexValue(@"(.\d+) photo\(s\) copied.", actualOutput);
		var hasTakenDateAndCoordinate = GetRegexValue(@"(.\d+) photo\(s\) has taken date and coordinate.", actualOutput);
		var hasTakenDateButNoCoordinate = GetRegexValue(@"(.\d+) photo\(s\) has taken date but no coordinate.", actualOutput);
		var hasNoTakenDateAndCoordinate = GetRegexValue(@"(.\d+) photo\(s\) has no taken date and coordinate.", actualOutput);
		var directoriesCreated = GetRegexValue(@"(.\d+) directory/directories created.", actualOutput);
		return new ConsoleOutputValues(photosFound, photosCopied, hasTakenDateAndCoordinate, hasTakenDateButNoCoordinate, hasNoTakenDateAndCoordinate, directoriesCreated);
	}

	private int GetRegexValue(string regex, string actualOutput)
	{
		var value = new Regex(regex).Match(actualOutput).Groups[1].Value;
		return value.IsPresent() ? int.Parse(value) : 0;
	}

	private static string FullPath(string filePath)
	{
		return Path.Combine(AppContext.BaseDirectory, filePath);
	}

	protected Task<string> RunMain(IEnumerable<string> args, ExitCode expectedExitCode = ExitCode.Success)
	{
		return RunMain(args.ToArray(), expectedExitCode);
	}

	protected async Task<string> RunMain(string[] args, ExitCode expectedExitCode = ExitCode.Success)
	{
		var stringWriter = new StringWriter();
		var exitCode = (ExitCode)await Program.MainStream(args, stringWriter);
		_testOutputHelper.WriteLine(stringWriter.ToString());
		var actualOutput = GetTrimmedConsoleOutput(stringWriter);
		exitCode.Should().Be(expectedExitCode);
		return actualOutput;
	}

	private string GetTrimmedConsoleOutput(StringWriter stringWriter)
	{
		var rawOutput = stringWriter.GetStringBuilder().ToString();
		var lines = rawOutput.Split(Environment.NewLine);
		var trimmedLines = lines.Select(s => s.Trim());
		var mergedLines = string.Join(Environment.NewLine, trimmedLines.SkipLast(1));
		return mergedLines;
	}

	protected void StringsShouldMatchDiscardingLineEndings(string actual, string expected)
	{
		actual.ReplaceLineEndings().Should().Be(expected.ReplaceLineEndings());
	}

	protected static string OutputFolderForE2ETestPrivateToEachTest()
	{
		return Path.Combine("e2e-tests-output", Guid.NewGuid().ToString());
	}

	protected static void DeleteOutput(string outputPath)
	{
		if (Directory.Exists(outputPath))
			Directory.Delete(outputPath, true);
	}
}
