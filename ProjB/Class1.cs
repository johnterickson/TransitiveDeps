namespace ProjB
{
    public class Class1
    {
        public static int GetVersion()
        {
            return typeof(Microsoft.IdentityModel.Abstractions.EventLogLevel).Assembly.GetName().Version?.Major ?? -1;
        }
    }
}
