using System.Runtime.Serialization;

namespace netcore_mock_server.Configuration
{
    public enum ApplicationMode
    {
        [EnumMember(Value = "File")]
        File,
        [EnumMember(Value = "Files")]
        Files,
        [EnumMember(Value = "Dirrectory")]
        Dirrectory
    }

    public class ApplicationConfig : IApplicationConfig
    {
        public ApplicationConfig(ApplicationMode applicationMode)
        {
            ApplicationMode = applicationMode;
        }

        public ApplicationMode ApplicationMode { get; }
    }
}
