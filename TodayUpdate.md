# `Today Update`
(Notes: "&hearts;" Welcome to visit or fork or star my LeetCode Manager @
https://github.com/jackzhenguo/LeetCodeManager

## Bit Mainpulation
### 461 Hamming Distance
*  [CSDN:#461 Hamming Distance](http://blog.csdn.net/daigualu/article/details/72830624)
   > x&(x-1) application; xor application</br>
   ```C#
       public int HammingDistance(int x, int y)
        {
            ///a and y are different bits, so we think the XOR
            ///think:0001(1D)
            ///     0100(4D)
            ///xor = 0101(1D^4D)
            int dist = 0, xor = x ^ y;
            while (xor > 0)
            {
                ///xor & (xor-1): it sets the rightest 1 bit    to   0 bit of xor.  
                ++dist;
                xor = xor & (xor - 1);
            }
            return dist;
        }
   ```C#