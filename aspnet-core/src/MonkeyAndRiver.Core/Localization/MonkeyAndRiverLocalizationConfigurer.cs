using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MonkeyAndRiver.Localization
{
    public static class MonkeyAndRiverLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MonkeyAndRiverConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MonkeyAndRiverLocalizationConfigurer).GetAssembly(),
                        "MonkeyAndRiver.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
