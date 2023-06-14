namespace PhotoCli.Utils;

public static class Constants
{
	public const string CsvExtensionRegex = @"^.*\.(csv|CSV)$";
	public const string PhotoExtensionRegex = @"^.*\.(jpg|JPG|jpeg|JPEG|heic|HEIC)$";

	public const string AppSettingsFileName = "appsettings.json";

	public const string ApplicationExeName = "po";
	public const string VerifyFileHashFileName = "sha1.lst";
}
