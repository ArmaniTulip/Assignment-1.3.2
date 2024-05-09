using System.Globalization;

namespace Assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] assignmentArray = { 2, 5, 7 };
            int n = assignmentArray.Length;
            int temp = 0;

            for (int i = 0; i < n / 2; i++)
            {
                temp = assignmentArray[i];
                assignmentArray[i] = assignmentArray[n - i - 1];
                assignmentArray[(n - i) - 1] = temp;
            }

            foreach (int i in assignmentArray)

            {
                Console.WriteLine(i);
            }

        }

    }

}