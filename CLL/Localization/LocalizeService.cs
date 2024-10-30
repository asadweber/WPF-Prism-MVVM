using Microsoft.Extensions.Localization;
using System;
using System.Reflection;

namespace CLL.Localization
{
    public class LocalizeService
    {
        private readonly IStringLocalizer _localizer;

        public LocalizeService(IStringLocalizerFactory factory)
        {
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public LocalizedString GetLocalizedHtmlString(string key)
        {
            return _localizer[key];
        }

        public LocalizedString GetLocalizedHtmlStringAllowNull(string key)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                return _localizer[key];
            }

            return new LocalizedString(key, string.Empty);
        }

        public LocalizedString GetLocalizedHtmlString(string key, string parameter)
        {
            return _localizer[key, parameter];
        }



        public static string jsonStatusError(IStringLocalizer _sharedLocalizer)
        {
            return _sharedLocalizer["jsonStatusError"];
        }
        public static string jsonStatusFailed(IStringLocalizer _sharedLocalizer)
        {
            return _sharedLocalizer["jsonStatusFailed"];
        }
        public static string jsonStatusSuccess(IStringLocalizer _sharedLocalizer)
        {
            return _sharedLocalizer["jsonStatusSuccess"].Value;
        }
        public static string titleConfirmation(IStringLocalizer _sharedLocalizer)
        {
            return _sharedLocalizer["modalTitleConfirmation"].Value;
        }
        public static string titleError(IStringLocalizer _sharedLocalizer)
        {
            return _sharedLocalizer["modalTitleError"].Value;
        }
        public static string titleinformation(IStringLocalizer _sharedLocalizer)
        {
            return _sharedLocalizer["modalTitleInformation"].Value;
        }

    }
}
