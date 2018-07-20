using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            char[] Input = text.ToCharArray();
            string Answer = "";

            for (int i = 0; i < Input.Length; i++)
            {
                if ((int)text[i] >= 65 && (int)text[i] <= 90)
                {
                    Answer += (char)(((int)(text[i]) + shiftKey - 65) % 26 + 65);
                }
                else if ((int)text[i] >= 97 && (int)text[i] <= 122)

                {
                    Answer += (char)(((int)(text[i]) + shiftKey - 97) % 26 + 97);
                }

                else Answer += text[i];
            }

            return Answer;
        }
    }
}









