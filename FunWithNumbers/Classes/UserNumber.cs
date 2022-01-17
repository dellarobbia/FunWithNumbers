using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithNumbers.Classes
{
    class UserNumber
    {
        //Member Variables
        private double _number;
        private long _longNumber;

        //Constructor
        public UserNumber(double number)
        {
            SetNumber(number);
        }

        //Getters & Setters
        public double GetNumber()
        {
            return _number;
        }

        public void SetNumber(double number)
        {
            _number = number;
        }

        public long GetLongNumber()
        {
            return _longNumber;
        }

        //Special setter for _longNumber to convert the user's double input into a long
        public void SetLongNumber()
        {
            _longNumber = (long)_number;
        }
    }
}
