using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
    class Counter
    {
        //instance variable
        private int count = 0;

        // Include methods to set the counter to 0
        public Counter()
        {
            count = 0;
        }
        public int resetCounter()
        {
            return count = 0;
        }

        //Increase and Decrease Counter
        public int increaseCounter()
        {
            return count++;
        }
        public int decreaseCounter()
        {
            if (count == 0)
            {
                return count = 0;
            }
            else
            {
                return count--;
            }
        }
        //Getter             
        public int getCounter()
        {
            return count;
        }

        //Method that outputs the count to the screen
        public void displayCounter()
        {
            Console.WriteLine("Count value: " + count +".\n");
        }
        //ToString Method
        public String ToString()
        {
            return ("Count: "+ count);
        }
        //Equals Method
        public bool equals(Counter other)
        {
            return (this.count == other.count);
        }
    }
}