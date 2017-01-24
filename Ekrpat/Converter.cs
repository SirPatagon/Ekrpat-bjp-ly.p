using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekrpat
{
    public static class Converter
    {
        const string dvorak = "`1234567890[]',.pyfgcrl/=aoeuidhtns-\\\\;qjkxbmwvz~!@#$%^&*(){}\"<>PYFGCRL?+AOEUIDHTNS_||:QJKXBMWVZ";
        const string qwertz = "^1234567890ß´qwertzuiopü+asdfghjklöä#<yxcvbnm,.-°!\"§$%&/()=?`QWERTZUIOPÜ*ASDFGHJKLÖÄ'>YXCVBNM;:_";

        public static string ConvertToDvorak(string qwertzText)
        {
            return prc(qwertz, dvorak, qwertzText);
        }

        public static string ConvertToQwertz(string dvorakText)
        {
            return prc(dvorak, qwertz, dvorakText);
        }

        private static string prc(string from, string to, string text)
        {
            string returns = string.Empty;
            for(int i = 0; i<text.Length; i++)
            {
                if(from.IndexOf(text[i]) > -1)
                {
                    returns += to[from.IndexOf(text[i])];
                }
                else
                {
                    returns += text[i];
                }
            }
            return returns;
        }
    }
}
