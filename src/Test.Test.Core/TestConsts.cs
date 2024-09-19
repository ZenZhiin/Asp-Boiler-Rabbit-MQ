using Test.Test.Debugging;

namespace Test.Test
{
    public class TestConsts
    {
        public const string LocalizationSourceName = "Test";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d9dfaad7749d4c81abc64c6a0af20f44";
    }
}
