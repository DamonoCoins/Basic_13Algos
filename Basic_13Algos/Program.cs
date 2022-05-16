////        Assignment: Basic 13
//// Write these as static functions callable from Program.cs.
///
Console.WriteLine("Welcome to my Basic 13 C# Algorithms.\n" +
    "  (...press any key to continue...)");
Console.WriteLine();
Console.ReadKey();
Console.Clear();

//      1.)
Console.WriteLine("1.) Print Numbers\n" +
    "  (...press any key to continue...)");
Console.ReadLine();
PrintNumbers();
Console.ReadLine();
Console.Clear();

//      2.)
Console.WriteLine("2.) Print Odd Numbers\n" +
    "  (...press any key to continue...)");
Console.ReadLine();
PrintOdds();
Console.ReadLine();
Console.Clear();

//      3.)
Console.WriteLine("3.) Print Sum\n" +
    "  (...press any key to continue...)");
Console.ReadLine();
PrintSum();
Console.ReadLine();
Console.Clear();

//      4.)
LoopArray(new int[] { 1, 2, 3, 4, 5 });
Console.ReadLine();
Console.Clear();

//      5.)
FindMax(new int[] { -3, -5, -7 });
Console.ReadLine();
Console.Clear();

//      6.)
GetAverage(new int[] { 2, 10, 3 });
Console.ReadLine();
Console.Clear();

//      7.)
Console.WriteLine("7.) Create Array of Odd Numbers\n" +
    "  (...press any key to continue...)");
Console.ReadLine();
OddArray();
Console.ReadLine();
Console.Clear();

//      8.)
Console.WriteLine(GreaterThanY(new int[] { 1, 3, 5, 7 }, 3));
Console.ReadLine();
Console.Clear();

//      9.)
SquareArrayValues(new int[] { 1, 5, 10, -10 });
Console.ReadLine();
Console.Clear();

//      10.)
EliminateNegatives(new int[] { 1, 5, 10, -2 });
Console.ReadLine();
Console.Clear();


//      11.)
MinMaxAverage(new int[] { 1, 5, 10, -2 });
Console.ReadLine();
Console.Clear();

//      12.)
ShiftValues(new int[] { 1, 5, 10, 7, -2 });
Console.ReadLine();
Console.Clear();

//      13.)
NumToString(new int[] { -1, -3, 2 });
Console.ReadLine();
Console.Clear();



// 1.)
//          Print Numbers
void PrintNumbers()
{
    // Print all of the integers from 1 to 255.


    for (int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}

// 2.)
//          Print Odd Numbers
void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
    Console.WriteLine("2.) Print Odd Numbers\n");

    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}

// 3.)
//           Print Sum
void PrintSum()
{
    // Print all of the numbers from 0 to 255,
    Console.WriteLine("3.) Print Sum\n");

    int i, sum = 0;
    for (i = 0; i <= 255; i++)
    {
        int previousSum = sum;
        sum += i;
        Console.WriteLine(i + " \t Sum: " + +sum);
    }
}

// 4.)
//            Iterating through an Array
void LoopArray(int[] numbers)
{
    // Write a function that would iterate through each item of the given integer
    //array and print each value to the console.
    Console.WriteLine("4.) Loop through an Array\n");

    foreach (int i in numbers)
    {
        Console.WriteLine(i);
    }
}

// 5.)
//            Find Max
int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array.
    // Your program should also work with a given array that has all negative numbers(e.g. [-3, -5, -7]),
    // or even a mix of positive numbers, negative numbers and zero.
    Console.WriteLine("5.) Find Max Number\n");

    Console.WriteLine(numbers.Max());
    return numbers.Max();



}

// 6.)
//            Get Average
void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    Console.WriteLine("6.) Get Average Number\n");
    Console.WriteLine(numbers.Average());

}


// 7.)
//            Array with Odd Numbers
void OddArray()
{
    // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255.
    // When the program is done, this array should have the values of [1, 3, 5, 7,... 255].
    Console.WriteLine("7.) Create Array of Odd Numbers\n");

    int[] numArray = new int[256];
    for (int i = 1; i <= numArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            numArray[i] = i;
            Console.WriteLine(i.ToString());
        }
    }
}


// 8.)
//            Greater than Y
int GreaterThanY(int[] numArray, int y)
{
    // Write a function that takes an integer array, and a integer "y" and returns the number of array values
    // That are greater than the "y" value.
    // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2
    // (since there are two values in the array that are greater than 3).
    Console.WriteLine("8.) Get Numbers Greater than \"Y\"\n");

    int numsGreaterThan = 1;
    for (int i = 0; i < y; i++)
    {
        if (numArray[i] > y)
        {
            numsGreaterThan += 1;
        }
    }
    return numsGreaterThan;

}



// 9.)
//            Square the Values
void SquareArrayValues(int[] numbers)
{
    // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    Console.WriteLine("9.) Square Values of an Array\n");

    var multiArray = Array.ConvertAll(numbers, x => 2 * x);
    foreach (int i in multiArray)
    {
        Console.WriteLine(i);
    }
}



// 10.)
//            Eliminate Negative Numbers
void EliminateNegatives(int[] numbers)
{
    // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0.
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
    Console.WriteLine("10.) Eliminate and Replace Negative values\n");

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)          // less than : Replace with 0
        {
            numbers[i] = 0;

            Console.WriteLine(numbers[i]);

        }
        else if (numbers[i] > 0)     // greater than
        {

            Console.WriteLine(numbers[i]);
        }
    }
}



// 11.)
//            Min, Max, and Average
void MinMaxAverage(int[] numbers)
{
    // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array,
    // the minimum value in the array, and the average of the values in the array.
    Console.WriteLine("11.) Get Minimun, Maximum, and Average Number of an Array\n");

    Console.WriteLine("Max: " + numbers.Max());
    Console.WriteLine("Min: " + numbers.Min());
    Console.WriteLine("Avg: " + numbers.Average());
}


// 12.)
//            Shifting the values in an array
void ShiftValues(int[] numbers)
{
    // Given an integer array, say [1, 5, 10, 7, -2],
    // Write a function that shifts each number by one to the front and adds '0' to the end.
    // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function,
    // it should become [5, 10, 7, -2, 0].
    Console.WriteLine("12.) Shift Values\n");

    int[] newNumbers = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {

        if (i < numbers.Length - 1)
        {
            newNumbers[i] = numbers[i + 1];

        }
        else
        {
            newNumbers[i] = numbers[0];
        }
    }
    newNumbers[4] = 0;
    Array.ForEach(newNumbers, x => Console.WriteLine(x));

}


// 13.)
//            Number to String
object[] NumToString(int[] numbers)
{
    // Write a function that takes an integer array and returns an object array
    // that replaces any negative number with the string 'Claim'.
    // For example, if array "numbers" is initially [-1, -3, 2]
    // your function should return an array with values ['Claim', 'Claim', 2].
    Console.WriteLine("13.) Return String\n");

    int[] newNumbers = numbers;
    object[] newString = new object[newNumbers.Length];
    int indexNum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[indexNum] < 0)     // if negative
        {
            newString[indexNum] = "Claim";
        }
        else if (numbers[indexNum] > 0)    // if positive
        {
            newString[indexNum] = newNumbers[indexNum];
        }
        indexNum++;
    }


    foreach (object o in newString)
    {
        Console.WriteLine(o.ToString());
    }


    return newString;
}