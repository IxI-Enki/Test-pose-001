//---------------- NOT NEEDED, but nice --------------------------------//
using Microsoft.VisualBasic;
using System;
namespace Test_pose_001
{   class Program
    {   static void Main()
        {
            int task;
            string choice;
            do
            {
                Console.Clear();
                do
                {
                    Console.Write("\n Wählen Sie eine Aufgabe [1-6]" +
                                  "\n [0] > Auswahl beenden\n   ");
                    choice = Console.ReadLine();
                } while (int.TryParse(choice, out task) == false);

                switch (task)
                {
                    case 1:
                        {  First Show = new First();
                           Show.Task(); }break;
                    case 2:
                        {  Second Show = new Second();
                           Show.Task(); }break;
                    case 3:
                        {  Third Show = new Third();
                           Show.Task(); }break;
                    case 4:
                        {  Forth Show = new Forth();
                            Show.Task(); }break;
                    case 5:
                        {  Fifth Show = new Fifth();
                           Show.Task(); }break;
                    case 6:
                        {  Sixth Show = new Sixth();
                           Show.Task(); }break;
                    case 0:
                    default:
                        Console.Write("\n ungültige Wahl \n");
                        break;
                }
            } while (task != 0);
        }
    }
}

