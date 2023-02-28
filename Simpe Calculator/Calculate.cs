using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpe_Calculator
{
    public class Calculate
    {
        public static double DoCalcuation(double val1, double val2, string mathOperator)
        {
            double result = 0;

            switch (mathOperator)
            {
                case "/":
                result = val1 / val2;
                    break;

                case "-":
                    result = val1 - val2;
                    break;

                case "*":
                    result = val1 * val2;
                    break;

                case "+":
                    result = val1 + val2;
                    break;

                default:
                    break;
            }
            return result;
        }
    }
}
