using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if(text==null)
            {
                throw new ArgumentNullException();
            }
            if(text.Length==0)
            {
                throw new ArgumentException();
            }
            string[] Firstwords = text.Split(new char[] { ' ', ',', '.', '!', '?', '-', ':', ';' });
            int flag = Firstwords.Length;
            string[] newText = new string[flag];
            int k = 0;
            for (int i = 0; i < Firstwords.Length; i++)
            {
                for (int j = 0; j < Firstwords.Length; j++)
                {
                    var s = Firstwords[i].CompareTo(newText[j]);
                    if (s == 0)
                    {
                        Firstwords[i] = "";
                        break;
                    }
                    if (j == Firstwords.Length - 1)
                    {
                        newText[k] = Firstwords[i];
                        ++k;
                    }
                }
            }
            text = "";
            for (int i = 0; i < Firstwords.Length; i++)
            {
                if (i == Firstwords.Length - 1) { text += Firstwords[i]; }
                else
                {
                    text += Firstwords[i] + " ";
                }
            }
        }

    }
}