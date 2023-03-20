using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DUNP.Vezbe3
{
    public static class Spliter
    {
        //Short string i broj reci
        public static string Short(this string text,int? num)
        {
            if(!num.HasValue)
            {
                num = 5;
            }
            var splitText = text.Split(' ');
            if(splitText.Length <= num) {
                return text;
            }
            StringBuilder sb = new StringBuilder();
            //Danas pada kisa, Benjaminu to smeta i zatvorio je prozor!
            //[5]
            // ["Danas","pada","kisa","Benjaminu","to","smeta","i","zatvorio","je","prozor"];
            // Danas pada kisa,Benjaminu to ...
            for(int i = 0;i < num; i++)
            {
                sb.Append(splitText[i]);
                sb.Append(" ");
            }
            sb.Append("...");
            return sb.ToString();
        }
    }
}
