using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_Task
{
    class IsLellers
    {
        public static bool LettersTrue(string letters)
        {
            if (string.IsNullOrEmpty(letters))
                return false;
            for (int i = 0; i < letters.Length; i++)
            {
                if (!char.IsLetter(letters[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool LerrerPatronymic(string letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (!char.IsLetter(letters[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
