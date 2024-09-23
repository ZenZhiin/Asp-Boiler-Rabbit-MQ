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
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8240205e3efd43d6a54b436479a7bcf0";
    }
}
