//------ NOT needed on handwritten test --------------------------------//
using System;                                                           //
namespace Test_pose_001                                                 //
{   public class Sixth                                                  //
    {   public void Task()                                              //
        {  //-----------------------------------------------------------//
/* DECLARE VARIABLES */
            int n, sum;
                sum = 0;
//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n Zahl [n]: ");                             //
            n = Convert.ToInt32(Console.ReadLine());                    //
//----------------------------------------------------------------------//
/* CALCULATION */
            while(n != 0)
            {   sum = sum + (n % 10);
                n = n / 10;
            }
/* OUT */   Console.Write($"\n Die Ziffernsumme der Zahl ist {sum}");
//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n [Enter] - zurück zur Auswahl.");          //
            Console.ReadLine();                                         //
        }                                                               //
    }                                                                   //
} //--------------------------------------------------------------------//

