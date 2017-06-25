using System;

namespace InterviewPractice
{
    class HowManySteps
    {
        /*
         * Problem: 8.1 Triple Step:
         * A child is running up a staircase with n steps and can hop either 1 step, 2 steps, or 3 steps at a time. Implement a method to count how many possible ways the child can
         * run up the stairs.
         * 
         * Solution: The key to the solution is that the final step can be one, two, or three steps. There is therefore a recursive relationship, where the solution to n is
         * f(n-3) + f(n-2) + f(n-1). 
         * 
         * The solution presented here could result in int overflow. To correct this, could use long or BigInteger
         */

        //Recursive solution
        public static int RecursiveSteps(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("Argument must be >= 0");
            }
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 4;
                default:
                    return RecursiveSteps(n - 3) + RecursiveSteps(n - 2) + RecursiveSteps(n - 1);
            }
        }

        //DP Solution "Bottom-Up"
        public static int DynamicRecursiveSteps(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("Argument must be >= 0");
            }
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 4;
                default:
                   break;
            }
            int[] steps = new int[n];
            steps[0] = 1; //n = 1
            steps[1] = 2; //n = 2
            steps[2] = 4; //n = 3
            for (int i = 3; i < steps.Length; i++)
            {
                steps[i] = steps[i - 1] + steps[i - 2] + steps[i - 3];
            }

            return steps[n-1];
        }


        static void Main(string[] args)
        {
            //Console.WriteLine(RecursiveSteps(50)); //Too slow
            Console.WriteLine(DynamicRecursiveSteps(50));
        }
    }
}
