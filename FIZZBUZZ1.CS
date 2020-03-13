using System; 

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args) 
        {   
            int counter = 1; 
            int mod;
                
            while (counter <
            101)
            {
                mod = counter % 3;
                mod = counter % 5;
                
                if ((counter %3 == 0) & (counter % 5 == 0))
                { 
                    Console.WriteLine("Fizz Buzz"); 
                }
                else if (counter % 3 == 0)
                {   
                    Console.WriteLine("Fizz");
                }
                else if (counter % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(counter);
                }
                    
                counter = counter +1; // counter++    
            }
            Console.ReadKey();  
        }
    }
}
       
  
    