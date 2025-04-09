using System;

class Program
{
    static void Main()
    {


        int[] mynum = { 2, 5, 7 };
        int length = mynum.Length;
        int temp = 0;

        for (int i = 0; i < length / 2; i++)
        {
            temp = mynum[i];
            mynum[i] = mynum[length - i - 1];
            mynum[length - i - 1] = temp;
        }

        // Display the array after reversing
        Console.WriteLine("The values store into the array in reverse are: ");
        for (int i = 0; i < length; i++)
        {

            Console.WriteLine(mynum[i] + " ");
        }
    }
}