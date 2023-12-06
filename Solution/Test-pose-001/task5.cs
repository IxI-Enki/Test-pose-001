//------ NOT needed on handwritten test --------------------------------//
using System;                                                           //
namespace Test_pose_001                                                 //
{   public class Fifth                                                  //
    {   public void Task()                                              //
        {                                                               //
/* DECLARE VARIABLES */                                                 //
            int y, x,   j;                                              //
            Console.Write("\n Schleife wählen [a/b]: ");                //
            char choice = Console.ReadKey().KeyChar;                    //
            switch(choice)                                              //
            {   case 'a':                                               //
/* LOOP A */        y = 1; j = 1;                                       //
                    do                                                  //
                    {   y = y + j;                                      //
                        j++;                                            //
                        Console.Write($"\n y:{y}, j:{j}");              //
/* NO */          } while (y < 200);                                    //
/* TERMINATION */ Console.Write("\n A terminierte.");                   //
                    break;                                              //
                case 'b':                                               //
/* LOOP B */        x = 1; j = 20;                                      //
                    while (x+j < 100)                                   //
                    {   x = x + 3;                                      //
                        j--; j--;                                       //
                        Console.Write($"\n y:{x}, j:{j}");              //
                    }                                                   //
/* TERMINATED */    Console.Write("\n B terminierte.");                 //
                    break;                                              //
            }                                                           //
            Console.Write("\n [Enter] - zurück zur Auswahl.");          //
            Console.ReadLine();                                         //
        }                                                               //
    }                                                                   //
} //--------------------------------------------------------------------//