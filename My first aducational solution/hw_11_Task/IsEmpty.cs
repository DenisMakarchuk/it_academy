using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_11_Task
{
    class IsEmpty
    {
        public static bool LettersTrue(string letters)
        {
            if (string.IsNullOrEmpty(letters))
                return false;
            return true;
        }
    }
}
