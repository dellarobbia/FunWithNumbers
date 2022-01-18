/*
 * Class used to apply calculations to a collection of numbers
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithNumbers.Classes
{
    class Calculator
    {
        //Member Variables
        private List<UserNumber> _userNumbers;
        private long _sum;
        private double _average;

        //Constructor
        public Calculator(List<UserNumber> userNumbers)
        {
            SetUserNumbers(userNumbers);
            SetSum();
            SetAverage();
        }

        //Getters and Setters
        public List<UserNumber> GetUserNumbers()
        {
            return _userNumbers;
        }

        public void SetUserNumbers(List<UserNumber> userNumbers)
        {
            _userNumbers = userNumbers;
        }

        public long GetSum()
        {
            return _sum;
        }

        //Special setter that calculates _sum based on given _userNumbers
        private void SetSum()
        {
            for(int i = 0; i <= _userNumbers.Count - 1; i++)
            {
                _sum += _userNumbers[i].GetLongNumber();
            }
        }

        public double GetAverage()
        {
            return _average;
        }

        //Special setter that calculates _average based on given _userNumbers
        private void SetAverage()
        {
            _average = _sum / _userNumbers.Count;
        }
    }
}
