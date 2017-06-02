# `Today Update`
(Notes: "&hearts;" Welcome to visit or fork or star my LeetCode Manager @
https://github.com/jackzhenguo/LeetCodeManager

## Bit Mainpulation
*  [CSDN:#476 Number Complement](http://blog.csdn.net/daigualu/article/details/72843822)
   > get bits for a number</br>
   ```C#
        public int FindComplement(int num)
        {
            int bits = 1; //num including bits
            while (Math.Pow(2, bits) <= num)
                bits++;
            int sum = (int) Math.Pow(2, bits) - 1;//sum =Pow(2,n)-1: sum of n bits 1
            return  sum - num; //sum - num is the complement

        }
   ```C#