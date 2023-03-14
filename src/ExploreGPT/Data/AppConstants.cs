namespace ExploreGPT.Data
{
    public enum MessageSources
    {
        System, User, Asistant
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
