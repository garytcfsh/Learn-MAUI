using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5
{
    public sealed class I18N
    {
        public static I18N Tailand = new("th-TH", "Tailend"); //TempString
        public static I18N English = new("en-US", "English");
        public static I18N System = new("", "Follow System");

        public static List<I18N> AvailableLang { get; } = new()
        {
            Tailand,
            English,
            System
        };

        public string Code { get; }
        public string DisplayName { get; }

        private I18N(string code, string displayName)
        {
            Code = code;
            DisplayName = displayName;
        }
    }
}
