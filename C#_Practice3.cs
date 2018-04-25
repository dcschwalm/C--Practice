using System;
namespace Practice
{
class OurProgram
{
    static void Main()
    {
        CalcUserInput();
    }
    static void CalcUserInput() {
         Console.Write("Please enter a number between 1 and 10: ");
         int UserInput = Convert.ToInt32(Console.ReadLine());
         //if/else
         /*if (UserInput >= 1 && UserInput <= 5){
             Console.Write("That number is between 1 and 5");
         }
         else {
             Console.Write("That number is greater than 5");
         }
         //if/else if/else
         if (UserInput > 1 && UserInput < 5){
             Console.Write("That Number is between 1 and 5");
         }
        else if (UserInput > 5 && UserInput < 10){
            Console.Write("That number is between 5 and 10");
        }
        else{
            Console.Write("That number is not within our range");
        }*/
        bool outOfRange = false;
        if (UserInput > 1 && UserInput < 5){
             Console.Write("That Number is between 1 and 5");
         }
        else if (UserInput > 5 && UserInput < 10){
            Console.Write("That number is between 5 and 10");
        }
        else if (UserInput < 1 || UserInput > 10){
            outOfRange = true;
            if (outOfRange == true){
                Console.Write("That number is out of Range");
            }
        }
        else{
            Console.Write("That number is 1, 5, or 10");
        }
     }
 }
}