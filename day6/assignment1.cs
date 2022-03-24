


//Console.Write("What's your favorite color? ");
//string color = Console.ReadLine();
//Console.Write("What's your astrology sign? ");
//string sign = Console.ReadLine();
//Console.Write("What's your street address number? ");
//string num = Console.ReadLine();

//Console.WriteLine($"Your hacker name is {color + sign + num}");

//---------------------------------------------------------//

//Practice number sizes and ranges
//1.Create a console application project named /02UnderstandingTypes/ that outputs
//the number of bytes in memory that each of the following number types uses,
//and the minimum and maximum values they can have:
//sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.

//Console.WriteLine($"sbyte max = {sbyte.MaxValue}, min = {sbyte.MinValue}");

//Console.WriteLine($"byte max = {byte.MaxValue}, min = {byte.MinValue}");

//Console.WriteLine($"short max = {short.MaxValue}, min = {short.MinValue}");

//Console.WriteLine($"ushort max = {ushort.MaxValue}, min = {ushort.MinValue}");

//Console.WriteLine($"int max = {int.MaxValue}, min = {int.MinValue}");

//Console.WriteLine($"uint max = {uint.MaxValue}, min = {uint.MinValue}");

//Console.WriteLine($"long max = {long.MaxValue}, min = {long.MinValue}");

//Console.WriteLine($"ulong max = {ulong.MaxValue}, min = {ulong.MinValue}");

//Console.WriteLine($"float max = {float.MaxValue}, min = {float.MinValue}");

//Console.WriteLine($"double max = {double.MaxValue}, min = {double.MinValue}");

//Console.WriteLine($"decimal max = {decimal.MaxValue}, min = {decimal.MinValue}");



//---------------------------------------------------------//

//Composite Formatting to learn how to align text in a console application
//2.
//Write program to enter an integer number of centuries and convert it to 
//years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
//Use an appropriate data type for every data conversion. Beware of overflows!
//Input: 1
//Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
//= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
//microseconds = 3155673600000000000 nanoseconds
//Input: 5
//Output: 5 centuries = 500 years = 182621 days = 4382904 hours = 262974240
//minutes = 15778454400 seconds = 15778454400000 milliseconds = 15778454400000000
//microseconds = 15778454400000000000 nanoseconds

//string s = Console.ReadLine();
//UInt64 century = Convert.ToUInt64(s);
//Console.WriteLine($"{century} century = {century * 100} years = {century * 100 * 365} days = " +
//    $"{century * 100 * 365 * 24} hours = {century * 100 * 365 * 24 * 60} minutes = " +
//    $"{century * 100 * 365 * 24 * 60 * 60} seconds = {century * 100 * 365 * 24 * 60 * 60 * 1000} milliseconds = " +
//    $" {century * 100 * 365 * 24 * 60 * 60 * 1000 * 1000} microseconds = " +
//    $" {century * 100 * 365 * 24 * 60 * 60 * 1000 * 1000 * 1000} nanoseconds");



//---------------------------------------------------------//

//Switch Expression ( slightly different from old switch )
//string s = Console.ReadLine();

//string re = s switch { 
//    "abc" => "abc",
//    "123" => "number",
//    _     => "anything else"
//};

//Console.WriteLine(re);  



//---------------------------------------------------------//
//Practice loops and operators
//1.FizzBuzz is a group word game for children to teach them about division. 
//Players take turns to count incrementally, 
//replacing any number divisible by three with the word /fizz/, 
//any number divisible by five with the word /buzz/,
//and any number divisible by both with /fizzbuzz/. 
//Create a console application in Chapter03 named Exercise03 that outputs a
//simulated FizzBuzz gamecounting up to 100.

//string s = "";
//for (int i = 1; i <= 100; i++)
//{
//    if(i % 3 == 0 && i % 5 == 0)
//    {
//        s += "FizzBuzz ";  
//    }else if(i % 3 == 0)
//    {
//        s += "fizz ";
//    }else if(i % 5 == 0)
//    {
//        s += "buzz ";
//    }
//    else
//    {
//        s += i + " ";
//    }
//}

//Console.WriteLine(s);




//infinite loop since byte max at 255,never reach 500
//int max = 500;
//for (byte i = 0; i < max; i++) {
//    Console.WriteLine(i); 
//}





//---------------------------------------------------------//
//Write a program that generates a random number between 1 and 3 and 
//asks the user to guess what the number is. 
//Tell the user if they guess low, high, or get the correct answer. 
//Also, tell the user if their answer is outside of the range of numbers that are valid guesses 
//(less than 1 or more than 3). 


