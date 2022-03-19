namespace HFAN.Web
{
    public class Settings
    {
        public EndPoints? EndPoints { get; set; }
    }

    public class EndPoints
    {
        public string? ApplicationApiBaseUri { get; set; }
    }
}
