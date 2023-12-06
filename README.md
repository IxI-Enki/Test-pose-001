<!-------------------------------------------------------------------  
 - MARKDOWN - Cheatsheets:  
    Getting started:
      https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/quickstart-for-writing-on-github
    Basic github formatting syntax:  
      https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax
 ------------------------------------------------------------------->

   > by Jan Ritt - 3ACIF    [ 71% - 3 ]
 
# 1. Test - Programmieren & Softwareentwicklung
## **Angabe**:  
> Vollständige [pdf](https://github.com/IxI-Enki/Test-pose-001/blob/main/Angabe/Test-pose-001%20--%20Angabe(leer).pdf)
<details>
  <summary> [klick] für VORSCHAU: </summary> 
  
  ![Angabe(leer)](https://github.com/IxI-Enki/Test-pose-001/assets/138018029/beebd258-8039-46b8-9a81-5f2923e65dd2)

</details>

-------------------------------  

<!------------------------------------------------->
## **Abgabe**:  
> Vollständige [pdf](https://github.com/IxI-Enki/Test-pose-001/blob/main/Abgabe/Test-pose-001.pdf)  

<details>
  <summary> [klick] - Angabeseite: </summary>  

 ![Angabe](https://github.com/IxI-Enki/Test-pose-001/blob/main/Abgabe/Test-pose-001%20--%20Angabe.jpg)  
 
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 1 & 2: </summary>    
 
 ![Seite 1](https://github.com/IxI-Enki/Test-pose-001/blob/main/Abgabe/Test-pose-001%20--%20Seite%20(1).jpg)
  
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 3: </summary>  

![Seite 2](https://github.com/IxI-Enki/Test-pose-001/blob/main/Abgabe/Test-pose-001%20--%20Seite%20(2).jpg) 
  
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 4: </summary>  

 ![Seite 5](https://github.com/IxI-Enki/Test-pose-001/blob/main/Abgabe/Test-pose-001%20--%20Seite%20(5).jpg)
  
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 5: </summary>  

 ![Seite 3](https://github.com/IxI-Enki/Test-pose-001/blob/main/Abgabe/Test-pose-001%20--%20Seite%20(3).jpg)
  
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 6: </summary>  

 ![Seite 4](https://github.com/IxI-Enki/Test-pose-001/blob/main/Abgabe/Test-pose-001%20--%20Seite%20(4).jpg)
  
</details>

-------------------------------  

<!------------------------------------------------->
## **Verbesserung**:  
> Vollständige [pdf]( )



-------------------------------  

<!------------------------------------------------->

## **Snippets**:  
> Vollständige [Solution](https://github.com/IxI-Enki/Test-pose-001/tree/main/Solution)
<details>
  <summary> [klick] - Nummer 1: </summary>  

```c#
/* DECLARE VARIABLES */
            double x,y, z;

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
```  
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 2: </summary>  

```c#
/* DECLARE VARIABLES */
            double a, b, c,
                   swap;
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
```  
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 3: </summary>  

```c#
/* DECLARE VARIABLES */
            int month, days;
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
                    days = 28; // Assuming no leap year for simplicity
                    break;
                default:
                    Console.Write("\nAbbruch\n");
                    return;
            }
/* OUT */   Console.Write($"\n Der {month}. Monat hat {days} Tage.");
```  
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 4: </summary>  

```c#
 /* DECLARE VARIABLES */
            int x, y, a,
                shortA;
/* CALCULATION ------ original code ------------ */  
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
```  
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 5: </summary>  

```c#
/* DECLARE VARIABLES */
            int y, x,   j;
/* LOOP A */        y = 1; j = 1;
                    do
                    {   y = y + j;
                        j--;
/* A */             } while (y < 200);
/* NOT TERMINATED */

/* LOOP B */        x = 1; j = 20;
                    while (x+j < 100)
                    {   x = x + 3;
                        j--; j--;
/* B - TERMINATED */}
```  
</details>

<!-- -->

<details>
  <summary> [klick] - Nummer 6: </summary>  

```c#
/* DECLARE VARIABLES */
            int n, sum;
                sum = 0;
/* CALCULATION */
            while(n != 0)
            {   sum = sum + (n % 10);
                n = n / 10;
            }
/* OUT */   Console.Write($"\n Die Ziffernsumme der Zahl ist {sum}");
```  
</details>


</details>


  


