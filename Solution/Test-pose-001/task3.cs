//------ NOT needed on handwritten test --------------------------------//
using System;                                                           //
namespace Test_pose_001                                                 //
{   public class Third                                                  //
    {   public void Task()                                              //
        {  //-----------------------------------------------------------//
/* DECLARE VARIABLES */
            int month, days;
//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n Wählen Sie ein Monat [1-12]\n");          //
            string input = Console.ReadLine();                          //
            int.TryParse(input, out month);                             //
//----------------------------------------------------------------------//
/* CALCULATION */
            switch (month)
            {   case 1:        // January
                case 3:        // March
                case 5:        // May
                case 7:        // July
                case 8:        // August
                case 10:       // October
                case 12:       // December
                    days = 31;
                    break;
                case 4:        // April
                case 6:        // June
                case 9:        // September
                case 11:       // November
                    days = 30;
                    break;
                case 2:        // February
                    days = 28; // Assuming no leap year
                    break;
                default:
                    Console.Write("\nUngültige Eingabe\n");
                    return;
            }
/* OUT */   Console.Write($"\n Der {month}. Monat hat {days} Tage.");       
//------ NOT needed on handwritten test --------------------------------//
            Console.Write("\n [Enter] - zurück zur Auswahl.");          //
            Console.ReadLine();                                         //
        }                                                               //
    }                                                                   //
} //--------------------------------------------------------------------//