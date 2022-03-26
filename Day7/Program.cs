using Assignment3.Entities;
using Assignment3.Interfaces;
namespace Assignment3
{
    public class Program {
        public static void Main(string[] args)
        {



            //1.
            //Let’s make a program that uses methods to accomplish
            //a task.Let’s take an array and
            //reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
            //become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
            //To accomplish this, you’ll create three methods: one to create the array, one to reverse the
            //array, and one to print the array at the end.

            //int[] numbers = GenerateNumbers(20); 
            //Reverse(numbers); 
            //PrintNumbers(numbers);



            //2.The Fibonacci sequence
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(Fibonacci(i));
            //}

            //Designing and Building Classes using object-oriented principles
            //6. Had to combine some classes in one file from too many files 
            /*  
             *  Overall stucture is built, some places stil lacks actual functionality
             */
            InstructorService ins = new InstructorService();
            ins.GetAge();
            


            //7.
            //BallDriver bd = new BallDriver();
            //bd.Run();

        }

        public static int Fibonacci(int num)
        {
            if(num == 1 || num == 2) { return 1; }

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }



        public static int[] GenerateNumbers(int len)
        {
            int[] numbers = new int[len];

            for(int i = 0; i < len; i++)
            {
                numbers[i] = i;
            }
            return numbers;
        }

        public static void Reverse(int[] nums)
        {
            for (int i = 0; i < nums.Length / 2; i++)
            {
                int temp = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = temp;
            }
        }

        public static void PrintNumbers(int[] nums)
        {
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}