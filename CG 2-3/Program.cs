using System;

namespace CG_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When were you born?");

            Console.Write("Please type your full month of birth (ex. September): ");
            String birthMonth;
            birthMonth = Console.ReadLine();

            Console.Write("Day of birth: ");
            String birthDay;
            birthDay = Console.ReadLine();
            int birthDayInt = int.Parse(birthDay);
            if (birthDay.Length >2) return;
            
            Console.Write("Year of birth: ");
            String birthYear;
            birthYear = Console.ReadLine();
            int birthYearInt = int.Parse(birthYear);
            if (birthYear.Length >4 || birthYear.Length <4) return;
            
            Console.WriteLine("My date of birth is " + birthMonth + " " + birthDayInt + "," + " " + birthYearInt + ".");
            Console.ReadLine(); 


        }
    }
}
