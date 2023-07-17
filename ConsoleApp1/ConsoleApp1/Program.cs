// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using System;
using System.Data;
using System.Linq.Expressions;

class DemoProgram
{
    // Main Method
    static public void Main()
    {
        int value = 25; 
        int v1=0, v2=0;
        Boolean f1=false, f2=false, f3=false;

        if(value > 19)
        {
            f3 = true;f1= true;
            v1 = value / 10;
            v2 = value % 10;
        }
        else if(value > 9)
        {
            f2 = true;
            v2 = value;
        }
        else
        {
            f1 = true;
            v2 = value;
        }

        if(f3)
        {
            switch(v1) 
            {
                case 2: Console.Write("Twenty");break;
                case 3: Console.Write("Thirty"); break;
                case 4: Console.Write("Fourty"); break;
                case 5: Console.Write("Fifty"); break;
                case 6: Console.Write("Sixty"); break;
                case 7: Console.Write("Seventy"); break;
                case 8: Console.Write("Eighty"); break;
                case 9: Console.Write("Ninty"); break;
            }
        }
        if (f2)
        {
            switch (v2)
            {
                case 10: Console.Write("Ten"); break;
                case 11: Console.Write("Eleven"); break;
                case 12: Console.Write("Twelve"); break;
                case 5: Console.Write("Fifty"); break;
                case 6: Console.Write("Sixty"); break;
                case 7: Console.Write("Seventy"); break;
                case 8: Console.Write("Eighty"); break;
                case 9: Console.Write("Ninty"); break;
            }
        }

        if (f1)
        {
            switch (v2)
            {
                case 0: Console.Write(""); break;
                case 1: Console.Write("One"); break;
                case 2: Console.Write("Two"); break;
                case 5: Console.Write("Fifty"); break;
                case 6: Console.Write("Sixty"); break;
                case 7: Console.Write("Seventy"); break;
                case 8: Console.Write("Eighty"); break;
                case 9: Console.Write("Ninty"); break;
            }
        }
    }
}


/*
string s = "HellolleH";
        char[] arr = s.ToCharArray();
        Boolean flag = true;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != arr[arr.Length-i-1])
            {
                flag = false;
            }
        }

        if(flag) 
        {
            Console.WriteLine("String is Palindrom");
        }
        else 
        {
            Console.WriteLine("String is not Palindrom");

        }


 */


/*
 
using System;
class GFG {
 
    // Main Method
    static public void Main()
    {
 
        // assigned int value
        // 23 to num
        int num = 23;
 
        // boxing
        object obj = num;
 
        // unboxing
        int i = (int)obj;
 
        // Display result
        Console.WriteLine("Value of ob object is : " + obj);
        Console.WriteLine("Value of i is : " + i);
    }
}

*/

/*
       int num;
       string val;
       Boolean flag = true;
       Console.WriteLine("Please enter valid Integer Number");
       val = Console.ReadLine();

       num = Convert.ToInt32(val);

       for(int i=2; i<num; i++)
       {
           if(num % i == 0)
           {
               flag = false;
           }
       }

       if(flag == true)
       {
           Console.WriteLine("Number {0} is prime ", val);
       }
       else
       {
           Console.WriteLine("Number {0} is not prime", val);
       }
       */