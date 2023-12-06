//---------------- NOT NEEDED, but nice --------------------------------//
using Microsoft.VisualBasic;
using System;
namespace Test_pose_001
{   class Program
    {   static void Main()
        {  int task;
            string choice;
            do
            {   Console.Clear();
                do
                {   Console.Write("\n Wählen Sie eine Aufgabe [1-6]" +
                                  "\n [0] > Auswahl beenden   " +
                                  "\n" +
                                  "\n 1) Prüfe 3 Werte, auf GENAU 2 gleiche" +
                                  "\n 2) Sortiere 3 Werte absteigend" +
                                  "\n 3) Gib die Tage eines Monats aus" +
                                  "\n 4) Codevereinfachung" +
                                  "\n 5) 2 Schleifen" +
                                  "\n 6) Errechne die Ziffernsumme");
                    choice = Console.ReadLine();
                } while (int.TryParse(choice, out task) == false);

                switch (task)
                {   case 1:
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
                        Console.Write("\n Abbruch \n"); break;
                }
            } while (task != 0);
        }
    }
}

