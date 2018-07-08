using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarvationPlayings
{
    public static class Patterns
    {
        public static Regex playerRegex = new Regex(@"\(Player\d\)", RegexOptions.ECMAScript);
        public static Regex groupRegex = new Regex(@"\(Group\d\)", RegexOptions.ECMAScript);
        public static Regex hisRegex = new Regex(@"\(his\/her\d\)", RegexOptions.ECMAScript);
        public static Regex selfRegex = new Regex(@"\(self\d\)", RegexOptions.ECMAScript);
    }
}
