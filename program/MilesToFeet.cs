using System;
using System.Collections.Generic;

namespace MilesToFeet
{
    class convert
    {
        static public void MilesToFeetMain()
        {
            float miles = 4.5f;
            const int MILES_RATIO = 5200;
            const int INCHES_RATIO = 63360;

            Console.WriteLine("{0:F2} miles = {1} feet", miles, miles * MILES_RATIO);
            Console.WriteLine("{0:F2} miles = {1} inches", miles, miles * INCHES_RATIO);
        }


    }
}
