using System;
using System.Text.RegularExpressions;

namespace Lab_8_HW_Raheel_Khan
{
    class Program
    {
        public static void Main(string[] args)
        {
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







            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (please enter a number 1-20:)");

            for (int i = 0; i < names.Length; i++)

                Console.WriteLine((i + 1) + ". " + names[i]);

            string nameAnswer = (Console.ReadLine());
            string nameAnswerPattern = (@"(^[1-9]{1}$)|(^[1]{1}[1-9]|(^[2]{1}[0]))");

            string elseAnswer = "";
            bool success = GetMatchStudent(nameAnswer, nameAnswerPattern);
            bool c = true;

            int nameAnswerInt = int.Parse(nameAnswer);
            int nameAnswerReal = nameAnswerInt - 1;

            bool repeat = false;
            bool repeatSecond = false;


            while (repeat == false)
            {


                if (success == true)
                {
                    Console.WriteLine("Student " + nameAnswer + " is " + names.GetValue(nameAnswerReal) + ".  What would you like to know about " + names.GetValue(nameAnswerReal) + "? (enter \"hometown\" or \"favorite food\"):");
                    repeat = true;
                }
                else 
                {

                    while (repeatSecond == false)
                    {

                        Console.WriteLine("That student does not exist.  Please try again.(enter a number 1-20)");
                        elseAnswer = Console.ReadLine();
                        success = GetMatchStudent(elseAnswer, nameAnswerPattern);

                        if (success == true)
                        {
                            repeatSecond = true;
                        }
                        else
                        {
                            repeatSecond = false;
                        }

                    }

                    repeat = false;
                }

                

            }


       
            string questionOneAnswer = Console.ReadLine();

       

            if (questionOneAnswer == "hometown" || questionOneAnswer == "Hometown")
            {
                Console.WriteLine(names.GetValue(nameAnswerReal) + " is from " + hometown.GetValue(nameAnswerReal) + ".  Would you like to know more? (enter \"yes\" or \"no\"):");

                string answerToQuestionOneHomeTown = Console.ReadLine();


                if (answerToQuestionOneHomeTown == "no" || answerToQuestionOneHomeTown == "NO" || answerToQuestionOneHomeTown == "No")
                {
                    Console.WriteLine("Thanks!");
                    return;
                }

                if (answerToQuestionOneHomeTown == "yes" || answerToQuestionOneHomeTown == "YES" || answerToQuestionOneHomeTown == "Yes")
                {
                    Console.WriteLine("What would you like to know about " + names.GetValue(nameAnswerReal) + "? (enter \"hometown\" or \"favorite food\"):");
                    string answerToQuestionOneHomeTownTwo = Console.ReadLine();
              
                }

                else
                {
                    Console.WriteLine("That data does not exist. Please try again. (enter or “hometown” or “favorite food”):");
                }


            }
            if (questionOneAnswer == "favorite food" || questionOneAnswer == "Favorite Food")
            {
                Console.WriteLine(names.GetValue(nameAnswerReal) + "'s favorite food is " + food.GetValue(nameAnswerReal) + ".  Would you like to know more? (enter \"yes\" or \"no\"):");

                string answerToQuestionOneFood = Console.ReadLine();

                if (answerToQuestionOneFood == "no" || answerToQuestionOneFood == "NO" || answerToQuestionOneFood == "No")
                {
                    Console.WriteLine("Thanks!");
                    return;
                }

                if (answerToQuestionOneFood == "yes" || answerToQuestionOneFood == "YES" || answerToQuestionOneFood == "Yes")
                {
                    Console.WriteLine("What would you like to know about " + names.GetValue(nameAnswerReal) + "? (enter \"hometown\" or \"favorite food\"):");
                    return;
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again. (enter or “hometown” or “favorite food”):");
                }

            }

            else
            {
                Console.WriteLine("That data does not exist. Please try again. (enter or “hometown” or “favorite food”):");
            }





        }







        public static bool GetMatchStudent(string input, string pattern)
        {
            Match getMatch = Regex.Match(input, pattern);
            if (getMatch.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }





}