//int correctNumber = new Random().Next(3) + 1;

//bool correct = false;
//while (!correct)
//{
//    int guessedNumber = int.Parse(Console.ReadLine());



//    if (guessedNumber == correctNumber)
//    {
//        correct = true;
//        Console.WriteLine("You got it right");
//    } else if (guessedNumber < 1 || guessedNumber > 3)
//    {
//        Console.WriteLine("Not even close, try again");
//    }else if(guessedNumber > correctNumber)
//    {
//        Console.WriteLine("too high");
//    }
//    else
//    {
//        Console.WriteLine("too low");
//    }

//}




//---------------------------------------------------------//

//2.
//Print - a - Pyramid.
//Like the star pattern examples that we saw earlier, create a program that 
//will print the following pattern: If you find yourself getting stuck, try recreating the two 
//examples that we just talked about in this chapter first. They’re simpler, and you can 
//compare your results with the code included above. 
//This can actually be a pretty challenging problem, so here is a hint to get you going. I used 
//three total loops. One big one contains two smaller loops. The bigger loop goes from line 
//to line. The first of the two inner loops prints the correct number of spaces, while the 
//second inner loop prints out the correct number of stars. 


//for(int i = 1; i <= 9; i += 2)
//{
//    for(int j = 1; j <= (9 - i)/2; j++)
//    {
//        Console.Write(" ");
//    }


//    for(int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }

//    for (int j = 1; j <= (9 - i) / 2; j++)
//    {
//        Console.Write(" ");
//    }
//    Console.WriteLine();
//}



//---------------------------------------------------------//


//4.
//Write a simple program that defines a variable representing a birth date and calculates 
//how many days old the person with that birth date is currently.
//For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
//Note: once you figure out their age in days, you can calculate the days until the next 
//anniversary using
//int daysToNextAnniversary = 10000 - (days % 10000);

//DateTime d = DateTime.UtcNow;

//Console.WriteLine("What year are you born?");
//int year  = int.Parse(Console.ReadLine());
//Console.WriteLine("What month are you born?");
//int mon = int.Parse(Console.ReadLine()); 
//Console.WriteLine("What day are you born?");
//int day = int.Parse(Console.ReadLine());

//DateTime birthday = new DateTime(year,mon,day);

//Console.WriteLine($"You lived :{(d - birthday).Days} days");
//int daysToNextAnniversary = 10000 - ((d - birthday).Days % 10000);
//Console.WriteLine($"Next 10000 day anni is {daysToNextAnniversary} days from now");





//---------------------------------------------------------//

//5.
//Write a program that greets the user using the appropriate greeting for the time of day.
//Use only
//if, not else or switch, statements to do so. Be sure to include the following 
//greetings:
//"Good Morning"
//"Good Afternoon"
//"Good Evening"
//"Good Night"
//It 's up to you which times should serve as the starting and ending ranges for each of the 
//greetings.If you need a refresher on how to get the current time, see 
//DateTime Formatting
//. When testing your program, you'll probably want to use a
//DateTime variable you define, rather than the current time. Once you're confident the program works 
//correctly, you can substitute
//DateTime.Now for your variable (or keep your variable and just 
//Assign DateTime.Now as its value, which is often a better approach).

//DateTime time = new DateTime(2022, 3, 23, 22, 0, 0);

//DateTime time = DateTime.Now;
//Console.WriteLine(time.ToString());

//if(time.Hour > 4 && time.Hour < 12)
//{
//    Console.WriteLine("Good Morning");
//}else if(time.Hour > 11 && time.Hour < 17)
//{
//    Console.WriteLine("Good Afternoon");

//}else if (time.Hour > 16 && time.Hour < 22)
//{
//    Console.WriteLine("Good Evening");
//}
//else
//{
//    Console.WriteLine("Good Night");
//}




//6.
//Write a program that prints the result of counting up to 24 using four different increments.
//First, count by 1s, then by 2s, by 3s, and finally by 4s.
//Use nested for loops with your outer loop counting from 1 to 4. You inner loop should 
//count from 0 to 24, but increase the value of its /loop control variable/ by the value of the
// / loop control variable/ from the outer loop.
// This means the incrementing in the /afterthought/ expression will be based on a variable.
//Your output should look something like this:
//0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
//0,2,4,6,8,10,12,14,16,18,20,22,24
//0,3,6,9,12,15,18,21,24
//0,4,8,12,16,20,24

for (int i = 1; i <= 4; i++)
{
    for (int j = 0; j <= 24; j += i)
    {
        Console.Write(j + ", ");
    }
    Console.WriteLine();
}





