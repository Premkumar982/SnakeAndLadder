using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Common
    {
        public static readonly int maxScore = 100;
        public static readonly int maxDiceValue = 6;
        public static Dictionary<int, int> dicSnakesandLadders = new Dictionary<int, int>()
        {
            { 2, 15 },
            { 5, 34 },
            { 9, 52 },
            { 16, 4 },
            { 25, 45},
            { 32, 54 },
            { 36, 10 },
            { 42, 74 },
            { 48, 23 },
            { 57,  6},
            { 63, 95 },
            { 67, 41 },
            { 72, 85 },
            { 83, 99 },
            { 87, 38 },
            { 90, 100},
            { 93, 44 }
        };
    }
}
