/* ==============================================================================
 * 功能描述：PowerOfTwo  
 * 创 建 者：gz
 * 创建日期：2017/5/8 18:58:49
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math.Lib
{
//    Write an algorithm to determine if a number is "happy".

//A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.

//Example: 19 is a happy number

//1^2 + 9^2 = 82
//8^2 + 2^2 = 68
//6^2 + 8^2 = 100
//1^2 + 0^2 + 0^2 = 1
public class HappyNumberSln {
    public bool IsHappy(int n) {
        int slow =n, fast = n;
        do{
            slow = getSum(slow);
            fast = getSum(fast);
            fast = getSum(fast);
        }while(slow!=fast);
        return slow==1;
    }
    
    public int getSum(int n){
        int sum=0;
        int tmp = n;
        while(tmp>0){
            int i = tmp%10;
            sum+=i*i;
            tmp = tmp/10;
        }
        return sum;
    }
}
}
