using System;
using System.Text.RegularExpressions;

namespace Lab_8_HW_Raheel_Khan
{
    class Program
    {
        public static void Main(string[] args)
        {

            bool repeat = true;
            string[] names =
            {
                "Jacob",    //Names[0]
                "Drew",     //Names[1]
                "Peter",    //Names[2]
                "Raheel",   //Names[3]
                "Joseph",   //Names[4]
                "Michael",  //Names[5]
                "Jason",    //Names[6]
                "Melissa",  //Names[7]
                "Grace",    //Names[8]
                "Sarah",    //Names[9]
                "Aisha",    //Names[10]
                "Madison",  //Names[11]
                "Anthony",  //Names[12]
                "Mathew",   //Names[13]
                "Carl",     //Names[14]
                "Lenore",   //Names[15]
                "Frank",    //Names[16]
                "Ford",     //Names[17]
                "Katy",     //Names[18]
                "David",    //Names[19]
              
            };
            string[] food =
            {
                "Cookies",      //Food[0]
                "Ice Cream",    //Food[1]
                "Thai",         //Food[2]
                "Pizza",        //Food[3]
                "Burgers",      //Food[4]
                "Hotdogs",      //Food[5]
                "Shawrma",      //Food[6]
                "Rice",         //Food[7]
                "Kabob",        //Food[8]
                "Chicken",      //Food[9]
                "Salad",        //Food[10]
                "Subs",         //Food[11]
                "Tacos",        //Food[12]
                "Nachos",       //Food[13]
                "Fajita",       //Food[14]
                "Burrito",      //Food[15]
                "Pasta",        //Food[16]
                "Cereal",       //Food[17]
                "Lobster",      //Food[18]
                "Donuts",       //Food[19]
             
            };
            string[] hometown =
            {
                "Merrillville",     //hometown[1]
                "Detroit",          //hometown[2]
                "In Michigan",      //hometown[3]
                "Chicago",          //hometown[4]
                "Indiana",          //hometown[5]
                "Cincinnati",       //hometown[6]
                "New York",         //hometown[7]
                "Florida",          //hometown[8]
                "Miami",            //hometown[9]
                "Texas",            //hometown[10]
                "Dallas",           //hometown[11]
                "Houston",          //hometown[12]
                "Los Angeles",      //hometown[13]
                "San Francisco",    //hometown[14]
                "Seattle",          //hometown[15]
                "Denver",           //hometown[16]
                "Phoenix",          //hometown[17]
                "Atlanta",          //hometown[18]
                "Memphis",          //hometown[19]
              
            };




            while (repeat)
            {
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?");

                //Show menu
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {names[i]}");
                }

                //get number into variable and validate
                int studentNumber = Validator(names);

                //get student name into variable
                string studentName = names[studentNumber];
                Console.WriteLine($"\nYou have chosen {studentName}.");

                //get information about student selected
                bool repeatOne = true;
                while (repeatOne)
                {
                    getInfo(studentName, studentNumber, food, hometown);
                    repeatOne = repeator(studentName);
                }
                repeat = repeator("another student");
                if (repeat == false)
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }








        public static int Validator(string[] array)
        {
            int number = 0;
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Please Enter a Student Number (1-20):");
                try
                {
                    string userInput = Console.ReadLine();
                    number = int.Parse(userInput) - 1;
                    string testRange = array[number];
                    repeat = false;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That is not a student number! Please try again.  (enter a number between 1-20):");
                    repeat = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("That is not a student number! Please try again.  (enter a number between 1-20):");
                    repeat = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number please!");
                    repeat = true;
                }

            }
            return number;




        }
        public static void getInfo(string names, int studentNum, string[] food, string[] hometown)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"\nWhat would you like to know about {names}?\n\tYou can choose: Food, Hometown.");
                string whatInfo = Console.ReadLine().ToLower();
                if (whatInfo == "hometown")
                {
                    Console.WriteLine($"{names}'s hometown is {hometown[studentNum]}.");
                    repeat = false;

                }
                else if (whatInfo == "food")
                {
                    Console.WriteLine($"{names}'s favorite food is {food[studentNum]}.");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Im sorry that wasnt a choice!");
                }

            }

        }
        public static bool repeator(string learnMore)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"Would you like to know more about {learnMore}?");
                string userRepeat = Console.ReadLine().ToLower();

                if (userRepeat == "n" || userRepeat == "no")
                {
                    Console.WriteLine("Thank You, Goodbye!");
                    repeat = false;
                }
                else if (userRepeat == "y" || userRepeat == "yes")
                {
                    repeat = false;
                    return true;
                }
                else
                {
                    Console.WriteLine("Please put a yes, y, no, or n.");
                }

            }
            return repeat;
        }
    }
}
















