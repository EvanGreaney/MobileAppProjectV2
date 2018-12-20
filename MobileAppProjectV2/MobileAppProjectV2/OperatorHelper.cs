using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppProjectV2
{
    //a class that when called has one method called calculate that based on the values entered will return the result
    class OperatorHelper
    {
        public static int Calculate(int value1, int value2, string myoperator)
        {
            int result = value2;
            switch (myoperator)
            {
                
                case "+":
                    result += value1;
                    
                    break;
                case "-":
                    result -= value1;
                    break;

            }
            return result;

        }


    }

}

