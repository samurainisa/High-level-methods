using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    //Разработать класс строк на основе массива символов. Перегрузить операторы +, ==, !=
    public class charArrayString
    {
        private char[] charArray;

        public charArrayString(string str)
        {
            charArray = str.ToCharArray();
        }

        public charArrayString(char[] charArray)
        {
            this.charArray = charArray;
        }

        public char[] CharArray
        {
            get { return charArray; }
            set { charArray = value; }
        }

        public static charArrayString operator +(charArrayString str1, charArrayString str2)
        {
            char[] charArray = new char[str1.charArray.Length + str2.charArray.Length];
            for (int i = 0; i < str1.charArray.Length; i++)
            {
                charArray[i] = str1.charArray[i];
            }

            for (int i = 0; i < str2.charArray.Length; i++)
            {
                charArray[i + str1.charArray.Length] = str2.charArray[i];
            }

            return new charArrayString(charArray);
        }

        public static bool operator ==(charArrayString str1, charArrayString str2)
        {
            if (str1.charArray.Length != str2.charArray.Length)
            {
                return false;
            }

            for (int i = 0; i < str1.charArray.Length; i++)
            {
                if (str1.charArray[i] != str2.charArray[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(charArrayString str1, charArrayString str2)
        {
            if (str1.charArray.Length != str2.charArray.Length)
            {
                return true;
            }

            for (int i = 0; i < str1.charArray.Length; i++)
            {
                if (str1.charArray[i] != str2.charArray[i])
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < charArray.Length; i++)
            {
                str += charArray[i];
            }

            return str;
        }
    }
}