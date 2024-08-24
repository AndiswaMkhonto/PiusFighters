using MonkeyAndRiver.Debugging;

namespace MonkeyAndRiver
{
    public class MonkeyAndRiverConsts
    {
        public const string LocalizationSourceName = "MonkeyAndRiver";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "aa8acc711e544aa480a8b834070c4e80";
    }
}
