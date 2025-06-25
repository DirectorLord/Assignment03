namespace Assignment02
{
    using System;
    public class Program
    {
        public static void Main()
        {
            #region Question 1
            ////Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Please enter the number to be divided");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0) Console.WriteLine("Yes");

            //else Console.WriteLine("No");

            #endregion
            #region Question 2
            ////Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter a number: ");
            //int pos = Convert.ToInt32(Console.ReadLine());
            //if (pos > 0) Console.WriteLine("The number is positive!");
            //else Console.WriteLine("The number is Negative!");
            #endregion
            #region Question 3
            ////Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("Enter the first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the third number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int max = num1;
            //int min = num1;
            //if (num2 > max) max = num2;
            //else if (num3 > max) max = num3;
            //else if (num2 < min) min = num2;
            //else if (num3 < min) min = num3;
            //Console.WriteLine("The max is: " + max + " The min is: " + min);
            #endregion
            #region Question 4
            ////Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Enter a number for even or odd: ");
            //int even = Convert.ToInt32(Console.ReadLine());
            //if (even % 2 == 0) Console.WriteLine("The number is even!");
            //else Console.WriteLine("The number is odd!");
            #endregion
            #region Question 5
            ////Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Enter a letter: ");
            //char letter = Convert.ToChar(Console.ReadLine().ToLower());
            //if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') Console.WriteLine("Vowel");

            //else Console.WriteLine("Consonant");

            #endregion
            #region Question 6
            ////Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter a number for its range: ");
            //int range = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= range; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Question 7
            ////Write a program that allows the user to insert an integer then 
            ////print a multiplication table up to 12
            //Console.WriteLine("Enter a number for multiplication table: ");
            //int multi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Multiplication table for " + multi + "is: ");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(multi + " * " + i + " = " + (multi * i));
            //}
            #endregion
            #region Question 8
            ////Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter a number to print its even numbers: ");
            //int numeven = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Even numbers between 0 and " + numeven + " are: ");
            //for (int i = 0; i <= numeven; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //#endregion
            //#region Question 9
            ////Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter the based number: ");
            //int based = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the power: ");
            //int power = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //if (power == 0)
            //{

            //    result = 1;
            //}
            //else
            //{

            //    result = 1;
            //    for (int i = 1; i <= power; i++)
            //    {
            //        Console.WriteLine(result *= based); ;
            //    }
            //}
            #endregion
            #region Question 10
            ////Write a program to enter marks of five subjects and calculate total, average and percentage
            //Console.WriteLine("Enter marks for five subjects: ");
            //int total = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Enter marks for subject " + i + ": ");
            //    int marks = Convert.ToInt32(Console.ReadLine());
            //    total += marks;
            //}
            //Console.WriteLine("Total marks: " + total);
            //double average = total / 5.0;
            //Console.WriteLine("Average marks: " + average);
            //double percentage = (total / 500.0) * 100;
            //Console.WriteLine("Percentage: " + percentage + "%");
            #endregion
            #region Question 11
            ////Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter the month number (1-12): ");
            //int month = Convert.ToInt32(Console.ReadLine());
            //int days = 0;
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        Console.WriteLine("Days in month is: " + days);
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        Console.WriteLine("Days in month is: " + days);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        break;
            //}
            #endregion
            #region Question 12
            ////Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n
            ////Console.WriteLine("Enter the size of the identity matrix (n): ");
            ////int n = Convert.ToInt32(Console.ReadLine());

            ////for (int i = 0; i < n; i++)
            ////{
            ////    for (int j = 0; j < n; j++)
            ////    {
            ////        if (i == j)
            ////            Console.Write("1 ");
            ////        else
            ////            Console.Write("0 ");
            ////    }
            ////    Console.WriteLine();
            ////}
            #endregion
            #region Question 13
            ////Write a program in C# Sharp to find the sum of all elements of the array
            //Console.WriteLine("Enter the size of the array: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //int sum = 0;
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += arr[i];
            //}
            //Console.WriteLine("The sum of all elements in the array is: " + sum);
            #endregion
            #region Question 14
            //14- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.WriteLine("Enter the size of the array: ");
            //int size2 = Convert.ToInt32(Console.ReadLine());
            //int[] arr2 = new int[size2];
            //int sum2 = 0;
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < size2; i++)
            //{
            //    arr2[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Frequency of each element in the array: "+ arr2);
            //????
            #endregion
            #region Question 15
            ////Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.WriteLine("Enter the size of the array: ");
            //int size3 = Convert.ToInt32(Console.ReadLine());
            //int[] arr3 = new int[size3];
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < size3; i++)
            //{
            //    arr3[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int maxElement = arr3[0];
            //int minElement = arr3[0];
            //for (int i = 1; i < size3; i++)
            //{
            //    if (arr3[i] > maxElement)
            //    {
            //        maxElement = arr3[i];
            //    }
            //    if (arr3[i] < minElement)
            //    {
            //        minElement = arr3[i];
            //    }
            //}
            //Console.WriteLine("Maximum element in the array: " + maxElement);
            //Console.WriteLine("Minimum element in the array: " + minElement);
            #endregion
            #region Question 16
            ////Write a program in C# Sharp to find the second largest element in an array
            //Console.WriteLine("Enter the size of the array: ");
            //int size4 = Convert.ToInt32(Console.ReadLine());
            //int[] arr4 = new int[size4];
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < size4; i++)
            //{
            //    arr4[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int max = arr4[0];
            //????
            #endregion
        }
    }
}
