namespace BitManipulation
{
    // Given an integer (signed 32 bits), write a function to check whether it is a power of 4.

    // Example:
    // Given num = 16, return true. Given num = 5, return false.

    // Follow up: Could you solve it without loops/recursion?
    public class Solution
    {
        public bool IsPowerOfFour(int num)
        {
            //4d: 0010Binary 3d: 1100  0010 & 1100 = 0
            //16d:00001      15d: 11110 00001 & 11110 = 0
            return (num & (num - 1)) == 0 && (num & 0x55555555) != 0;
            //0x55555555 is to remove those power of 2 but not power of 4
            //so that the value 1 always appears at the odd index 
        }
    }
}
