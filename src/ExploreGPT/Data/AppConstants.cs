namespace ExploreGPT.Data
{
    public class FineTuneData
    {
        public string Prompt { get; set; }
        public string Completion { get; set; }
    }
    public enum FineTuneCases
    {
        ClassificationSentiment,
        ClassificationYesNo,
        ClassificationNumericalCategory,
        GenerationWriteAds,
        GenerationEntityExtraction,
        GenerationCustomerSupport,
        GenerationProductDesc
    }
    public enum MessageSources
    {
        System, User, Assistant
    }
    public class ChatItem
    {
        public MessageSources Source { get; set; }
        public string Message { get; set; }
    }
    public class AppConstants
    {
        public static string OpenAIKey = "";
        public static string OrgID = "";
    }
}
