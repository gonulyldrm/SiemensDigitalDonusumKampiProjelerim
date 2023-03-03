using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6.Helper
{
    internal static class StringHelpers
    {
        public static bool CheckIfEmpty(string str)
        {
            bool sonuc = false;
            if (string.IsNullOrEmpty(str))
            {
                sonuc = true;
            }
            return sonuc;
        }
        
    }
}
