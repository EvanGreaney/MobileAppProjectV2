using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppProjectV2
{
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

