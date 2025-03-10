using MauiApp5.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5
{
    public class TokenService
    {
        private static TokenService _instance;
        public static TokenService Instance => _instance ??= new TokenService();

        private TokenService()
        {
            // set the default (in advanced scenarios, this could be read from the preferences)
            Theme = Theme.System;
        }

        private Theme _theme;
        public Theme Theme
        {
            get => _theme;
            set
            {
                if(_theme == value) return;
                _theme = value;
                if (Application.Current is Application app)
                {
                    app.UserAppTheme = value.AppTheme;
                }
            }
        }

        private I18N _i18n;
        public I18N I18N
        {
            get => _i18n;
            set
            {
                if (_i18n == value) return;
                _i18n = value;
                CultureInfo.CurrentUICulture = new CultureInfo(value.Code, false);
                Debug.WriteLine($"{AppResources.myLang}");
            }
        }
    }
}
