using System;
/*
Zachary Gardner
CST-117
September 3, 2020
Professor Pritchard

 */

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int fatCals;
            int carbCals;
            //Welcome message
            Console.WriteLine("Welcome to the Calorie Calculator");

            //Console.ReadLine will take user input and save inside variables
            Console.WriteLine("Please enter your total Carbohydrates for the day in grams");
            string carbGrams = Console.ReadLine();

            //Console.ReadLine will take user input and save inside variables
            Console.WriteLine("Please enter your total Fats for the day in grams");
            string fatGrams = Console.ReadLine();

            //capturing data from methods
            fatCals = FatCalories(Int32.Parse(fatGrams));
            carbCals = CarbCalories(Int32.Parse(carbGrams));

            //displaying the returned values
            Console.WriteLine("Your total Calories from Carbs for the day are " + carbCals + 
                "\r\nYour total Calories from Fat for the day are " + fatCals);


        }
        //FatCalories method takes grams of fat as input, then multiplies by 9 to return number of calories from fat.
        public static int FatCalories(int fatGrams)
        {
            int fatCals = 0;
            fatCals = fatGrams * 9;

            return fatCals;
        }
        //CarbCalories method takes grams of Carbs as input, then multiplies by 4 to return number of calories from carbs.
        public static int CarbCalories(int carbGrams)
        {
            int carbCals = 0;
            carbCals = carbGrams * 4;
            return carbCals;
        }
    }
}
/*
 * A nutritionist who works for a fitness club helps members by evaluating their diets. 
 * As part of her evaluation, she asks members for the number of fat grams and carbohydrate grams that they consume in a day. 
 * Then, she calculates the number of calories that result from the fat using the following formula: 
 * Calories from fat = Fat grams × 9 
 * Next, she calculates the number of calories that result from the carbohydrates using the following formula:
 * Calories from carbs = Carbs grams × 4 
 * Create an application that will make these calculations. 
 * In the application, you should have the following methods:
 * FatCalories–This method should accept a number of fat grams as an argument and return the number of calories from that amount of fat.
 * CarbCalories–This method should accept a number of carbohydrate grams as an argument and return the number of calories from that amount of carbohydrates.
 * 
 * 
 * 
 * 
 */
