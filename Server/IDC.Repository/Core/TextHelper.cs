using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Core
{
    public static class TextHelper
    {
        public static string Guid()
        {
            return System.Guid.NewGuid().ToString().Replace("-", "").ToUpper();
        }
        public static int RandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        public static string Random()
        {
            return DateTime.Now.Ticks.ToString();
        }
        public static string Random(int length,RandomType randomType, bool isStrong)
        {
            string result = string.Empty;
            System.Random r = null;
            if (isStrong)
                r = new System.Random(RandomSeed());
            else
                r = new System.Random();
            switch (randomType)
            {
                case RandomType.Number:
                    string range1 = "0123456789";
                    for (int i = 0; i < length; i++)
                        result += range1[r.Next(0, 9)].ToString();
                    break;
                case RandomType.Alphabet:
                    string range2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    for (int i = 0; i < length; i++)
                        result += range2[r.Next(0, 25)].ToString();
                    break;
                case RandomType.NumberAlphabet:
                    string range3 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    for (int i = 0; i < length; i++)
                        result += range3[r.Next(0, 35)].ToString();
                    break;
            }
            return result;
        }
        public static bool EqualsIgnoreCase(this string str1, string str2)
        {
            return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        }
        public static string Trim(string str)
        {
            return str == null ? string.Empty : str.Trim();
        }
        public static string CutTail(string sourceString, int length, string appendString = "")
        {
            if (sourceString == null || sourceString.Length <= length)
                return sourceString;

            return sourceString.Substring(0, length) + appendString;
        }
        public static string CutMiddle(string sourceString, int headLength, int tailLength, string fillString)
        {
            if (sourceString == null || sourceString.Length <= (headLength + tailLength))
                return sourceString;

            return sourceString.Substring(0, headLength) + fillString + sourceString.Substring(sourceString.Length - tailLength, tailLength);
        }
        public static string DateString(int dateInt, string delimiter)
        {
            string s = dateInt.ToString();
            return s.Substring(0, 4) + delimiter + s.Substring(4, 2) + delimiter + s.Substring(6);
        }

        /// <summary>
        /// HTML去除
        /// </summary>
        /// <param name="Htmlstring"></param>
        /// <returns></returns>
        public static string DelHTML(string Htmlstring)//将HTML去除
        {
            #region
            //删除脚本

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            //删除HTML

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"-->", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"<!--.*", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            //Htmlstring =System.Text.RegularExpressions. Regex.Replace(Htmlstring,@"<A>.*</A>","");

            //Htmlstring =System.Text.RegularExpressions. Regex.Replace(Htmlstring,@"<[a-zA-Z]*=\.[a-zA-Z]*\?[a-zA-Z]+=\d&\w=%[a-zA-Z]*|[A-Z0-9]","");



            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(amp|#38);", "&", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(lt|#60);", "<", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(gt|#62);", ">", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(nbsp|#160);", " ", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Htmlstring = System.Text.RegularExpressions.Regex.Replace(Htmlstring, @"&#(\d+);", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);


            Htmlstring.Replace("<", "");

            Htmlstring.Replace(">", "");

            Htmlstring.Replace("\r\n", "");

            #endregion

            return Htmlstring;
        }
        public enum RandomType
        {
            Number,
            Alphabet,
            NumberAlphabet
        }
    }
   
}
