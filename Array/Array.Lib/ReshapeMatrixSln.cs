using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array.Lib
{
    //    In MATLAB, there is a very useful function called 'reshape', which can reshape a matrix into a new one with different size but keep its original data.

    //You're given a matrix represented by a two-dimensional array, and two positive integers r and c representing the row number and column number of the wanted reshaped matrix, respectively.

    //The reshaped matrix need to be filled with all the elements of the original matrix in the same row-traversing order as they were.

    //If the 'reshape' operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.

    //Example 1:
    //Input: 
    //nums = 
    //[[1,2],
    // [3,4]]
    //r = 1, c = 4
    //Output: 
    //[[1,2,3,4]]
    //Explanation:
    //The row-traversing of nums is [1,2,3,4]. The new reshaped matrix is a 1 * 4 matrix, fill it row by row by using the previous list.
    //Example 2:
    //Input: 
    //nums = 
    //[[1,2],
    // [3,4]]
    //r = 2, c = 4
    //Output: 
    //[[1,2],
    // [3,4]]
    //Explanation:
    //There is no way to reshape a 2 * 2 matrix to a 2 * 4 matrix. So output the original matrix.
    public class ReshapeMatrixSln
    {
        // i*c+j = si*dim1+sj;
        public int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int dim0 = nums.GetUpperBound(0);
            int dim1 = nums.GetUpperBound(1);
            int si = 0, sj = 0;
            if (r * c != (dim0+1) * (dim1+1)) return nums;
            int[,] rtn = new int[r, c];
            for (int i = 0; i < r; i++) {
                for (int j = 0; j < c; j++,sj++){
                    if (sj > dim1){
                        si++;
                        sj = 0;
                    }
                    rtn[i, j] = nums[si, sj];
                }
             }
            return rtn;
        }
    }
}
