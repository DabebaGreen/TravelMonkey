namespace TravelMonkey
{
	public static class ApiKeys
	{
        #warning You need to set up your API keys.
		public static string ComputerVisionApiKey = "6b31f8ba71ea46f8867375403ebfcb49";
		public static string TranslationsApiKey = "f47932a17b22400cacb3f4ac32516c29";
		public static string BingImageSearch = "5d10554c045245e59fe322e64f88b870";

		// Change this to the Azure Region you are using
		public static string ComputerVisionEndpoint = "https://francecentral.api.cognitive.microsoft.com/";
		public static string TranslationsEndpoint = "https://api.cognitive.microsoft.com/sts/v1.0/issuetoken";
	}
}