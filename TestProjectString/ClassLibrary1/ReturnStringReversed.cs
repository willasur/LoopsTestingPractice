using System;



/// <summary>
/// not done
/// </summary>

namespace ClassLibrary1
{
    public class ReturnStringReversed 
    {
        public bool Check(string[] str)
        {
            var strng = str[0];
            for (var i = 0; i < str.Length; i++)
            {
                if (strng == str[i])
                    strng = str[i];
            }
            return true;
        }


    }
}
