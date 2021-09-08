    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Scrambler
    {
        public class Coder
        {
            static public string Scrambler(string str, string textKey)
            {
              byte[] text = new byte[str.Length];
              text = Encoding.Unicode.GetBytes(str);
              byte[] scrambled = new byte[text.Length];
              for (int i = 0; i < text.Length; i++)
              {
               scrambled[i] = (byte)(text[i] ^ int.Parse(textKey));
              }
              return Encoding.Unicode.GetString(scrambled);
             }

        }
    }
