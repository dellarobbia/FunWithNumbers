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
        private double _max;
        private double _min;

        //Constructor
        public Calculator(List<UserNumber> userNumbers)
        {
            SetUserNumbers(userNumbers);
            SetSum();
            SetAverage();
            SetMax();
            SetMin();
        }

        //Getters and Setters
        public List<UserNumber> GetUserNumbers() => _userNumbers;

        public void SetUserNumbers(List<UserNumber> userNumbers) => _userNumbers = userNumbers;

        public long GetSum() => _sum;

        //Special setter that calculates _sum based on given _userNumbers
        private void SetSum()
        {
            for(int i = 0; i <= _userNumbers.Count - 1; i++)
            {
                _sum += _userNumbers[i].GetLongNumber();
            }
        }

        public double GetAverage() => _average;

        //Special setter that calculates _average based on given _userNumbers
        private void SetAverage() => _average = _sum / _userNumbers.Count;

        public double GetMax() => _max;

        //Special setter that determines _max based on given _userNumbers
        private void SetMax()
        {
            /*setting _max to the first UserNumber guaruntees that at least one
            / on the user's numbers is determined to be the Max*/
            double _max = _userNumbers[0].GetNumber();
            double _compMax = 0;

            //loop through _userNumbers to find if any other value is the highest value
            for(int i = 0; i <= _userNumbers.Count - 1; i++)
            {
                _compMax = _userNumbers[i].GetNumber();

                if(_max < _compMax)
                {
                    _max = _compMax;
                }
            }

            //set the _max class property to the determined max value
            this._max = _max;
        }

        public double GetMin() => _min;

        //Special setter that determines _min based on given _userNumbers
        private void SetMin()
        {
            /*setting _min to the first UserNumber guaruntees that at least one
            / on the user's numbers is determined to be the Min*/
            double _min = _userNumbers[0].GetNumber();
            double _compMin = 0;

            //loop through _userNumbers to find if any other value is the lowest value
            for (int i = 0; i <= _userNumbers.Count - 1; i++)
            {
                _compMin = _userNumbers[i].GetNumber();

                if (_min > _compMin)
                {
                    _min = _compMin;
                }
            }

            //set the _min class property to the determined min value
            this._min = _min;
        }
    }
}
