using System;
namespace MyNameSpace
{
    public class Program
    {
        public static string GetNextName(out int id)
        {
            return "returnText";
        }
        public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }

        public static void Main(String[] args)
        {
            int i= 1;
            Console.WriteLine("Previous value of integer i:{0}", i);
            string test = GetNextName(ref i);
            Console.WriteLine("Current value of integer i:{0}", i);
            GetNextName(out i);
        }
    }
}

/*
 public class Semester
    {
        public void display(int sem)
        {
            Console.WriteLine("Current Semester is {0}", sem);
        }
    }
 
public class Program
    {
        public static void Main(String[] args)
        {
            Semester s4 = new Semester(); //Object 1
            s4.display(4);
            Semester s2 = new Semester(); //Object 2
            s2.display(2);
            Console.ReadLine();
        }
    }
 */