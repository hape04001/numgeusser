using System;

namespace Number_Gueser
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random  num = new Random();
            int tal = num.Next(1, 101);
            Console.WriteLine("gissa tal mellan 0 och 100");
            int försök = 0;
            while(true)
            {
               
                int awnser = int.Parse(Console.ReadLine()); 
                
                 
                if(awnser < tal){
                    Console.WriteLine("talet för lågt. Försök igen");
                    försök++;
                }
                else if (awnser > tal){
                    Console.WriteLine("talet för högt. försök igen");
                    försök++;
                }
                else{
                    försök++;
                    Console.WriteLine($"Rätt tal. Du gissade rätt efter {försök} försök");
                    break;
                }

            }

        }
    }
}
