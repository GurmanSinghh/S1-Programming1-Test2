using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 1

            /*  int number = 10;


              Console.WriteLine("Number   Square   Cube");
              Console.WriteLine("----------------------");

             for (number = 10; number >= 1; number--) 
              {
                  Console.WriteLine($"{number, 6}{number*number, 9}{number*number*number, 7}");

              }  */


            //QUESTION 2

            /* int year = 1;
             double balance = 1000;


             Console.WriteLine("Year     Balance");
             Console.WriteLine("----------------");

             while(year<=10)
             {
                 balance = balance + 0.08 * balance;
                 Console.WriteLine($"{year,4}{balance.ToString("c"), 12}");
                 year = year + 1;

             }*/


            //QUESTION 3

            /*  int individualGrade = 0;
              int sumGrades = 0;
              int averageGrades;
              int totalInputs = 0;


              while (true)
              {

               if (individualGrade == 999)
                {
                    break;
                }

                if (individualGrade < 0)
                  {
                      Console.WriteLine("Invalid. Grade less than 0 is not accepted");
                  }

                  if (individualGrade > 100)
                  {
                      Console.WriteLine("Invalid. Grade more than 100 is not accepted.");
                  }

                  if (individualGrade <= 100 && individualGrade >= 0)
                  {
                      totalInputs++;
                      sumGrades = sumGrades + individualGrade;
                  }



                  Console.Write("Enter A Grade: ");
                  individualGrade = Convert.ToInt32(Console.ReadLine());

              }

              totalInputs = totalInputs - 1; 


              averageGrades = sumGrades / (totalInputs);

              Console.WriteLine("Your Total Grade Is: " + sumGrades);
              Console.WriteLine("Your Average Grade Is: " + averageGrades);

              Console.ReadKey(); */

            //QUESTION 4

           /*  const int Gurman_Singh = -6;

             decimal x;
             decimal y;

             Console.WriteLine("x      2x^2     -x          -6           y     (x,y)");
             Console.WriteLine("--------------------------------------------------------");

             for (x = 1.0m; x <= 5; x += 0.5m)
             {
                 y = (2 * x * x) - x - 6;
                 Console.WriteLine($"{x,2:F1}{2 * x * x,7:F1}{-x,10}{Gurman_Singh,10}{y,12:F1}   ({x}, {y:F1})");
             }
             Console.ReadLine();*/


            


        }
    }
}
