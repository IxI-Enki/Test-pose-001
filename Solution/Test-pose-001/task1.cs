//------ NOT needed on handwritten test --------------------------------//
using System;                                                           //
namespace Test_pose_001                                                 //
{    public class First                                                 //
    {   public void Task()                                              //
        {  //-----------------------------------------------------------//
/* DECLARE VARIABLES */
            double x,y, z;
//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n Geben Sie drei Werte ein\n");             //
            Console.Write(" x: ");                                      //
            x = Convert.ToDouble(Console.ReadLine());                   //
            Console.Write(" y: ");                                      //
            y = Convert.ToDouble(Console.ReadLine());                   //
            Console.Write(" z: ");                                      //
            z = Convert.ToDouble(Console.ReadLine());                   //
//----------------------------------------------------------------------//

/* CALCULATION ------------------------  // TEST ARGUMENTS */
            if ((x == y && x != z) ||    //    x IS y AND NOT z  OR ..
                (x == z && x != y) ||    //    x IS z AND NOT y  OR ..
                (y == z && y != x))      //    y IS z AND NOT x  
            { // if ONE ARGUEMENT is TRUE
/* OUT */       Console.Write("\n Genau 2 Werte sind gleich.");
            }
            else
            { // if ALL ARGUMENTS are FALSE
/* OUT */       Console.Write("\n Es sind nicht genau 2 Werte gleich.");
            }
//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n [Enter] - zurück zur Auswahl.");          //
            Console.ReadLine();                                         //
        }                                                               //
    }                                                                   //
} //--------------------------------------------------------------------//