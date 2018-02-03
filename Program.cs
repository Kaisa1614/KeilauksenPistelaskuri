using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KeilauksenPistelaskuri
{
    
    public class PisteLaskuri
    {
            static int intLength(int WholeNumber)
            {
                int length = 1;
                if (WholeNumber / 10 > 0)
                    length = 2;
                if (WholeNumber / 100 > 0)
                    length = 3;
                return length;
            }


            static String scoreTwo(int totalScore, String score2)
            {
                if (intLength(totalScore) == 1)
                    score2 += totalScore + "	 ";
                else if (intLength(totalScore) == 2)
                    score2 += totalScore + "	";
                if (intLength(totalScore) == 3)
                    score2 += totalScore + "   ";
                return score2;
            }

        static void Main(string[] args)
        {

        }
    }
}
