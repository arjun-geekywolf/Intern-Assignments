namespace MathUtilities
{
    public class MathUtility
    {

        public bool IsEven(int num)
        {
            if(num % 2 ==0)
                return true;
            return false;
        }

        public bool IsPrime(int num)
        {
            if (num < 2)
                return false;
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        public int fact(int num)
        {
            int res=1;

            for (int i = 1; i <= num; i++)
                res *= i;
            return res;
        }
    }
}
