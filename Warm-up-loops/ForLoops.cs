using System.Diagnostics;
using Warm_up_loops;




namespace Warm_up_loops
{
    //[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class ForLoop
    {
       //private int int32;

        /// <summary>
        ///
        /// Return lowest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns lowest number in array.  If array is empty, returns null</returns>
        /// 
        public int? GetLowest(int[] arr)
        {
            if (arr.Length == 0)
            {
                return null;
            }

            var number = arr[0];
            for (var i = 1; i < arr.Length; i++)
            {
                if (number >= arr[i])
                    number = arr[i];
               
            }
            return number;
            
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Return highest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns highest number in array.  If array is empty, returns null</returns>
        public int? GetHighest(int[] arr)// Last Errors
        {
            if (arr.Length == arr.Length) //GetHighest_EmptyArray_ReturnNull
               
            {
                return null;
            }
            var number = arr[0];
            for (var i = 0; i < arr.Length; i++)
            {
                if (number < arr[i])
                    number = arr[i];

            }
            return number;
            ////throw new NotImplementedException();
            {

            }

    }

    /// <summary>
    /// Return highest number in jagged array
    /// <param name="arr">System.Int32[][]</param>
    /// <returns>Returns highest number in array.  If there are no numbers provided, returns ?</returns>
    public int? GetHighest(int[][] arr)
    {
        if (arr == null) return null;
        if (arr.Length == 0) return null;

        int? number = null;
        for (var i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (number == null) number = arr[i][j];
                if (number < arr[i][j])
                    number = arr[i][j];
            }

        }
        //throw new NotImplementedException();
        return number;
    }

         //private string GetDebuggerDisplay();
        //{
        //  return ToString();
    }
}
