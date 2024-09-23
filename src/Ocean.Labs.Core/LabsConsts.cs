using Ocean.Labs.Debugging;

namespace Ocean.Labs
{
    public class LabsConsts
    {
        public const string LocalizationSourceName = "Labs";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4778b4acd6104313bc18b5570f897faa";
    }
}
