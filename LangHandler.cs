using R2API;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroveMaster.Helpers
{
    public static class LangHandler
    {

        public static void RegisterLang() {

            LanguageAPI.Add("GROVEMASTER_BOSS_BODY_NAME", "Grovemaster");
            LanguageAPI.Add("GROVEMASTER_BOSS_BODY_SUBTITLE", "Reap and Sow");
            LanguageAPI.Add("GROVEMASTER_BOSS_BODY_LORE", "Grovemaster\n" +
                "\nGrovemaster is a large Grovetender that protects Sundered Grove. The Grovemaster seems keen on preventing those within his demense from escaping. The Grovemaster seems to have an acute interest in preserving the souls of its victims, giving them to the Grovetenders it oversees to cultivate into new Wisps.\n" +
                "\nNote: Grovemaster appears to simply be a larger, stronger version of the Grovetender, but does not appear to have any special powers or movesets making it different than the Grovetenders. This suggests it is simply an older specimen that other Grovetenders respect and obey.\n" +
                "\nUse caution when engaging.\n" +
                "\nCategories: Enemies | Bosses | Unlisted Enemies\n" +
                "\nLanguages: English");
            LanguageAPI.Add("GROVEMASTER_BOSS_BODY_OUTRO_FLAVOR", "...and so he left, to reap a new harvest.");
            LanguageAPI.Add("GROVEMASTER_SPAWN_BEGIN", "<style=cWorldEvent>Your soul feels weak...</style>");
        
        }

    }
}
