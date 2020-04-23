using System;

namespace Csharp_basics
{
    class Program
    {

        static void Main(string[] args)
        {
            /*  int? a = 10;
              int x = a??0 ; //NUllCoalescen
              bool b = (a == 10 ? true : false);
              Console.WriteLine(b);
              int? i = null; //coverting non nullable to nullable 
              float d = 100.25f;
              int r = (int)d;
              int r1 = Convert.ToInt32(d);
              Console.WriteLine(r1);
              string sno = "1234";
              int ino = int.Parse(sno); //covertion using parse method 
              Console.WriteLine(ino);
              string sno1 = "1234$";
              int ino1 = 0;
              if(int.TryParse(sno1, out ino1))
                              ino1 = int.Parse(sno1);
               else
                  Console.WriteLine("conversion not possible");
                  //covertion using parse method 
              Console.WriteLine(ino1);*/
            /*  arryas in C# *
            int[] num = new int[3];
                for (int j = 0; j < num.Length; j++)
                    num[j] = j;
                for (int j = 0; j < num.Length; j++)
                    Console.WriteLine(num[j]);*/
            /*if else statement */
            labl:
            Console.WriteLine("1. small  2.Medium  3.Large");
            int a = int.Parse(Console.ReadLine());
            int totalBill = 0;
            /*if (a == 1)
                Console.WriteLine("user entered {0}", a);
            else
                Console.WriteLine("user entered {0}", a);*/
            /*switch statement*/

            switch (a)
            {
                case 1:
                    totalBill += 1;
                    break;
                case 2:
                    totalBill += 2;
                    break;
                case 3:
                    totalBill += 3;
                    break;
                default:
                    Console.WriteLine("you have entered wrong option");
                    break;
            }    
             Console.WriteLine("Do you wanna continue Y/N?");
             string userchoice = Console.ReadLine();
             if (userchoice == "Y")
                 goto labl;
             else
                Console.WriteLine("bill is {0}", totalBill);
              

             

          

        }
    }
}
