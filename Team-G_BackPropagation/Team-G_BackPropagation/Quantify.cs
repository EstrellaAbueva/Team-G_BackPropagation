using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Team_G_BackPropagation
{
    public class Quantify
    {
        double ages, sexs, scholars, studies, nonscis, scis, attendances, mids1, mids2, note, listens, interests, grades;
        
        //getters and setters
        public Quantify() { }

        public double[] Equivalent(double ages, double sexs, double scholars, double studies, double nonscis, double scis, double attendances, double mids1, double mids2, double note, double listens, double interests, double grades)
        {
            //declare an array
            double[] equivalent = new double[13];

            if (ages == 1)
            {
                equivalent[0] = 0;
            }
            else if (ages == 2)
            {
                equivalent[0] = 0.5;
            }
            else
            {
                equivalent[0] = 2;
            }

            if (sexs == 1)
            {
                equivalent[1] = 0;
            }
            else
            {
                equivalent[1] = 1;
            }

            if (scholars == 1)
            {
                equivalent[2] = 0;
            }
            else if (scholars == 2)
            {
                equivalent[2] = 0.25;
            }
            else if (scholars == 3)
            {
                equivalent[2] = 0.5;
            }
            else if (scholars == 4)
            {
                equivalent[2] = 0.75;
            }
            else
            {
                equivalent[2] = 1;
            }

            if (studies == 1)
            {
                equivalent[3] = 0;
            }
            else if (studies == 2)
            {
                equivalent[3] = 0.25;
            }
            else if (studies == 3)
            {
                equivalent[3] = 0.5;
            }
            else if (studies == 4)
            {
                equivalent[3] = 0.75;
            }
            else
            {
                equivalent[3] = 1;
            }

            if (nonscis == 1)
            {
                equivalent[4] = 0;
            }
            else if (nonscis == 2)
            {
                equivalent[4] = 0.5;
            }
            else
            {
                equivalent[4] = 1;
            }

            if (scis == 1)
            {
                equivalent[5] = 0;
            }
            else if (scis == 2)
            {
                equivalent[5] = 0.5;
            }
            else
            {
                equivalent[5] = 1;
            }

            if (attendances == 1)
            {
                equivalent[6] = 0;
            }
            else if (attendances == 2)
            {
                equivalent[6] = 0.5;
            }
            else
            {
                equivalent[6] = 1;
            }

            if (mids1 == 1)
            {
                equivalent[7] = 0;
            }
            else if (mids1 == 2)
            {
                equivalent[7] = 0.5;
            }
            else
            {
                equivalent[7] = 1;
            }

            if (mids2 == 1)
            {
                equivalent[8] = 0;
            }
            else if (mids2 == 2)
            {
                equivalent[8] = 0.5;
            }
            else
            {
                equivalent[8] = 1;
            }

            if (note == 1)
            {
                equivalent[9] = 0;
            }
            else if (note == 2)
            {
                equivalent[9] = 0.5;
            }
            else
            {
                equivalent[9] = 1;
            }

            if (listens == 1)
            {
                equivalent[10] = 0;
            }
            else if (listens == 2)
            {
                equivalent[10] = 0.5;
            }
            else
            {
                equivalent[10] = 1;
            }

            if (interests == 1)
            {
                equivalent[11] = 0;
            }
            else if (interests == 2)
            {
                equivalent[11] = 0.5;
            }
            else
            {
                equivalent[11] = 1;
            }

            if (grades == 1)
            {
                equivalent[12] = 0;
            }
            else if (grades == 2 || grades == 3)
            {
                equivalent[12] = 0.33;
            }
            else if (grades == 4 || grades == 5)
            {
                equivalent[12] = 0.66;
            }
            else
            {
                equivalent[12] = 1;
            }

            return equivalent;
        }
    }
}
