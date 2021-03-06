﻿using System;
using System.Speech.Synthesis;

namespace GRADES
{
    class Program
    {
        static void Main(string[] args)
        {

            BookOfGrades book1 = new BookOfGrades();

               
            book1.Name = "Brooklyn's book of grades";

            book1.AddGrade(67);
            book1.AddGrade(57);
            book1.AddGrade(63);
            book1.AddGrade(61);
            book1.AddGrade(77);
            book1.AddGrade(47);
            book1.AddGrade(60);
            book1.AddGrade(2);
            book1.AddGrade(7);
            book1.AddGrade(6);
            book1.AddGrade(16);
            book1.AddGrade(23);
            book1.AddGrade(57);
            book1.AddGrade(38);
            book1.AddGrade(94);
            book1.AddGrade(69);
            book1.AddGrade(99);
            book1.AddGrade(12);
            book1.AddGrade(17);
            book1.AddGrade(87);
            CurrentGrades(book1.NumOfGrades());

            Gstats stats = book1.ComputeStatistics();
            Console.WriteLine(book1.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            }


        static void CurrentGrades(int numOfGrades)
        {

            Random ran = new Random();

           
            int num = ran.Next(1, 100);

            string result = "";
            if (numOfGrades == 1)
            {
                result = "currently low";
            }
            else if (numOfGrades == 2)
            {
                result = "currently one tenth full";
            }
            else if (numOfGrades == 3)
            {
                result = "currently three twentieths full";
            }
            else if (numOfGrades == 4)
            {
                result = "currently 2 tenths full";
            }
            else if (numOfGrades == 5)
            {
                result = "currently five twentieths full";
            }
            else if (numOfGrades == 6)
            {
                result = "currently three tenths full";
            }
            else if (numOfGrades == 7)
            {
                result = "currently seven twentieths full";
            }
            else if (numOfGrades == 8)
            {
                result = "currently 4 tenths full";
            }
            else if (numOfGrades == 9)
            {
                result = "currently 9 twentieths full";
            }
            else if (numOfGrades == 10)
            {
                result = "currently 5 tenths full";
            }
            else if (numOfGrades == 11)
            {
                result = "currently 11 twentieths full";
            }
            else if (numOfGrades == 12)
            {
                result = "currently 6 tenths full";
            }
            else if (numOfGrades == 13)
            {
                result = "currently 13 twentieths full";
            }
            else if (numOfGrades == 14)
            {
                result = "currently 7 tenths full";
            }
            else if (numOfGrades == 15)
            {
                result = "currently 15 twentieths full";
            }
            else if (numOfGrades == 16)
            {
                result = "currently 8 tenths full";
            }
            else if (numOfGrades == 17)
            {
                result = "currently 17 twentieths full";
            }
            else if (numOfGrades == 18)
            {
                result = "currently 9 tenths full";
            }
            else if (numOfGrades == 19)
            {
                result = "currently 19 twentieths full";
            }
            else if (numOfGrades == 20)
            {
                result = "currently full";
            }


            SpeechSynthesizer talk = new SpeechSynthesizer();
            talk.Speak("hello, this is the book of grades which is" + result);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}  
