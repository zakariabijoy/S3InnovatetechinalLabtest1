using System;

namespace S3InnovatetechinalLabtest1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bill = 0.00 ;

            DateTime pickHour1 = new DateTime(2019, 08, 31, 09, 00, 00);
            DateTime pickHour2 = new DateTime(2019, 08, 31, 22, 59, 59);


            DateTime startTime = new DateTime(2019, 08, 31, 08, 59, 13);
            DateTime endTime = new DateTime(2019, 08, 31, 09, 00, 39);

            TimeSpan diff = endTime - startTime;

            double callduration = diff.TotalSeconds/20;

            for (double i = 0; i <= callduration; i++)
            {
                startTime = startTime.AddSeconds(20);

                if (startTime >= pickHour1 && startTime <= pickHour2)
                {
                    bill += 30;
                }
                else
                {
                    bill += 20;
                }

                

            }

            Console.WriteLine(bill/100 + " taka");
      }
    }
}
