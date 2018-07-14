using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {

        
        static void MyGame() {

            int nMin = 1;
             int nMax = 10;
            Random oRandom = new Random();

            for (int nlevel = 1; nlevel <= 5; nlevel++) {
                int counter = 0;


                while (counter < 5)
                {
                    try
                    {

                        int nFirstNumber = oRandom.Next(nMin, nMax);
                       int nSecondNumber = oRandom.Next(nMin, nMax);

                        Console.WriteLine(nFirstNumber + " + " + nSecondNumber + " = ");


                        int nResult = 0;
                        bool bTryParse = int.TryParse(Console.ReadLine(), out nResult);

                        if (bTryParse)
                        {
                            if (nResult == (nFirstNumber + nSecondNumber))
                            {
                                counter++;
                            }
                            else
                            {
                                Console.WriteLine("please try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("please enter valid number");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Console.WriteLine("Next Level Reached");

                nMax += 10;
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Congratulations");

            MyGame();
            Console.ReadKey();
        }
    }
}
