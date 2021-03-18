using System;

namespace Lab01a_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {

            StartSequence();
        } //end main function
        static void StartSequence()
        {
            Console.WriteLine("Enter a number: ");
            string userNum = Console.ReadLine();
            int userIntNum = Convert.ToInt32(userNum);

            int[] numArray= new int[userIntNum];
            Populate(numArray);
        } //end StartSequence function
        static int[] Populate(int[] userNumArray)
        {
            
            var counterNum = userNumArray.Length;
            string[] numbersArray = new string[counterNum];

            Console.WriteLine(counterNum);

            for (var i = 0; i < userNumArray.Length; i++)
            {
                Console.WriteLine($"Enter a number: {i} of {counterNum}" );
                string userNum = Console.ReadLine();
               // int userIntNum = Convert.ToInt32(userNum);

                numbersArray[i] = userNum;
                Console.WriteLine($"You entered: {numbersArray[i]}");

            }
            Console.WriteLine("The numbers you entered are: " + numbersArray);
            return userNumArray;
        } //end Populate function

    }
}
