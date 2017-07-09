using System;
using System.Collections.Generic;

namespace school
{
    class printSchool
    {
        static public void print()
        {
            Console.WriteLine(Asterix());
            Console.WriteLine(schoolInfo());
            Console.WriteLine(Asterix());
        }

        static string Asterix()
        {
            return "*******************************************";
        }

        static string schoolInfo()
        {
            string schoolName = "City University of seattle";
            string schoolCountry = "Slovakia";
            int schoolCost = 15000;
            int numOfStudents = 1000;

            string schoolInfo = string.Format("schoolName:     {0}\n" + 
                                            "schoolCountry:    {1}\n" +
                                            "schoolCost:       {2:C2}\n" +
                                            "schoolStudents:   {3}\n",
                                            schoolName,schoolCountry,schoolCost,numOfStudents);

            return schoolInfo;
        }
    }
}
