using System;

namespace ClassLibrary1
{
    public class DoesDoubleExist
    {
        public bool Check(int[]num)
        {
            for (var i = 0; i < num.Length; i++)
            {
                var num2 = num[i];
                for (var j = 0; j < num.Length; j++)
                {
                    if (num2 * 2 == num[j])
                    return true;
                }
            }
            return false;
        }
    }
}
