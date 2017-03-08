namespace LanguageTranslator
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;
    using EloBuddy;
    using EloBuddy.Sandbox;
    using EloBuddy.SDK.Events;
    using EloBuddy.SDK.Menu;
    using EloBuddy.SDK.Menu.Values;
    using Newtonsoft.Json;
    using Version = System.Version;


    public enum Language
    {
        English,
        ChineseSimplified,
        ChineseTraditional,
    }

    public static class Program
    {

        private static string _jsonPath, _programDirectory;
        private static bool _jsonPathExists, _loaded, _ready;
        private static Dictionary<string, Dictionary<Language, Dictionary<int, string>>> _translations = new Dictionary<string, Dictionary<Language, Dictionary<int, string>>>();

        private static readonly Dictionary<string, Language> CulturesToLanguage = new Dictionary<string, Language>
        {
            { "en-US", Language.English },
            { "en-GB", Language.English },
            { "zh-CHS", Language.ChineseSimplified },
            { "zh-CHT", Language.ChineseTraditional }
        };

        private static Language CurrentCulture
        {
            get { return CulturesToLanguage.ContainsKey(CultureInfo.InstalledUICulture.ToString()) ? CulturesToLanguage[CultureInfo.InstalledUICulture.ToString()] : Language.English; }
        }

        static void Main(string[] args)
        {
        }
    }
}
