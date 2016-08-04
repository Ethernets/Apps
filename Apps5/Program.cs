namespace Apps5
{
    using System;

   public class Program
    {
       public static void Main(string[] args)
        {
            Staff staff = new Staff();

            staff.AssignFuckingNames();

            staff.ShowFuckingInfo();

            Console.ReadKey();
        }
    }
}
