using System;
namespace InterviewPractice
{
    //The LCS algorithm from CLRS. 

    public enum DIRECTION { Up, Left, UpLeft }

    public class LCS
    {
       
        public static int[,] FindLCS(char[] X, char[] Y, out DIRECTION[,] tracker) {
            int m = X.Length;
            int n = Y.Length;
            int[,] c = new int[m+1, n+1];
            tracker = new DIRECTION[m+1, n+1];

            for (int i = 1; i <= m; i++){
                for (int j = 1; j <= n; j++) {
                    if (X[i-1] == Y[j-1]) {
                        c[i, j] = c[i - 1, j - 1] + 1;
                        tracker[i, j] = DIRECTION.UpLeft;
                    } else if (c[i-1, j] >= c[i, j-1]) {
                        c[i, j] = c[i - 1, j];
                        tracker[i, j] = DIRECTION.Up;
                    } else {
                        c[i, j] = c[i, j - 1];
                        tracker[i, j] = DIRECTION.Left;
                    }
                }
            }
            

            return c;

        }

        public static void PrintLCS(DIRECTION[,] tracker, char[] seq1, int i, int j) {
            if (i < 0 || j < 0) 
            {
                return;
            }
            if (tracker[i,j] == DIRECTION.UpLeft) //We know that X[i] == Y[j]
            {
                PrintLCS(tracker, seq1, i-1, j-1);
                Console.WriteLine(seq1[i-1]);
            } 
            else if (tracker[i,j] == DIRECTION.Up)
            {
                PrintLCS(tracker, seq1, i-1, j);
            } 
            else
            {
                PrintLCS(tracker, seq1, i, j-1);    
            }


        }

        public static void Main(string[] args)
        {
            string one = "ABCBDAB";
            string two = "BDCABA";
            char[] test1 = one.ToCharArray();
            char[] test2 = two.ToCharArray();
            DIRECTION[,] tracker;
            int[,] results = FindLCS(test1, test2, out tracker);
            PrintLCS(tracker, test1, test1.Length, test2.Length);
        }
    }
}
