using System;

namespace From_A_to_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int counter = 0;

            if(a < b){
                counter = 0;
                counter += b - a;
            }
            else{
                while(a > b){
                    if(a % 2 ==0){
                        a = a / 2;
                        counter++;
                    }
                    else{
                        a++;
                        counter++;
                    }
                }
                counter++;
            }
            
            Console.WriteLine(counter);
        }
    }
}
