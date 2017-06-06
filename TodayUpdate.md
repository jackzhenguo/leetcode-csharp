# `Today Update`
(Notes: "&hearts;" Welcome to visit or fork or star my LeetCode Manager @
https://github.com/jackzhenguo/LeetCodeManager

## Bit Mainpulation
*  [CSDN:#397 Integer Replacement](http://blog.csdn.net/daigualu/article/details/72861851)
   > Following coding refers to A couple of Java solutions with explanations 
   > But it has a bug of overflowing and I fix it.</br>
   ```C#
    public int IntegerReplacement(int n) {
        int cnt = 0;
        long bign = (long)n; //n = Int32.MaxValue(2147483647),adds 1 and would overflow
        while (bign != 1) {
        if ((bign & 1) == 0) { //even number
            bign >>= 1;
          } 
          //It is enough to examine the last two digits to figure out 
          //whether incrementing or decrementing will give more 1's. Indeed, 
          //if a number ends with 01, 
          //then certainly decrementing is the way to go. Otherwise, if it ends with 11, 
          //then certainly incrementing is at least as good as decrementing (*011 -> *010 / *100) or
          // even better (if there are three or more 1's).
          else if (bign == 3|| ((bign >> 1) & 1) == 0) { //*01
            --bign;
          }
          else { //*11
            ++bign;
        }
        ++cnt;
       } 
       return cnt;
    }
   ```