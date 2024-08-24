using System.Collections.Generic;

namespace MonkeyAndRiver.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
