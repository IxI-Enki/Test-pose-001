//------ NOT needed on handwritten test --------------------------------//
using System;                                                           //
namespace Test_pose_001                                                 //
{   public class Forth                                                  //
    {   public void Task()                                              //
        {  //-----------------------------------------------------------//
 /* DECLARE VARIABLES */
            int x, y, a,
                shortA;
//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n Erster Wert [x]: ");                      //
            x = Convert.ToInt32(Console.ReadLine());                    //
            Console.Write("\n Erster Wert [y]: ");                      //
            y = Convert.ToInt32(Console.ReadLine());                    //
//----------------------------------------------------------------------//

/* CALCULATION ------ original code ------------ //  1. | 2. | 3. | 4.  */  
            if (x < 0 && y < 0)                  //
                a = x * y;                       //
            else if (x < 0)                      //
                a = x * (-y);                    // -------- x --------
            else if (y > 0)                      //  -1 | -1 |  1 |  1 
                a = (-x) * (-y);                 //
            else                                 // -------- y --------
                a = x * (-y);                    //  -1 |  1 | -1 |  1 
/* CALCULATION ------ shortened code ----------- */
            shortA = (x * y < 0) ? x * (-y) : x * y;  
/* OUT */   Console.Write($"\n [a]: {a}" +       // a 1 |  1 |  1 |  1 
                          $"\n [A]: {shortA}");  // A 1 |  1 |  1 |  1 

//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n [Enter] - zurück zur Auswahl.");          //
            Console.ReadLine();                                         //
        }                                                               //
    }                                                                   //
} //--------------------------------------------------------------------//



