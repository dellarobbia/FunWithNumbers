/*
 * FunWithNumbers
 * 
 * Written by Andrew McKay
 * Last Edited 1/16/21
 * 
 * The purpose of this program is to demonstrate knowledge in console input and output in C#.
 * The program will prompt the user to enter 5 numbers, calculate the sum and average of those
 * numbers, and display both calculations' results to the user.
 * 
 */

using System;
using System.Collections.Generic;
using FunWithNumbers.Classes;

namespace FunWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserNumber> _userNumbers = GetUserInputs();
            Calculator _userNumberCalculator = new Calculator(_userNumbers);

            //Format the output to a max of two decimal places
            Console.WriteLine("The sum is " + String.Format("{0:0.##}", _userNumberCalculator.GetSum()));
            Console.WriteLine("The average is " + String.Format("{0:0.##}",_userNumberCalculator.GetAverage()));
        }

        //Loop a prompt 5 times to get numbers from the user
        static List<UserNumber> GetUserInputs()
        {
            List<UserNumber> _holdUserNumbers = new List<UserNumber>();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Please enter number {0}:", i);
                _holdUserNumbers.Add(new UserNumber(Double.Parse(Console.ReadLine())));
            }

            return _holdUserNumbers;
        }
    }
}
