//------ NOT needed on handwritten test --------------------------------//
using System;                                                           //
namespace Test_pose_001                                                 //
{   public class Second                                                 //
    {   public void Task()                                              //
        {  //-----------------------------------------------------------//
/* DECLARE VARIABLES */
            double a, b, c,
                   swap;
//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n Geben Sie drei Werte ein");               //
            Console.Write(" a: ");                                      //
            a = Convert.ToDouble(Console.ReadLine());                   //
            Console.Write(" b: ");                                      //
            b = Convert.ToDouble(Console.ReadLine());                   //
            Console.Write(" c: ");                                      //
            c = Convert.ToDouble(Console.ReadLine());                   //
//----------------------------------------------------------------------//

/* CALCULATION */
            if (a < b)      // SWAP a & b IF b is bigger
            {  swap = a;
               a = b;
               b = swap;
            }
            if (a < c)      // SWAP a & c IF c is bigger
            {  swap = a;
               a = c;
               c = swap;
            }
            if (b < c)      // SWAP b & c IF c is bigger
            {  swap = b;
               b = c;
               c = swap;
            }
/* OUT */   Console.Write($"\n Absteigende Reihenfolge:" +
                          $"\n {a}" +
                          $"\n {b}" +
                          $"\n {c}");
//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n [Enter] - zurück zur Auswahl.");          //
            Console.ReadLine();                                         //
        }                                                               //
    }                                                                   //
} //--------------------------------------------------------------------//