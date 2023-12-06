<!-------------------------------------------------------------------  
 - MARKDOWN - Cheatsheets:  
    Getting started:
      https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/quickstart-for-writing-on-github
    Basic github formatting syntax:  
      https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax
 ------------------------------------------------------------------->

# Visual Studio Solution
> Über das Auswahlmenü Main die einzelnen Aufgaben wählen.
 
 <details>
  <summary> [klick] - Auswahlmenü: </summary>  

```c#
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
                        Console.Write("\n Abbruch \n");
                        break;
                }
            } while (task != 0);
        }
    }
}





```

</details>
