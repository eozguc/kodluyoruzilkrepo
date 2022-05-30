namespace BitwiseAnd;

public class BitwiseAnd
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int count = Convert.ToInt32(firstMultipleInput[0]);

            int lim = Convert.ToInt32(firstMultipleInput[1]);

            int res = Result.bitwiseAnd(count, lim);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

class Result
{

    /*
     * Complete the 'bitwiseAnd' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER N
     *  2. INTEGER K
     */
    
    public static int bitwiseAnd(int N, int K)
    {


        var max = int.MinValue;
        for (var i = 1; i < N; i++)
        {
            for (var j = i + 1; j <= N; j++)
            {
                var curr = i & j;
                if (curr < K)
                {
                    max = Math.Max(max, curr);
                    
                }
            }
        }

        return max;
        
        
        int result = 0;
        for (int i = 1; i <= N; i++) {
            for (int j = i + 1; j <= N; j++) {
                int current = i & j;
                if (current > result && current < K) {
                    result = current;
                }
            }
        }
        return result;


    }
}



